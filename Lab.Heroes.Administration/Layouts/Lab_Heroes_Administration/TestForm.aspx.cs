using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Lab.Heroes.Core.UI.ApplicationPages;
using Lab.Heroes.Core.DomainObjects;
using Lab.Heroes.Core.DomainObjects.Internal;

namespace Lab.Heroes.Administration.Layouts
{
    public partial class TestForm : FormPageBase<Hero>
    {
        public TestForm()
        {
            ObjectFactory.Register<Hero>(new HeroFactoryStrategy()); //TODO Move this code to another place
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
    }

}
