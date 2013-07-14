using Lab.Heroes.Core.Dao.Internal;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Serialization;
using Lab.Heroes.Core.Services;
using Lab.Heroes.Core.Services.Internal;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Lab.Heroes.Core.UI.ApplicationPages
{
    public class FormPageBase<TObject> : LayoutsPageBase where TObject : IObjectBase
    {
        public FormPageBase()
        {
            //TODO Move this configuration to another file
            var dao = new GenericObjectDao<TObject>();
            Service = new GenericObjectAdministrationService<TObject>(dao);
        }

        HtmlInputText jsonBridge = new HtmlInputText("hidden");

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            this.Controls.Add(jsonBridge);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            LoadObject();
        }

        /// <summary>
        /// This service should be used to manage objects corresponding to TObject.
        /// </summary>
        public IObjectAdministrationService<TObject> Service { get; set; }

        /// <summary>
        /// This methods uses parameter from query string to load an item. 
        /// This item will be serialized to JSON. 
        /// The JSON string should be transported in the bridge.
        /// </summary>
        protected void LoadObject()
        {
            if (!this.IsPostBack)
            {
                var idParameter = "id";
                var parameters = HttpUtility.ParseQueryString(this.ClientQueryString);
                if (!String.IsNullOrEmpty(parameters[idParameter]))
                {
                    var id = parameters[idParameter];
                    TObject currentObject = Service.GetBy(id);
                    jsonBridge.Value = currentObject.Json.AsString();
                }
            }
        }
    }
}
