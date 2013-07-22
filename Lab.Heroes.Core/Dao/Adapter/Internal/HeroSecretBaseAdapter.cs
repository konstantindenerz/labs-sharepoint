using Lab.Heroes.Core.DomainObjects;

namespace Lab.Heroes.Core.Dao.Adapter.Internal
{
    public class HeroSecretBaseAdapter<TObject> : AbstractDataAdapter<IHero, TObject> where TObject : IObjectBase
    {
        public override TObject Load(TObject data)
        {
            var hero = (IHero)data;
            switch (hero.Id)
            {
                case "42":
                    hero.SecretBase = "Playboy Mansion";
                    break;
            }


            return data;
        }

        public override void Save(TObject data)
        {
            throw new System.NotImplementedException();
        }
    }
}