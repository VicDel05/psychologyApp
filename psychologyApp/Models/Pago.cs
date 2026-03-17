namespace psychologyApp.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public int CitaId { get; set; }
        public Cita Cita { get; set; }
    }
}
