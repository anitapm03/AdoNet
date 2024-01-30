namespace AdoNet
{
    partial class Form11pARAMETROSsALIDA
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
            cmbDeptos = new ComboBox();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDeptos
            // 
            cmbDeptos.FormattingEnabled = true;
            cmbDeptos.Location = new Point(20, 44);
            cmbDeptos.Name = "cmbDeptos";
            cmbDeptos.Size = new Size(124, 23);
            cmbDeptos.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(20, 73);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(124, 23);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 123);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Suma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 190);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Media:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 250);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Personas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 11);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 6;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(195, 44);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(206, 244);
            lstEmpleados.TabIndex = 7;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(20, 141);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 8;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(20, 208);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 9;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(20, 268);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 10;
            // 
            // Form11pARAMETROSsALIDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 332);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbDeptos);
            Controls.Add(label1);
            Name = "Form11pARAMETROSsALIDA";
            Text = "Form11pARAMETROSsALIDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDeptos;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
    }
}