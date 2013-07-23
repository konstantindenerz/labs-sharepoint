namespace Lab.Core.DomainObjects.Serialization
{
    public interface IJsonSerializable
    {
        IJsonSerializer Json { get; set; }
    }
}