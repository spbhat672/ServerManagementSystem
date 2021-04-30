using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

using Apache.NMS.ActiveMQ;

namespace webserwinform
{
    class RESTClientUrlLoader
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static string _SecurityContext = null; // - For ENOVIA SecurityContext
        private static string _content_type = null; // - Header of the response, Content-Type field
        private static HttpStatusCode _response_code = HttpStatusCode.OK; // - Response code last call
        private static string _response_msg = null; // - Response msg last call
        private static Uri _last_redirect_url = null; // - On redirection
        private static CookieContainer _cookieContainer = null;
        private static string _cookie = null;
        private static string _CSRF_name = null;// - CSRF Token header field name
        private static string _CSRF_value = null;// - CSRF Token header field value
        CookieContainer cookiejar = new CookieContainer();
        /// <summary>
        /// default getter </summary>
        /// <returns> content type of last URL loaded, null if none has been load </returns>
        public virtual string ContentTypeFromHeader
        {
            get
            {
                return _content_type;
            }
        }
        public virtual string setCSRFHeader 
        {
            set 
            {
            _CSRF_name = value;
            }
            //_CSRF_value = CSRF_header_value;
        }

        public virtual string setCSRFTokenValue
        {
            set
            {
                _CSRF_value = value;
            }

        }

        /// <summary>
        /// default getter </summary>
        /// <returns> content type of last URL loaded, null if none has been load </returns>
        public virtual HttpStatusCode ResponseCode
        {
            get
            {
                return _response_code;
            }
        }

        /// <summary>
        /// default getter </summary>
        /// <returns> content type of last URL loaded, null if none has been load </returns>
        public virtual string ResponseMessage
        {
            get
            {
                return _response_msg;
            }
        }

        /// <summary>
        /// default setter
        /// </summary>
        public virtual string SecurityContext
        {
            set
            {
                _SecurityContext = value;
            }
        }

        /// <summary>
        /// default getter </summary>
        /// <returns> Last known redirect URL, null if none has been set </returns>
        public static Uri LastRedirectUrl
        {
            get
            {
                return _last_redirect_url;
            }
        }

        public static string Cookie
        {
            get
            {
                return _cookie;
            }
        }


        /// <summary>
        /// default getter </summary>
        /// <returns> Last known redirect URL, null if none has been set </returns>
        public static CookieContainer cookieContainer
        {
            get
            {
               // _cookieContainer.GetCookies();
                return _cookieContainer;
            }
            set
            {
                _cookieContainer = value;
            }
        }


        public RESTClientUrlLoader()
        {
            _cookieContainer = new CookieContainer();

        }

        /// <summary>
        /// Load an URL and catch the response </summary>
        /// <param name="url"> the URL to load. </param>
        /// <param name="method"> GET or POST </param>
        /// <param name="content_type"> mandatory when method is POST </param>
        /// <param name="post_data"> the data to send when using POST method </param>
        /// <returns> response body </returns>
        public virtual sbyte[] loadUrl(string urlAsString, string method, string content_type, sbyte[] post_data, bool is_jason,
                                       string accept, string uploadfilenamewithpath, NameValueCollection nvc, string name, string filename)
        {
            System.IO.Stream input = new System.IO.MemoryStream();
           // log.Debug("##CLIENT REQUEST");
           // log.Debug("##------------------------------------------------------------");

            // Create the URL from the String
            Uri url = new Uri(urlAsString);
           // log.Debug("[" + method + "] " + url.ToString());

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 1   == 
            // == Open the connection
            // - Set up connection
            HttpWebRequest connection = (HttpWebRequest)HttpWebRequest.Create(url);


            connection.CookieContainer = cookieContainer;
            
         //   cookieContainer.
            List<Cookie> cookies = cookieContainer.GetCookies(url).Cast<Cookie>().ToList();
            if (cookies.Count > 0)
            {
                for (int i = 0; i < cookies.Count; i++) // Loop through List with for
                {
                    string cookie = cookies[i].ToString();
                   
                }
            }

            
            
            
            connection.UserAgent = "CAA URL Loader";

            //support automatic redirect
            connection.AllowAutoRedirect = true;
            connection.KeepAlive = true;

            if (method.Equals("PATCH"))
            {
                connection.Headers["X-HTTP-Method-Override"] = "PATCH";
              //  log.Debug("  [HEADER] X-HTTP-Method-Override : PATCH");
                connection.Method = "POST";
            }
            else
            {
                // - Add information to request header
                connection.Method = method;
            }

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 2   == 
            // == Request header

            if (!string.ReferenceEquals(_SecurityContext, null) && (_SecurityContext.Length != 0))
            {
                connection.Headers["SecurityContext"] = _SecurityContext;
              //  log.Debug("  [HEADER] SecurityContext: " + _SecurityContext + " encoded as: " + Uri.EscapeUriString(_SecurityContext) + " <-");
            }

           

            if (accept.Length > 0)
            {
                connection.Accept = accept;
            }
            else
            {
                connection.Accept = "application/json";
            }

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 3   == 
            // == Post data
            // - If there is data to send, send it!
            if (post_data != null || uploadfilenamewithpath.Length > 0)
            {

                Stream output = null;

                if (post_data != null)
                {
                    connection.ContentType = content_type;
                    connection.ContentLength = post_data.Length;
                    if ((_CSRF_value != null) && (_CSRF_value.Length > 0) && (_CSRF_name.Length > 0))
                    {

                       // HttpRequestHeader csrftonken = new HttpRequestHeader()
                        //csrftonken.
                        //connection.Headers.Add(Uri.EscapeUriString(_CSRF_name), Uri.EscapeUriString(_CSRF_value));
                         connection.Headers["ENO_CSRF_TOKEN"] = _CSRF_value;
                    }
                    output = connection.GetRequestStream();
                    //output.re
                }

               // log.Debug("Content-Type=" + content_type);

                // - Send data
                if (uploadfilenamewithpath.Length > 0)
                {
                    string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
                    byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                    connection.ContentType = "multipart/form-data; boundary=" + boundary;
                    connection.KeepAlive = true;
                    output = connection.GetRequestStream();
                    string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                    foreach (string key in nvc.Keys)
                    {
                        output.Write(boundarybytes, 0, boundarybytes.Length);
                        string formitem = string.Format(formdataTemplate, key, nvc[key]);
                        byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                        output.Write(formitembytes, 0, formitembytes.Length);
                    }

                    output.Write(boundarybytes, 0, boundarybytes.Length);

                    string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
                    string header = string.Format(headerTemplate, name, filename, content_type);
                    byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                    output.Write(headerbytes, 0, headerbytes.Length);

                    FileStream fileStream = new FileStream(uploadfilenamewithpath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[4096];
                    int bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                    fileStream.Close();

                    byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                    output.Write(trailer, 0, trailer.Length);
                    output.Close();

                }
                else
                {
                    string post_data_str = System.Text.Encoding.UTF8.GetString((byte[])(object)post_data, 0, post_data.Length);
                  //  log.Debug("POST Data : " + post_data_str);
                    // - Add POST information to request header
                    output.Write((byte[])(Array)post_data, 0, post_data.Length);
                }

                output.Flush();
                output.Close();
            }

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==

            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 4   == 
            // == Catching response
            // - connection.getResponseCode() actually perform the request !!! 
            HttpWebResponse myHttpWebResponse = null;
            try
            {
                myHttpWebResponse = (HttpWebResponse)connection.GetResponse();
                WebHeaderCollection headers = myHttpWebResponse.Headers;
                for (int i = 0; i < headers.Count; ++i)
                {
                    string header = headers.GetKey(i);
                    foreach (string value in headers.GetValues(i))
                    {
                        Console.WriteLine("{0}: {1}", header, value);
                    }
                }
                
                CookieCollection rescookies = myHttpWebResponse.Cookies;
                for (int i = 0; i < rescookies.Count; ++i)
                {
                    string cookiestr = rescookies.ToString();
                    Console.WriteLine(cookiestr);
                    cookiejar.Add(rescookies[i]);
                }

                _response_code = myHttpWebResponse.StatusCode;
                _response_msg = myHttpWebResponse.ToString();

               // log.Debug("");
              //  log.Debug("##SERVER RESPONSE [" + myHttpWebResponse.StatusCode.ToString() + "] " + _response_msg);

              //  log.Debug("##--------------------");

                // - When AllowAutoRedirect=true URL might have change due to redirect
                _last_redirect_url = null;
                if (!myHttpWebResponse.ResponseUri.ToString().Equals(url.ToString()))
                {
                    _last_redirect_url = myHttpWebResponse.ResponseUri;
                  // log.Debug("");
                  //  log.Debug("Has been redirected. Last Redirect URL : " + _last_redirect_url);
                }

                HttpStatusCode httpStatusCode = myHttpWebResponse.StatusCode;

                // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==

                // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
                // == STEP 5   == 
                // == Response header
                // - Response Header
                //log.Debug("");
                //log.Debug("#RESPONSE HEADER : ");
                //log.Debug("#--------------------");
                //log.Debug(myHttpWebResponse.Headers.Keys[0]);

                for (int i = 1; i <= myHttpWebResponse.Headers.Count - 1; i++)
                {
                    string header_name = myHttpWebResponse.Headers.Keys[i];
                    string header_value = myHttpWebResponse.Headers[i];
                    if (string.ReferenceEquals(header_name, null) && string.ReferenceEquals(header_value, null))
                    {
                        break;
                    }
                    else
                    {
                        //log.Debug(header_name + ": " + header_value);
                    }

                    // - Content Type : for response analysis and casting purpose
                    if (header_name.Equals("Content-Type"))
                    {
                        _content_type = header_value;
                    }

                }


                // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==

                // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
                // == STEP 6   == 
                // == Response body
                // - Read response body content

                //DELETE no content
                if (myHttpWebResponse.StatusCode != HttpStatusCode.NoContent)
                {
                    input = myHttpWebResponse.GetResponseStream();
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                    input = ex.Response.GetResponseStream();

                //log.Error("Error in request " + urlAsString, ex);
            }



            sbyte[] io_buffer = null;
            if (input != null)
            {
                int read = 0;
                System.IO.MemoryStream ba = new System.IO.MemoryStream();
                io_buffer = new sbyte[0x10000];
                while ((read = input.Read((byte[])(Array)io_buffer, 0, io_buffer.Length)) >= 0)
                {
                    if (read == 0)
                    {
                        break;
                    }
                    ba.Write((byte[])(Array)io_buffer, 0, read);
                }
                io_buffer = (sbyte[])(Array)ba.ToArray();
            }
            return io_buffer;
            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
        }

    }
}
