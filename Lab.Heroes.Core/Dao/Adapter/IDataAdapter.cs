using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao.Adapter
{
    /// <summary>
    ///     A data adapter should be used to process partial data from one data source.
    /// </summary>
    public interface IDataAdapter<TObject> where TObject : IObjectBase
    {
        /// <summary>
        ///     This method should be invoked before the invocation of other methods on data adapter. If this method returns true,
        ///     the invocation of other methods can be continued.
        /// </summary>
        /// <returns></returns>
        bool IsValidObjectType();

        TObject Load(TObject data);

        void Save(TObject data);
    }
}