using Lab.Core.Dao;
using Lab.Core.DomainObjects;

namespace Lab.Core.Services
{
    public interface IObjectAdministrationService<TObject> where TObject : IObjectBase
    {
        IObjectDao<TObject> Dao { get; set; }
        TObject GetBy(string id);
    }
}