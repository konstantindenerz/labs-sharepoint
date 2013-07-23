using System;
using Lab.Core.DomainObjects;

namespace Lab.Core.Dao.Adapter.Internal
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
