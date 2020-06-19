using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.ProgramasDeBecas.Components.ProgramaBecaDataTableComponent
{
    public class ProgramaBecaDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ProgramaBecaDataTable");
        }
    }
}
