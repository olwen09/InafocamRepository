using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Profesores.Components.TeacherDataTableComponent
{
    public class TeacherDataTableComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("TeacherDataTable");
        }
    }
}
