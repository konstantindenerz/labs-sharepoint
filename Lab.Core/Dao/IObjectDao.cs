using Lab.Core.Dao.Adapter;
using Lab.Core.DomainObjects;

namespace Lab.Core.Dao
{
    public interface IObjectDao<TObject> where TObject : IObjectBase
    {
        IDataAssembler<TObject> Assembler { get; set; }
        TObject LoadBy(string id);
        void Save(TObject data);
    }
}