using Microsoft.EntityFrameworkCore;
using psychologyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace psychologyApp.Data
{
    public class ClinicaContext : DbContext
    {
        // Estas propiedades se convertirán en las tablas de tu base de datos
        public DbSet<Psicologo> Psicologos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Configuración de la conexión
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Usaremos SQLite porque es perfecto para apps de escritorio: 
            // no requiere servidor y la base de datos es un simple archivo .db
            optionsBuilder.UseSqlite("Data Source=ClinicaPsicologia.db");
        }

        // Configuración adicional (Opcional pero recomendada)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aquí puedes definir reglas más específicas, como valores únicos
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
