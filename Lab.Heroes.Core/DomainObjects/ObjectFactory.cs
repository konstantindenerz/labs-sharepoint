using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects
{
    public static class ObjectFactory
    {
        private static IDictionary<Type, IObjectFactoryStrategy> factoryStrategies = new Dictionary<Type, IObjectFactoryStrategy>();
        
        /// <summary>
        /// Returns an object matched the given type TTarget. Uses the first match of type parameter.
        /// </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IObjectBase Create<TTarget>(string name)
        {
            IObjectFactoryStrategy strategy;
            var key = FindKey<TTarget>();
            strategy = factoryStrategies[key];
            return strategy.Execute(name);
        }

        private static Type FindKey<TTarget>()
        {
            Type result = null;
            foreach (Type type in factoryStrategies.Keys)
            {
                if (type.IsAssignableFrom(typeof(TTarget)))
                {
                    result = type;
                }
            }

            if (null == result)
            {
                throw new ArgumentException(String.Format("There is no registered strategy for given target type (TType): {0}", typeof(TTarget).Name));
            }
            return result;
        }

        public static void Register<TTarget>(IObjectFactoryStrategy strategy) where TTarget : IObjectBase
        {
            var type = typeof(TTarget);
            factoryStrategies.Add(type, strategy);
        }

        public static void Unregister<TTarget>()
        {
            var key = FindKey<TTarget>();
            factoryStrategies.Remove(key);
        }
    }
}
