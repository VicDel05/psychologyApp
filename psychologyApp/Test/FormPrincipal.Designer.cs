namespace psychologyApp.Test
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            btnIngresos = new Button();
            btnConfiguracion = new Button();
            btnCitas = new Button();
            btnPacientes = new Button();
            btnPsicologos = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(116, 59);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(59, 25);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(115, 138);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(112, 34);
            btnIngresos.TabIndex = 1;
            btnIngresos.Text = "button1";
            btnIngresos.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(358, 135);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(112, 34);
            btnConfiguracion.TabIndex = 2;
            btnConfiguracion.Text = "button1";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(116, 280);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(112, 34);
            btnCitas.TabIndex = 3;
            btnCitas.Text = "button1";
            btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(361, 282);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(112, 34);
            btnPacientes.TabIndex = 4;
            btnPacientes.Text = "button1";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnPsicologos
            // 
            btnPsicologos.Location = new Point(599, 144);
            btnPsicologos.Name = "btnPsicologos";
            btnPsicologos.Size = new Size(112, 34);
            btnPsicologos.TabIndex = 5;
            btnPsicologos.Text = "button1";
            btnPsicologos.UseVisualStyleBackColor = true;
            btnPsicologos.Click += btnPsicologos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPsicologos);
            Controls.Add(btnPacientes);
            Controls.Add(btnCitas);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnIngresos);
            Controls.Add(lblBienvenida);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnIngresos;
        private Button btnConfiguracion;
        private Button btnCitas;
        private Button btnPacientes;
        private Button btnPsicologos;
    }
}