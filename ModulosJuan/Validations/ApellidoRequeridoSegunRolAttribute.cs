using System.ComponentModel.DataAnnotations;

// Esta clase es para que los administradores no tengan que poner apellidos para crear el usuario
// Solo se les pide apellido a empleados a clientes

namespace ModulosJuan.Validations
{
    public class ApellidoRequeridoSegunRolAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var usuario = (Models.Usuario)validationContext.ObjectInstance;

            // Si el Rol es Empleado o Cliente y el Apellido está vacío → error
            if ((usuario.Rol == Models.Rol.Empleado || usuario.Rol == Models.Rol.Cliente)
                && string.IsNullOrWhiteSpace(usuario.Apellido))
            {
                return new ValidationResult("El apellido es obligatorio para empleados y clientes.");
            }

            // Si es Administrador, el Apellido puede ser nulo
            return ValidationResult.Success;
        }
    }
}

