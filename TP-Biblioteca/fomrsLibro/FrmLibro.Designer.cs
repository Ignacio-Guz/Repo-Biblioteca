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
            GrillaLibros = new DataGridView();
            BtmBuscar = new Button();
            label3 = new Label();
            txtTitulo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrillaLibros).BeginInit();
            SuspendLayout();
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(150, 207, 190);
            BtnEliminar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(687, 641);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(135, 75);
            BtnEliminar.TabIndex = 20;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.FromArgb(150, 207, 190);
            BtnModificar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(546, 641);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(135, 75);
            BtnModificar.TabIndex = 19;
            BtnModificar.Text = "MODIFICAR";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.FromArgb(150, 207, 190);
            BtnNuevo.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevo.Location = new Point(12, 641);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 75);
            BtnNuevo.TabIndex = 18;
            BtnNuevo.Text = "+";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(283, 40);
            label2.TabIndex = 17;
            label2.Text = "DATOS DE LIBRO";
            // 
            // GrillaLibros
            // 
            GrillaLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaLibros.Location = new Point(12, 147);
            GrillaLibros.Name = "GrillaLibros";
            GrillaLibros.RowHeadersWidth = 51;
            GrillaLibros.Size = new Size(810, 488);
            GrillaLibros.TabIndex = 15;
            GrillaLibros.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtmBuscar
            // 
            BtmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            BtmBuscar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtmBuscar.Location = new Point(687, 86);
            BtmBuscar.Name = "BtmBuscar";
            BtmBuscar.Size = new Size(135, 51);
            BtmBuscar.TabIndex = 14;
            BtmBuscar.Text = "BUSCAR";
            BtmBuscar.UseVisualStyleBackColor = false;
            BtmBuscar.Click += BtmBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 21;
            label3.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Consolas", 15F);
            txtTitulo.Location = new Point(110, 91);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(571, 37);
            txtTitulo.TabIndex = 22;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(837, 728);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnNuevo);
            Controls.Add(label2);
            Controls.Add(GrillaLibros);
            Controls.Add(BtmBuscar);
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
        private DataGridView GrillaLibros;
        private Button BtmBuscar;
        private Label label3;
        private TextBox txtTitulo;
    }
}