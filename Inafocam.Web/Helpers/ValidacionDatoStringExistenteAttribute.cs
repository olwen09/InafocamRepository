//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;
//using Andamios.Core.Interfaces;

//namespace Andamios.Web.Helpers
//{
//    public class ValidacionDatoStringExistenteAttribute : ValidationAttribute
//    {
//        private readonly ICliente _cliente;
//        public ValidacionDatoStringExistenteAttribute(ICliente cliente)
//        {
//            _cliente = cliente;
//        }

//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            var result = _cliente.GetGlienteByCodigo(value.ToString());

//            if (result != null)
//            {
//                return ValidationResult.Success;
//            }

//            return new ValidationResult("Un cliente tiene este código registrado");
//        }
//    }
//}
