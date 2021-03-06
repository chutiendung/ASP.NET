﻿using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;

[assembly: OwinStartup(typeof(ASP.NET_Web_Api_JSON.Startup))]

namespace ASP.NET_Web_Api_JSON
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            HttpConfiguration config = new HttpConfiguration();
            ConfigureWebApi(config);
        }

        public void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            JsonMediaTypeFormatter json = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
