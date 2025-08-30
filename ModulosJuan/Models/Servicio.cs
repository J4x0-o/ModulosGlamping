using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModulosJuan.Models
{
    public class Servicio
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre del servicio es obligatorio")]
        public string NombreServicio { get; set; }
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio del servicio es obligatorio")]
        public string Precio { get; set; }

        public bool Activo { get; set; } = true;

    }
}
