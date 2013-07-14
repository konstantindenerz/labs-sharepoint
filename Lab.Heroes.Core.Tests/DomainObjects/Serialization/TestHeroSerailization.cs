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

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void ToJsonWithMockSerializer()
        {
            
            // Build 
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            IObjectBase hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithMockSerializer.ToString());
            // Process
            var jsonString = hero.Json.AsString();
            // Check
            Assert.IsNotNullOrEmpty(jsonString);
        }
    }
}
