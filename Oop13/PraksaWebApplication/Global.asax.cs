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
using Autofac.Integration.WebApi;

namespace PraksaWebApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            #region ContainerBuilder

            var containerBuilder = new ContainerBuilder();
            
            containerBuilder.RegisterType<PraksaController>();

            // When someone need IPraksaPersonService(interface) return instance of PraksaPersonService
            containerBuilder.RegisterType<PraksaPersonService>().As<IPraksaPersonService>();

            // When someone need IPraksaPersonService(interface) return instance of PraksaPersonService
            containerBuilder.RegisterType<PraksaPersonRepository>().As<IPraksaPersonRepository>();

            var container = containerBuilder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
            #endregion
        }
    }
}
