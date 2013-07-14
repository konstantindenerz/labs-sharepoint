using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects.Serialization
{
    public abstract class AbstractJsonSerializer : IJsonSerializer
    {
        private IJsonSerializable jsonSerializable;
        protected IJsonSerializable JsonSerializable { get { return jsonSerializable; } }

        private AbstractJsonSerializer()
        {

        }

        public AbstractJsonSerializer(IJsonSerializable jsonSerializable)
        {
            this.jsonSerializable = jsonSerializable;
        }

        public abstract void Load(string jsonString);

        public abstract string AsString();
    }
}
