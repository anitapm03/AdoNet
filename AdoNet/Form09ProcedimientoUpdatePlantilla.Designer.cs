namespace AdoNet
{
    partial class Form09ProcedimientoUpdatePlantilla
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
            label1 = new Label();
            cmbHospital = new ComboBox();
            btnModificarSalarios = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(16, 30);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(151, 23);
            cmbHospital.TabIndex = 1;
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(186, 30);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(117, 23);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "Modificar salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 15;
            lstPlantilla.Location = new Point(16, 88);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(287, 184);
            lstPlantilla.TabIndex = 4;
            // 
            // Form09ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 294);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnModificarSalarios);
            Controls.Add(cmbHospital);
            Controls.Add(label1);
            Name = "Form09ProcedimientoUpdatePlantilla";
            Text = "Form09ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospital;
        private Button btnModificarSalarios;
        private Label label2;
        private ListBox lstPlantilla;
    }
}