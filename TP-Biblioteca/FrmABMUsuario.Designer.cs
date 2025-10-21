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
            btmBuscar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 90);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "DOCUMENTO";
            // 
            // btmBuscar
            // 
            btmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            btmBuscar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmBuscar.Location = new Point(387, 82);
            btmBuscar.Margin = new Padding(3, 2, 3, 2);
            btmBuscar.Name = "btmBuscar";
            btmBuscar.Size = new Size(96, 27);
            btmBuscar.TabIndex = 3;
            btmBuscar.Text = "BUSCAR";
            btmBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 125);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(611, 230);
            dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 35);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 9;
            label2.Text = "DATOS DE USUARIO";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(150, 207, 190);
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(42, 391);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 10;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(150, 207, 190);
            button2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(310, 391);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 11;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(150, 207, 190);
            button3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(557, 391);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(96, 44);
            button3.TabIndex = 12;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(700, 473);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btmBuscar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btmBuscar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}