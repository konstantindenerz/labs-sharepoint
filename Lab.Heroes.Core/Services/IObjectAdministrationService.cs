using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Services
{
    public interface IObjectAdministrationService<TObject> where TObject : IObjectBase
    {
        IObjectDao<TObject> Dao { get; set; }
        TObject GetBy(string id);
    }
}