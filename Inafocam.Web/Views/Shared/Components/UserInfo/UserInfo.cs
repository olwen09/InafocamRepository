using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Andamios.Web.Views.Shared.Components.SharedComponents
{

    public class UserInfo : ViewComponent
    {
 

   
        public IViewComponentResult Invoke()
        {
         

            return View("UserInfo");
        }
    }
}
