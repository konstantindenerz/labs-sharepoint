using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao.Adapter.Internal
{
    class OtherUnusedAdapter<TObject> : AbstractDataAdapter<IDesperado, TObject> where TObject : IObjectBase
    {
        public override TObject Load(TObject data)
        {
            data.Set("weapon", "gun");
            return data;
        }

        public override void Save(TObject data)
        {
            throw new NotImplementedException();
        }
    }
}
