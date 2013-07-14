using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects.Internal
{
    public class HeroFactoryStrategy : IObjectFactoryStrategy
    {
        public IObjectBase Execute(string id)
        {
            var result = new Hero(id);

            return result;
        }
    }
}
