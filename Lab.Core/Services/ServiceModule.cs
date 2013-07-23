using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Core.Dao;
using Lab.Core.Services.Internal;
using Ninject.Modules;

namespace Lab.Core.Services
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IObjectAdministrationService<>)).To(typeof(GenericObjectAdministrationService<>));
        }
    }
}
