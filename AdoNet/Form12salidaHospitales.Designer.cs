namespace AdoNet
{
    partial class Form12salidaHospitales
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
            txtPersonas = new TextBox();
            txtMedia = new TextBox();
            txtSuma = new TextBox();
            lstEmpleadosHospital = new ListBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnMostrarDatos = new Button();
            cmbHospitales = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(46, 274);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 21;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(46, 214);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 20;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(46, 147);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 19;
            // 
            // lstEmpleadosHospital
            // 
            lstEmpleadosHospital.FormattingEnabled = true;
            lstEmpleadosHospital.ItemHeight = 15;
            lstEmpleadosHospital.Location = new Point(221, 50);
            lstEmpleadosHospital.Name = "lstEmpleadosHospital";
            lstEmpleadosHospital.Size = new Size(206, 244);
            lstEmpleadosHospital.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 32);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 17;
            label5.Text = "Empleados hospital\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 256);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 16;
            label4.Text = "Personas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 196);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Media:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 129);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "Suma:";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(46, 79);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(124, 23);
            btnMostrarDatos.TabIndex = 13;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(46, 50);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(124, 23);
            cmbHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // Form12salidaHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 332);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(lstEmpleadosHospital);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form12salidaHospitales";
            Text = "Form12salidaHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonas;
        private TextBox txtMedia;
        private TextBox txtSuma;
        private ListBox lstEmpleadosHospital;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnMostrarDatos;
        private ComboBox cmbHospitales;
        private Label label1;
    }
}