namespace TP_Biblioteca
{
    partial class FrmUsuarioNuevo
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
            BtnGuardar = new Button();
            btnCancelar = new Button();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtCalle = new TextBox();
            txtAltura = new TextBox();
            cmbTipoDoc = new ComboBox();
            cmbBarrio = new ComboBox();
            SuspendLayout();
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            BtnGuardar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            BtnGuardar.Location = new Point(710, 641);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(115, 75);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            btnCancelar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(573, 641);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 75);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 20F);
            label8.Location = new Point(26, 19);
            label8.Name = "label8";
            label8.Size = new Size(112, 40);
            label8.TabIndex = 27;
            label8.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14F);
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 28;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F);
            label2.Location = new Point(26, 148);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 29;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14F);
            label3.Location = new Point(26, 208);
            label3.Name = "label3";
            label3.Size = new Size(233, 28);
            label3.TabIndex = 30;
            label3.Text = "Tipo de documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14F);
            label4.Location = new Point(26, 268);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 31;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14F);
            label5.Location = new Point(26, 328);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 32;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14F);
            label6.Location = new Point(26, 388);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 33;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 14F);
            label7.Location = new Point(26, 448);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 34;
            label7.Text = "Barrio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 14F);
            label9.Location = new Point(26, 508);
            label9.Name = "label9";
            label9.Size = new Size(77, 28);
            label9.TabIndex = 35;
            label9.Text = "Calle";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 14F);
            label10.Location = new Point(26, 568);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 36;
            label10.Text = "Altura";
            label10.Click += label10_Click;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombres.Location = new Point(277, 85);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(535, 35);
            txtNombres.TabIndex = 37;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(277, 145);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(535, 35);
            txtApellidos.TabIndex = 38;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(277, 265);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(535, 35);
            txtDocumento.TabIndex = 40;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(277, 325);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(535, 35);
            txtTelefono.TabIndex = 41;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(277, 385);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(535, 35);
            txtEmail.TabIndex = 42;
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalle.Location = new Point(277, 505);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(535, 35);
            txtCalle.TabIndex = 44;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAltura.Location = new Point(277, 565);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(535, 35);
            txtAltura.TabIndex = 45;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.Font = new Font("Consolas", 14F);
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new Point(277, 205);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(535, 35);
            cmbTipoDoc.TabIndex = 46;
            // 
            // cmbBarrio
            // 
            cmbBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarrio.Font = new Font("Consolas", 14F);
            cmbBarrio.FormattingEnabled = true;
            cmbBarrio.Location = new Point(277, 445);
            cmbBarrio.Name = "cmbBarrio";
            cmbBarrio.Size = new Size(535, 35);
            cmbBarrio.TabIndex = 47;
            // 
            // FrmUsuarioNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(837, 728);
            Controls.Add(cmbBarrio);
            Controls.Add(cmbTipoDoc);
            Controls.Add(txtAltura);
            Controls.Add(txtCalle);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(BtnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUsuarioNuevo";
            Text = "Nuevo Usuario";
            Load += FrmUsuarioNuevo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuardar;
        private Button btnCancelar;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtCalle;
        private TextBox txtAltura;
        private ComboBox cmbTipoDoc;
        private ComboBox cmbBarrio;
    }
}