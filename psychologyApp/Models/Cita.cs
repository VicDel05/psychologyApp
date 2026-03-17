using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace psychologyApp.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public int DuracionMinutos { get; set; } // Estándar: 50 o 60 min

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Completada, Cancelada

        public string Notas { get; set; }

        // --- RELACIONES ---

        [Required]
        public int PacienteId { get; set; }

        [ForeignKey("PacienteId")]
        public virtual Paciente Paciente { get; set; }

        [Required]
        public int PsicologoId { get; set; }

        [ForeignKey("PsicologoId")]
        public virtual Psicologo Psicologo { get; set; }

        // Relación 1 a 1 opcional con el pago
        public virtual Pago Pago { get; set; }
    }
}
