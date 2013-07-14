using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab.Heroes.Core.Utility;
namespace Lab.Heroes.Core.Dao.Internal
{
    public class GenericObjectDao<TObject> : IObjectDao<TObject> where TObject : IObjectBase
    {

        public TObject LoadBy(string id)
        {
            var currentObject = ObjectFactory.Create<TObject>(id);
            Fill(currentObject);
            return currentObject;
        }

        private void Fill(TObject currentObject)
        {
            //This code should call a data base adapter to get data.
            // this is an example to how merge existing instance with data from database
            currentObject.GetValues().Merge(new Dictionary<string, object>() {
                {"name", "Deadpool"},
                {"secredBase", "Unknown"}
            });
        }
    }
}
