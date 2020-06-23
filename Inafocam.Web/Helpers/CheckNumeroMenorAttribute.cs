using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Helpers
{
    /// <summary>
    /// Verifica que el número inicial no sea mayor que el final
    /// </summary>
    public class CheckNumeroMayorINT : ValidationAttribute
    {
        private readonly string _numeroComparacion;

        public CheckNumeroMayorINT(string numeracionFinal)
        {
            _numeroComparacion = numeracionFinal;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propiedad = validationContext.ObjectType.GetProperty(_numeroComparacion);

            if (propiedad == null || value == null)
                throw new ArgumentException("la propiedad con este nombre no exite");

            int inicial = (int) value;  // cantidad que traer la propiedad asignada

            int final = (int)propiedad.GetValue((validationContext.ObjectInstance)); // cnatidad que trae la propiedad en el parámetro

            if(inicial > final)
                return new ValidationResult("Este número no puede ser mayor que " + _numeroComparacion);

            if (inicial == final)
                return new ValidationResult("La numeración final e inicial no pueden ser iguales'");


            return ValidationResult.Success;
        }
    }

}
