using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Inafocam.Web.Areas.ConvocatoriaDeBecas.Models;

namespace Inafocam.Web.Areas.ConvocatoriaDeBecas.Controllers
{
   
    [Area("ConvocatoriaDeBecas"), ReturnArea("ConvocatoriaDeBecas")]
    [ReturnControllador("Convocatoria De Becas"), ReturnController("ConvocatoriaDeBeca")]
    public class ConvocatoriaDeBecaController : Controller
    {
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;
        private readonly IUniversity _university;
        private readonly IScholarshipLevel _scholarshipLevel;
        private readonly IScholarshipProgram _scholarshipProgram;
        private readonly IStatus _status;

        public ConvocatoriaDeBecaController(IScholarshipProgramUniversity scholarshipProgramUniversity,
            IUniversity university, IScholarshipLevel scholarshipLevel, IScholarshipProgram scholarshipProgram, IStatus status)
        {
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
            _university = university;
            _scholarshipLevel = scholarshipLevel;
            _scholarshipProgram = scholarshipProgram;
            _status = status;
        }

        public IActionResult Index()
        {
            var scholarshipProgramUniversity = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();

            return View(scholarshipProgramUniversity);
        }

        public IActionResult Editar(int id)
        {
            var scholarshipProgramUniversity = _scholarshipProgramUniversity.GetById(id);
            var scholarshipProgramUniversityModel = CopyPropierties.Convert<ScholarshipProgramUniversity, ScholarshipProgramUniversityModel>(scholarshipProgramUniversity);


            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
            ViewBag.Nivel = new SelectList(_scholarshipLevel.ScholarshipsLevel, "ScholarshipLevelId", "ScholarshipLevelName");
            ViewBag.scholarshipProgram = new SelectList(_scholarshipProgram.GetAll, "ScholarshipProgramId", "ScholarshipProgramName");
            ViewBag.scholarshipProgram = new SelectList(_status.Status, "StatusId", "StatusName");
            return View("Crear", scholarshipProgramUniversityModel);
        }

        public IActionResult Crear(ScholarshipProgramUniversity model)
        {
            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
            ViewBag.Nivel = new SelectList(_scholarshipLevel.ScholarshipsLevel, "ScholarshipLevelId", "ScholarshipLevelName");
            ViewBag.scholarshipProgram = new SelectList(_scholarshipProgram.GetAll, "ScholarshipProgramId", "ScholarshipProgramName");
            ViewBag.scholarshipProgram = new SelectList(_status.Status, "StatusId", "StatusName");

            return View();
        }


    }
}
