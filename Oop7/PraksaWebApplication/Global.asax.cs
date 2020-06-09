using Autofac;
using Praksa.Repository;
using Praksa.Repository.Common;
using Praksa.Service;
using Praksa.Service.Common;
using PraksaWebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Reflection;
using Autofac.Core;
using System.Web.Http.Dependencies;

namespace PraksaWebApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);


            #region ContainerBuilder

            var containerBuilder = new ContainerBuilder();
            var container = containerBuilder.Build();

            // When someone need IPraksaPersonService (interface) return instance of PraksaPersonService
            containerBuilder.RegisterType<PraksaPersonService>().As<IPraksaPersonService>();

            containerBuilder.RegisterType<PraksaPersonRepository>().As<IPraksaPersonRepository>();


            #endregion
        }
    }
}
