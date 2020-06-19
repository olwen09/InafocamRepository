using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Areas.Usuarios.Models
{
    public class UsuarioIndexList
    {
        public IEnumerable<UsuarioIndex> Index { get; set; }
        public ResetPasswordViewModel ResetPasswordViewModel { get; set; }
    }
}
