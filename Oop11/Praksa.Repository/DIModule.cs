using Autofac;
using Praksa.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repository
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);
            builder.RegisterType<PraksaPersonRepository>().As<IPraksaPersonRepository>();
        }
    }
}
