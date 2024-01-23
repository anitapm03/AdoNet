namespace AdoNet
{
    partial class Form07Hospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInsertar = new Button();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtCamas = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            lbltelf = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(223, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(223, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 23);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(223, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.Location = new Point(223, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 144);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 16;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 32);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 14;
            label2.Text = "ID:";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(223, 328);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 15;
            lstHospitales.Location = new Point(12, 32);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(180, 379);
            lstHospitales.TabIndex = 12;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "Hospitales:\r\n";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(223, 270);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 23);
            txtCamas.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(223, 216);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 252);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 23;
            label5.Text = "Numero de camas:";
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Location = new Point(223, 198);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new Size(55, 15);
            lbltelf.TabIndex = 22;
            lbltelf.Text = "Telefono:";
            // 
            // Form07Hospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(txtCamas);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(lbltelf);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnInsertar);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form07Hospitales";
            Text = "Form07Hospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnInsertar;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtCamas;
        private TextBox txtTelefono;
        private Label label5;
        private Label lbltelf;
    }
}