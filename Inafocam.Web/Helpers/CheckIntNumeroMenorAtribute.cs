using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Helpers
{
    public class CheckIntNumeroMenorAtribute : ValidationAttribute
    {
        private readonly string _numeracionFinal;

        public CheckIntNumeroMenorAtribute(string numeracionFinal)
        {
            _numeracionFinal = numeracionFinal;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propiedad = validationContext.ObjectType.GetProperty(_numeracionFinal);

            if (propiedad == null)
                throw new ArgumentException("la propiedad con este nombre no exite");


            int inicial = (int)value;

            int final = (int)propiedad.GetValue(validationContext.ObjectInstance);

            //if (final < 1)
            //    return new ValidationResult("la cantidad a modificar no puede ser  0");

            if (inicial < final)
                return new ValidationResult("La Cantidad a modificar  no puede ser mayor que la cantidad actual");

            if (inicial == 0 && final == 0)
                return new ValidationResult("Las Cantidades no pueden estar igualadas a 0");


           

            return ValidationResult.Success;
        }
    }
}
