namespace AdoNet
{
    partial class Form04ModificarSalas
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Salas:";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.ItemHeight = 15;
            lstSalas.Location = new Point(17, 43);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(173, 259);
            lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(244, 123);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 43);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar sala";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form04ModificarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 450);
            Controls.Add(btnModificar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Name = "Form04ModificarSalas";
            Text = "Form04ModificarSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNombre;
        private Button btnModificar;
    }
}