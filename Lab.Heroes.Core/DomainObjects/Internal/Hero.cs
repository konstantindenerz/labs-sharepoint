using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.DomainObjects.Internal
{
    public class Hero: AbstractObjectBase, IHero
    {
        public Hero()
        {

        }

        public Hero(string id)
        {
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return Get<string>("name");
            }
            set
            {
                Set("name", value);
            }
        }

        public string SecretBase
        {
            get
            {
                return Get<string>("secretBase");
            }
            set
            {
                Set("secretBase", value);
            }
        }

        public string Id
        {
            get
            {
                return Get<string>("id");
            }
            set
            {
                Set("id", value);
            }
        }
    }
}
