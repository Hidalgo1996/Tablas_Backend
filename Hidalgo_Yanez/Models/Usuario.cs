using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hidalgo_Yanez.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombreUsuario { get; set; }
        [Required]
        public string clave { get; set; }
        [Required]
        public int estado { get; set; }
        [Required]
        public int GeneroId { get; set; }
       
    }
}
