using Lab.Core.DomainObjects;

namespace Lab.Heroes.Core.DomainObjects
{
    public interface IDesperado : IObjectBase
    {
        string Weapon { get; set; }
    }
}