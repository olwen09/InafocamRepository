using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Materias.Components.MateriaDataTableComponent
{
    public class MateriaDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("MateriaDataTable");
        }
    }
}
