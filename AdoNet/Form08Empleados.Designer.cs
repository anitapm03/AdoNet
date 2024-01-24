namespace AdoNet
{
    partial class Form08Empleados
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 15;
            lstOficios.Location = new Point(14, 33);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(120, 229);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 9);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados:";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(169, 33);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(178, 229);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 39);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Incremento de salario:";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(366, 57);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(121, 23);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(366, 97);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(121, 23);
            btnIncrementar.TabIndex = 6;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(192, 279);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(128, 15);
            lblSuma.TabIndex = 7;
            lblSuma.Text = "Suma salarial del oficio";
            // 
            // Form08Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 347);
            Controls.Add(lblSuma);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form08Empleados";
            Text = "Form08Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label lblSuma;
    }
}