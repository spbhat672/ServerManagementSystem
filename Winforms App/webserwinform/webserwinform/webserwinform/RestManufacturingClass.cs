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
    class RestManufacturingClass
    {

        private RestClient _client; // common client toolbox
        public RestManufacturingClass(RestClient client)
        {
            _client = client;
        }
        public string Get_MfgItem(string MfgID)
        {

            string response_str;
            sbyte[] response;
            string space3ds_url_str_mFG = _client.get3DSpaceURL + "/resources/v1/modeler/dsmfg/dsmfg:MfgItem/" + MfgID;
          //  string space3ds_url_str_mFG = _client.get3DSpaceURL + "/resources/v1/modeler/dsmfg/dsmfg:MfgItem/3B65BD56059E00005FE0FB860004274F";
            string passport3ds_login_url_str = _client.getDemoCenterLoginURL + "/login?service=" + Uri.EscapeUriString(space3ds_url_str_mFG);
            response = _client.URLLoader.loadUrl(passport3ds_login_url_str, "GET", null, null, false, "application/json", "", null, "", "");

            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            //log.Debug("#RESPONSE BODY");
            //log.Debug("#--------------------");
            //log.Debug(response_str.ToString());

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");
            return response_str;
        }

        public string Get_MfgItemfromEngItem()
        {

            string response_str ="";
            sbyte[] response;
            string space_post_data_str = "[3B65BD5667D400005FF20A4F000D593D, 3B65BD5667D400005FF2120300009F32]";
            string space3ds_url_str_mfg = _client.get3DSpaceURL + "/resources/v1/modeler/dsmfg/invoke/dsmfg:getMfgItemsFromEngItem";
            sbyte[] post_data = new sbyte[System.Text.Encoding.UTF8.GetByteCount(space_post_data_str)];
            System.Text.Encoding.UTF8.GetBytes(space_post_data_str, 0, space_post_data_str.Length, (byte[])(object)post_data, 0);

            string encodageForm = "application/json;charset=UTF-8";
            response = _client.URLLoader.loadUrl(Uri.EscapeUriString(space3ds_url_str_mfg), "POST", encodageForm, post_data, false, "application/json", "", null, "", "");

            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            ////log.Debug("#RESPONSE BODY");
            ////log.Debug("#--------------------");
            ////log.Debug(response_str.ToString());

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");
            return response_str;
        }
    }
}
