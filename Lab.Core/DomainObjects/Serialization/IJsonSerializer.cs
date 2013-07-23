namespace Lab.Core.DomainObjects.Serialization
{
    public interface IJsonSerializer
    {
        void Load(string jsonString);
        string AsString();
    }
}