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
            optionsBuilder.UseSqlite("Data Source=ClinicaPsicologia.db");

            return new ClinicaContext(optionsBuilder.Options);
        }
    }
}
