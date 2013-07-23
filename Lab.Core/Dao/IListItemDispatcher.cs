using Lab.Core.DomainObjects;

namespace Lab.Core.Dao
{
    public interface IListItemDispatcher<TObject> where TObject : IObjectBase
    {
        void Dispatch(TObject data);
    }
}