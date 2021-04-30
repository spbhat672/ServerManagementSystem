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
using Newtonsoft.Json;
using System.Text.Json;
using System.Dynamic;

namespace webserwinform
{

    class RestClientLogin
    {
        private RestClient _client; // common client toolbox
        private Csrf csrf;
        public RestClientLogin(RestClient client)
        {
            _client = client;
        }


        public virtual void login(string username, string password, string securitycontext)
        {
            string response_str;
            sbyte[] response;
            string passport3ds_lt_url_str = "";
            string passport3ds_url_str = "";
            string space3ds_url_str_CSRF = "";
            string space3ds_url_str_CSRF_Cloud = "";

            if (_client.getServer_Type() == "On Premise")
            {
                passport3ds_url_str = _client.get3DPassportURL;
                space3ds_url_str_CSRF = _client.get3DSpaceURL + "/resources/v1/application/CSRF";
            }
            else if (_client.getServer_Type() == "Cloud")
            {
                passport3ds_url_str = _client.getCloudLoginURL;
                space3ds_url_str_CSRF = _client.getTenantURL + "/resources/v1/application/CSRF" + _client.getTenantID;
            }
            else if (_client.getServer_Type() == "Demo Center")
            {
                passport3ds_url_str = _client.getDemoCenterLoginURL;
                space3ds_url_str_CSRF = _client.get3DSpaceURL + "/resources/v1/application/CSRF";
            }

             // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 1   Retrieve the login ticket == 
            // == GET <3DPassport server>/login?action=get_auth_params 
            passport3ds_lt_url_str = passport3ds_url_str + "/login?action=get_auth_params";
            // - Load URL
            response = _client.URLLoader.loadUrl(passport3ds_lt_url_str, "GET", null, null, false, "application/json", "", null, "", "");
            // - Display Response
            //response_str = StringHelperClass.NewString(response, CAAi3dxClient.ENCODING);
            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");

            // - Catch Login Ticket LT from response body
            string lt = response_str.Substring(response_str.IndexOf("lt", StringComparison.Ordinal) + 5);
            lt = lt.Substring(0, lt.IndexOf("\"", StringComparison.Ordinal));
            _client.set3DLoginTicket(lt);


            // == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
            // == STEP 2   ==
            // == POST <3DPassport CAS server>/login & 3DSpace login

            // - Prepare data to send
            string post_data_str;
            
            string usernameEnc = Uri.EscapeUriString(username);//.encode(username, CAAi3dxClient.ENCODING);
            string passwordEnc = Uri.EscapeUriString(password);// CAAi3dxClient.ENCODING);
            post_data_str = "lt=" + lt + "&username=" + usernameEnc + "&password=" + passwordEnc;

            // sbyte[] post_data = post_data_str.GetBytes();
            sbyte[] post_data = new sbyte[System.Text.Encoding.UTF8.GetByteCount(post_data_str)];
            System.Text.Encoding.UTF8.GetBytes(post_data_str, 0, post_data_str.Length, (byte[])(object)post_data, 0);

            // - Build 3DPassport login web service URL
            string passport3ds_login_url_str = passport3ds_url_str + "/login";
            // - Load URL
            string encodageForm = "application/x-www-form-urlencoded;charset=UTF-8";
            response = _client.URLLoader.loadUrl(passport3ds_login_url_str, "POST", encodageForm, post_data, false, "application/json", "", null, "", "");
            // - Display Response
            //response_str = StringHelperClass.NewString(response, CAAi3dxClient.ENCODING);
            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            //Pay attention the previous call can return 200 while the authentication has failed.
            int indexError = response_str.IndexOf("error.authentication.credentials.bad", StringComparison.Ordinal);
            if (indexError > 0)
            {
                //log.Debug("#--------------------");
                //log.Debug("error.authentication.credentials.bad");
                throw new Exception("Login error: check login or password values");
            }

            // - Check the successuful login to the service:  
            //     - The url of redirection is the input url service in adjonction with a service ticket.
            //     - The response (to the redirection) is 200.
            //
            Uri last_dirURL = RESTClientUrlLoader.LastRedirectUrl;

            bool issue = true;
            if ((_client.URLLoader.ResponseCode == HttpStatusCode.OK) && last_dirURL != null)
            {
                string queryURL = last_dirURL.Query;
                int index_ticket = queryURL.IndexOf("ticket=", StringComparison.Ordinal);
                if (index_ticket != -1)
                {
                    issue = false;
                }
            }
            if (issue)
            {
                //log.Debug("#--------------------");
                //log.Debug("Issue with the " + space3ds_url_str + " login. Check if the last returned code is 200, and the URL contains the ticket quey parameter");
              //  throw new Exception("Login issue with ->" + space3ds_url_str);
            }

            _client.URLLoader.SecurityContext = securitycontext;
           // // string space3ds_url_str_CSRF_Cloud = "https://" +"r1132100693975-indw2-space.3dexperience.3ds.com/enovia" + "?tenant=" + "R1132100693975" + " / resources/v1/application/CSRF";
           //// string space3ds_url_str_CSRF = _client.get3DSpaceURL + "/resources/v1/application/CSRF";
           // string space3ds_url_str_CSRF_Cloud = "https://" + "r1132100693975-indw2-space.3dexperience.3ds.com/enovia" + "/resources/v1/application/CSRF" +"?tenant="+ "R1132100693975";
            //passport3ds_login_url_str = passport3ds_url_str + "/login?service=" + Uri.EscapeUriString(space3ds_url_str_CSRF);
            response = _client.URLLoader.loadUrl(Uri.EscapeUriString(space3ds_url_str_CSRF), "GET", null, null, false, "application/json", "", null, "", "");

            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            //log.Debug("#RESPONSE BODY");
            //log.Debug("#--------------------");
            //log.Debug(response_str.ToString());

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");


            // - Catch Login Ticket LT from response body
            string csrfValue = response_str.Substring(response_str.IndexOf("value", StringComparison.Ordinal) + 8);
            csrfValue = csrfValue.Substring(0, csrfValue.IndexOf("\"", StringComparison.Ordinal));
            string csrfName = response_str.Substring(response_str.IndexOf("name", StringComparison.Ordinal) + 7);
            csrfName = csrfName.Substring(0, csrfName.IndexOf("\"", StringComparison.Ordinal));

           
          ////  csrf.name = csrfName;
         //   csrf.value = csrfValue;

            _client.URLLoader.setCSRFHeader = csrfName;
            _client.URLLoader.setCSRFTokenValue = csrfValue;
            _client.setcsrfLoginTicket(csrfName + ":   "  + csrfValue);
            //string space_post_data_str = "{\"items\":[{ \"attributes\": { \"title\": \"webservprd\", \"description\": \"webservprd\"} }]}";
            // space3ds_url_str_CSRF_Cloud = "https://" + "r1132100693975-indw2-space.3dexperience.3ds.com/enovia" + "/resources/v1/modeler/dseng/dseng:EngItem" + "?tenant=" + "R1132100693975";
            ////string space3ds_url_str_Eng = _client.get3DSpaceURL + "/resources/v1/modeler/dseng/dseng:EngItem";
            //post_data = new sbyte[System.Text.Encoding.UTF8.GetByteCount(space_post_data_str)];
            //System.Text.Encoding.UTF8.GetBytes(space_post_data_str, 0, space_post_data_str.Length, (byte[])(object)post_data, 0);
            //encodageForm = "application/json;charset=UTF-8";
            //response = _client.URLLoader.loadUrl(Uri.EscapeUriString(space3ds_url_str_CSRF_Cloud), "POST", encodageForm, post_data, false, "application/json", "", null, "", "");
            //// - Display Response
            ////response_str = StringHelperClass.NewString(response, CAAi3dxClient.ENCODING);
            //response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            //if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");

            //string space3ds_url_str_mFG = _client.get3DSpaceURL + "/resources/v1/modeler/dsmfg/dsmfg:MfgItem/3B65BD56059E00005FE0FB860004274F";
            //passport3ds_login_url_str = passport3ds_url_str + "/login?service=" + Uri.EscapeUriString(space3ds_url_str_mFG);
            //response = _client.URLLoader.loadUrl(passport3ds_login_url_str, "GET", null, null, false, "application/json", "", null, "", "");

            //response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            ////log.Debug("#RESPONSE BODY");
            ////log.Debug("#--------------------");
            ////log.Debug(response_str.ToString());

            //if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");


            // - Catch Login Ticket LT from response body
            //string mfg = response_str.Substring(response_str.IndexOf("csrf", StringComparison.Ordinal) + 5);


            //lt = lt.Substring(0, lt.IndexOf("\"", StringComparison.Ordinal));


        }

    }    
}
