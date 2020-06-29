using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Seguimientos.Components.SeguimientoDataTableComponent
{
    public class SeguimientoDataTableComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("SeguimientoDataTable");
        }
    }
}
