using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveMQ;
using Apache.NMS;


namespace webserwinform
{

    public delegate void QMessageReceivedDelegate(string message);
    public class JMS_Event_Consumer_onPrem: IDisposable
    {

        private bool isDisposed = false;
        public event QMessageReceivedDelegate OnMessageReceived;
        private readonly IConnectionFactory connectionFactory;
        private readonly IConnection connection;
        private readonly ISession session;
        private readonly IMessageConsumer consumer_user;
        private readonly IMessageConsumer consumer_admin;
        private readonly IMessageConsumer consumer_user_onprem;
        private readonly IMessageConsumer consumer_exchange_admin;

        public JMS_Event_Consumer_onPrem(string tenantid, string brokerUri, string AgentID, string AgentPwd)
        {

            Uri connecturi = new Uri(brokerUri);
            try
            {
                connectionFactory = new Apache.NMS.ActiveMQ.ConnectionFactory(connecturi);
                connection = connectionFactory.CreateConnection(AgentID, AgentPwd);
                connection.ClientId = "iPASS_Clients";
                connection.Start();
                AcknowledgementMode Ackmode = AcknowledgementMode.AutoAcknowledge;
                session = connection.CreateSession(Ackmode);
                ITopic topic_user_onprem = null;
                String topicname_user = "3dsevents." + tenantid + ".3DSpace.user";
                ITopic topic_user = session.GetTopic(topicname_user);

                String topicname_admin = "3dsevents." + tenantid + ".3DSpace.admin";
                ITopic topic_admin = session.GetTopic(topicname_admin);

                String topicname_exchange_admin = "3dsevents." + tenantid + ".exchange.admin";
                ITopic topic_exchange_admin = session.GetTopic(topicname_exchange_admin);
                // session.CreateConsumer()

                if (tenantid == "")
                {
                    topic_user_onprem = session.GetTopic("K75_3DEXPERIENCE_LOCAL_MESSAGES");
                    consumer_user_onprem = session.CreateDurableConsumer(topic_user_onprem, "ClientID_Events_Durable_Consumer_onprem_3DSpace_user", null, false);
                }
                else
                {
                    consumer_user = session.CreateDurableConsumer(topic_user, "ClientID_Events_Durable_Consumer_3DSpace_user", null, false);
                }

                
                consumer_admin = session.CreateDurableConsumer(topic_admin, "ClientID_Events_Durable_Consumer_3DSpace_admin", null, false);
                consumer_exchange_admin = session.CreateDurableConsumer(topic_exchange_admin, "ClientID_Events_Durable_Consumer_3DSpace_exchange_admin", null, false);

                if (tenantid == "")
                {
                    consumer_user_onprem.Listener += new MessageListener(OnMessage_User_onprem);
                }
                else
                {
                    consumer_user.Listener += new MessageListener(OnMessage_User);
                }
                
                consumer_admin.Listener += new MessageListener(OnMessage_Admin);
                consumer_exchange_admin.Listener += new MessageListener(OnMessage_Exch_Admin);
                
              //  connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //System.err.println("NOT CONNECTED!!!");
            }
        }


        public void OnMessage_User_onprem(IMessage message)
        {
            Console.WriteLine("OnMessage " + (message != null).ToString());
            try
            {
                Console.WriteLine("Message received");
                ITextMessage msg = (ITextMessage)message;
                message.Acknowledge();
                Console.WriteLine(msg.Text);
                OnMessageReceived(msg.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void OnMessage_User(IMessage message)
        { 
            Console.WriteLine("OnMessage " + (message != null).ToString());
            try
            {
                Console.WriteLine("Message received");
                ITextMessage msg = (ITextMessage)message;
                message.Acknowledge();
                Console.WriteLine(msg.Text);
                OnMessageReceived(msg.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void OnMessage_Admin(IMessage message)
        {
            Console.WriteLine("OnMessage " + (message != null).ToString());
            try
            {
                Console.WriteLine("Message received");
                ITextMessage msg = (ITextMessage)message;
                message.Acknowledge();
                Console.WriteLine(msg.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void OnMessage_Exch_Admin(IMessage message)
        {
            Console.WriteLine("OnMessage " + (message != null).ToString());
            try
            {
                Console.WriteLine("Message received");
                ITextMessage msg = (ITextMessage)message;
                message.Acknowledge();
                Console.WriteLine(msg.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Dispose()
        {
            if (!this.isDisposed)
            {
                this.consumer_user.Dispose(); 
                this.consumer_admin.Dispose(); 
                this.consumer_exchange_admin.Dispose();
               // this.consumer
                this.session.Dispose();
                this.connection.Dispose();
                this.isDisposed = true;
            }
        }

    }

    //public class JMS_Event_Consumer_Oncloud : IDisposable
    //{

    //    private bool isDisposed = false;
    //    public event QMessageReceivedDelegate OnMessageReceived;
    //    private readonly IConnectionFactory connectionFactory;
    //    private readonly IConnection connection;
    //    private readonly ISession session;
    //    private readonly IMessageConsumer consumer_user;
    //    private readonly IMessageConsumer consumer_admin;
    //    private readonly IMessageConsumer consumer_user_onprem;
    //    private readonly IMessageConsumer consumer_exchange_admin;

    //    public JMS_Event_Consumer_Oncloud(string tenantid, string brokerUri, string AgentID, string AgentPwd)
    //    {

    //        Uri connecturi = new Uri(brokerUri);
    //        try
    //        {
    //            connectionFactory = new Apache.NMS.ActiveMQ.ConnectionFactory(connecturi);
    //            connection = connectionFactory.CreateConnection(AgentID, AgentPwd);
    //            connection.ClientId = "iPASS_Client_Cloud";
    //            connection.Start();
    //            AcknowledgementMode Ackmode = AcknowledgementMode.AutoAcknowledge;
    //            session = connection.CreateSession(Ackmode);

    //            String topicname_user = "3dsevents." + tenantid + ".3DSpace.user";
    //            ITopic topic_user = session.GetTopic(topicname_user);




    //            String topicname_admin = "3dsevents." + tenantid + ".3DSpace.admin";
    //            ITopic topic_admin = session.GetTopic(topicname_admin);

    //            String topicname_exchange_admin = "3dsevents." + tenantid + ".exchange.admin";
    //            ITopic topic_exchange_admin = session.GetTopic(topicname_exchange_admin);
    //            // session.CreateConsumer()

    //            consumer_user_onprem = session.CreateDurableConsumer(topic_user_onprem, "ClientID_Events_Durable_Consumer_onprem_3DSpace_user", null, false);

    //            consumer_user = session.CreateDurableConsumer(topic_user, "ClientID_Events_Durable_Consumer_3DSpace_user", null, false);
    //            consumer_admin = session.CreateDurableConsumer(topic_admin, "ClientID_Events_Durable_Consumer_3DSpace_admin", null, false);
    //            consumer_exchange_admin = session.CreateDurableConsumer(topic_exchange_admin, "ClientID_Events_Durable_Consumer_3DSpace_exchange_admin", null, false);

    //            consumer_user_onprem.Listener += new MessageListener(OnMessage_User_onprem);

    //            consumer_user.Listener += new MessageListener(OnMessage_User);
    //            consumer_admin.Listener += new MessageListener(OnMessage_Admin);
    //            consumer_exchange_admin.Listener += new MessageListener(OnMessage_Exch_Admin);

    //            //  connection.Close();
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //            //System.err.println("NOT CONNECTED!!!");
    //        }
    //    }


    //    public void OnMessage_User_onprem(IMessage message)
    //    {
    //        Console.WriteLine("OnMessage " + (message != null).ToString());
    //        try
    //        {
    //            Console.WriteLine("Message received");
    //            ITextMessage msg = (ITextMessage)message;
    //            message.Acknowledge();
    //            Console.WriteLine(msg.Text);
    //            OnMessageReceived(msg.Text);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    public void OnMessage_User(IMessage message)
    //    {
    //        Console.WriteLine("OnMessage " + (message != null).ToString());
    //        try
    //        {
    //            Console.WriteLine("Message received");
    //            ITextMessage msg = (ITextMessage)message;
    //            message.Acknowledge();
    //            Console.WriteLine(msg.Text);
    //            OnMessageReceived(msg.Text);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    public void OnMessage_Admin(IMessage message)
    //    {
    //        Console.WriteLine("OnMessage " + (message != null).ToString());
    //        try
    //        {
    //            Console.WriteLine("Message received");
    //            ITextMessage msg = (ITextMessage)message;
    //            message.Acknowledge();
    //            Console.WriteLine(msg.Text);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    public void OnMessage_Exch_Admin(IMessage message)
    //    {
    //        Console.WriteLine("OnMessage " + (message != null).ToString());
    //        try
    //        {
    //            Console.WriteLine("Message received");
    //            ITextMessage msg = (ITextMessage)message;
    //            message.Acknowledge();
    //            Console.WriteLine(msg.Text);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        if (!this.isDisposed)
    //        {
    //            this.consumer_user.Dispose();
    //            this.consumer_admin.Dispose();
    //            this.consumer_exchange_admin.Dispose();
    //            // this.consumer
    //            this.session.Dispose();
    //            this.connection.Dispose();
    //            this.isDisposed = true;
    //        }
    //    }

    //}

    
}
