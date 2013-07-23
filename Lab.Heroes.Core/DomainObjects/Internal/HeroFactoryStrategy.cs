using Lab.Core.DomainObjects;

namespace Lab.Heroes.Core.DomainObjects.Internal
{
    public class HeroFactoryStrategy : IHeroFactoryStrategy
    {
        public IObjectBase Execute(string id)
        {
            var result = new Hero(id);

            return result;
        }
    }
}