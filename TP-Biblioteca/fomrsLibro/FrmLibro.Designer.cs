namespace TP_Biblioteca
{
    partial class FrmLibro
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
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnNuevo = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            GrillaLibros = new DataGridView();
            BtmBuscar = new Button();
            label1 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrillaLibros).BeginInit();
            SuspendLayout();
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(150, 207, 190);
            BtnEliminar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(629, 547);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(117, 75);
            BtnEliminar.TabIndex = 20;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.FromArgb(150, 207, 190);
            BtnModificar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(329, 547);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(117, 75);
            BtnModificar.TabIndex = 19;
            BtnModificar.Text = "MODIFICAR";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.FromArgb(150, 207, 190);
            BtnNuevo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevo.Location = new Point(46, 547);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(117, 75);
            BtnNuevo.TabIndex = 18;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 57);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 17;
            label2.Text = "DATOS DE LIBRO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 160);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 16;
            // 
            // GrillaLibros
            // 
            GrillaLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaLibros.Location = new Point(46, 220);
            GrillaLibros.Name = "GrillaLibros";
            GrillaLibros.RowHeadersWidth = 51;
            GrillaLibros.Size = new Size(698, 291);
            GrillaLibros.TabIndex = 15;
            GrillaLibros.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtmBuscar
            // 
            BtmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            BtmBuscar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtmBuscar.Location = new Point(405, 140);
            BtmBuscar.Name = "BtmBuscar";
            BtmBuscar.Size = new Size(110, 51);
            BtmBuscar.TabIndex = 14;
            BtmBuscar.Text = "BUSCAR";
            BtmBuscar.UseVisualStyleBackColor = false;
            BtmBuscar.Click += BtmBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 160);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 13;
            label1.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 120);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 21;
            label3.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(157, 115);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(218, 27);
            txtTitulo.TabIndex = 22;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(787, 749);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnNuevo);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(GrillaLibros);
            Controls.Add(BtmBuscar);
            Controls.Add(label1);
            Name = "FrmLibro";
            Text = "Libro";
            Load += FrmLibro_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEliminar;
        private Button BtnModificar;
        private Button BtnNuevo;
        private Label label2;
        private TextBox textBox1;
        private DataGridView GrillaLibros;
        private Button BtmBuscar;
        private Label label1;
        private Label label3;
        private TextBox txtTitulo;
    }
}