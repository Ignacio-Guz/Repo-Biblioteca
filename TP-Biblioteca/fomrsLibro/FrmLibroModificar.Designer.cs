namespace TP_Biblioteca
{
    partial class FrmLibroModificar
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            txtTitulo = new TextBox();
            txtEdicion = new TextBox();
            txtAñoPubli = new TextBox();
            txtCantTotal = new TextBox();
            label9 = new Label();
            cmbCategoria = new ComboBox();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtCantDispo = new TextBox();
            btnCancelar = new Button();
            BtnGuardar = new Button();
            btnNuevaEditorial = new Button();
            btnNuevoAutor = new Button();
            txtCodLibro = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20F);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F);
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14F);
            label3.Location = new Point(26, 148);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 3;
            label3.Text = "Edición";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14F);
            label4.Location = new Point(26, 208);
            label4.Name = "label4";
            label4.Size = new Size(207, 28);
            label4.TabIndex = 9;
            label4.Text = "Año Publicación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 14F);
            label7.Location = new Point(26, 268);
            label7.Name = "label7";
            label7.Size = new Size(194, 28);
            label7.TabIndex = 12;
            label7.Text = "Cantidad Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14F);
            label6.Location = new Point(26, 388);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 13;
            label6.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14F);
            label5.Location = new Point(26, 448);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 14;
            label5.Text = "Editorial";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 14F);
            label8.Location = new Point(26, 508);
            label8.Name = "label8";
            label8.Size = new Size(77, 28);
            label8.TabIndex = 15;
            label8.Text = "Autor";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(290, 85);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(457, 35);
            txtTitulo.TabIndex = 16;
            // 
            // txtEdicion
            // 
            txtEdicion.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdicion.Location = new Point(290, 145);
            txtEdicion.Name = "txtEdicion";
            txtEdicion.Size = new Size(457, 35);
            txtEdicion.TabIndex = 17;
            // 
            // txtAñoPubli
            // 
            txtAñoPubli.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAñoPubli.Location = new Point(290, 205);
            txtAñoPubli.Name = "txtAñoPubli";
            txtAñoPubli.Size = new Size(457, 35);
            txtAñoPubli.TabIndex = 18;
            // 
            // txtCantTotal
            // 
            txtCantTotal.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantTotal.Location = new Point(290, 265);
            txtCantTotal.Name = "txtCantTotal";
            txtCantTotal.Size = new Size(457, 35);
            txtCantTotal.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 14F);
            label9.Location = new Point(26, 328);
            label9.Name = "label9";
            label9.Size = new Size(259, 28);
            label9.TabIndex = 20;
            label9.Text = "Cantidad Disponible";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Consolas", 14F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(290, 385);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(457, 35);
            cmbCategoria.TabIndex = 23;
            // 
            // cmbEditorial
            // 
            cmbEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorial.Font = new Font("Consolas", 14F);
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(290, 445);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(457, 35);
            cmbEditorial.TabIndex = 24;
            // 
            // cmbAutor
            // 
            cmbAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutor.Font = new Font("Consolas", 14F);
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(290, 505);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(457, 35);
            cmbAutor.TabIndex = 25;
            // 
            // txtCantDispo
            // 
            txtCantDispo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantDispo.Location = new Point(290, 325);
            txtCantDispo.Name = "txtCantDispo";
            txtCantDispo.Size = new Size(457, 35);
            txtCantDispo.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            btnCancelar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(575, 641);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 75);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            BtnGuardar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            BtnGuardar.Location = new Point(710, 641);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(115, 75);
            BtnGuardar.TabIndex = 28;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // btnNuevaEditorial
            // 
            btnNuevaEditorial.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnNuevaEditorial.Location = new Point(753, 445);
            btnNuevaEditorial.Name = "btnNuevaEditorial";
            btnNuevaEditorial.Size = new Size(35, 35);
            btnNuevaEditorial.TabIndex = 29;
            btnNuevaEditorial.Text = "+";
            btnNuevaEditorial.UseVisualStyleBackColor = true;
            btnNuevaEditorial.Click += btnNuevaEditorial_Click;
            // 
            // btnNuevoAutor
            // 
            btnNuevoAutor.Font = new Font("Consolas", 14F, FontStyle.Bold);
            btnNuevoAutor.Location = new Point(753, 505);
            btnNuevoAutor.Name = "btnNuevoAutor";
            btnNuevoAutor.Size = new Size(35, 35);
            btnNuevoAutor.TabIndex = 30;
            btnNuevoAutor.Text = "+";
            btnNuevoAutor.UseVisualStyleBackColor = true;
            btnNuevoAutor.Click += btnNuevoAutor_Click;
            // 
            // txtCodLibro
            // 
            txtCodLibro.Location = new Point(49, 655);
            txtCodLibro.Name = "txtCodLibro";
            txtCodLibro.Size = new Size(125, 27);
            txtCodLibro.TabIndex = 31;
            // 
            // FrmLibroModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(837, 728);
            Controls.Add(txtCodLibro);
            Controls.Add(btnNuevoAutor);
            Controls.Add(btnNuevaEditorial);
            Controls.Add(BtnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCantDispo);
            Controls.Add(cmbAutor);
            Controls.Add(cmbEditorial);
            Controls.Add(cmbCategoria);
            Controls.Add(label9);
            Controls.Add(txtCantTotal);
            Controls.Add(txtAñoPubli);
            Controls.Add(txtEdicion);
            Controls.Add(txtTitulo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLibroModificar";
            Text = " Modificar Libro";
            Load += FrmLibroModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtTitulo;
        private TextBox txtEdicion;
        private TextBox txtAñoPubli;
        private TextBox txtCantTotal;
        private Label label9;
        private ComboBox cmbCategoria;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtCantDispo;
        private Button btnCancelar;
        private Button BtnGuardar;
        private Button btnNuevaEditorial;
        private Button btnNuevoAutor;
        private TextBox txtCodLibro;
    }
}