
namespace webserwinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LoginCredentials = new System.Windows.Forms.GroupBox();
            this.cnxt_text = new System.Windows.Forms.TextBox();
            this.Cnxt_label = new System.Windows.Forms.Label();
            this.pwd_text = new System.Windows.Forms.TextBox();
            this.usrname_text = new System.Windows.Forms.TextBox();
            this.port_text = new System.Windows.Forms.TextBox();
            this.url_text = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.Port_Number = new System.Windows.Forms.Label();
            this.url_name = new System.Windows.Forms.Label();
            this.WebServices = new System.Windows.Forms.TabControl();
            this.Login_Tab = new System.Windows.Forms.TabPage();
            this.Login_Result_txt = new System.Windows.Forms.TextBox();
            this.Server_Type = new System.Windows.Forms.GroupBox();
            this.Cloud_Tenant = new System.Windows.Forms.GroupBox();
            this.Tenant_Region = new System.Windows.Forms.TextBox();
            this.Tenant_Country = new System.Windows.Forms.Label();
            this.Tenant_id_txt = new System.Windows.Forms.TextBox();
            this.Tenant_ID = new System.Windows.Forms.Label();
            this.url_lowercase = new System.Windows.Forms.CheckBox();
            this.Demo_Center = new System.Windows.Forms.RadioButton();
            this.Cloud_Type = new System.Windows.Forms.RadioButton();
            this.On_Premise = new System.Windows.Forms.RadioButton();
            this.Application_Tab = new System.Windows.Forms.TabPage();
            this.tabcontrol_1 = new System.Windows.Forms.TabControl();
            this.Engineering_Tab = new System.Windows.Forms.TabPage();
            this.Prd_Apply_Button = new System.Windows.Forms.Button();
            this.Prd_ID_txt = new System.Windows.Forms.TextBox();
            this.Prd_Name_Text = new System.Windows.Forms.TextBox();
            this.Prd_Title_Text = new System.Windows.Forms.TextBox();
            this.Prd_ID = new System.Windows.Forms.Label();
            this.Prd_Name = new System.Windows.Forms.Label();
            this.Prd_Title = new System.Windows.Forms.Label();
            this.Result_Prd_Data = new System.Windows.Forms.TextBox();
            this.Get_Product_Details = new System.Windows.Forms.CheckBox();
            this.Get_Product_List = new System.Windows.Forms.CheckBox();
            this.Create_Product = new System.Windows.Forms.CheckBox();
            this.Mfg_Tab = new System.Windows.Forms.TabPage();
            this.Mfg_Item_Button = new System.Windows.Forms.Button();
            this.Result_Mfg_Data = new System.Windows.Forms.TextBox();
            this.Mfgid_Txt = new System.Windows.Forms.TextBox();
            this.Mfg_ID = new System.Windows.Forms.Label();
            this.Get_mfg_Assembly = new System.Windows.Forms.CheckBox();
            this.Execution_Tab = new System.Windows.Forms.TabPage();
            this.Apr_url_txt = new System.Windows.Forms.TextBox();
            this.Apr_Server_lbl = new System.Windows.Forms.Label();
            this.Order_ID_Status_txt = new System.Windows.Forms.TextBox();
            this.Order_Id_Status = new System.Windows.Forms.Label();
            this.Order_Status = new System.Windows.Forms.CheckBox();
            this.Apr_Input = new System.Windows.Forms.Button();
            this.Result_Apr_Data = new System.Windows.Forms.TextBox();
            this.Order_ID_Txt = new System.Windows.Forms.TextBox();
            this.Order_id = new System.Windows.Forms.Label();
            this.Apr_CreateOrder = new System.Windows.Forms.CheckBox();
            this.ERP_Tab = new System.Windows.Forms.TabPage();
            this.Events_Tab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Connection_Param = new System.Windows.Forms.TabPage();
            this.Event_GB = new System.Windows.Forms.GroupBox();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.Tenant_name_txt = new System.Windows.Forms.TextBox();
            this.Agent_Pwd_txt = new System.Windows.Forms.TextBox();
            this.Tenant_ID_lbl = new System.Windows.Forms.Label();
            this.Agent_Pwd_lbl = new System.Windows.Forms.Label();
            this.Agent_ID_lbl = new System.Windows.Forms.Label();
            this.Broker_uri_lbl = new System.Windows.Forms.Label();
            this.Agent_ID_txt = new System.Windows.Forms.TextBox();
            this.Broker_uri_txt = new System.Windows.Forms.TextBox();
            this.Event_Processing = new System.Windows.Forms.TabPage();
            this.Event_Text = new System.Windows.Forms.TextBox();
            this.LoginCredentials.SuspendLayout();
            this.WebServices.SuspendLayout();
            this.Login_Tab.SuspendLayout();
            this.Server_Type.SuspendLayout();
            this.Cloud_Tenant.SuspendLayout();
            this.Application_Tab.SuspendLayout();
            this.tabcontrol_1.SuspendLayout();
            this.Engineering_Tab.SuspendLayout();
            this.Mfg_Tab.SuspendLayout();
            this.Execution_Tab.SuspendLayout();
            this.Events_Tab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Connection_Param.SuspendLayout();
            this.Event_GB.SuspendLayout();
            this.Event_Processing.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginCredentials
            // 
            this.LoginCredentials.Controls.Add(this.cnxt_text);
            this.LoginCredentials.Controls.Add(this.Cnxt_label);
            this.LoginCredentials.Controls.Add(this.pwd_text);
            this.LoginCredentials.Controls.Add(this.usrname_text);
            this.LoginCredentials.Controls.Add(this.port_text);
            this.LoginCredentials.Controls.Add(this.url_text);
            this.LoginCredentials.Controls.Add(this.Pwd);
            this.LoginCredentials.Controls.Add(this.User_Name);
            this.LoginCredentials.Controls.Add(this.Port_Number);
            this.LoginCredentials.Controls.Add(this.url_name);
            this.LoginCredentials.Location = new System.Drawing.Point(6, 6);
            this.LoginCredentials.Name = "LoginCredentials";
            this.LoginCredentials.Size = new System.Drawing.Size(581, 216);
            this.LoginCredentials.TabIndex = 5;
            this.LoginCredentials.TabStop = false;
            this.LoginCredentials.Text = "Login Credentials";
            // 
            // cnxt_text
            // 
            this.cnxt_text.Location = new System.Drawing.Point(118, 161);
            this.cnxt_text.Name = "cnxt_text";
            this.cnxt_text.Size = new System.Drawing.Size(435, 22);
            this.cnxt_text.TabIndex = 9;
            // 
            // Cnxt_label
            // 
            this.Cnxt_label.AutoSize = true;
            this.Cnxt_label.Location = new System.Drawing.Point(7, 161);
            this.Cnxt_label.Name = "Cnxt_label";
            this.Cnxt_label.Size = new System.Drawing.Size(55, 17);
            this.Cnxt_label.TabIndex = 8;
            this.Cnxt_label.Text = "Context";
            // 
            // pwd_text
            // 
            this.pwd_text.Location = new System.Drawing.Point(118, 123);
            this.pwd_text.Name = "pwd_text";
            this.pwd_text.PasswordChar = '*';
            this.pwd_text.Size = new System.Drawing.Size(435, 22);
            this.pwd_text.TabIndex = 7;
            // 
            // usrname_text
            // 
            this.usrname_text.Location = new System.Drawing.Point(118, 90);
            this.usrname_text.Name = "usrname_text";
            this.usrname_text.Size = new System.Drawing.Size(435, 22);
            this.usrname_text.TabIndex = 6;
            // 
            // port_text
            // 
            this.port_text.Location = new System.Drawing.Point(118, 61);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(435, 22);
            this.port_text.TabIndex = 5;
            // 
            // url_text
            // 
            this.url_text.Location = new System.Drawing.Point(118, 32);
            this.url_text.Name = "url_text";
            this.url_text.Size = new System.Drawing.Size(435, 22);
            this.url_text.TabIndex = 4;
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(7, 129);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(69, 17);
            this.Pwd.TabIndex = 3;
            this.Pwd.Text = "Password";
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Location = new System.Drawing.Point(7, 92);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(79, 17);
            this.User_Name.TabIndex = 2;
            this.User_Name.Text = "User Name";
            // 
            // Port_Number
            // 
            this.Port_Number.AutoSize = true;
            this.Port_Number.Location = new System.Drawing.Point(7, 60);
            this.Port_Number.Name = "Port_Number";
            this.Port_Number.Size = new System.Drawing.Size(88, 17);
            this.Port_Number.TabIndex = 1;
            this.Port_Number.Text = "Port Number";
            // 
            // url_name
            // 
            this.url_name.AutoSize = true;
            this.url_name.Location = new System.Drawing.Point(7, 32);
            this.url_name.Name = "url_name";
            this.url_name.Size = new System.Drawing.Size(36, 17);
            this.url_name.TabIndex = 0;
            this.url_name.Text = "URL";
            // 
            // WebServices
            // 
            this.WebServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebServices.Controls.Add(this.Login_Tab);
            this.WebServices.Controls.Add(this.Application_Tab);
            this.WebServices.Location = new System.Drawing.Point(3, 1);
            this.WebServices.Name = "WebServices";
            this.WebServices.SelectedIndex = 0;
            this.WebServices.Size = new System.Drawing.Size(616, 498);
            this.WebServices.TabIndex = 6;
            // 
            // Login_Tab
            // 
            this.Login_Tab.Controls.Add(this.Login_Result_txt);
            this.Login_Tab.Controls.Add(this.Server_Type);
            this.Login_Tab.Controls.Add(this.LoginCredentials);
            this.Login_Tab.Controls.Add(this.button1);
            this.Login_Tab.Location = new System.Drawing.Point(4, 25);
            this.Login_Tab.Name = "Login_Tab";
            this.Login_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Login_Tab.Size = new System.Drawing.Size(608, 469);
            this.Login_Tab.TabIndex = 0;
            this.Login_Tab.Text = "Authentication";
            this.Login_Tab.UseVisualStyleBackColor = true;
            // 
            // Login_Result_txt
            // 
            this.Login_Result_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Result_txt.Location = new System.Drawing.Point(326, 237);
            this.Login_Result_txt.Multiline = true;
            this.Login_Result_txt.Name = "Login_Result_txt";
            this.Login_Result_txt.Size = new System.Drawing.Size(261, 114);
            this.Login_Result_txt.TabIndex = 11;
            // 
            // Server_Type
            // 
            this.Server_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Server_Type.Controls.Add(this.Cloud_Tenant);
            this.Server_Type.Controls.Add(this.url_lowercase);
            this.Server_Type.Controls.Add(this.Demo_Center);
            this.Server_Type.Controls.Add(this.Cloud_Type);
            this.Server_Type.Controls.Add(this.On_Premise);
            this.Server_Type.Location = new System.Drawing.Point(6, 228);
            this.Server_Type.Name = "Server_Type";
            this.Server_Type.Size = new System.Drawing.Size(314, 161);
            this.Server_Type.TabIndex = 10;
            this.Server_Type.TabStop = false;
            this.Server_Type.Text = "Server";
            // 
            // Cloud_Tenant
            // 
            this.Cloud_Tenant.Controls.Add(this.Tenant_Region);
            this.Cloud_Tenant.Controls.Add(this.Tenant_Country);
            this.Cloud_Tenant.Controls.Add(this.Tenant_id_txt);
            this.Cloud_Tenant.Controls.Add(this.Tenant_ID);
            this.Cloud_Tenant.Location = new System.Drawing.Point(6, 52);
            this.Cloud_Tenant.Name = "Cloud_Tenant";
            this.Cloud_Tenant.Size = new System.Drawing.Size(295, 73);
            this.Cloud_Tenant.TabIndex = 6;
            this.Cloud_Tenant.TabStop = false;
            this.Cloud_Tenant.Text = "Cloud Tenant";
            // 
            // Tenant_Region
            // 
            this.Tenant_Region.Location = new System.Drawing.Point(90, 45);
            this.Tenant_Region.Name = "Tenant_Region";
            this.Tenant_Region.Size = new System.Drawing.Size(100, 22);
            this.Tenant_Region.TabIndex = 6;
            // 
            // Tenant_Country
            // 
            this.Tenant_Country.AutoSize = true;
            this.Tenant_Country.Location = new System.Drawing.Point(9, 44);
            this.Tenant_Country.Name = "Tenant_Country";
            this.Tenant_Country.Size = new System.Drawing.Size(61, 17);
            this.Tenant_Country.TabIndex = 5;
            this.Tenant_Country.Text = "Region :";
            // 
            // Tenant_id_txt
            // 
            this.Tenant_id_txt.Location = new System.Drawing.Point(90, 18);
            this.Tenant_id_txt.Name = "Tenant_id_txt";
            this.Tenant_id_txt.Size = new System.Drawing.Size(199, 22);
            this.Tenant_id_txt.TabIndex = 3;
            // 
            // Tenant_ID
            // 
            this.Tenant_ID.AutoSize = true;
            this.Tenant_ID.Location = new System.Drawing.Point(6, 18);
            this.Tenant_ID.Name = "Tenant_ID";
            this.Tenant_ID.Size = new System.Drawing.Size(78, 17);
            this.Tenant_ID.TabIndex = 4;
            this.Tenant_ID.Text = "Tenant ID :";
            // 
            // url_lowercase
            // 
            this.url_lowercase.AutoSize = true;
            this.url_lowercase.Location = new System.Drawing.Point(7, 131);
            this.url_lowercase.Name = "url_lowercase";
            this.url_lowercase.Size = new System.Drawing.Size(132, 21);
            this.url_lowercase.TabIndex = 5;
            this.url_lowercase.Text = "LowerCase URL";
            this.url_lowercase.UseVisualStyleBackColor = true;
            // 
            // Demo_Center
            // 
            this.Demo_Center.AutoSize = true;
            this.Demo_Center.Location = new System.Drawing.Point(118, 29);
            this.Demo_Center.Name = "Demo_Center";
            this.Demo_Center.Size = new System.Drawing.Size(112, 21);
            this.Demo_Center.TabIndex = 2;
            this.Demo_Center.TabStop = true;
            this.Demo_Center.Text = "Demo Center";
            this.Demo_Center.UseVisualStyleBackColor = true;
            // 
            // Cloud_Type
            // 
            this.Cloud_Type.AutoSize = true;
            this.Cloud_Type.Location = new System.Drawing.Point(236, 29);
            this.Cloud_Type.Name = "Cloud_Type";
            this.Cloud_Type.Size = new System.Drawing.Size(65, 21);
            this.Cloud_Type.TabIndex = 1;
            this.Cloud_Type.TabStop = true;
            this.Cloud_Type.Text = "Cloud";
            this.Cloud_Type.UseVisualStyleBackColor = true;
            // 
            // On_Premise
            // 
            this.On_Premise.AutoSize = true;
            this.On_Premise.Location = new System.Drawing.Point(7, 29);
            this.On_Premise.Name = "On_Premise";
            this.On_Premise.Size = new System.Drawing.Size(103, 21);
            this.On_Premise.TabIndex = 0;
            this.On_Premise.TabStop = true;
            this.On_Premise.Text = "On Premise";
            this.On_Premise.UseVisualStyleBackColor = true;
            // 
            // Application_Tab
            // 
            this.Application_Tab.Controls.Add(this.tabcontrol_1);
            this.Application_Tab.Location = new System.Drawing.Point(4, 25);
            this.Application_Tab.Name = "Application_Tab";
            this.Application_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Application_Tab.Size = new System.Drawing.Size(608, 469);
            this.Application_Tab.TabIndex = 1;
            this.Application_Tab.Text = "REST Services";
            this.Application_Tab.UseVisualStyleBackColor = true;
            // 
            // tabcontrol_1
            // 
            this.tabcontrol_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol_1.Controls.Add(this.Engineering_Tab);
            this.tabcontrol_1.Controls.Add(this.Mfg_Tab);
            this.tabcontrol_1.Controls.Add(this.Execution_Tab);
            this.tabcontrol_1.Controls.Add(this.ERP_Tab);
            this.tabcontrol_1.Controls.Add(this.Events_Tab);
            this.tabcontrol_1.Location = new System.Drawing.Point(6, 6);
            this.tabcontrol_1.Name = "tabcontrol_1";
            this.tabcontrol_1.SelectedIndex = 0;
            this.tabcontrol_1.Size = new System.Drawing.Size(599, 460);
            this.tabcontrol_1.TabIndex = 0;
            // 
            // Engineering_Tab
            // 
            this.Engineering_Tab.Controls.Add(this.Prd_Apply_Button);
            this.Engineering_Tab.Controls.Add(this.Prd_ID_txt);
            this.Engineering_Tab.Controls.Add(this.Prd_Name_Text);
            this.Engineering_Tab.Controls.Add(this.Prd_Title_Text);
            this.Engineering_Tab.Controls.Add(this.Prd_ID);
            this.Engineering_Tab.Controls.Add(this.Prd_Name);
            this.Engineering_Tab.Controls.Add(this.Prd_Title);
            this.Engineering_Tab.Controls.Add(this.Result_Prd_Data);
            this.Engineering_Tab.Controls.Add(this.Get_Product_Details);
            this.Engineering_Tab.Controls.Add(this.Get_Product_List);
            this.Engineering_Tab.Controls.Add(this.Create_Product);
            this.Engineering_Tab.Location = new System.Drawing.Point(4, 25);
            this.Engineering_Tab.Name = "Engineering_Tab";
            this.Engineering_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Engineering_Tab.Size = new System.Drawing.Size(591, 431);
            this.Engineering_Tab.TabIndex = 0;
            this.Engineering_Tab.Text = "Engineering";
            this.Engineering_Tab.UseVisualStyleBackColor = true;
            // 
            // Prd_Apply_Button
            // 
            this.Prd_Apply_Button.Location = new System.Drawing.Point(470, 91);
            this.Prd_Apply_Button.Name = "Prd_Apply_Button";
            this.Prd_Apply_Button.Size = new System.Drawing.Size(102, 33);
            this.Prd_Apply_Button.TabIndex = 10;
            this.Prd_Apply_Button.Text = "Apply";
            this.Prd_Apply_Button.UseVisualStyleBackColor = true;
            this.Prd_Apply_Button.Click += new System.EventHandler(this.Prd_Apply_Button_Click);
            // 
            // Prd_ID_txt
            // 
            this.Prd_ID_txt.Location = new System.Drawing.Point(290, 63);
            this.Prd_ID_txt.Name = "Prd_ID_txt";
            this.Prd_ID_txt.Size = new System.Drawing.Size(282, 22);
            this.Prd_ID_txt.TabIndex = 9;
            // 
            // Prd_Name_Text
            // 
            this.Prd_Name_Text.Location = new System.Drawing.Point(290, 35);
            this.Prd_Name_Text.Name = "Prd_Name_Text";
            this.Prd_Name_Text.Size = new System.Drawing.Size(282, 22);
            this.Prd_Name_Text.TabIndex = 8;
            // 
            // Prd_Title_Text
            // 
            this.Prd_Title_Text.Location = new System.Drawing.Point(290, 7);
            this.Prd_Title_Text.Name = "Prd_Title_Text";
            this.Prd_Title_Text.Size = new System.Drawing.Size(282, 22);
            this.Prd_Title_Text.TabIndex = 7;
            // 
            // Prd_ID
            // 
            this.Prd_ID.AutoSize = true;
            this.Prd_ID.Location = new System.Drawing.Point(220, 63);
            this.Prd_ID.Name = "Prd_ID";
            this.Prd_ID.Size = new System.Drawing.Size(21, 17);
            this.Prd_ID.TabIndex = 6;
            this.Prd_ID.Text = "ID";
            // 
            // Prd_Name
            // 
            this.Prd_Name.AutoSize = true;
            this.Prd_Name.Location = new System.Drawing.Point(220, 35);
            this.Prd_Name.Name = "Prd_Name";
            this.Prd_Name.Size = new System.Drawing.Size(45, 17);
            this.Prd_Name.TabIndex = 5;
            this.Prd_Name.Text = "Name";
            // 
            // Prd_Title
            // 
            this.Prd_Title.AutoSize = true;
            this.Prd_Title.Location = new System.Drawing.Point(217, 7);
            this.Prd_Title.Name = "Prd_Title";
            this.Prd_Title.Size = new System.Drawing.Size(35, 17);
            this.Prd_Title.TabIndex = 4;
            this.Prd_Title.Text = "Title";
            // 
            // Result_Prd_Data
            // 
            this.Result_Prd_Data.Location = new System.Drawing.Point(0, 130);
            this.Result_Prd_Data.Multiline = true;
            this.Result_Prd_Data.Name = "Result_Prd_Data";
            this.Result_Prd_Data.Size = new System.Drawing.Size(591, 301);
            this.Result_Prd_Data.TabIndex = 3;
            // 
            // Get_Product_Details
            // 
            this.Get_Product_Details.AutoSize = true;
            this.Get_Product_Details.Location = new System.Drawing.Point(7, 63);
            this.Get_Product_Details.Name = "Get_Product_Details";
            this.Get_Product_Details.Size = new System.Drawing.Size(153, 21);
            this.Get_Product_Details.TabIndex = 2;
            this.Get_Product_Details.Text = "Get Product Details";
            this.Get_Product_Details.UseVisualStyleBackColor = true;
            // 
            // Get_Product_List
            // 
            this.Get_Product_List.AutoSize = true;
            this.Get_Product_List.Location = new System.Drawing.Point(7, 35);
            this.Get_Product_List.Name = "Get_Product_List";
            this.Get_Product_List.Size = new System.Drawing.Size(132, 21);
            this.Get_Product_List.TabIndex = 1;
            this.Get_Product_List.Text = "Search Product ";
            this.Get_Product_List.UseVisualStyleBackColor = true;
            // 
            // Create_Product
            // 
            this.Create_Product.AutoSize = true;
            this.Create_Product.Location = new System.Drawing.Point(7, 7);
            this.Create_Product.Name = "Create_Product";
            this.Create_Product.Size = new System.Drawing.Size(125, 21);
            this.Create_Product.TabIndex = 0;
            this.Create_Product.Text = "Create Product";
            this.Create_Product.UseVisualStyleBackColor = true;
            // 
            // Mfg_Tab
            // 
            this.Mfg_Tab.Controls.Add(this.Mfg_Item_Button);
            this.Mfg_Tab.Controls.Add(this.Result_Mfg_Data);
            this.Mfg_Tab.Controls.Add(this.Mfgid_Txt);
            this.Mfg_Tab.Controls.Add(this.Mfg_ID);
            this.Mfg_Tab.Controls.Add(this.Get_mfg_Assembly);
            this.Mfg_Tab.Location = new System.Drawing.Point(4, 25);
            this.Mfg_Tab.Name = "Mfg_Tab";
            this.Mfg_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Mfg_Tab.Size = new System.Drawing.Size(591, 431);
            this.Mfg_Tab.TabIndex = 1;
            this.Mfg_Tab.Text = "Manufacturing";
            this.Mfg_Tab.UseVisualStyleBackColor = true;
            // 
            // Mfg_Item_Button
            // 
            this.Mfg_Item_Button.Location = new System.Drawing.Point(472, 55);
            this.Mfg_Item_Button.Name = "Mfg_Item_Button";
            this.Mfg_Item_Button.Size = new System.Drawing.Size(100, 28);
            this.Mfg_Item_Button.TabIndex = 4;
            this.Mfg_Item_Button.Text = "Apply";
            this.Mfg_Item_Button.UseVisualStyleBackColor = true;
            this.Mfg_Item_Button.Click += new System.EventHandler(this.Mfg_Item_Button_Click);
            // 
            // Result_Mfg_Data
            // 
            this.Result_Mfg_Data.Location = new System.Drawing.Point(3, 89);
            this.Result_Mfg_Data.Multiline = true;
            this.Result_Mfg_Data.Name = "Result_Mfg_Data";
            this.Result_Mfg_Data.Size = new System.Drawing.Size(588, 336);
            this.Result_Mfg_Data.TabIndex = 3;
            // 
            // Mfgid_Txt
            // 
            this.Mfgid_Txt.Location = new System.Drawing.Point(301, 7);
            this.Mfgid_Txt.Name = "Mfgid_Txt";
            this.Mfgid_Txt.Size = new System.Drawing.Size(271, 22);
            this.Mfgid_Txt.TabIndex = 2;
            // 
            // Mfg_ID
            // 
            this.Mfg_ID.AutoSize = true;
            this.Mfg_ID.Location = new System.Drawing.Point(275, 7);
            this.Mfg_ID.Name = "Mfg_ID";
            this.Mfg_ID.Size = new System.Drawing.Size(19, 17);
            this.Mfg_ID.TabIndex = 1;
            this.Mfg_ID.Text = "Id";
            // 
            // Get_mfg_Assembly
            // 
            this.Get_mfg_Assembly.AutoSize = true;
            this.Get_mfg_Assembly.Location = new System.Drawing.Point(7, 7);
            this.Get_mfg_Assembly.Name = "Get_mfg_Assembly";
            this.Get_mfg_Assembly.Size = new System.Drawing.Size(211, 21);
            this.Get_mfg_Assembly.TabIndex = 0;
            this.Get_mfg_Assembly.Text = "Get Manufacturing Assembly";
            this.Get_mfg_Assembly.UseVisualStyleBackColor = true;
            // 
            // Execution_Tab
            // 
            this.Execution_Tab.Controls.Add(this.Apr_url_txt);
            this.Execution_Tab.Controls.Add(this.Apr_Server_lbl);
            this.Execution_Tab.Controls.Add(this.Order_ID_Status_txt);
            this.Execution_Tab.Controls.Add(this.Order_Id_Status);
            this.Execution_Tab.Controls.Add(this.Order_Status);
            this.Execution_Tab.Controls.Add(this.Apr_Input);
            this.Execution_Tab.Controls.Add(this.Result_Apr_Data);
            this.Execution_Tab.Controls.Add(this.Order_ID_Txt);
            this.Execution_Tab.Controls.Add(this.Order_id);
            this.Execution_Tab.Controls.Add(this.Apr_CreateOrder);
            this.Execution_Tab.Location = new System.Drawing.Point(4, 25);
            this.Execution_Tab.Name = "Execution_Tab";
            this.Execution_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Execution_Tab.Size = new System.Drawing.Size(591, 431);
            this.Execution_Tab.TabIndex = 2;
            this.Execution_Tab.Text = "Execution";
            this.Execution_Tab.UseVisualStyleBackColor = true;
            // 
            // Apr_url_txt
            // 
            this.Apr_url_txt.Location = new System.Drawing.Point(119, 11);
            this.Apr_url_txt.Name = "Apr_url_txt";
            this.Apr_url_txt.Size = new System.Drawing.Size(451, 22);
            this.Apr_url_txt.TabIndex = 14;
            // 
            // Apr_Server_lbl
            // 
            this.Apr_Server_lbl.AutoSize = true;
            this.Apr_Server_lbl.Location = new System.Drawing.Point(4, 14);
            this.Apr_Server_lbl.Name = "Apr_Server_lbl";
            this.Apr_Server_lbl.Size = new System.Drawing.Size(94, 17);
            this.Apr_Server_lbl.TabIndex = 13;
            this.Apr_Server_lbl.Text = "Apriso Server";
            // 
            // Order_ID_Status_txt
            // 
            this.Order_ID_Status_txt.Location = new System.Drawing.Point(299, 65);
            this.Order_ID_Status_txt.Name = "Order_ID_Status_txt";
            this.Order_ID_Status_txt.Size = new System.Drawing.Size(271, 22);
            this.Order_ID_Status_txt.TabIndex = 12;
            // 
            // Order_Id_Status
            // 
            this.Order_Id_Status.AutoSize = true;
            this.Order_Id_Status.Location = new System.Drawing.Point(273, 65);
            this.Order_Id_Status.Name = "Order_Id_Status";
            this.Order_Id_Status.Size = new System.Drawing.Size(19, 17);
            this.Order_Id_Status.TabIndex = 11;
            this.Order_Id_Status.Text = "Id";
            // 
            // Order_Status
            // 
            this.Order_Status.AutoSize = true;
            this.Order_Status.Location = new System.Drawing.Point(5, 65);
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.Size = new System.Drawing.Size(111, 21);
            this.Order_Status.TabIndex = 10;
            this.Order_Status.Text = "Order Status";
            this.Order_Status.UseVisualStyleBackColor = true;
            // 
            // Apr_Input
            // 
            this.Apr_Input.Location = new System.Drawing.Point(470, 93);
            this.Apr_Input.Name = "Apr_Input";
            this.Apr_Input.Size = new System.Drawing.Size(100, 28);
            this.Apr_Input.TabIndex = 9;
            this.Apr_Input.Text = "Apply";
            this.Apr_Input.UseVisualStyleBackColor = true;
            this.Apr_Input.Click += new System.EventHandler(this.Apr_Input_Click);
            // 
            // Result_Apr_Data
            // 
            this.Result_Apr_Data.Location = new System.Drawing.Point(1, 127);
            this.Result_Apr_Data.Multiline = true;
            this.Result_Apr_Data.Name = "Result_Apr_Data";
            this.Result_Apr_Data.Size = new System.Drawing.Size(588, 297);
            this.Result_Apr_Data.TabIndex = 8;
            // 
            // Order_ID_Txt
            // 
            this.Order_ID_Txt.Location = new System.Drawing.Point(299, 37);
            this.Order_ID_Txt.Name = "Order_ID_Txt";
            this.Order_ID_Txt.Size = new System.Drawing.Size(271, 22);
            this.Order_ID_Txt.TabIndex = 7;
            // 
            // Order_id
            // 
            this.Order_id.AutoSize = true;
            this.Order_id.Location = new System.Drawing.Point(273, 37);
            this.Order_id.Name = "Order_id";
            this.Order_id.Size = new System.Drawing.Size(19, 17);
            this.Order_id.TabIndex = 6;
            this.Order_id.Text = "Id";
            // 
            // Apr_CreateOrder
            // 
            this.Apr_CreateOrder.AutoSize = true;
            this.Apr_CreateOrder.Location = new System.Drawing.Point(5, 37);
            this.Apr_CreateOrder.Name = "Apr_CreateOrder";
            this.Apr_CreateOrder.Size = new System.Drawing.Size(113, 21);
            this.Apr_CreateOrder.TabIndex = 5;
            this.Apr_CreateOrder.Text = "Create Order";
            this.Apr_CreateOrder.UseVisualStyleBackColor = true;
            // 
            // ERP_Tab
            // 
            this.ERP_Tab.Location = new System.Drawing.Point(4, 25);
            this.ERP_Tab.Name = "ERP_Tab";
            this.ERP_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ERP_Tab.Size = new System.Drawing.Size(591, 431);
            this.ERP_Tab.TabIndex = 3;
            this.ERP_Tab.Text = "ERP";
            this.ERP_Tab.UseVisualStyleBackColor = true;
            // 
            // Events_Tab
            // 
            this.Events_Tab.Controls.Add(this.tabControl1);
            this.Events_Tab.Location = new System.Drawing.Point(4, 25);
            this.Events_Tab.Name = "Events_Tab";
            this.Events_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Events_Tab.Size = new System.Drawing.Size(591, 431);
            this.Events_Tab.TabIndex = 4;
            this.Events_Tab.Text = "Events";
            this.Events_Tab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Connection_Param);
            this.tabControl1.Controls.Add(this.Event_Processing);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // Connection_Param
            // 
            this.Connection_Param.Controls.Add(this.Event_GB);
            this.Connection_Param.Location = new System.Drawing.Point(4, 25);
            this.Connection_Param.Name = "Connection_Param";
            this.Connection_Param.Padding = new System.Windows.Forms.Padding(3);
            this.Connection_Param.Size = new System.Drawing.Size(580, 393);
            this.Connection_Param.TabIndex = 0;
            this.Connection_Param.Text = "Connection";
            this.Connection_Param.UseVisualStyleBackColor = true;
            // 
            // Event_GB
            // 
            this.Event_GB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Event_GB.Controls.Add(this.Connect_Btn);
            this.Event_GB.Controls.Add(this.Tenant_name_txt);
            this.Event_GB.Controls.Add(this.Agent_Pwd_txt);
            this.Event_GB.Controls.Add(this.Tenant_ID_lbl);
            this.Event_GB.Controls.Add(this.Agent_Pwd_lbl);
            this.Event_GB.Controls.Add(this.Agent_ID_lbl);
            this.Event_GB.Controls.Add(this.Broker_uri_lbl);
            this.Event_GB.Controls.Add(this.Agent_ID_txt);
            this.Event_GB.Controls.Add(this.Broker_uri_txt);
            this.Event_GB.Location = new System.Drawing.Point(0, 6);
            this.Event_GB.Name = "Event_GB";
            this.Event_GB.Size = new System.Drawing.Size(577, 198);
            this.Event_GB.TabIndex = 0;
            this.Event_GB.TabStop = false;
            this.Event_GB.Text = "Connection Parameters";
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(467, 169);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 8;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Tenant_name_txt
            // 
            this.Tenant_name_txt.Location = new System.Drawing.Point(146, 123);
            this.Tenant_name_txt.Name = "Tenant_name_txt";
            this.Tenant_name_txt.Size = new System.Drawing.Size(362, 22);
            this.Tenant_name_txt.TabIndex = 7;
            // 
            // Agent_Pwd_txt
            // 
            this.Agent_Pwd_txt.Location = new System.Drawing.Point(146, 91);
            this.Agent_Pwd_txt.Name = "Agent_Pwd_txt";
            this.Agent_Pwd_txt.Size = new System.Drawing.Size(362, 22);
            this.Agent_Pwd_txt.TabIndex = 6;
            // 
            // Tenant_ID_lbl
            // 
            this.Tenant_ID_lbl.AutoSize = true;
            this.Tenant_ID_lbl.Location = new System.Drawing.Point(10, 123);
            this.Tenant_ID_lbl.Name = "Tenant_ID_lbl";
            this.Tenant_ID_lbl.Size = new System.Drawing.Size(70, 17);
            this.Tenant_ID_lbl.TabIndex = 5;
            this.Tenant_ID_lbl.Text = "Tenant ID";
            // 
            // Agent_Pwd_lbl
            // 
            this.Agent_Pwd_lbl.AutoSize = true;
            this.Agent_Pwd_lbl.Location = new System.Drawing.Point(10, 91);
            this.Agent_Pwd_lbl.Name = "Agent_Pwd_lbl";
            this.Agent_Pwd_lbl.Size = new System.Drawing.Size(79, 17);
            this.Agent_Pwd_lbl.TabIndex = 4;
            this.Agent_Pwd_lbl.Text = "Agent_Pwd";
            // 
            // Agent_ID_lbl
            // 
            this.Agent_ID_lbl.AutoSize = true;
            this.Agent_ID_lbl.Location = new System.Drawing.Point(10, 61);
            this.Agent_ID_lbl.Name = "Agent_ID_lbl";
            this.Agent_ID_lbl.Size = new System.Drawing.Size(66, 17);
            this.Agent_ID_lbl.TabIndex = 3;
            this.Agent_ID_lbl.Text = "Agent_ID";
            // 
            // Broker_uri_lbl
            // 
            this.Broker_uri_lbl.AutoSize = true;
            this.Broker_uri_lbl.Location = new System.Drawing.Point(10, 33);
            this.Broker_uri_lbl.Name = "Broker_uri_lbl";
            this.Broker_uri_lbl.Size = new System.Drawing.Size(72, 17);
            this.Broker_uri_lbl.TabIndex = 2;
            this.Broker_uri_lbl.Text = "Broker Uri";
            // 
            // Agent_ID_txt
            // 
            this.Agent_ID_txt.Location = new System.Drawing.Point(146, 61);
            this.Agent_ID_txt.Name = "Agent_ID_txt";
            this.Agent_ID_txt.Size = new System.Drawing.Size(362, 22);
            this.Agent_ID_txt.TabIndex = 1;
            // 
            // Broker_uri_txt
            // 
            this.Broker_uri_txt.Location = new System.Drawing.Point(146, 33);
            this.Broker_uri_txt.Name = "Broker_uri_txt";
            this.Broker_uri_txt.Size = new System.Drawing.Size(362, 22);
            this.Broker_uri_txt.TabIndex = 0;
            // 
            // Event_Processing
            // 
            this.Event_Processing.Controls.Add(this.Event_Text);
            this.Event_Processing.Location = new System.Drawing.Point(4, 25);
            this.Event_Processing.Name = "Event_Processing";
            this.Event_Processing.Padding = new System.Windows.Forms.Padding(3);
            this.Event_Processing.Size = new System.Drawing.Size(580, 393);
            this.Event_Processing.TabIndex = 1;
            this.Event_Processing.Text = "Processing ";
            this.Event_Processing.UseVisualStyleBackColor = true;
            // 
            // Event_Text
            // 
            this.Event_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Event_Text.Location = new System.Drawing.Point(1, 0);
            this.Event_Text.Multiline = true;
            this.Event_Text.Name = "Event_Text";
            this.Event_Text.Size = new System.Drawing.Size(583, 393);
            this.Event_Text.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 499);
            this.Controls.Add(this.WebServices);
            this.Name = "Form1";
            this.Text = "Web Application";
            this.LoginCredentials.ResumeLayout(false);
            this.LoginCredentials.PerformLayout();
            this.WebServices.ResumeLayout(false);
            this.Login_Tab.ResumeLayout(false);
            this.Login_Tab.PerformLayout();
            this.Server_Type.ResumeLayout(false);
            this.Server_Type.PerformLayout();
            this.Cloud_Tenant.ResumeLayout(false);
            this.Cloud_Tenant.PerformLayout();
            this.Application_Tab.ResumeLayout(false);
            this.tabcontrol_1.ResumeLayout(false);
            this.Engineering_Tab.ResumeLayout(false);
            this.Engineering_Tab.PerformLayout();
            this.Mfg_Tab.ResumeLayout(false);
            this.Mfg_Tab.PerformLayout();
            this.Execution_Tab.ResumeLayout(false);
            this.Execution_Tab.PerformLayout();
            this.Events_Tab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Connection_Param.ResumeLayout(false);
            this.Event_GB.ResumeLayout(false);
            this.Event_GB.PerformLayout();
            this.Event_Processing.ResumeLayout(false);
            this.Event_Processing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox LoginCredentials;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label Port_Number;
        private System.Windows.Forms.Label url_name;
        private System.Windows.Forms.TextBox pwd_text;
        private System.Windows.Forms.TextBox usrname_text;
        private System.Windows.Forms.TextBox port_text;
        private System.Windows.Forms.TextBox url_text;
        private System.Windows.Forms.TextBox cnxt_text;
        private System.Windows.Forms.Label Cnxt_label;
        private System.Windows.Forms.TabControl WebServices;
        private System.Windows.Forms.TabPage Login_Tab;
        private System.Windows.Forms.GroupBox Server_Type;
        private System.Windows.Forms.RadioButton Demo_Center;
        private System.Windows.Forms.RadioButton Cloud_Type;
        private System.Windows.Forms.RadioButton On_Premise;
        private System.Windows.Forms.TabPage Application_Tab;
        private System.Windows.Forms.Label Tenant_ID;
        private System.Windows.Forms.TextBox Tenant_id_txt;
        private System.Windows.Forms.TextBox Login_Result_txt;
        private System.Windows.Forms.CheckBox url_lowercase;
        private System.Windows.Forms.GroupBox Cloud_Tenant;
        private System.Windows.Forms.TextBox Tenant_Region;
        private System.Windows.Forms.Label Tenant_Country;
        private System.Windows.Forms.TabControl tabcontrol_1;
        private System.Windows.Forms.TabPage Engineering_Tab;
        private System.Windows.Forms.TabPage Mfg_Tab;
        private System.Windows.Forms.Button Prd_Apply_Button;
        private System.Windows.Forms.TextBox Prd_ID_txt;
        private System.Windows.Forms.TextBox Prd_Name_Text;
        private System.Windows.Forms.TextBox Prd_Title_Text;
        private System.Windows.Forms.Label Prd_ID;
        private System.Windows.Forms.Label Prd_Name;
        private System.Windows.Forms.Label Prd_Title;
        private System.Windows.Forms.TextBox Result_Prd_Data;
        private System.Windows.Forms.CheckBox Get_Product_Details;
        private System.Windows.Forms.CheckBox Get_Product_List;
        private System.Windows.Forms.CheckBox Create_Product;
        private System.Windows.Forms.Button Mfg_Item_Button;
        private System.Windows.Forms.TextBox Result_Mfg_Data;
        private System.Windows.Forms.TextBox Mfgid_Txt;
        private System.Windows.Forms.Label Mfg_ID;
        private System.Windows.Forms.CheckBox Get_mfg_Assembly;
        private System.Windows.Forms.TabPage Execution_Tab;
        private System.Windows.Forms.TextBox Order_ID_Status_txt;
        private System.Windows.Forms.Label Order_Id_Status;
        private System.Windows.Forms.CheckBox Order_Status;
        private System.Windows.Forms.Button Apr_Input;
        private System.Windows.Forms.TextBox Result_Apr_Data;
        private System.Windows.Forms.TextBox Order_ID_Txt;
        private System.Windows.Forms.Label Order_id;
        private System.Windows.Forms.CheckBox Apr_CreateOrder;
        private System.Windows.Forms.TabPage ERP_Tab;
        private System.Windows.Forms.TextBox Apr_url_txt;
        private System.Windows.Forms.Label Apr_Server_lbl;
        private System.Windows.Forms.TabPage Events_Tab;
        private System.Windows.Forms.GroupBox Event_GB;
        private System.Windows.Forms.TextBox Agent_ID_txt;
        private System.Windows.Forms.TextBox Broker_uri_txt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Connection_Param;
        private System.Windows.Forms.TabPage Event_Processing;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.TextBox Agent_Pwd_txt;
        private System.Windows.Forms.Label Tenant_ID_lbl;
        private System.Windows.Forms.Label Agent_Pwd_lbl;
        private System.Windows.Forms.Label Agent_ID_lbl;
        private System.Windows.Forms.Label Broker_uri_lbl;
        private System.Windows.Forms.TextBox Tenant_name_txt;
        private System.Windows.Forms.TextBox Event_Text;
    }
}