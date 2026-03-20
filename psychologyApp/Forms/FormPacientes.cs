using psychologyApp.Data;
using psychologyApp.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychologyApp.Forms
{
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void CargarPacientes()
        {
            using (var db = new ClinicaContext())
            {
                // Traemos todos los pacientes y los mostramos en el Grid
                dgvPacientes.DataSource = db.Pacientes.ToList();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return;

            using (var db = new ClinicaContext())
            {
                var nuevoPaciente = new Paciente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                db.Pacientes.Add(nuevoPaciente);
                db.SaveChanges(); // Aquí se guarda en el archivo .db

                MessageBox.Show("Paciente registrado con éxito.");
                CargarPacientes(); // Refrescamos la tabla
                //LimpiarCampos();
            }
        }
    }
}
