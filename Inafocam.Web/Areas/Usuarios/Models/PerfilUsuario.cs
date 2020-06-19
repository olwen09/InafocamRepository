using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Areas.Usuarios.Models
{
    public class PerfilUsuario
    {
        public EditarUsuarioModel EditarUsuarioModel { get; set; }
        public ResetPasswordViewModel ResetPasswordViewModel { get; set; }

        public LoginViewModel LoginViewModel { get; set; }
    }
}
