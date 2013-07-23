using Lab.Core.DomainObjects;

namespace Lab.Core.Dao.Internal
{
    public class MockListItemDispatcher<TObject> : IListItemDispatcher<TObject> where TObject : IObjectBase
    {
        public void Dispatch(TObject data)
        {
            // TODO Implement this method
        }
    }
}