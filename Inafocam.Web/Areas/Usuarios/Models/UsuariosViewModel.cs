using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Andamios.Web.Areas.Usuarios.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Es necesario el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario el Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Es necesario el Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Es necesario suministrar una contraseña válida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La contraseñas suministradas no coinciden, vuelva a intentarlo.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Es necesario un usuario")]
        public string UserName { get; set; }

        public string Role { get; set; }

        public string Imagen { get; set; }
    }

    public class EditarUsuarioModel
    {
     
        public string Id { get; set; }

        [Required(ErrorMessage = "Es necesario el nombre")]

        public string Nombre { get; set; }

 
        [Required(ErrorMessage = "Es necesario el Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Es necesario el Correo electrónico")]
      
        public string Email { get; set; }

     

        [Required(ErrorMessage = "Es necesario un usuario")]
        //[MinLength(9, ErrorMessage = "El campo {0} solo puede tener un minimo de [1} caracteres")]
        public string UserName { get; set; }

    
        public string Role { get; set; }

        public string Imagen { get; set; }
        public string ReturnUrl { get; set; }

        public bool Estado { get; set; }

        public string ImageUrl { get; set; }

        public RoleModel Roles { get; set; }




    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Es necesario su nombre de usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Es necesaria la contraseña")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public bool Estado { get; set; }
    }

    public class ResetPasswordViewModel
    {

        public string Id { get; set; }

        
        [EmailAddress]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "La contraseña es necesaria")]
        [StringLength(100, ErrorMessage = "La {0} debe ser de por lo menos {2} caracteres de longitud.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmar las contraseñas es necesario")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmacion de Clave")]
        [Compare("Password", ErrorMessage = "La clave y la confirmacion de clave no son iguales.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
        public string Url { get; set; }


        public string controller { get; set; }
        public string action { get; set; }
        public string area { get; set; }
    }
}

