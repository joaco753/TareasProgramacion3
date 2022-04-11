using System.ComponentModel.DataAnnotations;

namespace apiprueba1.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Stock { get; set; }

    }
}
