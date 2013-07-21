using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.Dao.Internal;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Internal;
using Lab.Heroes.Core.Services;
using Lab.Heroes.Core.Services.Internal;
using Ninject;

namespace Lab.Heroes.Core.Di
{
    public class KernelConfiguration
    {
        private static IKernel kernel;
        public static IKernel GetDefault()
        {
            
            if (null == kernel)
            {
                CreateKernelInstance();
            }

            return kernel;
        }

        private static void CreateKernelInstance()
        {
            kernel = new StandardKernel();
            kernel.Bind(typeof(IObjectAdministrationService<>)).To(typeof(GenericObjectAdministrationService<>));
            kernel.Bind(typeof(IObjectDao<>)).To(typeof(GenericObjectDao<>));
            OtherStuff();
        }

        private static void OtherStuff()
        {
            ObjectFactory.Register<Hero>(new HeroFactoryStrategy());
        }
    }

}
