﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using InnventEconnomics.Model;
using Newtonsoft.Json;

namespace InnventEconnomics.Controllers
{
    [RoutePrefix("api/currencies")]
    public class CurrencyController : ApiController
    {
        public static string date_1;
        public static string date_2;
        public static string date_3;
        public static string date_4;
        public static string date_5;
        public static string date_6;
        public static string date_7;
        public static string currency;


        public  string url_1 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_1 + "&currencies=" +
             currency + "&format=1";

        public string url_2 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_2 + "&currencies=" +
                     currency + "&format=1";

        public string url_3 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_3 + "&currencies=" +
                     currency + "&format=1";

        public string url_4 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_4 + "&currencies=" +
                     currency + "&format=1";

        public string url_5 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_5 + "&currencies=" +
                     currency + "&format=1";

        public string url_6 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_6 + "&currencies=" +
                     currency + "&format=1";

        public string url_7 = "https://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_7 + "&currencies=" +
                     currency + "&format=1";

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
             

                date_1 = DateTime.Now.ToString("yyyy-MM-dd");
                date_2 = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
                date_3 = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd");
                date_4 = DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd");
                date_5 = DateTime.Now.AddDays(-4).ToString("yyyy-MM-dd");
                date_6 = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd");
                date_7 = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd");


        
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response = (HttpWebResponse)request.GetResponse();
                    

                using (var sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {                  
                    var text = JsonConvert.DeserializeObject<Object>(sr.ReadToEnd());
                    text = sr.ReadToEnd();
                   // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response2 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response3 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request4 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response4 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request5 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response5 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request6 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response6 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request7 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response7 = (HttpWebResponse)request.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
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
