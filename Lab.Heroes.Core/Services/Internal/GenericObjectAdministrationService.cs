using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using Lab.Heroes.Core.DomainObjects.Serialization.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Services.Internal
{
    public class GenericObjectAdministrationService<TObject> : IObjectAdministrationService<TObject> where TObject : IObjectBase
    {
        public GenericObjectAdministrationService(IObjectDao<TObject> dao)
        {
            this.Dao = dao;
        }

        public IObjectDao<TObject> Dao { get; set; }
        public TObject GetBy(string id)
        {
            var result = default(TObject);
            result = Dao.LoadBy(id);
            AddSerializer(result);
            return result;
        }

        private void AddSerializer(TObject result)
        {
            IJsonSerializable jsonSerializable = result;
            jsonSerializable.Json = new JsonSerializer(result);
        }

        
    }
}
