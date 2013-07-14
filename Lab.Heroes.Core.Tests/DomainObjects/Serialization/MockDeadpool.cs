using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects.Serialization
{
    class MockDeadpool : IHero
    {
        public MockDeadpool(){

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
