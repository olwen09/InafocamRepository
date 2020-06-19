using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.AcuerdoProgramasdeBecas.Components.AcuerdoProgramasdeBecasDataTableComponent
{
    public class AcuerdoProgramasdeBecasDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AcuerdoProgramasdeBecasDataTable");
        }
    }
}
