using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.FloattingButtonComponent
{
    public class FloattingButtonComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string action, string controller, string area, string vista, bool enabled = true)
        {
            return View("FloattingButton", new FloattingActionButtom(action, controller, area, vista, enabled));
        }
    }

    public class FloattingActionButtom
    {
        public string Vista { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public bool Enabled { get; set; }

        public FloattingActionButtom(string action, string controller, string area, string vista, bool enabled)
        {
            Action = action;
            Area = area;
            Controller = controller;
            Vista = vista;
            Enabled = enabled;
        }
    }
}
