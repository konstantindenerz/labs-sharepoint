using Lab.Core.DomainObjects;
using NUnit.Framework;

namespace Lab.Core.Tests.DomainObjects.Serialization
{
    [TestFixture]
    class TestHeroJsonSerailization
    {

        [SetUp]
        public void SetUp()
        {
            ObjectFactory.Clear();
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

        [Test]
        public void ToJson()
        {
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            var hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithSerializer.ToString());
            Assert.IsNotNull(hero);
            hero.Name = "Deadpool";
            var json = hero.Json.AsString();
            Assert.IsNotNullOrEmpty(json);
            Assert.AreEqual("{\"name\":\"Deadpool\"}", json);

        }

        [Test]
        public void Load()
        {
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            var hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithSerializer.ToString());
            Assert.IsNotNull(hero);
            Assert.IsNullOrEmpty(hero.Name);
            hero.SecretBase = "Unknown";
            hero.Json.Load("{\"name\":\"Deadpool\"}");
            Assert.AreEqual("Deadpool", hero.Name);
            Assert.IsNotNullOrEmpty(hero.SecretBase);
            Assert.AreEqual("Unknown", hero.SecretBase);
        }
    }
}
