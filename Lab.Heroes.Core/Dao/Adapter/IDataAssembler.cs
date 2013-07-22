using System.Collections;
using System.Collections.Generic;
using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao.Adapter
{
    /// <summary>
    /// A data assembler should use adapters to create and process objects.
    /// </summary>
    /// <typeparam name="TObject"></typeparam>
    public interface IDataAssembler<TObject> where TObject : IObjectBase
    {
        IList<IDataAdapter<TObject>> Adapters { get; set; } 
        TObject GetById(string id);
        void Save(TObject data);
    }
}