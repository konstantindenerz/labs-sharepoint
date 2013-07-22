using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao
{
    public interface IListItemDispatcher<TObject> where TObject : IObjectBase
    {
        void Dispatch(TObject data);
    }
}