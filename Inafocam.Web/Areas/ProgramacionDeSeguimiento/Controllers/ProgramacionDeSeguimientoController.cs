using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inafocam.Web.Areas.ProgramacionDeSeguimiento.Controllers
{
    [Area("ProgramacionDeSeguimiento") , ReturnArea("ProgramacionDeSeguimiento")]
    [ReturnControllador("Programacion De Seguimientos"),ReturnController("ProgramacionDeSeguimiento")]
    public class ProgramacionDeSeguimientoController : Controller
    {
        private readonly IScholarshipProgramTracing _scholarshipProgramTracing;

        public ProgramacionDeSeguimientoController(IScholarshipProgramTracing scholarshipProgramTracing)
        {
            _scholarshipProgramTracing = scholarshipProgramTracing;
        }
    

        public IActionResult Index()
        {
            var scholarshipProgramTracing = _scholarshipProgramTracing.ScholarshipProgramTracing;

            return View(scholarshipProgramTracing);
        }
        
        public IActionResult Crear()
        {
            return View();
        }
    }
}
