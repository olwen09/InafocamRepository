using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Andamios.Web.Helpers
{
    /// <summary>
    /// Retornar el nombre de la vista en texto
    /// </summary>
    public class ReturnViewAtttribute : ResultFilterAttribute
    {
        private string view;
        public ReturnViewAtttribute(string controlador)
        {
            this.view = controlador;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var viewResult = context.Result as ViewResult;
            if (viewResult != null)
            {
                viewResult.ViewData["view"] = this.view;
            }
        }
    }
}
