using Lab.Heroes.Core.Dao.Adapter;
using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao
{
    public interface IObjectDao<TObject> where TObject : IObjectBase
    {
        IDataAssembler<TObject> Assembler { get; set; }
        TObject LoadBy(string id);
        void Save(TObject data);
    }
}