using System;
using Lab.Core.DomainObjects;
using NUnit.Framework;

namespace Lab.Core.Tests.DomainObjects
{
    [TestFixture]
    class TestHeroFactory
    {
        [SetUp]
        public void SetUp()
        {
            ObjectFactory.Clear();
        }
      
        [Test]
        public void Clear()
        {
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            var hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithMockSerializer.ToString());
            Assert.NotNull(hero);
            Assert.Throws(typeof(ArgumentException), delegate()
            {
                ObjectFactory.Clear();
                hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithMockSerializer.ToString());
                Assert.NotNull(hero);
            });
        }


        [Test]
        public void Create()
        {
            // Build
            IObjectBase hero;
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());
            // Process
            hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.deadPoolWithMockSerializer.ToString());
            // Check
            Assert.NotNull(hero);
        }

        [Test]
        public void CreateWithMultipleRegistration()
        {
            IObjectBase hero;
            ObjectFactory.Register<IObjectBase>(new MockHeroFactoryStrategy());
            ObjectFactory.Register<ISpecialHero>(new MockHeroFactoryStrategy());
            ObjectFactory.Register<IHero>(new MockHeroFactoryStrategy());

            hero = ObjectFactory.Create<ISpecialHero>(EMockHeroFactoryStrategy.deadPoolWithMockSerializer.ToString());
            Assert.IsInstanceOf<ISpecialHero>(hero);

            hero = ObjectFactory.Create<IHero>(EMockHeroFactoryStrategy.mockHero.ToString());
            Assert.IsInstanceOf<IHero>(hero);
            Assert.IsNotInstanceOf<ISpecialHero>(hero);

            var mockObject = ObjectFactory.Create<IObjectBase>(EMockHeroFactoryStrategy.mockObject.ToString());
            Assert.IsInstanceOf<IObjectBase>(mockObject);
            Assert.IsNotInstanceOf<IHero>(mockObject);

        }
    }
}
