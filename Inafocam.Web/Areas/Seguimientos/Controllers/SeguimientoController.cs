using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.Seguimientos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.Seguimientos.Controllers
{

    [Area("Seguimientos"),ReturnArea("Seguimientos")]
    [ReturnControllador("Seguimiento"),ReturnController("Seguimiento")]
    public class SeguimientoController : Controller
    {
        private readonly IScholarshipProgramTracing _scholarshipProgramTracing;
        private readonly IUniversity _university;
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;
        private readonly IScholarshipProgram _scholarshipProgram;
        private readonly IAgent _agent;
        private readonly IAgentType _agentType;
        private readonly IStatus _status;

        public SeguimientoController(IScholarshipProgramTracing scholarshipProgramTracing,
            IUniversity university, IScholarshipProgramUniversity scholarshipProgramUniversity,IAgent agent,
            IAgentType agentType, IStatus status, IScholarshipProgram scholarshipProgram)
        {
            _scholarshipProgramTracing = scholarshipProgramTracing;
            _university = university;
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
            _agent = agent;
            _agentType = agentType;
            _status = status;
            _scholarshipProgram = scholarshipProgram;
        }

        public IActionResult Index()
        {
            var data = _scholarshipProgramTracing.ScholarshipProgramTracing;
            return View(data);
        }


        public IActionResult Crear(ScholarshipProgramTracingModel model)
        {


            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
            //ViewBag.ScholarshipProgramUniversity = new SelectList(_scholarshipProgramUniversity.ScholarshipProgramUniversity, "ScholarshipProgramUniversityId", );
            //ViewBag.ScholarshipProgram = new SelectList(_scholarshipProgramUniversity.ScholarshipProgramUniversity,);
            //ViewBag.Coordinator = new SelectList(_agentType.GetCoordinators, "AgentTypeId", "AgentTypeName");
            //ViewBag.Technical = new SelectList(_agentType.GetTechnicals, "AgentTypeId", "AgentTypeName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var data =  _scholarshipProgramTracing.GetById(id);

            var model = CopyPropierties.Convert<ScholarshipProgramTracing, ScholarshipProgramTracingModel>(data);


            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
            //ViewBag.ScholarshipProgramUniversity = new SelectList(_scholarshipProgramUniversity.ScholarshipProgramUniversity, "ScholarshipProgramUniversityId", );
            //ViewBag.ScholarshipProgram = new SelectList(_scholarshipProgramUniversity.ScholarshipProgramUniversity,);
            //ViewBag.Coordinator = new SelectList(_agentType.GetCoordinators, "AgentTypeId", "AgentTypeName");
            //ViewBag.Technical = new SelectList(_agentType.GetTechnicals, "AgentTypeId", "AgentTypeName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            return View("Crear",model);
        }
    }
}
