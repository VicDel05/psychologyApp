using psychologyApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychologyApp.Forms
{
    public partial class FormPsicologos : Form
    {
        public FormPsicologos()
        {
            InitializeComponent();
        }

        private void CargarPsicologos()
        {
            using (var db = new ClinicaContext())
            {
                // Traemos todos los pacientes y los mostramos en el Grid
                dgvPsicologos.DataSource = db.Psicologos.ToList();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return;

            using (var db = new Data.ClinicaContext())
            {
                var nuevoPsicologo = new Models.Psicologo
                {
                    Nombre = txtNombre.Text.Trim(),
                    Especialidad = txtEspecialidad.Text.Trim(),
                    TarifaPorHora = Decimal.Parse(numTarifa.Text),
                };
                db.Psicologos.Add(nuevoPsicologo);
                db.SaveChanges(); // Aquí se guarda en el archivo .db
                MessageBox.Show("Psicólogo registrado con éxito.");
                CargarPsicologos(); // Refrescamos la tabla
                                    //LimpiarCampos();
            }
        }
    }
}
