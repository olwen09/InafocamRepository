using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inafocam.Web.Areas.ConvocatoriaDeBecas.Controllers
{
   
    [Area("ConvocatoriaDeBecas"), ReturnArea("ConvocatoriaDeBecas")]
    [ReturnControllador("Convocatoria De Becas"), ReturnController("ConvocatoriaDeBeca")]
    public class ConvocatoriaDeBecaController : Controller
    {
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;

        public ConvocatoriaDeBecaController(IScholarshipProgramUniversity scholarshipProgramUniversity)
        {
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
        }

        public IActionResult Index()
        {
            var scholarshipProgramUniversity = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();

            return View(scholarshipProgramUniversity);
        }
    }
}
