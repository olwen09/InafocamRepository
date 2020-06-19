using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.InstitucionFomadora.Components.InstitucionFomadoraDataTableComponent
{
    public class InstitucionFomadoraDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("InstitucionFomadoraDataTable");
        }
    }
}
