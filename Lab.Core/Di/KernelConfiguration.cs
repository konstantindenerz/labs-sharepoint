using System;
using Lab.Core.Dao;
using Lab.Core.Dao.Adapter;
using Lab.Core.Dao.Adapter.Internal;
using Lab.Core.Dao.Internal;
using Lab.Core.DomainObjects;
using Lab.Core.Services;
using Lab.Core.Services.Internal;
using Ninject;

namespace Lab.Core.Di
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
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies());
        }

    }

}
