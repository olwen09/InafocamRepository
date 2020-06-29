using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.Usuarios.Components.UsuarioDataTableComponent
{
    public class UsuarioDataTableComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("UsuarioDataTable");
        }
    }
}
