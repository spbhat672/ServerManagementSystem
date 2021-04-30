using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            //Needs to be added
using System.Net;           //Needs to be added
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;
using System.Text.Json;
//using System.Net.Http.Json;


namespace webserwinform
{
    class RestClientApriso
    {
        public string Post_ProductData(string protocol, string url,string productID)
        {
            string strResponseValue = string.Empty;
            CookieContainer cookieContainerApr = new CookieContainer();

            HttpClientHandler clienthandler = new HttpClientHandler();
            clienthandler.AllowAutoRedirect = true;
            clienthandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            clienthandler.UseCookies = true;
            clienthandler.CookieContainer = cookieContainerApr;

            HttpClient Apr_Client = new HttpClient(clienthandler);

            string urllogin = protocol + "://" + url + "/Apriso/httpServices/operations/WebService3DX_CreateOrder";
            Uri aprurl = new Uri(urllogin);
            HttpResponseMessage result = null;
            try
            {
                Apr_Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Apr_Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json;charset=utf-8");

                string Apr_post_data_str = "{\"Inputs\":{ \"ProductNo\":" + '\"' + productID + '\"' + "}}";
                //string Apr_post_data_str = "{\"Inputs\":{ \"ProductNo\": \"TestPrdExecution\"}}";
                HttpContent PostContent = new StringContent(Apr_post_data_str, Encoding.UTF8, "application/json");
                // HttpContentHeaders contentheader = null;
                //  contentheader.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");

                var Apr_http_response = Apr_Client.PostAsync(urllogin, PostContent);
                Apr_http_response.Wait();
                result = Apr_http_response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var output = result.Content.ReadAsStringAsync();
                    strResponseValue = output.Result.ToString();
                }
            }
            catch (Exception ex)
            {
                // var output = ex.Message;
                strResponseValue = ex.Message;
                //We catch non Http 200 responses here.
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }

            return strResponseValue;
        }

        public string Get_orderStatus(string protocol, string url , string OrderID)
        {
            string strResponseValue = string.Empty;
            CookieContainer cookieContainerApr = new CookieContainer();

            HttpClientHandler clienthandler = new HttpClientHandler();
            clienthandler.AllowAutoRedirect = true;
            clienthandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            clienthandler.UseCookies = true;
            clienthandler.CookieContainer = cookieContainerApr;

            HttpClient Apr_Client = new HttpClient(clienthandler);

            string urllogin = protocol + "://" + url + "/Apriso/httpServices/operations/WebService3DX_OrderStatus";
            HttpResponseMessage result = null;
            try
            {
                Apr_Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Apr_Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json;charset=utf-8");
                string Apr_post_data_str = "{\"Inputs\":{ \"OrderNo\":"+ '\"'+ OrderID + '\"'+"}}";
           
                HttpContent PostContent = new StringContent(Apr_post_data_str, Encoding.UTF8, "application/json");
                // HttpContentHeaders contentheader = null;
                //  contentheader.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");

                var Apr_http_response = Apr_Client.PostAsync(urllogin, PostContent);
                Apr_http_response.Wait();
                result = Apr_http_response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var output = result.Content.ReadAsStringAsync();
                    strResponseValue = output.Result.ToString();

                    //dynamic jsonoutput = JsonSerializer.Deserialize(outputResult);
                    //string Text = jsonoutput[0].OrderStatus[2];
                   // var responsestr = jsonoutput.Outputs;
                  //  dynamic jsonoutputousts = JsonConvert.DeserializeObject(responsestr);
                   // var responsestrousts = jsonoutputousts.OrderStatus;
                }
            }
            catch (Exception ex)
            {
                // var output = ex.Message;
                strResponseValue = ex.Message;
                //We catch non Http 200 responses here.
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }

            return strResponseValue;
        }
    }
}




       