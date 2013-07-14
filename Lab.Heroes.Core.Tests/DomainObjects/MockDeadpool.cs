using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using Lab.Heroes.Core.Tests.DomainObjects.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Tests.DomainObjects
{
    class MockDeadpool : AbstractObjectBase, ISpecialHero
    {
        public MockDeadpool()
        {

        }

        public string Name
        {
            get
            {
                return Get<string>("name");
            }
            set
            {
                Set("name", value);
            }
        }

        public string SecretBase
        {
            get
            {
                return Get<string>("secretBase");
            }
            set
            {
                Set("secretBase", value);
            }
        }
    }
}
