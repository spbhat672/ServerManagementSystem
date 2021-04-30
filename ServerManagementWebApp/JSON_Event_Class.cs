using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webserwinform
{
 
        public class json_Event_Metadata
        {
            public string ServiceId { get; set; }
        public string GeoId { get; set; }
        public string TenantId { get; set; }
    }

        public class json_Event_Subject
        {
            public string Source { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public string RelativePath { get; set; }
    }

    public class json_Event_Object
    {
        public string Type  {get; set; }
        public string Value {get; set; }
    }

    public class json_Event_Data
        {
            public string EventClass { get; set; }
        public string EventType { get; set; }
        public long EventTime { get; set; }
        public string User { get; set; }
        public string Authorization { get; set; }
        public Dictionary<string, json_Event_Subject> Event_Subject { get; set; }

            public string Predicate { get; set; }

        public Dictionary<string, json_Event_Object> Event_Object { get; set; }


    }

    public class Event_Json_Root
    {
        public string Specversion { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public DateTime Time { get; set; }
        public long Timestamp { get; set; }

        public Dictionary<string, json_Event_Metadata> Event_Metadata { get; set; }

        public string Contenttype { get; set; }
        public Dictionary<string, json_Event_Data> Event_Data { get; set; }

    }


    public class Event_Json_Onprem_Data
    {

        public string Type { get; set; }
        public string Name { get; set; }
        public string Revision { get; set; }
        public string Id { get; set; }
        public string Event { get; set; }
        public string Timestamp { get; set; }
        public string Organization { get; set; }
        public string Project { get; set; }
        public string StateName { get; set; }
        public string NextState { get; set; }
    }

    public class Event_Json_Onprem_Root
    {
        public Dictionary<string, Event_Json_Onprem_Data> Event_Json_OnpremData { get; set; }

    }

}

