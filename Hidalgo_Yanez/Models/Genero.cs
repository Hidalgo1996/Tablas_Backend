using System.ComponentModel.DataAnnotations;

namespace Hidalgo_Yanez.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int estado { get; set; }
    }
}
