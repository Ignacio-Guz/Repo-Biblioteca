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
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1326, 781);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}