using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.Representantes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.Representantes.Controllers
{

    [Area("Representantes"), ReturnArea("Representantes")]
    [ReturnControllador("Tipo de Representante"), ReturnController("AgentType")]
    public class AgentTypeController : Controller
    {
        private readonly IAgentType _agentType;
        private readonly IStatus _status;

        public AgentTypeController(IAgentType agentType,IStatus status)
        {
            _agentType = agentType;
            _status = status;
        }
        public IActionResult Index()
        {
            var data = _agentType.GetAll;

            return View(data);
        }

        public IActionResult Crear(AgentTypeModel model)
        {
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");

            return View(model);
        }

        public IActionResult Editar(int id)
        {

            var data = _agentType.GetById(id);

            var model = CopyPropierties.Convert<AgentType, AgentTypeModel>(data);
            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");

            return View("Crear", model);
        }


        public IActionResult Guardar(AgentTypeModel model)
        {
            try
            {
                var data = CopyPropierties.Convert<AgentTypeModel, AgentType>(model);

                _agentType.Save(data);
            }
            catch (Exception e){

                return View("Index", _agentType.GetAll);

            }

            return View("Index", _agentType.GetAll);
        }
    }
}
