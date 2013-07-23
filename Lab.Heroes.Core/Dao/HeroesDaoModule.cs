using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Core.Dao.Adapter;
using Lab.Core.Di;
using Lab.Core.DomainObjects;
using Lab.Heroes.Core.Dao.Adapter.Internal;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Internal;
using Ninject.Modules;

namespace Lab.Heroes.Core.Dao
{
  
    public class HeroesDaoModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IDataAdapter<>)).To(typeof(HeroSecretBaseAdapter<>));
            Bind(typeof(IDataAdapter<>)).To(typeof(OtherUnusedAdapter<>));
            Bind(typeof(IDataAdapter<>)).To(typeof(HeroNameAdapter<>));
            Bind<IHeroFactoryStrategy>().To<HeroFactoryStrategy>();
            Bind<IDictionary<Type, IObjectFactoryStrategy>>().ToProvider<HeroFactoryStrategyProvider>();
        }
    }
}
