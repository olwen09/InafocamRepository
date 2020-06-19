using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Helpers
{
    public class NumeroMayorQueCeroAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {


            if (null != value && (int)value > 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Este campo no puede ser 0");

        }




    }
}
