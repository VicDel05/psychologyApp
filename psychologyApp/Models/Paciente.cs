using System.ComponentModel.DataAnnotations;

namespace psychologyApp.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        // Relación: Un paciente puede tener muchas citas históricas
        public virtual ICollection<Cita> Citas { get; set; }
    }
}
