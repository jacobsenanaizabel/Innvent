﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using InnventEconnomics.Model;

namespace InnventEconnomics.Controllers
{
    [RoutePrefix("api/currencies")]
    public class CurrencyController : ApiController
    {

        public HttpResponseMessage GetCurrencies()
        {
            return Request.CreateResponse(HttpStatusCode.NotFound);

        }
         
        [HttpGet]   
        [Route("exchange/{currency}")]
        public HttpResponseMessage GetExchangeCurrency(string currency)
        {
            try
            {
                CurrencyExchangeVo currencyExchange = new CurrencyExchangeVo();
                currencyExchange.nome = currency;
                string[] datas = new string[7];
                string[] urls = new string[7];
                Object[] request = new ObjectContent[7];
                datas[0] = DateTime.Now.ToString("yyyy-MM-dd");

                urls[0] = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date=" + datas[0] + "&currencies=" +
             currency + "&format=1";
                for (int i = 1; i < 7; i++)
                {
                    datas[i] = DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd");
                    urls[i] = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date=" + datas[i] + "&currencies=" +
             currency + "&format=1";
                }

                for (int i = 1; i <= 7; i++)
                {
                    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(urls[i]);
                    httpRequest.Method = WebRequestMethods.Http.Get;
                    httpRequest.Accept = "application/json";
                    var response = (HttpWebResponse)httpRequest.GetResponse();

                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        JavaScriptSerializer js = new JavaScriptSerializer();
                   
                        var text = sr.ReadToEnd();
                        CurrencyExchangeVo currencyObj =
                            (CurrencyExchangeVo) js.Deserialize(text, typeof(CurrencyExchangeVo));
                        /*
                        switch (i)
                        {
                            case 1:
                                currencyExchange.Dia1 = currencyObj;

                            case 2:
                                currencyExchange.Dia2 = currencyObj;

                            case 3:
                                currencyExchange.Dia3 = currencyObj;

                            case 4:
                                currencyExchange.Dia4 = currencyObj;

                            case 5:
                                currencyExchange.Dia5 = currencyObj;

                            case 6:
                                currencyExchange.Dia6 = currencyObj;

                            case 7:
                                currencyExchange.Dia7 = currencyObj;

                        }*/
                    }


                }
                
                return Request.CreateResponse(HttpStatusCode.OK, currencyExchange);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
