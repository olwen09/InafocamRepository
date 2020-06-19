using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Areas.Clientes.Enum;

namespace Andamios.Web.Areas.Clientes.Models
{
    public class ModuloModel
    {
        public int ModuloId { get; set; }
        [StringLength(3)]
        public string Codigo { get; set; }
        [StringLength(25)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; } = true;

        public List<Permiso> Permisos { get; set; }

        public ModuloModel()
        {
            Permisos = new List<Permiso>()
            {
                new Permiso("Create", "Creación de elementos"),
                new Permiso("Read", "Lectura de elementos"),
                new Permiso("Update", "Edición de elementos"),
                new Permiso("Admin", "Cambio de estado y/o eliminación de elementos, mas todos los demás"),

            };
        }
    }
}
