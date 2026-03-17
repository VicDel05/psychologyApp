using System;
using System.Collections.Generic;
using System.Text;

namespace psychologyApp.Models
{

    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Recuerda encriptarla
        public string Rol { get; set; } // "Admin" o "Recepcion"
    }
}
