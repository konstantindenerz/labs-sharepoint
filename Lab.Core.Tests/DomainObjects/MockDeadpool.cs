using System;
using Lab.Core.DomainObjects;

namespace Lab.Core.Tests.DomainObjects
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

        public string Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
