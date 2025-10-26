namespace TP_Biblioteca.AltasIndividuales
{
    partial class FrmAutorNuevo
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
            BtnGuardar = new Button();
            btnCancelar = new Button();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 1;
            label1.Text = "Datos";
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            BtnGuardar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            BtnGuardar.Location = new Point(531, 349);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(115, 75);
            BtnGuardar.TabIndex = 29;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            btnCancelar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(384, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 75);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombres.Location = new Point(189, 75);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(457, 35);
            txtNombres.TabIndex = 31;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(189, 138);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(457, 35);
            txtApellidos.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 33;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14F);
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 34;
            label3.Text = "Apellidos";
            // 
            // FrmAutorNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(672, 443);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(btnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(label1);
            Name = "FrmAutorNuevo";
            Text = "Nuevo Autor";
            Load += FrmAutorNuevo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnGuardar;
        private Button btnCancelar;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label label2;
        private Label label3;
    }
}