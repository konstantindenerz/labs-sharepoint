using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Dao
{
    public interface IObjectDao<TObject>
    {
        TObject LoadBy(string id);
    }
}
