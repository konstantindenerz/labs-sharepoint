using Lab.Heroes.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects.Serialization
{
    class MockHeroFactoryStrategy : IObjectFactoryStrategy
    {
        public IObjectBase Execute(string name)
        {
            var deadpool = new MockDeadpool();
            var serializer = new MockJsonSerializer(deadpool);
            deadpool.Json = serializer;
            return deadpool;
        }
    }
}
