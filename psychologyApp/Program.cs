using psychologyApp.Data;
using psychologyApp.Models;
using psychologyApp.Test;

namespace psychologyApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new ClinicaContext())
            {
                // Esto crea la base de datos y las tablas si no existen
                db.Database.EnsureCreated();

                // Si la tabla de usuarios está vacía, agregamos al admin de una vez
                if (!db.Usuarios.Any())
                {
                    db.Usuarios.Add(new Usuario
                    {
                        Username = "admin",
                        Password = "123", // Contraseña temporal
                        Rol = "Administrador",
                        NombreReal = "Adriana Aracely"
                    });
                    db.SaveChanges();
                }
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TestLogin());
        }
    }
}