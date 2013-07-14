using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects.Serialization
{
    public interface IJsonSerializable
    {
        IJsonSerializer Json { get; }
    }
}
