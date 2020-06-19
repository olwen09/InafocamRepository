using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using FluentValidation;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace Andamios.Web.Areas.Clientes.Models
{
    public class ClienteModel : IValidatableObject
    {

        /// <summary>
        /// ID
        /// </summary>
        public int ClienteId { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "solo se permiten 50 carácteres en este campo!")]
        public string Nombre { get; set; }
        /// <summary>
        /// Código del cliente (auntogenerado)
        /// </summary>
        //[Required(ErrorMessage = "El código Es requerido")]
        [MaxLength(8, ErrorMessage = "solo se permiten 7 carácteres en este campo!")]
        public string Codigo { get; set; }
        /// <summary>
        /// RNC del cliente 
        /// </summary>
        [Required(ErrorMessage = "El campo [ RNC o ID]  es obligatorio")]
        [MaxLength(11, ErrorMessage = "El campo {0} solo puede tener un máximo de {1} caracteres")]
        [MinLength(9, ErrorMessage = "El campo {0} solo puede tener un máximo de {1} caracteres")]
        public string Rnc { get; set; }
        /// <summary>
        /// Tipo de cliente
        /// </summary>
        public int TipoClienteId { get; set; }
        /// <summary>
        /// virtual a la tabla cliente
        /// </summary>
  
        /// <summary>
        /// Tipo de comprobante
        /// </summary>
        [Range(0, 11, ErrorMessage = "el {0} debe ser mínimo de {1} y un máximo de {2}")]
        public int? TipoComprobanteId { get; set; }
        /// <summary>
        /// virtual de la tabla Tipo comprobante
        /// </summary>
     
        /// <summary>
        /// Descripcion de la entidad Cliente
        /// </summary>
        [MaxLength(160, ErrorMessage = "solo se permiten 100 carácteres en este campo!")]
        [Required(ErrorMessage = "La descripcion es requerida")]
        public string Descripcion { get; set; }
        /// <summary>
        /// ID de la tabla municipio
        /// </summary>
        public int? MunicipioId { get; set; }
        /// <summary>
        /// Virtual a la tabla municipio
        /// </summary>
       
        /// <summary>
        /// Dirección del cliente
        /// </summary>
        [Required(ErrorMessage = "La dirección es requerida")]
        [MaxLength(100, ErrorMessage = "solo se permiten 100 carácteres en este campo!")]
        public string Direccion { get; set; }
        /// <summary>
        /// ID de la tabla provincia
        /// </summary>
        public int? ProvinciaId { get; set; }
        /// <summary>
        /// virutal a la tabla provincia
        /// </summary>
       
        /// <summary>
        /// Telefono 1 del cliente
        /// </summary>
        [MaxLength(16, ErrorMessage = "solo se permiten 10 carácteres en este campo!")]
        public string Telefono1 { get; set; }
        /// <summary>
        /// Telefono 2 del cliente
        /// </summary>
        [MaxLength(16, ErrorMessage = "solo se permiten 10 carácteres en este campo!")]
        public string Telefono2 { get; set; }
        /// <summary>
        /// Fax del cliente
        /// </summary>
        [MaxLength(16)]
        public string Fax { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "Este correo electronico no es válido, ingrese otro nuevo")]
        [MaxLength(50, ErrorMessage = "solo se permiten 50 carácteres en este campo!")]
        public string Email { get; set; }
        /// <summary>
        /// Registro del ID del usuario/empleado gestor de cobros (dropdown list)
        /// </summary>
        [MaxLength(40)]
        public string GestorCobros { get; set; }
        /// <summary>
        /// ID del usuario vendedor (dropdown list)
        /// </summary>
        [MaxLength(40)]
        public string Vendedor { get; set; }
        /// <summary>
        /// ID del Usuario creador
        /// </summary>
        [MaxLength(40)]
        public string Creador { get; set; }
        /// <summary>
        /// ID del Usuario modificador
        /// </summary>
        [MaxLength(40)]
        public string Modificador { get; set; }
        /// <summary>
        /// FEcha de creacion
        /// </summary>
        public DateTime? Creacion { get; set; }
        /// <summary>
        /// Fecha modificación
        /// </summary>
        public DateTime? Modificacion { get; set; }
        /// <summary>
        /// ID del usuario Gerente (dropdown list)
        /// </summary>
        [MaxLength(40)]
        public string Gerente { get; set; }
        /// <summary>
        /// Nombre del contacto en caso de ser una empresa
        /// </summary>
       
        [MaxLength(100, ErrorMessage = "El nombre del contacto debe tener como máximo 100 carateres")]
        public string ContactoNombre { get; set; }
        /// <summary>
        /// Teléfono principal de la persona de contacto
        /// </summary>
        [MaxLength(16, ErrorMessage = "solo se permiten 10 carácteres en este campo!")]

        public string ContactoTelefono1 { get; set; }
        /// <summary>
        /// Teléfono secundario de la persona de contacto 
        /// </summary>
        [MaxLength(16, ErrorMessage = "solo se permiten 10 carácteres en este campo!")]
        public string ContactoTelefono2 { get; set; }
        
    

        /// <summary>
        /// ID de la tabla estatus
        /// </summary>
        public int EstatusId { get; set; } = 1;
        /// <summary>
        /// virtual de la tabla de Tipo Estatus
        /// </summary>


        //==================================================================================
        //==================================================================================
        //==================================================================================
        //==================================================================================
        //==================================================================================
        //==================================================================================

        
        //validaciones globales
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            //validación de numeros telefónicos del cliente
            // REGLA: Al menos 1 debe ser completo
            bool someNumber = false;

            List<string> contactos = new List<string>();
             contactos.Add(Telefono1);
             contactos.Add(Telefono2);
             contactos.Add(ContactoTelefono1);
             contactos.Add(ContactoTelefono2);

             foreach (var item in contactos)
             {
                 if (!string.IsNullOrEmpty(item))
                 {
                     someNumber = true;
                     break;
                 }
             }

             if (!someNumber)
             {
                yield return new ValidationResult("Debe de escribir por lo menos un número de contacto");
             }

        }



    }
}
