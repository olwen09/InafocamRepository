using Andamios.Web.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Areas.Usuarios.Components.ResetPasswordComponent
{
    public class ResetPasswordComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ResetPasswordViewModel rpvm)
        {
            if (rpvm == null)
            {
                return View("ResetPassword");
            }



            return View("ResetPassword", rpvm);
        }
    }
}