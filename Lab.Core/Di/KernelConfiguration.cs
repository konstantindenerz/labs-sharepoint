using System;
using Ninject;

namespace Lab.Core.Di
{
    public class KernelConfiguration
    {
        private static IKernel kernel;
        private static object syncRoot = new Object();
        
        public static IKernel GetDefault()
        {
            if (null == kernel)
            {
                lock (syncRoot)
                {
                    if (null == kernel)
                    {
                        CreateKernelInstance();
                    }
                }
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