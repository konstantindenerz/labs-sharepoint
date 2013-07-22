using System.Collections.Generic;
using System.Web.UI.WebControls;
using Lab.Heroes.Core.Dao.Adapter;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.Utility;
using Ninject;

namespace Lab.Heroes.Core.Dao.Internal
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