using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Andamios.Web.Areas.Clientes.Models;
using Microsoft.AspNetCore.Identity;

namespace Andamios.Web.Areas.Usuarios.Models
{
    public class RoleModel : IdentityRole
    {
        public string Descripcion { get; set; }
        public string ReturnUrl { get; set; }


        public List<ModuloModel> Modulos { get; set; }


        public RoleModel()
        {

        }

        public RoleModel(string returnUrl)
        {
            ReturnUrl = returnUrl;
        }

    }
}