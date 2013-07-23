using Lab.Core.DomainObjects;

namespace Lab.Core.Dao.Adapter.Internal
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
