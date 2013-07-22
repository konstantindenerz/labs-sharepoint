﻿using System;
using System.Web;
using Ninject;

namespace Lab.Heroes.Core.Di
{
    /// <summary>
    /// This HTTP module should be used to create a container for dependency injection.
    /// </summary>
    public class SpDiHttpModule : IHttpModule, IDisposable
    {
        public void Init(HttpApplication context)
        {
            InitKernel(); 
        }

        private void InitKernel()
        {
            if (null == DiHelper.Kernel)
            {
                DiHelper.Kernel = KernelConfiguration.GetDefault();
            }
            
        }

        public void Dispose()
        {

        }
    }
}