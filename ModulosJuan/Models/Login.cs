using System.ComponentModel.DataAnnotations;

namespace Glamping.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "El Email es obligatorio.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}