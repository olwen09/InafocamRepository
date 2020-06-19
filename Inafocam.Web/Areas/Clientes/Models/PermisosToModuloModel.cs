using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Andamios.Web.Areas.Clientes.Models
{
    public class Permiso
    {

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Permiso(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = false;
        }

        public Permiso()
        {
            
        }
    }

    public class PermisosToModuloModel
    {
        public List<Permiso> Permisos { get; set; }

        public PermisosToModuloModel()
        {
            
        }
    }
}
