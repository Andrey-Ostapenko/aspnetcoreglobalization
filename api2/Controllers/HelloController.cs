﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Resources;
using System.Reflection;
using Microsoft.Extensions.Localization;

namespace api2.Controllers
{
    [Route("/Hello")]
    public class HelloController : Controller
    {

        public HelloController()
        {
           
        }
        
        // GET api/values
        [HttpGet]
        [Route("local")]
        public string local()
        {
            string msg = "";
            var cul = Thread.CurrentThread.CurrentCulture.Name;
            var culUI = Thread.CurrentThread.CurrentUICulture.Name;            
            var lang = Request.Headers["Accept-Language"];
            string rsFileName = "api2.Resources.rs1";
            ResourceManager rm = new ResourceManager(rsFileName, Assembly.GetExecutingAssembly());
            var msg2 = rm.GetString("Hello");
            var msg3 = rm.GetString("Hello", new System.Globalization.CultureInfo("fr-FR"));
            msg = msg2;
            return msg;
        }

        // GET api/values
        [HttpGet]
        [Route("lib")]
        public string lib()
        {
            string msg = "";
            msg = Lib1.ResRdr.Messenger.GetHello();           
            return msg;
        }
    }
}