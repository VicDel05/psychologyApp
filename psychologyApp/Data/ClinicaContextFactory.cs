using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace psychologyApp.Data
{
    // Esta clase permite a las herramientas de EF Core crear una instancia del DbContext en tiempo de diseño
    public class ClinicaContextFactory : IDesignTimeDbContextFactory<ClinicaContext>
    {
        public ClinicaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicaContext>();
            // Usar la instancia de SQL Server en el equipo DESKTOP-6R529V0
            // Agregamos TrustServerCertificate=True para evitar errores de certificado en entornos locales
            optionsBuilder.UseSqlServer("Server=DESKTOP-6R529V0;Database=psychologyapp;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

            return new ClinicaContext(optionsBuilder.Options);
        }
    }
}
