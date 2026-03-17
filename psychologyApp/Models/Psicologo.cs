namespace psychologyApp.Models
{
    public class Psicologo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public decimal TarifaPorHora { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}
