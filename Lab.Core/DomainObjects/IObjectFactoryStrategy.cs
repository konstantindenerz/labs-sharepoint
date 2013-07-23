namespace Lab.Core.DomainObjects
{
    public interface IObjectFactoryStrategy
    {
        IObjectBase Execute(string name);
    }
}