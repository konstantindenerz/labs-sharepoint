using Lab.Core.Dao.Adapter;
using Lab.Core.DomainObjects;
using Ninject;

namespace Lab.Core.Dao.Internal
{
    public class GenericObjectDao<TObject> : IObjectDao<TObject> where TObject : IObjectBase
    {
        [Inject]
        public IDataAssembler<TObject> Assembler { get; set; }

        [Inject]
        public IListItemDispatcher<TObject> ListItemDispatcher { get; set; }

        public TObject LoadBy(string id)
        {
            return Assembler.GetById(id);
        }

        public void Save(TObject data)
        {
            Assembler.Save(data);
            ListItemDispatcher.Dispatch(data);
        }
    }
}