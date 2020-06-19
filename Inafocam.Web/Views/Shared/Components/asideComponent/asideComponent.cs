using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.asideComponent
{
    public class asideComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string area, string vista, string controller, string controllerText, string cantidad, int id)
        {
            return View("aside", new AsideModel(area, vista, controller, controllerText, cantidad, id));
        }
    }

    public class AsideModel
    {
        public string Area { get; set; }
        public string Vista { get; set; }
        public string Controller { get; set; }
        public string ControllerText { get; set; }
        public string Cantidad { get; set; }
        public int Id { get; set; }

        public AsideModel(string area, string vista, string controller, string controllerText, string cantidad, int id)
        {
            Area = area;
            Vista = vista;
            Controller = controller;
            ControllerText = controllerText;
            Cantidad = cantidad;
            Id = id;
        }
    }
}
