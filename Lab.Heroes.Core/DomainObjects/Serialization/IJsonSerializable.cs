namespace Lab.Heroes.Core.DomainObjects.Serialization
{
    public interface IJsonSerializable
    {
        IJsonSerializer Json { get; set; }
    }
}