namespace TP_Biblioteca
{
    partial class FrmPrestamo
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
            textBox4 = new TextBox();
            BtnBuscarUsuario = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnBuscarLibro = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(150, 207, 190);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(BtnBuscarUsuario);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(665, 169);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(316, 134);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(59, 31);
            textBox4.TabIndex = 7;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.BackColor = Color.FromArgb(199, 200, 202);
            BtnBuscarUsuario.Location = new Point(506, 78);
            BtnBuscarUsuario.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            BtnBuscarUsuario.Size = new Size(94, 36);
            BtnBuscarUsuario.TabIndex = 6;
            BtnBuscarUsuario.Text = "Buscar";
            BtnBuscarUsuario.UseVisualStyleBackColor = false;
            BtnBuscarUsuario.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 58);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 31);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 88);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 23);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F);
            label3.Location = new Point(25, 102);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F);
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F);
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(150, 207, 190);
            groupBox2.Controls.Add(BtnBuscarLibro);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(37, 194);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(665, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Libro";
            // 
            // BtnBuscarLibro
            // 
            BtnBuscarLibro.BackColor = Color.FromArgb(199, 200, 202);
            BtnBuscarLibro.Location = new Point(506, 76);
            BtnBuscarLibro.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarLibro.Name = "BtnBuscarLibro";
            BtnBuscarLibro.Size = new Size(94, 36);
            BtnBuscarLibro.TabIndex = 7;
            BtnBuscarLibro.Text = "Buscar";
            BtnBuscarLibro.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 86);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 31);
            textBox7.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 56);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 31);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 24);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 31);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F);
            label6.Location = new Point(26, 94);
            label6.Name = "label6";
            label6.Size = new Size(60, 22);
            label6.TabIndex = 2;
            label6.Text = "Autor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F);
            label5.Location = new Point(23, 64);
            label5.Name = "label5";
            label5.Size = new Size(70, 22);
            label5.TabIndex = 1;
            label5.Text = "Título";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F);
            label4.Location = new Point(23, 32);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 0;
            label4.Text = "Código Libro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11.25F);
            label7.Location = new Point(37, 404);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 7;
            label7.Text = "Fecha Préstamo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F);
            label8.Location = new Point(37, 454);
            label8.Name = "label8";
            label8.Size = new Size(170, 22);
            label8.TabIndex = 8;
            label8.Text = "Fecha Devolución";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(223, 404);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 29);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(223, 454);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 29);
            textBox9.TabIndex = 8;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            BtnGuardar.Font = new Font("Consolas", 12F);
            BtnGuardar.Location = new Point(484, 496);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(98, 43);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            BtnCancelar.Font = new Font("Consolas", 12F);
            BtnCancelar.Location = new Point(599, 496);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(113, 43);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += button4_Click;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(738, 550);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 11.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrestamo";
            Text = "Préstamo";
            Load += FrmPrestamo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox4;
        private Button BtnBuscarUsuario;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnBuscarLibro;
    }
}