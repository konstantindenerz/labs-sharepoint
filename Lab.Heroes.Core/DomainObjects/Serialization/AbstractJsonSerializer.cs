namespace Lab.Heroes.Core.DomainObjects.Serialization
{
    public abstract class AbstractJsonSerializer : IJsonSerializer
    {
        private IObjectBase objectBase;

        protected IObjectBase ObjectBase
        {
            get { return objectBase; }
        }

        /// <summary>
        ///     Constructor without parameters should not be supported.
        /// </summary>
        private AbstractJsonSerializer()
        {
        }

        /// <summary>
        ///     This constructor should be used to get an instance to serializable object. This object should be used in
        ///     serialization.
        /// </summary>
        /// <param name="objectBase"></param>
        public AbstractJsonSerializer(IObjectBase objectBase)
        {
            this.objectBase = objectBase;
        }

        /// <summary>
        ///     Fills the serializable object with data from given JSON string.
        /// </summary>
        /// <param name="jsonString"></param>
        public abstract void Load(string jsonString);

        /// <summary>
        ///     Returns the serializable object as string.
        /// </summary>
        /// <returns></returns>
        public abstract string AsString();
    }
}