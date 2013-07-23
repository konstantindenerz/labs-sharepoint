using Lab.Core.DomainObjects;
using Lab.Core.DomainObjects.Serialization;

namespace Lab.Core.Tests.DomainObjects.Serialization
{
    class MockJsonSerializer : AbstractJsonSerializer
    {
        public MockJsonSerializer(IObjectBase objectBase)
            : base(objectBase)
        {

        }


        public override void Load(string jsonString)
        {
            
        }

        public override string AsString()
        {
            return "42";
        }
    }
}
