using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.AcuerdoProgramasdeBecas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.AcuerdoProgramasdeBecas.Controllers
{
    [Area("AcuerdoProgramasdeBecas"),ReturnArea("AcuerdoProgramasdeBecas")]
    [ReturnControllador("Acuerdo Programas de Becas"),ReturnController("AcuerdoProgramasdeBeca")]
    public class AcuerdoProgramasdeBecaController : Controller
    {
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;
        private readonly IAgreementType _agreementType;
        private readonly IStatus _status;
        //private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;

        public AcuerdoProgramasdeBecaController(IScholarshipProgramUniversity scholarshipProgramUniversity,
            IAgreementType agreementType, IStatus status)
        {
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
            _agreementType = agreementType;
            _status = status;
        }

        public IActionResult Index()
        {

            var scholarshipProgramUniversity = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();
        
            return View(scholarshipProgramUniversity);
        } 
        
        public IActionResult Crear()
        {

            //var prueba = _agreementType.GetAll.ToList();
            ViewBag.AgreementTypes = new SelectList(_agreementType.GetAll, "AgreementTypeId", "AgreementTypeName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            return View();
        }


        public IActionResult Editar(int id)
        {
            var data = _scholarshipProgramUniversity.GetById(id);

            var acuerdoProgramasdeBecaModel = CopyPropierties.Convert<ScholarshipProgramUniversity, AcuerdoProgramasdeBecaModel>(data);
            ViewBag.AgreementTypes = new SelectList(_agreementType.GetAll, "AgreementTypeId", "AgreementTypeName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");

            return View("Crear",acuerdoProgramasdeBecaModel);
        }

        public IActionResult Guardar(AcuerdoProgramasdeBecaModel model)
        {


            var scholarshipProgramUniversity = _scholarshipProgramUniversity.ScholarshipProgramUniversity.ToList();
            try
            {
                var data = CopyPropierties.Convert<AcuerdoProgramasdeBecaModel, ScholarshipProgramUniversity>(model);
                _scholarshipProgramUniversity.Save(data);
            }

            catch(Exception e)
            {
               

                return View("Index",scholarshipProgramUniversity);
            }

          

            return View("Index", scholarshipProgramUniversity);
        }
    }
}
