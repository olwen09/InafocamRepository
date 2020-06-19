using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Andamios.Web.Helpers
{
    public class ReturnControlladorAttribute : ResultFilterAttribute
    {
        private string controlador;
        public ReturnControlladorAttribute(string controlador)
        {
            this.controlador = controlador;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var viewResult = context.Result as ViewResult;
            if (viewResult != null)
            {
                viewResult.ViewData["controlador"] = this.controlador;
            }
        }
    }
}
