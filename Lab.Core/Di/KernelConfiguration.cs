using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

        private static List<Assembly> processedAssemblies = new List<Assembly>();
        private static void CreateKernelInstance()
        {
            kernel = new StandardKernel();
            Load();
        }

        public static void Load()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assembly.GetName().Name.StartsWith("Lab.")
                && !processedAssemblies.Contains(assembly));
            
            kernel.Load(assemblies);
            processedAssemblies.AddRange(assemblies);
        }
    }
}