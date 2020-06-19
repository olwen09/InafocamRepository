using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Andamios.Web.Helpers
{
    public static class GenerarCodigo
    {
        /// <summary>
        /// Genera un nuevo código Tipo texto
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static string GenrarCodigoNuevo(object tipo)
        {
            if (tipo == null)
            {
                return "1";
            }

            var props = tipo.GetType().GetProperties();

            string codigo = "";

            foreach (var prop in props)
            {
                if (prop.Name.ToLower().Contains("codigo"))
                {
                    codigo = (Convert.ToInt32(prop.GetValue(tipo)) + 1).ToString();
                }
            }

            return codigo;
        }

    }
}
