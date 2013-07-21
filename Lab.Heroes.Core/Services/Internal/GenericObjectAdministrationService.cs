using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using Lab.Heroes.Core.DomainObjects.Serialization.Internal;
using Ninject;

namespace Lab.Heroes.Core.Services.Internal
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