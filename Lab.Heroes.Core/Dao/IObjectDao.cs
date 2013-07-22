using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao
{
    public interface IObjectDao<TObject> where TObject : IObjectBase
    {
        TObject LoadBy(string id);
    }
}