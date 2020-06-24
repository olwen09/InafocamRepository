using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Representantes.Components.AgentTypeDataTableComponent
{
    public class AgentTypeDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AgentTypeDataTable");
        }
    }
}
