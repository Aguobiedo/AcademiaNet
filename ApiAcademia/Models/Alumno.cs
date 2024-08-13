using System.ComponentModel.DataAnnotations;

namespace ApiAcademia.Models
{
    public class Alumno
    {
        [Key]
        public int id { get; set; }
        
        [Required]
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo { get; set; }
    }
}
