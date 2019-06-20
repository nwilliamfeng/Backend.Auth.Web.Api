﻿
using Microcomm.Web.Http.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Backend.Auth.Web.Internal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new GlobalExceptionFilter());
            config.Filters.Add(new GlobalLogFilter());
        }
    }
}
