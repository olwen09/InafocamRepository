using Inafocam.core.Repository;
using Inafocam.Web.Areas.ProgramasDeBecas.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.ProgramasDeBecas.Components.ConvocatoriasComponent
{

    public class AgregarConvocatoriasComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ScholarshipProgramUniversityModel model)
        {
            return View();
        }
    }
}
