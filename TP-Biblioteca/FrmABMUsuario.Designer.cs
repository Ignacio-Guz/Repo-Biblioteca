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
            txtDocumento = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "DOCUMENTO";
            // 
            // btmBuscar
            // 
            btmBuscar.Font = new Font("Segoe UI", 12F);
            btmBuscar.Location = new Point(636, 31);
            btmBuscar.Name = "btmBuscar";
            btmBuscar.Size = new Size(110, 43);
            btmBuscar.TabIndex = 3;
            btmBuscar.Text = "BUSCAR";
            btmBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            txtDocumento.Anchor = AnchorStyles.None;
            txtDocumento.Font = new Font("Segoe UI", 12F);
            txtDocumento.Location = new Point(188, 36);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(415, 34);
            txtDocumento.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(698, 272);
            dataGridView1.TabIndex = 7;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtDocumento);
            Controls.Add(btmBuscar);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btmBuscar;
        private TextBox txtDocumento;
        private DataGridView dataGridView1;
    }
}