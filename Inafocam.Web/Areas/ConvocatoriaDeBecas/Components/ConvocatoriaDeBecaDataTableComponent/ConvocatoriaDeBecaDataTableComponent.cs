using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.ConvocatoriaDeBecas.Components.ConvocatoriaDeBecaDataTableComponent
{
    public class ConvocatoriaDeBecaDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ConvocatoriaDeBecasDataTable");
        }
    }
}
