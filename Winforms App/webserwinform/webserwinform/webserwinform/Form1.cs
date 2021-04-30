using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;

namespace webserwinform
{
    public partial class Form1 : Form
    {

        RestClient rclient;
        Event_Json_Root myDeserializedClass;
        bool isPremserver = false;
        Event_Json_Onprem_Root myDeserializedClass_onprem;

        private delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
             myDeserializedClass = new Event_Json_Root() ;
            myDeserializedClass_onprem = new Event_Json_Onprem_Root();
            // Declare and construct the ColumnHeader objects.

           
        }


        // CAAi3dxClient client = new CAAi3dxClient(space3ds_server, pass3ds_server, output_dir, tenant);
        //  CAAi3dxLoginClient client_login = new CAAi3dxLoginClient(client);
        // CAAi3dxGetWebServicesClient client_GetWS = new CAAi3dxGetWebServicesClient(client, app_path);


        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Login_Result_txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //  this.Login_Result_txt.Text = text;

                Event_Text.Text = text;
                //   var readOnlySpan = new ReadOnlySpan<byte>();
                //ListViewItem item = new ListViewItem();
                //if (isPremserver)
                //{
                //    myDeserializedClass_onprem = JsonConvert.DeserializeObject<Event_Json_Onprem_Root>(text);
                //    item.SubItems.Add("Created");
                //    foreach (var child in myDeserializedClass_onprem.Event_Json_OnpremData)
                //    {
                //        // Console.WriteLine(string.Format("Key: {0}, books:{1},min:{2},max:{3},fee:{4}",


                //        item.SubItems.Add(child.Value.Type);
                      
                //        // Event_Json_OnpremData.
                //        // child.Key, child.Value.books, child.Value.max, child.Value.min, child.Value.fee));
                //    }

                    //item.SubItems.Add(myDeserializedClass_onprem.Event_Json_OnpremData.Type);
                    //item.SubItems.Add()
                    //Console.WriteLine(myDeserializedClass_onprem.Event_Json_OnpremData.Type);
                    //item.SubItems.Add(myDeserializedClass.Event_Data.User);
                    //Console.WriteLine(myDeserializedClass.Event_Data.User);
                    //item.SubItems.Add(myDeserializedClass.Event_Data.Event_Subject.Type);
                    //Console.WriteLine(myDeserializedClass.Event_Data.Event_Subject.Type);
                    //item.SubItems.Add(myDeserializedClass.Event_Data.Event_Subject.Identifier);
                    //Console.WriteLine(myDeserializedClass.Event_Data.Event_Subject.Identifier);
                    //item.SubItems.Add(myDeserializedClass.Event_Data.Event_Object.Value);
               // }
               // else
               // {
                    //myDeserializedClass = JsonConvert.DeserializeObject<Event_Json_Root>(text);
                    
                    //item.SubItems.Add(myDeserializedClass.Type);
                    //Console.WriteLine(myDeserializedClass.Type);
                    //foreach (var child in myDeserializedClass.Event_Data)
                    //{
                    //    item.SubItems.Add(child.Value.User);
                    //    Console.WriteLine(myDeserializedClass.Type);
                    //}
                   
                    ////item.SubItems.Add(myDeserializedClass.Event_Data.Event_Subject.Type);
                    ////Console.WriteLine(myDeserializedClass.Event_Data.Event_Subject.Type);
                    ////item.SubItems.Add(myDeserializedClass.Event_Data.Event_Subject.Identifier);
                    ////Console.WriteLine(myDeserializedClass.Event_Data.Event_Subject.Identifier);
                    ////item.SubItems.Add(myDeserializedClass.Event_Data.Event_Object.Value);
            //    }

               // Process_List_View.Items.Add(item);

                // weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(readOnlySpan);

            }
        }
        void QueueSubscriber_OnMessageReceived(string message)
        {
           // Login_Result_txt.Text = message;
           SetText(message);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //this.SimpleTopicSubscriber.OnMessageReceived += new MessageReceivedDelegate(subscriber_OnMessageReceived)

              string ServerType_Value = "";
              string Tenantid_value = "";
              string Tenant_Country = "";
              bool lowercaseurl = false;
              bool isChecked_DemoCenter = Demo_Center.Checked;
              bool isChecked_Cloud = Cloud_Type.Checked;
              bool isChecked_OnPrem = On_Premise.Checked;
              if (isChecked_DemoCenter)
              {
                  ServerType_Value = Demo_Center.Text;
              }
              else if (isChecked_Cloud)
              {
                  ServerType_Value = Cloud_Type.Text;
                  Tenantid_value = Tenant_id_txt.Text;
                  Tenant_Country = Tenant_Region.Text;

              }
              else
              {
                  ServerType_Value = On_Premise.Text;
                  lowercaseurl = url_lowercase.Checked;
              }

              rclient = new RestClient("https", url_text.Text, port_text.Text, ServerType_Value, Tenantid_value, Tenant_Country,lowercaseurl);
              RestClientLogin rClientlogin = new RestClientLogin(rclient);



              rClientlogin.login(usrname_text.Text, pwd_text.Text, cnxt_text.Text);

              string strJSONLT = string.Empty;
              string strJSONCSRF = string.Empty;
              strJSONLT = rclient.getLoginTicket;
             // debugOutput(strJSONLT);
              strJSONCSRF = rclient.getcsrfLoginTicket;
          //    string value = strJSONLT + "\n" + strJSONCSRF;
              debugOutput(strJSONLT + Environment.NewLine +strJSONCSRF);
              //string AprisoServerlUlr = "vdemopro1098dsy.extranet.3ds.com";

              // debugOutput("RESTClient Object created.");

              // strJSONLT = rClientApr.Get_orderStatus(protocol,AprisoServerlUlr);
              //strJSONLT = rClientApr.Post_ProductData(protocol,AprisoServerlUlr);
              //
              //strJSONLT = rClientMfg.Get_MfgItemfromEngItem();
              // strJSONspace = rClientPrd.Create_EngItem();

              //   strJSONspace = rClient.Get_CSRFToken();
              // strJSON = rClient.HttpClientMode_3dSpaceLogin();
              // strJSON = rClient.webrequest_3dxconnection();  


        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                Login_Result_txt.Text = strDebugText;
                Login_Result_txt.Text = Login_Result_txt.Text + strDebugText + Environment.NewLine;
                Login_Result_txt.SelectionStart = Login_Result_txt.TextLength;
                Login_Result_txt.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Prd_Apply_Button_Click(object sender, EventArgs e)
        {

            RestProductClass rClientPrd = new RestProductClass(rclient);
            if (Create_Product.Checked)
            {
                string prdInof = rClientPrd.Create_EngItem(Prd_Title_Text.Text);
                Result_Prd_Data.Text = prdInof;
            }
            else if  (Get_Product_List.Checked)
            {
                string prdInof = rClientPrd.Search_EngItem(Prd_Name_Text.Text);
                Result_Prd_Data.Text = prdInof;
            }
            else if (Get_Product_Details.Checked)
            {
                string prdInof = rClientPrd.Get_EngItem(Prd_ID_txt.Text);
                Result_Prd_Data.Text = prdInof;
            }
        }

        private void Mfg_Item_Button_Click(object sender, EventArgs e)
        {
            RestManufacturingClass rClientMfg = new RestManufacturingClass(rclient);

            if (Get_mfg_Assembly.Checked)
            {
                string MfgInof = rClientMfg.Get_MfgItem(Mfgid_Txt.Text);
                Result_Mfg_Data.Text = MfgInof;
            }

            
        }

        private void Apr_Input_Click(object sender, EventArgs e)
        {
            RestClientApriso rClientApr = new RestClientApriso();
            string protocol = "https";

            if (Order_Status.Checked)
            {
               string orderExeStatus =  rClientApr.Get_orderStatus(protocol,Apr_url_txt.Text,Order_ID_Status_txt.Text);
                Result_Apr_Data.Text = orderExeStatus;
            }
            else if  (Apr_CreateOrder.Checked)
            {
               string orderStatus = rClientApr.Post_ProductData(protocol, Apr_url_txt.Text,Order_ID_Txt.Text);
                Result_Apr_Data.Text = orderStatus;
            }
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {

            //string brokerUri = "failover:(ssl://pod171-33-98-34.3dexperience.3ds.com:80,ssl://pod171-33-98-34-1.3dexperience.3ds.com:80)?randomize=false";
            //string AgentID = "d4974b15-64fe-4558-ad56-dd7f281ccba9";
            //string AgentPwd = "E<${uQM|7UR0b,)+P33M}hC*";
            //string tenantid = "R1132100000797";

            //string brokerUri = "tcp://BANVMWINDSI07.dsone.3ds.com:61616";
            //string AgentID = "";
            //string AgentPwd = "";
            //string tenantid = "";

            string brokerUri = Broker_uri_txt.Text;
            string AgentID = Agent_ID_txt.Text;
            string AgentPwd = Agent_Pwd_txt.Text;
            string tenantid = Tenant_name_txt.Text;
            isPremserver = false;
            if (tenantid == "")
            {
                isPremserver = true;
            }


            //string AgentID = "92fc6ff0-ddd2-45a3-946b-50c4b27f16d2";
            //string AgentPwd = "36<=B,k>B.gK9m{1xR=E\\2I(";
            //string tenantid = "R1132101176669 ";
            //string brokerUri = "failover:(ssl://pod171-33-98-34.3dexperience.3ds.com:80,ssl://pod171-33-98-34-1.3dexperience.3ds.com:80)?randomize=false";

            JMS_Event_Consumer_onPrem evtcons = new JMS_Event_Consumer_onPrem(tenantid, brokerUri, AgentID, AgentPwd);
            evtcons.OnMessageReceived += new QMessageReceivedDelegate(QueueSubscriber_OnMessageReceived);

        }
    }
}
