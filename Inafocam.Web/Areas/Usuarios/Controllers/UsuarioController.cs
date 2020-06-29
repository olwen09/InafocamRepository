using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inafocam.Web.Areas.Usuarios.Controllers
{
    [Area("Usuarios"),ReturnArea("Usuarios")]
    [ReturnControllador("Usuarios"),ReturnController("Usuario")]
    public class UsuarioController : Controller
    {

        private readonly IUser _user;
        private readonly IUserRole _userRole;

        public UsuarioController(IUser user, IUserRole userRole)
        {
            _user = user;
            _userRole = userRole;
        }

        public IActionResult Index()
        {

            var data = _user.GetAll;

            return View(data);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult PerfilUsuario()
        {
            return View();
        }   public IActionResult PerfilUsuarioAdmin(int id)
        {

            var data = _user.GetByID(id);

            var model = CopyPropierties.Convert<User, UserModel>(data);

            ViewBag.UserRole = new SelectList(_userRole.GetAll, "UserRoleId", "UserRoleName");

            return View(model);
        }

    }
}
