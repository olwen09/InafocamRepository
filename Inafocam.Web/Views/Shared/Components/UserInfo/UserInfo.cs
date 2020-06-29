using Inafocam.core.Modelos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.SharedComponents
{

    public class UserInfo : ViewComponent
    {


        //private readonly UserManager<User> _userManager;

        //public UserInfo(UserManager<User> userManager)
        //{
        //    _userManager = userManager;
        //}

        public IViewComponentResult Invoke()
        {
            //var id = _userManager.GetUserId(UserClaimsPrincipal);

            //var user = _userManager.FindByIdAsync(id).Result;

            return View("UserInfo");
        }
    }
}
