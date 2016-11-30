using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InnventEconnomics.Model;

namespace InnventEconnomics.Controllers
{
    [RoutePrefix("api/currencies")]
    public class CurrencyController : ApiController
    {
        private WebRequest webRequest;

        public HttpResponseMessage GetCurrencies()
        {
            return null;

        }
         
        [HttpGet]   
        [Route("exchange/{currency}")]
        public HttpResponseMessage GetExchangeCurrency(string currency)
        {
            try
            {
                CurrencyExchangeVo currencyExchange = new CurrencyExchangeVo();
                currencyExchange.nome = currency;
                string text = null;

                var date_1 = DateTime.Now.ToString("yyyy-mm-dd");
                var date_2 = DateTime.Now.AddDays(-1).ToString("yyyy-mm-dd");
                var date_3 = DateTime.Now.AddDays(-2).ToString("yyyy-mm-dd");
                var date_4 = DateTime.Now.AddDays(-3).ToString("yyyy-mm-dd");
                var date_5 = DateTime.Now.AddDays(-4).ToString("yyyy-mm-dd");
                var date_6 = DateTime.Now.AddDays(-5).ToString("yyyy-mm-dd");
                var date_7 = DateTime.Now.AddDays(-6).ToString("yyyy-mm-dd");

                string url_1 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date"+date_1+"&currencies=" +
                             currency+"&format=1";

                string url_2 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_2 + "&currencies=" +
                             currency + "&format=1";

                string url_3 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_3 + "&currencies=" +
                             currency + "&format=1";

                string url_4 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_4 + "&currencies=" +
                             currency + "&format=1";

                string url_5 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_5 + "&currencies=" +
                             currency + "&format=1";

                string url_6 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_6 + "&currencies=" +
                             currency + "&format=1";

                string url_7 = "http://apilayer.net/api/live?access_key=bfbb3baa3a9fa924ef69d83cebb2111a&date" + date_7 + "&currencies=" +
                             currency + "&format=1";

        
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response = (HttpWebResponse)request.GetResponse();
                    

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                   // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response2 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response3 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request4 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response4 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request5 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response5 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }


                HttpWebRequest request6 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response6 = (HttpWebResponse)request.GetResponse();


                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }

                HttpWebRequest request7 = (HttpWebRequest)WebRequest.Create("url_1");
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                var response7 = (HttpWebResponse)request.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                    // currencyExchange.Dia1(sr);
                }
                return Request.CreateResponse(HttpStatusCode.OK, text);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
