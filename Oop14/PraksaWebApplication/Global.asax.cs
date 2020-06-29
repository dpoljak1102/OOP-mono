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
using AutoMapper;

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
            containerBuilder.RegisterType<PraksaPersonService>().As<IPraksaPersonService>();
            containerBuilder.RegisterType<PraksaPersonRepository>().As<IPraksaPersonRepository>();
            containerBuilder.RegisterType<Mapper>().As<IMapper>();

            containerBuilder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }));

            containerBuilder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().SingleInstance();

            var container = containerBuilder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
            #endregion
        }
    }
}
