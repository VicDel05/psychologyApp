using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using psychologyApp.Forms;

namespace psychologyApp.Test
{
    public partial class FormPrincipal : Form
    {
        private string _rolActual;

        public FormPrincipal(string rol, string nombreUsuario)
        {
            InitializeComponent();
            _rolActual = rol;
            lblBienvenida.Text = $"Bienvenida, {nombreUsuario}";

            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            if (_rolActual == "Recepcion")
            {
                // Ocultamos lo que la recepcionista no debe ver (finanzas)
                btnIngresos.Visible = false;
                btnConfiguracion.Visible = false;

                // Solo dejamos habilitado lo operativo
                btnCitas.Enabled = true;
                btnPacientes.Enabled = true;
            }
            // Si es Administrador (Adriana), por defecto todo está Visible = true
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FormPacientes nuevoForm = new FormPacientes();
            nuevoForm.Show();
        }

        private void btnPsicologos_Click(object sender, EventArgs e)
        {
            FormPsicologos formPsicologos = new FormPsicologos();
            formPsicologos.Show();
        }
    }
}
