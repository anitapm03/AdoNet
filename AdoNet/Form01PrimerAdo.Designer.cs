namespace AdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label3 = new Label();
            lstTiposDato = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(12, 38);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(12, 87);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(75, 23);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(12, 139);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(75, 23);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 15;
            lstApellidos.Location = new Point(117, 38);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 124);
            lstApellidos.TabIndex = 5;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.ItemHeight = 15;
            lstColumnas.Location = new Point(267, 38);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 124);
            lstColumnas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 9);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipos Dato ";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.ItemHeight = 15;
            lstTiposDato.Location = new Point(407, 38);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(120, 124);
            lstTiposDato.TabIndex = 8;
            lstTiposDato.SelectedIndexChanged += lstTiposDato_SelectedIndexChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(41, 211);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 9;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 271);
            Controls.Add(lblMensaje);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label label1;
        private Label label2;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label3;
        private ListBox lstTiposDato;
        private Label lblMensaje;
    }
}