using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Andamios.Web.Helpers
{
    public static class ValidacionDocumento
    {
        public static int Validar(IFormFile file, int size,string ext, bool imgNoExiste)
        {

            if (file == null)
            {

                // validar que no haya imagen registrada
                if (imgNoExiste)
                {
                    return 1;
                }

                return 1;

            }
            bool isEmpty = file.Length == 0;
            if (isEmpty)
            {
                return 7;
            }
            bool isTooLarge = file.Length > size;
            if (isTooLarge)
            {
                return 8;
            }

            var extUpper = ext.ToUpper();

            if (extUpper == ".JPG" || extUpper == ".PNG")
            {
                return 1;
            }

            return 7;

        }

        public static async Task GuardarDocumentoAsync(IFormFile file, string rutaImg, string name)
        {
            if (file != null)
            {
                // construir documento
                var ruta = Path.Combine(Directory.GetCurrentDirectory(), rutaImg, name);

                await using var stream = System.IO.File.Create(ruta);

                await file.CopyToAsync(stream);
            }

        }
    }
}
