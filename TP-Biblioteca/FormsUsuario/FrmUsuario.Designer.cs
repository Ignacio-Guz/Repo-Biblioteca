namespace TP_Biblioteca
{
    partial class FrmUsuario
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
            BtmBuscar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            BtmNuevo = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 120);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // BtmBuscar
            // 
            BtmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            BtmBuscar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtmBuscar.Location = new Point(442, 109);
            BtmBuscar.Name = "BtmBuscar";
            BtmBuscar.Size = new Size(110, 36);
            BtmBuscar.TabIndex = 3;
            BtmBuscar.Text = "BUSCAR";
            BtmBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(698, 307);
            dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 115);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 47);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 9;
            label2.Text = "DATOS DE USUARIO";
            // 
            // BtmNuevo
            // 
            BtmNuevo.BackColor = Color.FromArgb(150, 207, 190);
            BtmNuevo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtmNuevo.Location = new Point(48, 521);
            BtmNuevo.Name = "BtmNuevo";
            BtmNuevo.Size = new Size(110, 59);
            BtmNuevo.TabIndex = 10;
            BtmNuevo.Text = "NUEVO";
            BtmNuevo.UseVisualStyleBackColor = false;
            BtmNuevo.Click += BtmNuevo_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.FromArgb(150, 207, 190);
            BtnModificar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(354, 521);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(125, 59);
            BtnModificar.TabIndex = 11;
            BtnModificar.Text = "MODIFICAR";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += button2_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(150, 207, 190);
            BtnEliminar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(637, 521);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(110, 59);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += button3_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(1510, 728);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtmNuevo);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BtmBuscar);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "Usuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtmBuscar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Button BtmNuevo;
        private Button BtnModificar;
        private Button BtnEliminar;
    }
}