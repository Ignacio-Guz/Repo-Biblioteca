namespace TP_Biblioteca.Formularios
{
    partial class FormularioPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "VerUsuarios";
            button1.BackColor = Color.FromArgb(16, 107, 111);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(779, 86);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(162, 48);
            button1.TabIndex = 0;
            button1.Text = "Ver usuarios";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AccessibleName = "VerUsuarios";
            button2.BackColor = Color.FromArgb(16, 107, 111);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(779, 184);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(162, 48);
            button2.TabIndex = 1;
            button2.Text = "Ver libros";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AccessibleName = "VerUsuarios";
            button3.BackColor = Color.FromArgb(16, 107, 111);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(779, 284);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(162, 48);
            button3.TabIndex = 2;
            button3.Text = "Ver Prestamos";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 126);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 327);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 241);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 184);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1326, 781);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}