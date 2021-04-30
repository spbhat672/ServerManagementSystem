using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace webserwinform
{
    class RestProductClass
    {

        String Create_EngItem_Path  = "/resources/v1/modeler/dseng/dseng:EngItem";
        String Srch_ListEngItem_Path = "​/resources​/v1​/modeler​/dseng​/dseng:EngItem​/search?search=";
        String Get_EngItem_Path = "/resources/v1/modeler/dseng/dseng:EngItem/";
    

    private RestClient _client; // common client toolbox
        public RestProductClass(RestClient client)
        {
            _client = client;
        }
        public string Create_EngItem(string Prd_Title)
        {
            string response_str;
            sbyte[] response;
            string space3ds_url_str_Eng = "";

            if (_client.getServer_Type() == "On Premise")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Create_EngItem_Path;
            }
            else if (_client.getServer_Type() == "Cloud")
            {
                space3ds_url_str_Eng = _client.getTenantURL + Create_EngItem_Path + _client.getTenantID;
            }
            else if (_client.getServer_Type() == "Demo Center")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Create_EngItem_Path;
            }

            string datahdr = "{\"items\":[{ \"attributes\":";
            string datat = "{ \"title\":" + '\"' + Prd_Title + '\"' + ",";
            string datad = "\"description\":" + '\"' + Prd_Title + '\"' + "} }]}";
            string space_post_data_str = datahdr + datat + datad;

           // string space_post_data_str_test = "{\"items\":[{ \"attributes\": { \"title\": \"webservprd\", \"description\": \"webservprd\"} }]}";
             
            sbyte[] post_data = new sbyte[System.Text.Encoding.UTF8.GetByteCount(space_post_data_str)];
            System.Text.Encoding.UTF8.GetBytes(space_post_data_str, 0, space_post_data_str.Length, (byte[])(object)post_data, 0);
            // space3ds_url_str = _Client.get3DSpaceURL() + "/";
            string passport3ds_login_url_str = _client.getDemoCenterLoginURL+ "/login?service=" + Uri.EscapeUriString(space3ds_url_str_Eng);
            string encodageForm = "application/json;charset=UTF-8";
            response = _client.URLLoader.loadUrl(space3ds_url_str_Eng, "POST", encodageForm, post_data, false, "application/json", "", null, "", "");
            // - Display Response
            //response_str = StringHelperClass.NewString(response, CAAi3dxClient.ENCODING);
            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);
           
            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");
            return response_str;
        }

        public string Get_EngItem(string Prd_ID)
        {
            string response_str;
            sbyte[] response;

            string space3ds_url_str_Eng = "";

            if (_client.getServer_Type() == "On Premise")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Get_EngItem_Path + Prd_ID; ;
            }
            else if (_client.getServer_Type() == "Cloud")
            {
                space3ds_url_str_Eng = _client.getTenantURL + Get_EngItem_Path +  Prd_ID +  _client.getTenantID  ;
            }
            else if (_client.getServer_Type() == "Demo Center")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Get_EngItem_Path + Prd_ID; ;
            }

            //string space3ds_url_str_Eng = _client.get3DSpaceURL + Get_EngItem_Path + Prd_ID;
            //string passport3ds_login_url_str = _client.getDemoCenterLoginURL + "/login?service=" + Uri.EscapeUriString(space3ds_url_str_Eng);
            response = _client.URLLoader.loadUrl(space3ds_url_str_Eng, "GET", null, null, false, "application/json", "", null, "", "");
            // - Display Response
            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");
            return response_str;
        }

        public string Search_EngItem(string Prd_Name)
        {
            string response_str;
            sbyte[] response;

            string space3ds_url_str_Eng = "";

            if (_client.getServer_Type() == "On Premise")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Get_EngItem_Path + Prd_Name; 
            }
            else if (_client.getServer_Type() == "Cloud")
            {
                space3ds_url_str_Eng = _client.getTenantURL + Get_EngItem_Path + Prd_Name +_client.getTenantID  ;
            }
            else if (_client.getServer_Type() == "Demo Center")
            {
                space3ds_url_str_Eng = _client.get3DSpaceURL + Get_EngItem_Path + Prd_Name;
            }

            //string datahdr = "{\"items\":[{ \"attributes\":";
            //string datat = "{ \"title\":" + '\"' + Prd_Title + '\"' + ",";
            //string datad = "\"description\":" + '\"' + Prd_Title + '\"' + "} }]}";
            //string space_post_data_str = datahdr + datat + datad;


           // string space3ds_url_str_Eng = _client.get3DSpaceURL + Srch_ListEngItem_Path + Prd_Name;
            //string passport3ds_login_url_str = _client.getDemoCenterLoginURL + "/login?service=" + Uri.EscapeUriString(space3ds_url_str_Eng);
            response = _client.URLLoader.loadUrl(space3ds_url_str_Eng, "GET", null, null, false, "application/json", "", null, "", "");
            // - Display Response
            //response_str = StringHelperClass.NewString(response, CAAi3dxClient.ENCODING);
            response_str = System.Text.Encoding.GetEncoding(RestClient.ENCODING).GetString((byte[])(object)response, 0, response.Length);

            if (response_str == "") throw new Exception("3DPassport get_auth_params returned nologin ticket ");
            return response_str;
        }
    }
}
