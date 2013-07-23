using Lab.Core.Dao;
using Lab.Core.Di;
using Lab.Core.DomainObjects;
using Ninject;
using NUnit.Framework;

namespace Lab.Core.Tests.Di
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
