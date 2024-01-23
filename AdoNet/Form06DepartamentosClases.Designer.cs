namespace AdoNet
{
    partial class Form06DepartamentosClases
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
            lstDepartamentos = new ListBox();
            btnInsertar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos:";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 15;
            lstDepartamentos.Location = new Point(15, 31);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(180, 199);
            lstDepartamentos.TabIndex = 1;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(226, 207);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 31);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 89);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 143);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Localidad:";
            // 
            // txtId
            // 
            txtId.Location = new Point(226, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(226, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(226, 161);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(365, 87);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(369, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form06DepartamentosClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 313);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnInsertar);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Name = "Form06DepartamentosClases";
            Text = "Form06DepartamentosClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Button btnInsertar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button btnModificar;
        private Button btnEliminar;
    }
}