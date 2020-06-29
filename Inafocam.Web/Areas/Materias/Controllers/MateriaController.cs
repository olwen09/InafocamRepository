using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.Materias.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.Materias.Controllers
{
    [Area("Materias"),ReturnArea("Materias")]
    [ReturnControllador("Materias"),ReturnController("Materia")]
    public class MateriaController : Controller
    {

        private readonly ISubjectMatter _subjectMatter;
        private readonly IStatus _status;

        public MateriaController(ISubjectMatter subjectMatter,IStatus status)
        {
            _subjectMatter = subjectMatter;
            _status = status;
        }

        public IActionResult Index()
        {

            var data = _subjectMatter.GetAll;

            return View(data);
        }

        public IActionResult Crear(SubjectMatterModel model)
        {
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            return View(model);
        }

        public IActionResult Editar(int id)
        {

            var data = _subjectMatter.GetById(id);

            var model = CopyPropierties.Convert<SubjectMatter, SubjectMatterModel>(data);

            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            return View("Crear", model);
        }

        public IActionResult Guardar(SubjectMatterModel model)
        {

            try
            {
                var data = CopyPropierties.Convert<SubjectMatterModel, SubjectMatter>(model);

                _subjectMatter.Save(data);
            }
            catch(Exception e)
            {

                return View("Index", _subjectMatter.GetAll);
            }

            return View("Index", _subjectMatter.GetAll);
        }

    }
}
