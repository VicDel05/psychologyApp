using Microsoft.EntityFrameworkCore;
using psychologyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace psychologyApp.Data
{
    public class ClinicaContext : DbContext
    {
        public DbSet<Psicologo> Psicologos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ClinicaPsicologia.db");
    }
}
