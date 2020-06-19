using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andamios.Web.Models
{
    public class MensajesViewModel
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }

        public MensajesViewModel()
        {
            Texto = "";
            Titulo = "";
            Tipo = "";
        }

        public MensajesViewModel(string texto, string tipo)
        {
            Texto = texto;
            Tipo = tipo;
        }

        public MensajesViewModel(string titulo, string texto, string tipo)
        {
            Texto = texto;
            Titulo = titulo;
            Tipo = tipo;
        }

        public MensajesViewModel(string titulo, string texto, string tipo, string clase)
        {
            Texto = texto;
            Titulo = titulo;
            Tipo = tipo;
            Clase = clase;
        }

    }

    public class MensajeJson
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }
        public object Objeto { get; set; }
    }
}
