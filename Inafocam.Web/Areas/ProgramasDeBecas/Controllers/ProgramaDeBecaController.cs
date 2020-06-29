using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.ProgramasDeBecas.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inafocam.Web.Areas.ProgramasDeBeca.Controllers
{
    
    [Area("ProgramasDeBecas"), ReturnArea("ProgramasDeBecas")]
    [ReturnControllador("Programa De Beca"), ReturnController("ProgramaDeBeca")]
    public class ProgramaDeBecaController : Controller
    {
        private readonly IScholarshipProgram _scholarshipProgram;
        private readonly IScholarshipLevel _scholarshipLevel;
        private readonly IStatus _status;
        private readonly IUniversity _university;
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;

        public ProgramaDeBecaController(IScholarshipProgram scholarshipProgram, 
            IScholarshipLevel scholarshipLevel,
            IStatus status,
            IUniversity university,
              IScholarshipProgramUniversity scholarshipProgramUniversity)
        {
            _scholarshipProgram = scholarshipProgram;
            _scholarshipLevel = scholarshipLevel;
            _status = status;
            _university = university;
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
          
        }

        [ReturnVista("Lista"), ReturnViewAtttribute("Index")]
        public IActionResult Index()
        {
            var ScholarshipProgramList = _scholarshipProgram.GetAll.ToList();
            return View(ScholarshipProgramList);
        }
        
        public IActionResult Crear(ScholarshipProgramModel model)
        {
            ViewBag.Nivel = new SelectList(_scholarshipLevel.ScholarshipsLevel, "ScholarshipLevelId", "ScholarshipLevelName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");

            //model.ScholarshipProgramUniversityList = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();

            return View(model);
        }

        public IActionResult Editar(int id)
        {
         var ProgramaDeBeca =   _scholarshipProgram.GetById(id);
            //var scholarshipProgramModel = CopyPropierties.Convert<ScholarshipProgram, ScholarshipProgramModel>(ProgramaDeBeca);

            var scholarshipProgramModel = new ScholarshipProgramModel
            {
                ScholarshipProgramId = ProgramaDeBeca.ScholarshipProgramId,
                ScholarshipProgramName = ProgramaDeBeca.ScholarshipProgramName,
                ScholarshipLevelId = ProgramaDeBeca.ScholarshipLevelId,
                CreationDate = ProgramaDeBeca.CreationDate,
                UpgradeDate = ProgramaDeBeca.UpgradeDate,
                StatusId = ProgramaDeBeca.StatusId,
                ScholarshipLevel = ProgramaDeBeca.ScholarshipLevel,
                Status = ProgramaDeBeca.Status,
                ScholarshipProgramUniversityList = ProgramaDeBeca.ScholarshipProgramUniversity,
            };

            ViewBag.Nivel = new SelectList(_scholarshipLevel.ScholarshipsLevel, "ScholarshipLevelId", "ScholarshipLevelName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");

            //scholarshipProgramModel.ScholarshipProgramUniversityList = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();

            return View("Crear", scholarshipProgramModel);
        }

        [HttpPost]
        public IActionResult GuardarPrograma(ScholarshipProgramModel model)
        {

            //var scholarshipProgramModel = CopyPropierties.Convert<ScholarshipProgramModel, ScholarshipProgram>(model);
            var scholarshipProgramModel = new ScholarshipProgram
            {
                ScholarshipProgramId = model.ScholarshipProgramId,
                ScholarshipProgramName = model.ScholarshipProgramName,
                ScholarshipLevelId = model.ScholarshipLevelId,
                CreationDate = model.CreationDate,
                UpgradeDate = model.UpgradeDate,
                StatusId = model.StatusId,
                ScholarshipLevel = model.ScholarshipLevel,
                Status = model.Status,
                //ScholarshipProgramUniversit = model.ScholarshipProgramUniversity
                //Status = model.Status,
                //ScholarshipProgramUniversity = model.ScholarshipProgramUniversityList,
            };


            var ScholarshipProgramUniversity = model.ScholarshipProgramUniversity;
            


            try
            {
                if (ScholarshipProgramUniversity != null)
                {
                    ScholarshipProgramUniversity.ScholarshipProgramId = model.ScholarshipProgramId;
                    _scholarshipProgramUniversity.Save(ScholarshipProgramUniversity);
                }

                _scholarshipProgram.GuardarScholarshipProgram(scholarshipProgramModel);

            }

            catch (Exception e)
            {
                ViewBag.Nivel = new SelectList(_scholarshipLevel.ScholarshipsLevel, "ScholarshipLevelId", "ScholarshipLevelName");
                ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
                ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
                return View("Crear", model);
            }



            var ScholarshipProgramList = _scholarshipProgram.GetAll.ToList();
            return View("Index",ScholarshipProgramList);
        }

        //[HttpPost]
        //public IActionResult AgregarConvocatoria(ScholarshipProgramModel model)
        //{

          

        //    return RedirectToAction("Editar", new { id =  });
        //}
    }
}
