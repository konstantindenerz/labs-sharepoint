using System.Collections.Generic;
using Lab.Heroes.Core.Utility;
using Newtonsoft.Json;

namespace Lab.Heroes.Core.DomainObjects.Serialization.Internal
{
    public class JsonSerializer : AbstractJsonSerializer
    {
        public JsonSerializer(IObjectBase objectBase)
            : base(objectBase)
        {
        }

        public override void Load(string jsonString)
        {
            var values = JsonConvert.DeserializeObject<IDictionary<string, object>>(jsonString);
            ObjectBase.GetValues().Merge(values);
        }

        public override string AsString()
        {
            var values = ObjectBase.GetValues();
            return JsonConvert.SerializeObject(values);
        }
    }
}