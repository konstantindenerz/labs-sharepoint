using Lab.Core.DomainObjects;

namespace Lab.Core.Dao.Adapter.Internal
{
    public abstract class AbstractDataAdapter<TExpected, TObject> : IDataAdapter<TObject>
        where TObject : IObjectBase
        where TExpected : IObjectBase
    {
        /// <summary>
        /// Returns true if type of TExpected is equals TObject.
        /// </summary>
        /// <returns></returns>
        public bool IsValidObjectType()
        {
            return typeof(TObject) == typeof(TExpected);
        }

        public abstract TObject Load(TObject data);

        public abstract void Save(TObject data);
    }
}
