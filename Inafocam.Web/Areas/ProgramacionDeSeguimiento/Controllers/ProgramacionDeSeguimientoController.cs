using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.ProgramacionDeSeguimiento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.ProgramacionDeSeguimiento.Controllers
{
    [Area("ProgramacionDeSeguimiento") , ReturnArea("ProgramacionDeSeguimiento")]
    [ReturnControllador("Programacion De Seguimientos"),ReturnController("ProgramacionDeSeguimiento")]
    public class ProgramacionDeSeguimientoController : Controller
    {
        private readonly IScholarshipProgramTracing _scholarshipProgramTracing;
        private readonly IUniversity _university;
        private readonly IScholarshipProgramUniversity _scholarshipProgramUniversity;
        private readonly IScholarshipProgram _scholarshipProgram;
        private readonly IAgent  _agent;
        private readonly IAgentType  _agentType;
        private readonly IStatus _status;

        public ProgramacionDeSeguimientoController(IScholarshipProgramTracing scholarshipProgramTracing,
            IUniversity university,
            IScholarshipProgramUniversity scholarshipProgramUniversity,
            IAgent agent,
            IScholarshipProgram scholarshipProgram,
            IAgentType agentType
            , IStatus status)
        {
            _scholarshipProgramTracing = scholarshipProgramTracing;
            _university = university;
            _scholarshipProgramUniversity = scholarshipProgramUniversity;
            _agent = agent;
            _scholarshipProgram = scholarshipProgram;
            _agentType = agentType;
            _status = status;
        }
    

        public IActionResult Index()
        {
            var scholarshipProgramTracing = _scholarshipProgramTracing.ScholarshipProgramTracing;

            var prueba = _agent.GetCoordinators.ToList();
            var prueba2 = _agent.GetTechnicals.ToList();
            var prueba3 = _agent.GetCoordinators.Where(x => x.AgentTypeId == 1).Select(x => x.Contact.ContactName);

            return View(scholarshipProgramTracing);
        }
        
        public IActionResult Crear()
        {

            var prueba3 = _agent.GetCoordinators.Where(x => x.AgentTypeId == 1).Select(x => x.Contact.ContactName).ToString();
            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");
            ViewBag.ScholarshipProgram = new SelectList(_scholarshipProgram.GetAll, "ScholarshipProgramId", "ScholarshipProgramName");
            //ViewBag.Coordinator = new SelectList(_agent.GetCoordinators, "AgentTypeId", );
            //ViewBag.Technical = new SelectList(_agentType.GetTechnicals, "AgentTypeId", "AgentTypeName");
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            //ViewBag.ScholarshipProgram = new SelectList(_scholarshipProgram, "ScholarshipProgramId", "ScholarshipProgramName");
            //ViewBag.Agent = new SelectList(_agent.Agents, "AgentId", );
            //ViewBag.Agent = new SelectList(_agent.Agents, "", "UniversityName");
            return View();
        }

        public IActionResult Editar(int id)
        {
            var scholarshipProgramTracing = _scholarshipProgramTracing.GetById(id);

            //var scholarshipProgramTracingModel = new ScholarshipProgramTracingModel
            //{
            //    ScholarshipProgramTracingId = scholarshipProgramTracing.ScholarshipProgramTracingId,
            //    UniversityId = scholarshipProgramTracing.UniversityId,
            //    ScholarshipProgramUniversityId = scholarshipProgramTracing.ScholarshipProgramUniversityId,
            //    CoordinatorId = scholarshipProgramTracing.CoordinatorId,
            //    TechnicalId = scholarshipProgramTracing.TechnicalId,
            //    StartDate = scholarshipProgramTracing.StartDate,
            //    EndDate = scholarshipProgramTracing.EndDate,
            //    CreationUserId = scholarshipProgramTracing.CreationUserId,
            //    UpgradeUserId = scholarshipProgramTracing.UpgradeUserId,
            //    CreationDate = scholarshipProgramTracing.CreationDate,
            //    UpgradeDate = scholarshipProgramTracing.UpgradeDate,
            //    StatusId = scholarshipProgramTracing.StatusId,
            //    Coordinator = scholarshipProgramTracing.Coordinator,
            //    CreationUser = scholarshipProgramTracing.CreationUser,
            //    ScholarshipProgramUniversity = scholarshipProgramTracing.ScholarshipProgramUniversity,
            //    Status = scholarshipProgramTracing.Status,
            //    Technical = scholarshipProgramTracing.Technical,
            //    ScholarshipProgramTracingAgreement = scholarshipProgramTracing.ScholarshipProgramTracingAgreement,
            //    ScholarshipProgramTracingCourse = scholarshipProgramTracing.ScholarshipProgramTracingCourse,
            //    ScholarshipProgramTracingCourseFile = scholarshipProgramTracing.ScholarshipProgramTracingCourseFile,
            //    ScholarshipProgramTracingPractice = scholarshipProgramTracing.ScholarshipProgramTracingPractice,
            //    ScholarshipProgramTracingPracticePlanning = scholarshipProgramTracing.ScholarshipProgramTracingPracticePlanning,
            //    ScholarshipProgramTracingQualitySystem = scholarshipProgramTracing.ScholarshipProgramTracingQualitySystem,
            //    ScholarshipProgramTracingStudentPractice = scholarshipProgramTracing.ScholarshipProgramTracingStudentPractice,
            //    ScholarshipProgramTracingStudentSupport = scholarshipProgramTracing.ScholarshipProgramTracingStudentSupport,
            //    TracingStudyPlanDevelopment = scholarshipProgramTracing.TracingStudyPlanDevelopment
            //};

            var scholarshipProgramTracingModel = CopyPropierties.Convert<ScholarshipProgramTracing, ScholarshipProgramTracingModel>(scholarshipProgramTracing);

            ViewBag.University = new SelectList(_university.Universities, "UniversityId", "UniversityName");

            return View("Crear", scholarshipProgramTracingModel);
        }
    }
}
