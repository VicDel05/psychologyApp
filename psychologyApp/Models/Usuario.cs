using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace psychologyApp.Models
{

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } // En un paso futuro veremos cómo encriptarla

        [Required]
        public string Rol { get; set; } // "Administrador" o "Recepcion"

        public string NombreReal { get; set; }
    }
}
