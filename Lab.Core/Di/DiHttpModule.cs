using System;
using System.Linq;
using System.Web;

namespace Lab.Core.Di
{
    /// <summary>
    ///     This HTTP module should be used to create a container for dependency injection.
    /// </summary>
    public class DiHttpModule : IHttpModule, IDisposable
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
            DiHelper.Kernel.Dispose();
        }
    }
}