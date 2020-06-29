using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Praksa.Service.Common;

namespace Praksa.Service
{
    public class DIModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);
            builder.RegisterType<PraksaPersonService>().As<IPraksaPersonService>();
        }
    }
}