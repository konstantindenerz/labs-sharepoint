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
        /// <param name="name">An identifier that should be used to create an object.</param>
        /// <returns></returns>
        public static TTarget Create<TTarget>(string name) where TTarget : IObjectBase
        {
            IObjectFactoryStrategy strategy;
            var key = FindKey<TTarget>();
            strategy = factoryStrategies[key];
            return (TTarget)strategy.Execute(name);
        }


        /// <summary>
        /// Uses the type parameter to find a registered strategy.
        /// </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <returns></returns>
        private static Type FindKey<TTarget>()
        {
            Type result = null;
            foreach (Type type in factoryStrategies.Keys)
            {
                if (type == typeof(TTarget))
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTarget">Ignored registration if a strategy with for same type is registered.</typeparam>
        /// <param name="strategy"></param>
        public static void Register<TTarget>(IObjectFactoryStrategy strategy) where TTarget : IObjectBase
        {
            var type = typeof(TTarget);
            if (!factoryStrategies.Keys.Contains(type))
            {
                factoryStrategies.Add(type, strategy);
            }
        }

        public static void Unregister<TTarget>()
        {
            var key = FindKey<TTarget>();
            factoryStrategies.Remove(key);
        }

        public static void Clear()
        {
            factoryStrategies.Clear();
        }
    }
}
