﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using Backend.Auth.Data.Redis;
using Microcomm.Web.Http.Autofac;

namespace Backend.Auth.Web.Internal
{
    public class WebApiApplication : System.Web.HttpApplication
    {


        protected void Application_Start()
        {
            RedisCache.ConfigName = "RedisServer";

            AutofacWebapiConfig .Initialize(this,GlobalConfiguration.Configuration, "Backend.Auth", new string[] { "Repository", "Cache", "Service" });
            
          
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
