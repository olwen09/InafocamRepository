using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.ProgramacionDeSeguimiento.Components.ProgramacionSeguimientoDataTableComponent
{
    public class ProgramacionSeguimientoDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ProgramacionSeguimientoDataTable");
        }
    }
}
