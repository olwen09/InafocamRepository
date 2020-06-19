using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Helpers
{
    public class NumerodecimalMayorQueCero : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (null != value && (decimal)value > 0)
            {
                return ValidationResult.Success;
            }
          

            return new ValidationResult("El ingreso debe ser mayor que cero");
        }

    }
}
