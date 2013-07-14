using Lab.Heroes.Core.Dao;
using Lab.Heroes.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Services
{
    public interface IObjectAdministrationService<TObject> where TObject : IObjectBase
    {
        IObjectDao<TObject> Dao { get; set; }
        TObject GetBy(string id);
    }
}
