namespace Lab.Heroes.Core.DomainObjects
{
    public interface IHero : IObjectBase
    {
        string Id { get; set; }
        string Name { get; set; }
        string SecretBase { get; set; }
    }
}