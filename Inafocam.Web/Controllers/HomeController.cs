using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Andamios.Web.Areas.Usuarios.Models;
using Andamios.Web.Helpers;
using Andamios.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Andamios.Web.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
  

        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        
        }

        [Layout ("_layout")]

        public async Task<IActionResult> Index () {
            //var roles = _roleManager.Roles.ToList();

            var claims = User.Claims.Select (c =>
                new {
                    c.Type,
                        c.Value
                }).ToList ();

            //foreach (var role in roles.ToList())
            //     {
            //         foreach(var modulo in _modulo.GetAll.ToList())
            //         {
            //             await _roleManager.RemoveClaimAsync(role, new Claim(Constante.Module, modulo.Nombre));

            //foreach (var role in roles.ToList())
            //     {
            //         foreach(var modulo in _modulo.GetAll.ToList())
            //         {
            //             await _roleManager.RemoveClaimAsync(role, new Claim(Constante.Module, modulo.Nombre));

            //         }


            //     }

            //     claims = User.Claims.Select(c =>
            //         new
            //         {
            //             c.Type,
            //             c.Value
            //         }).ToList();

            //var userCulture = "es";

            //Response.Cookies.Append(
            //   CookieRequestCultureProvider.DefaultCookieName,
            //   CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(userCulture))
            //   //new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            //   );




            //return View(nameof(StartPage));
            return View("Home");
        }

        public IActionResult Lock () {
            return View ();
        }

        [Layout ("_layout")]
        public IActionResult Home () {

            return View ();
        }

        public IActionResult StartPage () {

            return View ();
        }

        public IActionResult Instrucciones () {
            return View ();
        }

        public IActionResult Soporte () {
            return View ();
        }

        [AllowAnonymous]
        public void ClearTempData () {
            TempData.Clear ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public void GetParametros(string culture, string returnUrl)
        {
            SetLanguage(culture, returnUrl);
        }

        public IActionResult SetLanguage(string culture, string returnUrl)
        {

           
            Response.Cookies.Append(
               CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture))
               //new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
               );

            return LocalRedirect(returnUrl);
            //return View(nameof(Index));

        }
    }
}