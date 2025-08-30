using ModulosJuan.Validations;
using System.ComponentModel.DataAnnotations;

namespace ModulosJuan.Models
{
    public enum Rol
    {
        Administrador,
        Empleado,
        Cliente
    }
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [ApellidoRequeridoSegunRol]
        public string? Apellido { get; set; } // Es nullable, pero se validará según el rol


        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contrasena { get; set; }
        public Rol Rol { get; set; }
        public bool Activo { get; set; } = true;
    }
}
