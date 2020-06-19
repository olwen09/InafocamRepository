using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Andamios.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.PagerViewComponent
{
    public class PagerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Pager pager, string area, string controller, string action)
        {
            ViewData["area"] = area;
            ViewData["controller"] = controller;
            ViewData["action"] = action;

            return View("PagerViewComponent", pager);
        }
    }
}
