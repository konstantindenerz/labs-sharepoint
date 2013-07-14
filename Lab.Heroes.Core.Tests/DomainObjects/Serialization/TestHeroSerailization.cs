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
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
        }

        [Test]
        public void ToJson()
        {
            // Build 
            IObjectBase hero = ObjectFactory.Create<ISpecialHero>(heroName);
            // Process
            var jsonString = hero.Json.AsString();
            // Check
            Assert.IsNotNullOrEmpty(jsonString);
        }
    }
}
