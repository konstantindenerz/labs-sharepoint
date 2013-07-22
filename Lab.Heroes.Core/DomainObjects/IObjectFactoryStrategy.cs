namespace Lab.Heroes.Core.DomainObjects
{
    public interface IObjectFactoryStrategy
    {
        IObjectBase Execute(string name);
    }
}