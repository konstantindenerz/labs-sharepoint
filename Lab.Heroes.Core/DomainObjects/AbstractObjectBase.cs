using System.Collections.Generic;
using Lab.Heroes.Core.DomainObjects.Serialization;

namespace Lab.Heroes.Core.DomainObjects
{
    public abstract class AbstractObjectBase : IObjectBase
    {
        private IDictionary<string, object> values = new Dictionary<string, object>();

        public TResult Get<TResult>(string property) where TResult : class
        {
            TResult result = default(TResult);
            if (values.ContainsKey(property))
            {
                result = (TResult) values[property];
            }
            return result;
        }

        public void Set(string property, object value)
        {
            values[property] = value;
        }

        public IDictionary<string, object> GetValues()
        {
            return values;
        }

        private IJsonSerializer jsonSerializer;

        public IJsonSerializer Json
        {
            get { return jsonSerializer; }
            set { jsonSerializer = value; }
        }
    }
}