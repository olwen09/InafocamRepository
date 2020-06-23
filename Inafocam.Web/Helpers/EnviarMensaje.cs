using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Andamios.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace Inafocam.Web.Helpers
{
    public static class EnviarMensaje
    {
        // TODO: VOLVERLO UN PAQUETE PARA REUTILIZARLO
        /// <summary>
        /// Enviar mensaje a la vista.
        /// TIPO: color del mensaje |
        /// FUNC: la operación que se ejecuta
        /// (0=ID no encontrado, 1=guardar, 2=generar, 3=actualizar, 4=cambiar estado, 5=eliminar, 6=secuencia existente, 7=archivo inválido, 8=archivo muy grande, 9 = No ha seleccionado productos,
        /// 10 = No se pudo cambiar el estatus, 11 = campo vacío)
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="func"></param>
        ///<returns>mensaje</returns>
        public static void Enviar(this ITempDataDictionary tempData, string tipo, int func)
        {
            MensajesViewModel mensaje = new MensajesViewModel("", "", "");
            tempData.Clear();
            if (func == 1)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Hubo un error";
                    mensaje.Texto = "No se pudo guardar la información";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Información guardada";
                    mensaje.Texto = "La información se pudo guardar satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 2)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Hubo un error";
                    mensaje.Texto = "No se pudo generar la información";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Información generada";
                    mensaje.Texto = "La información se pudo generar satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 3)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Hubo un error";
                    mensaje.Texto = "No se pudo actualizar la información";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Actualización completa";
                    mensaje.Texto = "La información se pudo actualizar satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 4)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Hubo un error";
                    mensaje.Texto = "No se pudo cambiar el estado";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Actualización del estado";
                    mensaje.Texto = "El estado se pudo actualizar satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 5)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Hubo un error";
                    mensaje.Texto = "No se pudo eliminar la información";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Información eliminada";
                    mensaje.Texto = "La información fue eliminada permanentemente!";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 6)
            {
                if (tipo == "red")
                {
                    mensaje.Titulo = "Comprobantes existentes";
                    mensaje.Texto = "Ya existen comprobantes con esa secuencia";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Información eliminada";
                    mensaje.Texto = "La información fue eliminada permanentemente!";
                    mensaje.Tipo = tipo;
                }
            }
            // Archivo inválido
            else if (func == 7)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Archivo Inválido";
                    mensaje.Texto = "verifique si cargó un archivo o si este es de la extensión requerida (ej: si es imagen:.jpg, excel: .xls ó documento:s .pdf)";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Archivo cargado correctamente";
                    mensaje.Texto = "El archivo se guardó en el servidor satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            // Archivo muy grande
            else if (func == 8)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Archivo muy grande";
                    mensaje.Texto = "Debe cargar in documento que tenga un tamaño permitido (3 MB o menos)";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Archivo cargado correctamente";
                    mensaje.Texto = "El archivo se guardó en el servidor satisfactoriamente";
                    mensaje.Tipo = tipo;
                }
            }
            // Seleccionar producto
            else if (func == 9)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Piezas sin seleccionar";
                    mensaje.Texto = "Debe seleccionar una pieza por lo menos";
                    mensaje.Tipo = tipo;
                }

            }
            // Cambiar estatus
            else if (func == 10)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "No se pudo cambiar el estado";
                    mensaje.Texto = "Hubo un error al intentar cambiar el estado, intentelo luego, o contacte al administrador del sistema";
                    mensaje.Tipo = tipo;
                }

            }
            // Cambiar estatus
            else if (func == 11)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Campo vacío";
                    mensaje.Texto = "verifique que esté completando todos los campos de texto";
                    mensaje.Tipo = tipo;
                }

            }
            else if (func == 12)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Contraseña Incorrecta";
                    mensaje.Texto = "Asegúrese de completar todos los campos";
                    mensaje.Tipo = tipo;
                }

                if (tipo == "green")
                {
                    mensaje.Titulo = "Contraseña correcta";
                    mensaje.Texto = "La contraseña fue cambiada correctamente";
                    mensaje.Tipo = tipo;
                }
            }
            else if (func == 13)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Los contraseñas no coindicen";
                    mensaje.Texto = "Asegurese de que las contraseñas coincidan";
                    mensaje.Tipo = tipo;
                }

            }
            else if (func == 14)
            {
                if (tipo == "red")
                {

                    mensaje.Titulo = "Usuario Inactivo";
                    mensaje.Texto = "Contacte Al Administrador Del Sistema";
                    mensaje.Tipo = tipo;
                }

            }
            else
            {
                mensaje.Titulo = "ID Inválido";
                mensaje.Texto = "el número de ID suministrado no existe";
                mensaje.Tipo = "red";
            }

            TempDataExtensions.Put<MensajesViewModel>(tempData, "mensaje", mensaje);

            // return mensaje;

        }

        public static void Enviar(this ITempDataDictionary tempData, string tipo, string texto)
        {
            MensajesViewModel mensaje = new MensajesViewModel("", "", "");

            mensaje.Titulo = "Mensaje";
            mensaje.Texto = texto;
            mensaje.Tipo = tipo;

            TempDataExtensions.Put<MensajesViewModel>(tempData, "mensaje", mensaje);

        }

        public static void Enviar(this ITempDataDictionary tempData, string titulo, string tipo, string texto)
        {
            MensajesViewModel mensaje = new MensajesViewModel();

            mensaje.Titulo = titulo;
            mensaje.Texto = texto;
            mensaje.Tipo = tipo;

            TempDataExtensions.Put<MensajesViewModel>(tempData, "mensaje", mensaje);

        }

        public static void AccesoDenegado(this ITempDataDictionary tempData, string titulo, string texto, string tipo)
        {
            MensajesViewModel accessoDenegado = new MensajesViewModel(titulo, texto, tipo);
            TempDataExtensions.Put<MensajesViewModel>(tempData, "accessoDenegado", accessoDenegado);
        }

        public static JsonResult MensajeJson(string titulo, string texto, string tipo, bool estado = true)
        {
            var data = new MensajeJson { Titulo = titulo, Texto = texto, Tipo = tipo, Estado = estado };
            var json = JsonConvert.SerializeObject(data);

            return new JsonResult(json);
        }

        public static JsonResult MensajeJson(string tipo)
        {

            if (tipo == "green")
            {

                var success = new MensajeJson
                {
                    Titulo = "Información generada",
                    Texto = "La información se pudo generar satisfactoriamente",
                    Tipo = tipo
                };
                var jsonSuccess = JsonConvert.SerializeObject(success);
                return new JsonResult(jsonSuccess);

            }

            var data = new MensajeJson
            {
                Titulo = "Hubo un error",
                Texto = "No se pudo generar la información",
                Tipo = tipo
            };
            var json = JsonConvert.SerializeObject(data);

            return new JsonResult(json);


        }

        public static JsonResult MensajeJson(string titulo, string texto, string tipo, object obj, bool estado = true)
        {
            var data = new MensajeJson { Titulo = titulo, Texto = texto, Tipo = tipo, Objeto = obj, Estado = estado };

            var json = JsonConvert.SerializeObject(data);

            return new JsonResult(json);
        }
    }
}