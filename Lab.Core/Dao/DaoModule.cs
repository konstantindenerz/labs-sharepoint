using Lab.Core.Dao.Adapter;
using Lab.Core.Dao.Adapter.Internal;
using Lab.Core.Dao.Internal;
using Ninject.Modules;

namespace Lab.Core.Dao
{
    public class DaoModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IObjectDao<>)).To(typeof(GenericObjectDao<>));
            Bind(typeof(IDataAssembler<>)).To(typeof(GenericDataAssembler<>));
            Bind(typeof(IListItemDispatcher<>)).To(typeof(MockListItemDispatcher<>));
        }
    }
}