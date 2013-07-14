using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects.Serialization.Internal
{
    public class JsonSerializer : AbstractJsonSerializer
    {

        public JsonSerializer(IJsonSerializable jsonSerializable)
            : base(jsonSerializable)
        {

        }

        public override void Load(string jsonString)
        {
            throw new NotImplementedException();
        }

        public override string AsString()
        {
            throw new NotImplementedException();
        }
    }
}
