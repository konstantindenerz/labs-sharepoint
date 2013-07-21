namespace Lab.Heroes.Core.DomainObjects.Internal
{
    public class Hero : AbstractObjectBase, IHero
    {
        public Hero()
        {
        }

        public Hero(string id)
        {
            Id = id;
        }

        public string Name
        {
            get { return Get<string>("name"); }
            set { Set("name", value); }
        }

        public string SecretBase
        {
            get { return Get<string>("secretBase"); }
            set { Set("secretBase", value); }
        }

        public string Id
        {
            get { return Get<string>("id"); }
            set { Set("id", value); }
        }
    }
}