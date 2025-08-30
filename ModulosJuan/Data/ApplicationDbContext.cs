using Microsoft.EntityFrameworkCore;
using ModulosJuan.Models;

namespace ModulosJuan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //Constructor
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servicio> Servicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed para el usuario Administrador inicial
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    ID = 1,
                    Nombre = "Admin",
                    Email = "admin@glamping.com",
                    // En un proyecto real, la contraseña debe ser hasheada.
                    // Ejemplo: "123456"
                    Contrasena = "123456",
                    Rol = Rol.Administrador,
                    Activo = true,
                    Apellido = null // El administrador no necesita apellido
                }
            );
        }
    }
}
