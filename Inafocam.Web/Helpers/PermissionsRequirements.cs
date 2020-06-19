using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Andamios.Web.Helpers
{
    public class ReadRequirement : IAuthorizationRequirement
    {
        public ReadRequirement(string permiso)
        {
            Permiso = permiso;
        }

        public string Permiso { get; set; }
    }
}
