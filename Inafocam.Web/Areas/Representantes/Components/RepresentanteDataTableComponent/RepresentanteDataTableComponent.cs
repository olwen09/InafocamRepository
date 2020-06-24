using Andamios.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Representantes.Components.RepresentanteDataTableComponent
{

  
    public class RepresentanteDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("RepresentanteDataTable");
        }
    }
}
