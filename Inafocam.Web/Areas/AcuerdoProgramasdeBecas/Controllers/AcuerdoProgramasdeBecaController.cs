using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Inafocam.Web.Areas.AcuerdoProgramasdeBecas.Controllers
{
    [Area("AcuerdoProgramasdeBecas"),ReturnArea("AcuerdoProgramasdeBecas")]
    [ReturnControllador("Acuerdo Programas de Becas"),ReturnController("AcuerdoProgramasdeBeca")]
    public class AcuerdoProgramasdeBecaController : Controller
    {
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;

        public AcuerdoProgramasdeBecaController(IScholarshipProgramUniversity scholarshipProgramUniversity)
        {
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
        }

        public IActionResult Index()
        {

            var scholarshipProgramUniversity = _scholarshipProgramUniversity.ScholarshipProgramUniversity;
            return View(scholarshipProgramUniversity);
        } 
        
        public IActionResult Crear()
        {
            return View();
        }
    }
}
