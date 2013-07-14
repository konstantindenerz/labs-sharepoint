using Lab.Heroes.Core.DomainObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects.Serialization
{
    [TestFixture]
    class TestHeroFactory
    {
        [Test]
        public void Create()
        {
            // Build
            var heroName = "Deadpool";
            IObjectBase hero;
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            // Process
            hero = ObjectFactory.Create<IHero>(heroName);
            // Check
            Assert.NotNull(hero);
        }
    }
}
