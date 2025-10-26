namespace TP_Biblioteca.AltasIndividuales
{
    partial class FrmEditorialNueva
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
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnCancelar = new Button();
            BtnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 2;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 34;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14F);
            label3.Location = new Point(20, 200);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 35;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14F);
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 36;
            label4.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(159, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(457, 35);
            txtNombre.TabIndex = 37;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(159, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(457, 35);
            txtEmail.TabIndex = 38;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(159, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(457, 35);
            txtTelefono.TabIndex = 39;
            txtTelefono.TextChanged += textBox2_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            btnCancelar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(409, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 75);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            BtnGuardar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            BtnGuardar.Location = new Point(545, 356);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(115, 75);
            BtnGuardar.TabIndex = 41;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FrmEditorialNueva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(672, 443);
            Controls.Add(BtnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEditorialNueva";
            Text = "Nueva Editorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnCancelar;
        private Button BtnGuardar;
    }
}