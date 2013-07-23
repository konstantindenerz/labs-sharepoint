using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Core.DomainObjects
{
    public interface IObjectFactory
    {
        IDictionary<Type, IObjectFactoryStrategy> Strategies { get; set; }

        TTarget Create<TTarget>(string name) where TTarget : IObjectBase;

        void Register<TTarget>(IObjectFactoryStrategy strategy) where TTarget : IObjectBase;

        void Unregister<TTarget>();

        void Clear();
    }
}
