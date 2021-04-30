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

namespace webserwinform
{
    public class Csrf
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class CsrfObject
    {
        public Csrf csrf { get; set; }
    }

    class RestClient
    {
        enum Server_Type
        {
            DemoCenter,
            OnPremise,
            OnCloud
        }

        private string _3dxServerUrl;
        private string _3dxSpaceUrl;
        private string _3dxPassportUrl;
        private string _loginTicket;
        private string _CSRFloginTicket;
        private string _3dxDemocenterServerUrl;
        private string _3dxCloudLoginServerUrl;
        private string _3dxCloudTenantUrl;
        private string _3dxServerType;
        private string _3dxCloudTenantID;

        public const string ENCODING = "UTF-8";
        private static RESTClientUrlLoader _URL_loader = null; // unique storage of CAAURLLoader instance
                                                               // - Response msg last call
        private static CsrfObject CSRFOBJECT = null;
        //Default Constructor
        public RestClient(string protocol, string urlstring, string portnum, string ServerType, String TenantID ,string TenantCountry, bool lowercase)
        {
            Server_Type Ser_Var = Server_Type.OnCloud;
            _loginTicket = "";
            _CSRFloginTicket = "";
            string TenantIDURI = TenantID.ToLower();


            if (ServerType == "On Premise")
            {
                Ser_Var = Server_Type.OnPremise;
                _3dxServerType = "On Premise";
            }
            else if(ServerType == "Demo Center")
            {
                Ser_Var = Server_Type.DemoCenter;
                _3dxServerType = "Demo Center";
            }
            else if(ServerType == "Cloud")
            { 
                Ser_Var = Server_Type.OnCloud;
                _3dxServerType = "Cloud";
            }

            switch (Ser_Var)
            {
                case Server_Type.OnPremise:
                    _3dxServerUrl = protocol + "://" + urlstring + ":" + portnum;
                    if (lowercase)
                    {
                        _3dxPassportUrl = protocol + "://" + urlstring + "/3dpassport";
                        _3dxSpaceUrl = protocol + "://" + urlstring + "/3dspace";
                    }
                    else
                    {
                        _3dxPassportUrl = protocol + "://" + urlstring + "/3DPassport";
                        _3dxSpaceUrl = protocol + "://" + urlstring + "/3DSpace";
                    }
                    break;
                case Server_Type.DemoCenter:
                    _3dxServerUrl = protocol + "://" + urlstring + ":" + portnum;
                    _3dxDemocenterServerUrl = protocol + "://" + urlstring + "/iam";
                    _3dxPassportUrl = protocol + "://" + urlstring + "/3DPassport";
                    _3dxSpaceUrl = protocol + "://" + urlstring + "/3DSpace";
                    break;
                case Server_Type.OnCloud:

                    _3dxCloudTenantUrl = protocol + "://"+ TenantIDURI + "-" + TenantCountry + "-space.3dexperience.3ds.com/enovia";
                    _3dxCloudTenantID = "?tenant=" + TenantID;
                    _3dxCloudLoginServerUrl = protocol + "://" + urlstring + "/cas";
                    break;
            }

            try
            {
                _URL_loader = new RESTClientUrlLoader();
            }
            catch (Exception t)
            {
                //log.Error("Error in CAAi3dxClient ", t);
            }
        }

        public virtual string getServerURL
        {
            get
            {
                return _3dxServerUrl;
            }
        }

        public virtual string getDemoCenterLoginURL
        {
            get
            { return _3dxDemocenterServerUrl; }
        }


        public virtual string getCloudLoginURL
        {
            get
            { return _3dxCloudLoginServerUrl; }
             
           // += "?tenant=" + _client.getTenant();
        }

        public virtual string get3DSpaceURL
        {
            get
            { return _3dxSpaceUrl; }
        }

        public virtual string get3DPassportURL
        {
            get
            { return _3dxPassportUrl; }
        }

        public virtual string getTenantID
        {
            get
            { return _3dxCloudTenantID; }
            
        }

        public virtual string getTenantURL
        {
            get
            { return _3dxCloudTenantUrl; }

        }

        public virtual string getLoginTicket
        {
            get
            { return _loginTicket; }

        }

        public void set3DLoginTicket(string loginticket)
        {
            _loginTicket = loginticket;
        }

        public virtual string getcsrfLoginTicket
        {
            get
            { return _CSRFloginTicket; }

        }

        public void setcsrfLoginTicket(string csrfloginticket)
        {
            _CSRFloginTicket = csrfloginticket;
        }

        public virtual string getServer_Type()
        {
            return _3dxServerType;
        }

        public virtual RESTClientUrlLoader URLLoader
        {
            get
            {
                return _URL_loader;
            }
        }

        public static string getJSON(sbyte[] b)
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            string myString = enc.GetString((byte[])(Array)b);
            return myString;
        }

        //public string makeRequest_WebRequestMode()
        //{
        //    string strResponseValue = string.Empty;

        //    var request = (HttpWebRequest)WebRequest.Create(endPoint);

        //    request.Method = httpMethod.ToString();


        //    HttpWebResponse response = null;


        //    try
        //    {
        //        response = (HttpWebResponse)request.GetResponse();


        //        //Proecess the resppnse stream... (could be JSON, XML or HTML etc..._

        //        using (Stream responseStream = response.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                using (StreamReader reader = new StreamReader(responseStream))
        //                {
        //                    strResponseValue = reader.ReadToEnd();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //We catch non Http 200 responses here.
        //        strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
        //    }
        //    finally
        //    {
        //        if (response != null)
        //        {
        //            ((IDisposable)response).Dispose();
        //        }
        //    }

        //    return strResponseValue;

        //}

        //public string makeRequest_HttpClientMode ()
        //{
        //    string strResponseValue = string.Empty;
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(endPoint);
        //    HttpResponseMessage response; 
        //    // Add an Accept header for JSON format.    
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    // List all Names.    
        //    try
        //    {
        //        response = client.GetAsync(endPoint).Result;
        //        // Blocking call!    
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var products = response.Content.ReadAsStringAsync().Result;
        //            strResponseValue = products.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //We catch non Http 200 responses here.
        //      //  strResponseValue = (int)response.StatusCode + response.ReasonPhrase;
        //    }

        //    return strResponseValue;
        //}


        //public static bool OnCertificateValidation(object sender, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors errors)
        //{
        //    Console.WriteLine("Subject: {0}", certificate.Subject);
        //    Console.WriteLine("Effective date: {0}", certificate.GetEffectiveDateString());
        //    Console.WriteLine("Expiration date: {0}", certificate.GetExpirationDateString());
        //    Console.WriteLine("Issuer: {0}", certificate.Issuer);
        //    Console.WriteLine("Key algorithm: {0}", certificate.GetKeyAlgorithm());
        //    Console.WriteLine("Certificate hash: {0}", certificate.GetCertHashString());
        //    Console.WriteLine("Public key: {0}", certificate.GetPublicKeyString());
        //    Console.WriteLine("Serial number: {0}", certificate.GetSerialNumberString());
        //    Console.WriteLine("SSL policy errors: {0}", errors);
        //    return (errors == SslPolicyErrors.None);
        //}

        //public string WebRequest_3dxLoginTicket ()
        //{
        //    string strResponseValue = string.Empty;
        //    get3DPassportURL();
        //    _3dxPassportUrl = protocol + "://" + urlstring + "/3dpassport";
        //    string urllogin = _3dxPassportUrl + "/login?action=get_auth_params";
        //    // string urllogin = _3dxSpaceUrl + "/ticket/get?runasctx=" + Securitycontext + "&accept=text/plain";
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urllogin);
        //    request.Method = httpMethod.ToString();
        //    CookieContainer cookieContainerPassport = new CookieContainer();
        //    request.CookieContainer = cookieContainerPassport;
        //    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        //    // request.ServerCertificateValidationCallback += OnCertificateValidation;
        //    HttpWebResponse response = null;
        //    HttpWebResponse responsePost = null;
        //    try
        //    {
        //        response = (HttpWebResponse)request.GetResponse();
        //        //Proecess the resppnse stream... (could be JSON, XML or HTML etc..._
        //         string response_str = response.GetResponseStream().ToString();
        //        string lt = "";

        //        using (Stream responseStream = response.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                using (StreamReader reader = new StreamReader(responseStream))
        //                {
        //                    strResponseValue = reader.ReadToEnd();
        //                    _loginTicket = strResponseValue.Substring(strResponseValue.IndexOf("lt", StringComparison.Ordinal) + 5);
        //                    _loginTicket = lt.Substring(0, lt.IndexOf("\"", StringComparison.Ordinal));
        //                }
        //            }
        //        }

        //        string post_data_str;
        //        string usernameEnc = Uri.EscapeUriString(username);
        //        string passwordEnc = Uri.EscapeUriString(pwsd);
        //        post_data_str = "lt=" + _loginTicket + "&username=" + usernameEnc + "&password=" + passwordEnc;

        //        sbyte[] post_data = new sbyte[System.Text.Encoding.UTF8.GetByteCount(post_data_str)];
        //        System.Text.Encoding.UTF8.GetBytes(post_data_str, 0, post_data_str.Length, (byte[])(object)post_data, 0);
        //        get3DSpaceURL();
        //        string space3ds_url_str = _3dxSpaceUrl + '/';
        //        string passport3ds_login_url_str = _3dxPassportUrl + "/login?service=" + Uri.EscapeUriString(space3ds_url_str);
        //        string encodageForm = "application/x-www-form-urlencoded;charset=UTF-8";

        //        HttpWebRequest requestPost = (HttpWebRequest)WebRequest.Create(passport3ds_login_url_str);
        //        requestPost.Method = "POST";
        //        requestPost.ContentType = encodageForm;
        //        requestPost.ContentLength = post_data.Length;
        //        requestPost.Accept = "application/json";
        //        CookieContainer cookieContainerSpace = new CookieContainer();
        //        requestPost.CookieContainer = cookieContainerSpace;

        //        Stream responseStreamPost = requestPost.GetRequestStream();

        //        string post_data_str_wrt = System.Text.Encoding.UTF8.GetString((byte[])(object)post_data, 0, post_data.Length);
        //        // - Add POST information to request header
        //        responseStreamPost.Write((byte[])(Array)post_data, 0, post_data.Length);

        //        responsePost = (HttpWebResponse)requestPost.GetResponse();

        //        using (responseStreamPost = responsePost.GetResponseStream())
        //        {
        //            if (responseStreamPost != null)
        //            {
        //                using (StreamReader reader = new StreamReader(responseStreamPost))
        //                {
        //                    strResponseValue = reader.ReadToEnd();
        //                   // lt = strResponseValue.Substring(strResponseValue.IndexOf("lt", StringComparison.Ordinal) + 5);
        //                   // lt = lt.Substring(0, lt.IndexOf("\"", StringComparison.Ordinal));
        //                }
        //            }
        //        }

        //        //strResponseValue = responsePost.GetResponseStream().ToString();




        //    }
        //    catch (Exception ex)
        //    {
        //        //We catch non Http 200 responses here.
        //        strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
        //    }
        //    finally
        //    {
        //        if (response != null)
        //        {
        //            ((IDisposable)response).Dispose();
        //        }
        //    }

        //    return strResponseValue;

        //}

        //public string HttpClientMode_3dSpaceLogin()
        //{
        //    string strResponseValue = string.Empty;

        //    get3DPassportURL();

        //    string urllogin = _3dxPassportUrl + "/login?action=get_auth_params";
        ////    get3DSpaceURL();
        // //   string urllogin = _3dxSpaceUrl + "/ticket/get?runasctx=" + Securitycontext + "&accept=text/plain";
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(urllogin);
        //    HttpResponseMessage response;
        //    // Add an Accept header for JSON format.    
        //   client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    // List all Names.    
        //    try
        //    {

        //        response = client.GetAsync(urllogin).Result;

        //        // Blocking call!    
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var products = response.Content.ReadAsStringAsync().Result;
        //            strResponseValue = products.ToString();
        //        }
        //        strResponseValue = (int)response.StatusCode + response.ReasonPhrase;
        //    }
        //    catch (Exception ex)
        //    {
        //        //We catch non Http 200 responses here.
        //        //  strResponseValue = (int)response.StatusCode + response.ReasonPhrase;
        //    }

        //    return strResponseValue;
        //}

        //public string webrequest_3dxconnection()
        //{
        //    string strResponseValue = string.Empty;

        //    //  get3DPassportURL();
        //    getServerURL();
        //    // string urllogin = _3dxPassportUrl + "/login?action=get_auth_params";
        //    string urllogin = _3dxServerUrl + "/login?action=get_auth_params";
        //    Uri url = new Uri(urllogin);

        //    HttpWebRequest connection = (HttpWebRequest)HttpWebRequest.Create(url);

        //    //if (!string.ReferenceEquals(Securitycontext, null) && (Securitycontext.Length != 0))
        //    //{
        //    //    connection.Headers["SecurityContext"] = Uri.EscapeUriString(Securitycontext);
        //    //    //log.Debug("  [HEADER] SecurityContext: " + Securitycontext + " encoded as: " + Uri.EscapeUriString(Securitycontext) + " <-");
        //    //}
        //    connection.Method = "GET";
        //    connection.Accept = "application/json";


        //    HttpWebResponse myHttpWebResponse = null;
        //  //  try
        //   // {
        //        myHttpWebResponse = (HttpWebResponse)connection.GetResponse();

        //        _response_code = myHttpWebResponse.StatusCode;
        //        _response_msg = myHttpWebResponse.ToString();


        //  //  }
        //    return _response_msg;
        //}
    }
}
