using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.VerticalScriptSectionComponent
{
    public class VerticalScriptSectionComponent : ViewComponent    
    {
        public IViewComponentResult Invoke()
        {
            return View("VerticalScriptSection");
        }
    }
}
