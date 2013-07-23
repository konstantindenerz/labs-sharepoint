using System;
using Lab.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects;

namespace Lab.Core.Tests.DomainObjects
{
    class MockHero : AbstractObjectBase, IHero
    {
        public MockHero()
        {

        }
        
        public string Name
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


        public string SecretBase
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
