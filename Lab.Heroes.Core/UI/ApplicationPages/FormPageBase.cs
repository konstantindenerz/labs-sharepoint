using System;
using System.Web;
using System.Web.UI.HtmlControls;
using Lab.Heroes.Core.Dao.Internal;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.Services;
using Lab.Heroes.Core.Services.Internal;
using Microsoft.SharePoint.WebControls;

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

        private HtmlInputText jsonBridge = new HtmlInputText("hidden");

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            Controls.Add(jsonBridge);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            LoadObject();
        }

        /// <summary>
        ///     This service should be used to manage objects corresponding to TObject.
        /// </summary>
        public IObjectAdministrationService<TObject> Service { get; set; }

        /// <summary>
        ///     This methods uses parameter from query string to load an item.
        ///     This item will be serialized to JSON.
        ///     The JSON string should be transported in the bridge.
        /// </summary>
        protected void LoadObject()
        {
            if (!IsPostBack)
            {
                var idParameter = "id";
                var parameters = HttpUtility.ParseQueryString(ClientQueryString);
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