using System;
using System.Collections.Generic;
using Ninject;

namespace Lab.Core.DomainObjects.Internal
{
    public class ObjectFactory : IObjectFactory
    {
        public ObjectFactory()
        {
            Strategies = new Dictionary<Type, IObjectFactoryStrategy>();
        }

        [Inject]
        public IDictionary<Type, IObjectFactoryStrategy> Strategies { get; set; }

        /// <summary>
        ///     Returns an object matched the given type TTarget. Uses the first match of type parameter.
        /// </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="name">An identifier that should be used to create an object.</param>
        /// <returns></returns>
        public TTarget Create<TTarget>(string name) where TTarget : IObjectBase
        {
            IObjectFactoryStrategy strategy;
            var key = FindKey<TTarget>();
            strategy = Strategies[key];
            return (TTarget) strategy.Execute(name);
        }


        /// <summary>
        ///     Uses the type parameter to find a registered strategy.
        /// </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <returns></returns>
        private Type FindKey<TTarget>()
        {
            Type result = null;
            foreach (Type type in Strategies.Keys)
            {
                if (type == typeof (TTarget))
                {
                    result = type;
                }
            }

            if (null == result)
            {
                throw new ArgumentException(
                    String.Format("There is no registered strategy for given target type (TType): {0}",
                        typeof (TTarget).Name));
            }
            return result;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TTarget">Ignored registration if a strategy with for same type is registered.</typeparam>
        /// <param name="strategy"></param>
        public void Register<TTarget>(IObjectFactoryStrategy strategy) where TTarget : IObjectBase
        {
            var type = typeof (TTarget);
            if (!Strategies.Keys.Contains(type))
            {
                Strategies.Add(type, strategy);
            }
        }

        public void Unregister<TTarget>()
        {
            var key = FindKey<TTarget>();
            Strategies.Remove(key);
        }

        public void Clear()
        {
            Strategies.Clear();
        }
    }
}