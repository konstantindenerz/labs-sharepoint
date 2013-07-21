using System;
using Lab.Heroes.Core.DomainObjects.Internal;
using Lab.Heroes.Core.UI.ApplicationPages;

namespace Lab.Heroes.Administration.Layouts
{
    public partial class TestForm : FormPageBase<Hero>
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var test = 42;
        }
    }
}