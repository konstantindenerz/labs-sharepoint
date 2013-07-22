using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Internal;

namespace Lab.Heroes.Core.Dao.Adapter.Internal
{
    class HeroNameAdapter<TObject> : AbstractDataAdapter<IHero, TObject> where TObject : IObjectBase
    {
        
        public override TObject Load(TObject data)
        {
            var hero = (IHero) data;
            switch (hero.Id)
            {
                case "42":
                    hero.Name = "Deadpool";
                    break;
            }
            

            return data;
        }

        public override void Save(TObject data)
        {
            
        }
    }
}
