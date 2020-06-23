using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Inafocam.Web.Helpers
{
    public class Configuracion
    {
        private readonly IConfiguration _config;

        public string Direccion;
        public string Web;
        public string Tel;
        public string Numero;

        public Configuracion(IConfiguration configuration)
        {

            _config = configuration;

            Direccion = _config.GetSection("andamios_dominicanos").GetSection("direccion").Value;
            Numero = _config.GetSection("andamios_dominicanos").GetSection("rnc").Value;
            Tel = _config.GetSection("andamios_dominicanos").GetSection("tel").Value;
            Web = _config.GetSection("andamios_dominicanos").GetSection("web").Value;

        }
    }
}
