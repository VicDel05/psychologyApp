using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace psychologyApp.Models
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public DateTime FechaPago { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string MetodoPago { get; set; } // Ejemplo: Efectivo, Tarjeta, Transferencia

        // Relación 1 a 1 con Cita
        [Required]
        public int CitaId { get; set; }

        [ForeignKey("CitaId")]
        public virtual Cita Cita { get; set; }
    }
}
