using Lab.Heroes.Core.DomainObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects.Serialization
{
    [TestFixture]
    class TestHeroJsonSerailization
    {
        private string heroName = "Deadpool";

        [SetUp]
        public void SetUp()
        {
            HeroFactory.Register(heroName, new MockDeadpoolFactoryStrategy());
        }

        [Test]
        public void ToJson()
        {
            // Build 
            IHero hero = HeroFactory.Create(heroName);
            // Process
            var jsonString = hero.Json.AsString();
            // Check
            Assert.IsNotNullOrEmpty(jsonString);
        }
    }
}
