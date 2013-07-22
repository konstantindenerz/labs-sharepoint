using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.Dao.Internal;
using Lab.Heroes.Core.Di;
using Lab.Heroes.Core.DomainObjects;
using Ninject;
using NUnit.Framework;

namespace Lab.Heroes.Core.Tests.Di
{
    [TestFixture]
    class TestSpDiHttpModule
    {
        [Inject]
        public IObjectDao<IObjectBase> Dao { get; set; }

        [Test]
        public void Init()
        {
            var module = new SpDiHttpModule();
            Assert.IsNull(DiHelper.Kernel);
            Assert.IsNull(Dao);

            module.Init(null);
            
            Assert.IsNotNull(DiHelper.Kernel);
            DiHelper.Kernel.Inject(this);
            Assert.IsNotNull(Dao);
        }
    }
}
