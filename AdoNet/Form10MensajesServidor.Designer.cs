﻿namespace AdoNet
{
    partial class Form10MensajesServidor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMensajesServidor = new Label();
            btnInsertar = new Button();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Localidad\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 16);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Departamentos";
            // 
            // lblMensajesServidor
            // 
            lblMensajesServidor.AutoSize = true;
            lblMensajesServidor.Location = new Point(141, 277);
            lblMensajesServidor.Name = "lblMensajesServidor";
            lblMensajesServidor.Size = new Size(112, 15);
            lblMensajesServidor.TabIndex = 4;
            lblMensajesServidor.Text = "lblMensajesServidor";
            lblMensajesServidor.Click += lblMensajesServidor_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 182);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(97, 23);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(9, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(9, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 143);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 8;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 15;
            lstDepartamentos.Location = new Point(141, 34);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(251, 229);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form10MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 301);
            Controls.Add(lstDepartamentos);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(btnInsertar);
            Controls.Add(lblMensajesServidor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10MensajesServidor";
            Text = "Form10MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMensajesServidor;
        private Button btnInsertar;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private ListBox lstDepartamentos;
    }
}