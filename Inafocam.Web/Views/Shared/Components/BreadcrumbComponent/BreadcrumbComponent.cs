using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.Breadcrumb
{
    public class BreadcrumbComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string area, string controlador, string controller, string vista)
        {

            ViewData["area"] = area;
            ViewData["controlador"] = controlador;
            ViewData["controller"] = controller;
            
            if(string.IsNullOrEmpty(vista))
            {
                vista = "Inicio";
            }
            ViewData["vista"] = vista;
           


            return View("Breadcrumb");
        }
    }
}
