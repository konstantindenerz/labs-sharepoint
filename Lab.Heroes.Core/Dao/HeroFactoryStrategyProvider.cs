using System;
using System.Collections;
using System.Collections.Generic;
using Lab.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects;
using Ninject;
using Ninject.Activation;

namespace Lab.Heroes.Core.Dao
{
    public class HeroFactoryStrategyProvider : Provider<IDictionary<Type, IObjectFactoryStrategy>>
    {
        protected override IDictionary<Type, IObjectFactoryStrategy> CreateInstance(IContext context)
        {
            return new Dictionary<Type, IObjectFactoryStrategy>{{typeof(IHeroFactoryStrategy), context.Kernel.Get<IHeroFactoryStrategy>()}};
        }
    }
}