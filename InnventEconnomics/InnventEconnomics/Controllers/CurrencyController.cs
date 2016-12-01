using System;
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

                urls[0] = "http://apilayer.net/api/historical?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date=" + datas[0] + "&currencies=" +
             currency + "&format=1";
                for (int i = 1; i <= 7; i++)
                {
                    datas[i] = DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd");
                    urls[i] = "http://apilayer.net/historical/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date=" + datas[i] + "&currencies=" +
             currency + "&format=1";
                }

                for (int i = 0; i < 7; i++)
                {
                    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(urls[0]);
                    httpRequest.Method = WebRequestMethods.Http.Get;
                    httpRequest.Accept = "application/json";
                    var response = (HttpWebResponse)httpRequest.GetResponse();

                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        JavaScriptSerializer js = new JavaScriptSerializer();
                   
                        var text = sr.ReadToEnd();
                        Result currencyObj =
                            (Result) js.Deserialize(text, typeof(Result));

                        if (currencyExchange.dias != null) currencyExchange.dias[i] = currencyObj;
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
