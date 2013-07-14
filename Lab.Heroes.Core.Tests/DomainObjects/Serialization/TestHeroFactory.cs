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
            IHero hero;
            HeroFactory.Register(heroName, new MockDeadpoolFactoryStrategy());
            // Process
            hero = HeroFactory.Create(heroName);
            // Check
            Assert.NotNull(hero);
        }
    }
}
