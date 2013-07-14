using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using Lab.Heroes.Core.DomainObjects.Serialization.Internal;
using Lab.Heroes.Core.Tests.DomainObjects.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects
{
    class MockHeroFactoryStrategy : IObjectFactoryStrategy
    {
        public IObjectBase Execute(string name)
        {
            IObjectBase result = new MockDeadpool();

            IJsonSerializer serializer = null;

            switch ((EMockHeroFactoryStrategy)Enum.Parse(typeof(EMockHeroFactoryStrategy), name))
            {
                case EMockHeroFactoryStrategy.deadPoolWithMockSerializer:
                    var deadpool = new MockDeadpool();
                    serializer = new MockJsonSerializer(result);
                    deadpool.Json = serializer;
                    result = deadpool;
                    break;

                case EMockHeroFactoryStrategy.deadPoolWithSerializer:
                    var otherDeadpool = new MockDeadpool();
                    serializer = new JsonSerializer(result);
                    otherDeadpool.Json = serializer;
                    result = otherDeadpool;
                    break;

                case EMockHeroFactoryStrategy.mockObject:
                    var mockObject = new MockObject();
                    serializer = new JsonSerializer(result);
                    mockObject.Json = serializer;
                    result = mockObject;
                    break;

                case EMockHeroFactoryStrategy.mockHero:
                    var mockHero = new MockHero();
                    serializer = new JsonSerializer(result);
                    mockHero.Json = serializer;
                    result = mockHero;
                    break;
            }
            return result;
        }
    }
}
