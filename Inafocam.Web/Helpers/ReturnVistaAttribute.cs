using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Andamios.Web.Helpers
{
    /// <summary>
    /// Retornar el enlace a la vista
    /// </summary>
    public class ReturnVistaAttribute : ResultFilterAttribute
    {
        private string vista;
        public ReturnVistaAttribute(string vista)
        {
            this.vista = vista;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var viewResult = context.Result as ViewResult;
            if (viewResult != null)
            {
                viewResult.ViewData["vista"] = this.vista;
            }
        }
    }
}
