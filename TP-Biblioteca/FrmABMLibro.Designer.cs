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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btmBuscar = new Button();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(150, 207, 190);
            button3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(550, 410);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(102, 56);
            button3.TabIndex = 20;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(150, 207, 190);
            button2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(288, 410);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 56);
            button2.TabIndex = 19;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(150, 207, 190);
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 410);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 56);
            button1.TabIndex = 18;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 43);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 17;
            label2.Text = "DATOS DE LIBRO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 165);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(611, 218);
            dataGridView1.TabIndex = 15;
            // 
            // btmBuscar
            // 
            btmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            btmBuscar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmBuscar.Location = new Point(354, 105);
            btmBuscar.Margin = new Padding(3, 2, 3, 2);
            btmBuscar.Name = "btmBuscar";
            btmBuscar.Size = new Size(96, 38);
            btmBuscar.TabIndex = 14;
            btmBuscar.Text = "BUSCAR";
            btmBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 13;
            label1.Text = "AUTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 21;
            label3.Text = "TÍTULO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 22;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(689, 562);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btmBuscar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLibro";
            Text = "FrmLibro";
            Load += FrmLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btmBuscar;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
    }
}