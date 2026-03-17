namespace psychologyApp.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int DuracionMinutos { get; set; }
        public string Estado { get; set; } // "Pendiente", "Completada", "Cancelada"

        // Relaciones
        public int PsicologoId { get; set; }
        public Psicologo Psicologo { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public Pago Pago { get; set; }
    }
}
