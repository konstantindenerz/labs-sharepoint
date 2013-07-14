using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects
{
    public static class HeroFactory
    {
        private static IDictionary<string, IHeroFactoryStrategy> factoryStrategies = new Dictionary<string, IHeroFactoryStrategy>();

        public static IHero Create(string name)
        {
            CheckArgument(name);
            return factoryStrategies[name].Execute();
        }


        /// <summary>
        /// Checks the given argument. Throws exceptions if the given Argument is not valid.
        /// </summary>
        /// <param name="name"></param>
        private static void CheckArgument(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (!factoryStrategies.ContainsKey(name))
            {
                throw new ArgumentException(String.Format("There is no registered strategy for given name: {0}", name),name);
            }
        }

        
        public static void Register(string name, IHeroFactoryStrategy strategy) {
            factoryStrategies.Add(name, strategy);
        }

        public static void Unregister(string name)
        {
            factoryStrategies.Remove(name);
        }


        
    }
}
