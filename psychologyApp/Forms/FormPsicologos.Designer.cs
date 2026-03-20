namespace psychologyApp.Forms
{
    partial class FormPsicologos
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
            btn_Agregar = new Button();
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            numTarifa = new TextBox();
            dgvPsicologos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPsicologos).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(58, 268);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(112, 34);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "button1";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(60, 106);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(150, 31);
            txtEspecialidad.TabIndex = 2;
            // 
            // numTarifa
            // 
            numTarifa.Location = new Point(60, 167);
            numTarifa.Name = "numTarifa";
            numTarifa.Size = new Size(150, 31);
            numTarifa.TabIndex = 3;
            // 
            // dgvPsicologos
            // 
            dgvPsicologos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPsicologos.Location = new Point(345, 83);
            dgvPsicologos.Name = "dgvPsicologos";
            dgvPsicologos.RowHeadersWidth = 62;
            dgvPsicologos.Size = new Size(360, 225);
            dgvPsicologos.TabIndex = 4;
            // 
            // FormPsicologos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPsicologos);
            Controls.Add(numTarifa);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(btn_Agregar);
            Name = "FormPsicologos";
            Text = "FormPsicologos";
            ((System.ComponentModel.ISupportInitialize)dgvPsicologos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Agregar;
        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private TextBox numTarifa;
        private DataGridView dgvPsicologos;
    }
}