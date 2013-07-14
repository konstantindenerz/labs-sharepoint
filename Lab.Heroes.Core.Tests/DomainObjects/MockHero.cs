using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects
{
    class MockHero : IHero
    {
        public MockHero()
        {

        }
        
        private IJsonSerializer jsonSerializer;

        public IJsonSerializer Json
        {
            get { return jsonSerializer; }
            set
            {
                jsonSerializer = value;
            }
        }
    }
}
