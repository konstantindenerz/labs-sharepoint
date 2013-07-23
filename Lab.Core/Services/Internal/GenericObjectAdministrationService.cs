using Lab.Core.Dao;
using Lab.Core.DomainObjects;
using Lab.Core.DomainObjects.Serialization;
using Lab.Core.DomainObjects.Serialization.Internal;
using Ninject;

namespace Lab.Core.Services.Internal
{
    public class GenericObjectAdministrationService<TObject> : IObjectAdministrationService<TObject>
        where TObject : IObjectBase
    {
        public GenericObjectAdministrationService(IObjectDao<TObject> dao)
        {
            Dao = dao;
        }

        [Inject]
        public IObjectDao<TObject> Dao { get; set; }

        public TObject GetBy(string id)
        {
            var result = Dao.LoadBy(id);
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