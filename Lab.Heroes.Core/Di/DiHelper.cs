using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace Lab.Heroes.Core.Di
{
    public static class DiHelper
    {
        public static IKernel Kernel { get; set; }
    }
}
