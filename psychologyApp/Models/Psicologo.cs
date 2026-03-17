using System.ComponentModel.DataAnnotations;

namespace psychologyApp.Models
{
    public class Psicologo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public string Especialidad { get; set; }

        [Required]
        public decimal TarifaPorHora { get; set; }

        // Un psicólogo tiene muchas citas
        public virtual ICollection<Cita> Citas { get; set; }
    }
}
