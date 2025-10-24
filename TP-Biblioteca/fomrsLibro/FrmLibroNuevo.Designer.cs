namespace TP_Biblioteca
{
    partial class FrmLibroNuevo
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
            groupBox1 = new GroupBox();
            txtCantTotal = new TextBox();
            txtCodCategoria = new TextBox();
            txtCodEditorial = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAñoPubli = new TextBox();
            BtnGuardar = new Button();
            txtEdicion = new TextBox();
            txtCodAutor = new TextBox();
            txtTitulo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(150, 207, 190);
            groupBox1.Controls.Add(txtCantTotal);
            groupBox1.Controls.Add(txtCodCategoria);
            groupBox1.Controls.Add(txtCodEditorial);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAñoPubli);
            groupBox1.Controls.Add(BtnGuardar);
            groupBox1.Controls.Add(txtEdicion);
            groupBox1.Controls.Add(txtCodAutor);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Consolas", 11.25F);
            groupBox1.Location = new Point(126, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 493);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Libro";
            // 
            // txtCantTotal
            // 
            txtCantTotal.Font = new Font("Consolas", 11.25F);
            txtCantTotal.Location = new Point(182, 163);
            txtCantTotal.Name = "txtCantTotal";
            txtCantTotal.Size = new Size(258, 29);
            txtCantTotal.TabIndex = 17;
            // 
            // txtCodCategoria
            // 
            txtCodCategoria.Font = new Font("Consolas", 11.25F);
            txtCodCategoria.Location = new Point(183, 280);
            txtCodCategoria.Name = "txtCodCategoria";
            txtCodCategoria.Size = new Size(258, 29);
            txtCodCategoria.TabIndex = 16;
            // 
            // txtCodEditorial
            // 
            txtCodEditorial.Font = new Font("Consolas", 11.25F);
            txtCodEditorial.Location = new Point(183, 244);
            txtCodEditorial.Name = "txtCodEditorial";
            txtCodEditorial.Size = new Size(258, 29);
            txtCodEditorial.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11.25F);
            label7.Location = new Point(26, 164);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 11;
            label7.Text = "Cantidad Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F);
            label6.Location = new Point(26, 287);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 10;
            label6.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F);
            label5.Location = new Point(26, 244);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 9;
            label5.Text = "Editorial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F);
            label4.Location = new Point(26, 128);
            label4.Name = "label4";
            label4.Size = new Size(160, 22);
            label4.TabIndex = 8;
            label4.Text = "Año Publicación";
            // 
            // txtAñoPubli
            // 
            txtAñoPubli.Location = new Point(183, 128);
            txtAñoPubli.Name = "txtAñoPubli";
            txtAñoPubli.Size = new Size(258, 29);
            txtAñoPubli.TabIndex = 7;
            txtAñoPubli.TextChanged += textBox4_TextChanged;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(199, 200, 202);
            BtnGuardar.Location = new Point(488, 412);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(121, 48);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtEdicion
            // 
            txtEdicion.Font = new Font("Consolas", 11.25F);
            txtEdicion.Location = new Point(183, 87);
            txtEdicion.Name = "txtEdicion";
            txtEdicion.Size = new Size(258, 29);
            txtEdicion.TabIndex = 5;
            // 
            // txtCodAutor
            // 
            txtCodAutor.Font = new Font("Consolas", 11.25F);
            txtCodAutor.Location = new Point(183, 203);
            txtCodAutor.Name = "txtCodAutor";
            txtCodAutor.Size = new Size(258, 29);
            txtCodAutor.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(183, 48);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(258, 29);
            txtTitulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F);
            label3.Location = new Point(26, 90);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 2;
            label3.Text = "Edición";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F);
            label2.Location = new Point(26, 206);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F);
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // FrmLibroNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLibroNuevo";
            Text = "Nuevo Libro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCantTotal;
        private TextBox txtCodCategoria;
        private TextBox txtCodEditorial;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtAñoPubli;
        private Button BtnGuardar;
        private TextBox txtEdicion;
        private TextBox txtCodAutor;
        private TextBox txtTitulo;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}