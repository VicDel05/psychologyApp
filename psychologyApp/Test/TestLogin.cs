using psychologyApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychologyApp.Test
{
    public partial class TestLogin : Form
    {
        public TestLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validamos que no estén vacíos antes de ir a la DB
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new ClinicaContext())
                {
                    // Buscamos al usuario que coincida con ambos campos
                    var usuarioLogueado = db.Usuarios
                        .FirstOrDefault(u => u.Username == nombreUsuario && u.Password == password);

                    if (usuarioLogueado != null)
                    {
                        // ¡Éxito! Guardamos el rol para usarlo en la siguiente pantalla
                        string rol = usuarioLogueado.Rol;
                        string nombreReal = usuarioLogueado.NombreReal;

                        MessageBox.Show($"Bienvenido(a), {nombreReal}", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir el formulario principal y pasarle los datos del usuario
                        FormPrincipal principal = new FormPrincipal(rol, nombreReal);
                        principal.Show();

                        this.Hide(); // Ocultamos el login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
