using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webserwinform;

namespace ServerManagementWebApp.Controllers
{
    public class HomeController : Controller
    {

        RestClient rclient;
        Event_Json_Root myDeserializedClass;
        bool isPremserver = false;
        Event_Json_Onprem_Root myDeserializedClass_onprem;

        private delegate void SetTextCallback(string text);
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            var x = obj["lastname"];
            return View();
        }
    }
}