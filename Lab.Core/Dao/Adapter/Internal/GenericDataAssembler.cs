using System.Collections.Generic;
using System.Linq;
using Lab.Core.DomainObjects;
using Microsoft.SharePoint.JSGrid;
using Ninject;

namespace Lab.Core.Dao.Adapter.Internal
{
    public class GenericDataAssembler<TObject> : IDataAssembler<TObject> where TObject : IObjectBase
    {
        [Inject]
        public IList<IDataAdapter<TObject>> Adapters { get; set; }

        [Inject]
        public IObjectFactory ObjectFactory { get; set; }

        public TObject GetById(string id)
        {
            var result = ObjectFactory.Create<TObject>(id);
            return Adapters.Where(adapter => adapter.IsValidObjectType())
                .Aggregate(result, (current, adapter) => adapter.Load(current));
        }

        public void Save(TObject data)
        {
            foreach (var dataAdapter in Adapters.Where(dataAdapter => dataAdapter.IsValidObjectType()))
            {
                dataAdapter.Save(data);
            }
        }
    }
}