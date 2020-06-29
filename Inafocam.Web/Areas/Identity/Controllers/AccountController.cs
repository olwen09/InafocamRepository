using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Areas.Usuarios.Models;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Inafocam.Web.Areas.Identity.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUser _user;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;



        public AccountController(IUser user, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _user = user;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [ReturnVista("Login")]
        [AllowAnonymous]
        //[Authorize(Policy = Constante.UsuarioCanRead)]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = Constante.UsuarioCanRead)]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {

            if (!ModelState.IsValid) return View(model);
            /////
            var usuario = _user.GetAll.FirstOrDefault(x => x.UserLogin == model.UserLogin);
            //Where(n => n.UserName == model.UserName).Single();
            if (usuario != null)
            {
                //var estado = _usuario.Usuarios.Where(n => n.UserName == model.UserName).Select(x => x.Estado).AsQueryable().Single();

           
                    var result = await _signInManager.PasswordSignInAsync(model.UserLogin,
                 model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {




                        // _logger.LogInformation("User logged in.");

                        return RedirectToAction("Home", "Home", new { area = "" });




                    }

                    //if (result.RequiresTwoFactor)
                    //{
                    //    return RedirectToPage("./LoginWith2fa", new
                    //    {
                    //        ReturnUrl = returnUrl,
                    //        RememberMe = model.RememberMe
                    //    });
                    //}

                    //if (result.IsLockedOut)
                    //{
                    //    // _logger.LogWarning("User account locked out.");
                    //    return RedirectToPage("./Lockout");
                    //}
                    else
                    {
                        //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        //TempData.Enviar("error", "green", "olwen");
                        TempData.Enviar("Datos incorrectos", "error", "La Contraseña o el usuario no coinciden");
                        //EnviarMensaje.Enviar(TempData, "red", 13);
                        return View(model);
                    }
                }

         else
            {
                //var value = _localizer["Este usuario no existe"]. == null ? "Este usuario no existe" : "This user does not exist";
                TempData.Enviar("Este usuario no existe", "error", "Verifique el nombre del usuario o contacte al administrador");

                return View(model);
            }

            return View(model);



        }

    }
}
