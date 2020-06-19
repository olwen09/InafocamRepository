using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Andamios.Web.Areas.Clientes.Models
{
    public class ProyectoModel
    {
        public int ProyectoId { get; set; }
        /// <summary>
        /// Código del cliente (auntogenerado)
        /// </summary>
        [MaxLength(8)]
        public string Codigo { get; set; }
        /// <summary>
        /// ID de la tabla cliente
        /// </summary>
        public int ClienteId { get; set; }
        /// <summary>
        /// ID del vendedor
        /// </summary>
        [MaxLength(40)]
        public string Vendedor { get; set; }
        /// <summary>
        /// Nombre del proyecto
        /// </summary>
        [MaxLength(100)]
        public string Nombre { get; set; }
        /// <summary>
        /// Dirección del proyecto
        /// </summary>
        [MaxLength(100)]
        public string Direccion { get; set; }
        /// <summary>
        /// Nombre del contacto 
        /// </summary>
        [MaxLength(60)]
        public string NombreContacto { get; set; }
        /// <summary>
        /// Teléfono del contacto
        /// </summary>
        [MaxLength(20)]
        public string TelContacto { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [MaxLength(60)]
        public string Email { get; set; }
        /// <summary>
        /// Fecha del proyecto
        /// </summary>
        [Display(Name = "Fecha Activacion Cotizacion")]
        public DateTime? FechaActivacionCotizacion { get; set; }
        /// <summary>
        /// Descuento global con valor porcentual
        /// </summary>
        public int DescuentoGlobal { get; set; }
        /// <summary>
        /// ID del Usuario creador
        /// </summary>
        [MaxLength(40)]
        public string Creado { get; set; }
        /// <summary>
        /// Fecha de creación
        /// </summary>
        public DateTime? Creacion { get; set; }
        /// <summary>
        /// ID del usuario modificador
        /// </summary>
        public string Modificador { get; set; }
        /// <summary>
        /// Fecha de modificación
        /// </summary>
        
        public DateTime? FechaModifica { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// virtual de la tabla cliente
        /// </summary>
     
        /// <summary>
        /// coleccion virtual de la tabla conduce devolucion
        /// </summary>

    }
}
