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
            grillaUsuarios = new DataGridView();
            txtDocumento = new TextBox();
            label2 = new Label();
            BtmNuevo = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // BtmBuscar
            // 
            BtmBuscar.BackColor = Color.FromArgb(150, 207, 190);
            BtmBuscar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtmBuscar.Location = new Point(687, 86);
            BtmBuscar.Name = "BtmBuscar";
            BtmBuscar.Size = new Size(135, 51);
            BtmBuscar.TabIndex = 3;
            BtmBuscar.Text = "BUSCAR";
            BtmBuscar.UseVisualStyleBackColor = false;
            BtmBuscar.Click += BtmBuscar_Click;
            // 
            // grillaUsuarios
            // 
            grillaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaUsuarios.Location = new Point(12, 147);
            grillaUsuarios.Name = "grillaUsuarios";
            grillaUsuarios.RowHeadersWidth = 51;
            grillaUsuarios.Size = new Size(810, 488);
            grillaUsuarios.TabIndex = 7;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Consolas", 15F);
            txtDocumento.Location = new Point(157, 92);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(524, 37);
            txtDocumento.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(321, 40);
            label2.TabIndex = 9;
            label2.Text = "DATOS DE USUARIO";
            // 
            // BtmNuevo
            // 
            BtmNuevo.BackColor = Color.FromArgb(150, 207, 190);
            BtmNuevo.Font = new Font("Consolas", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtmNuevo.Location = new Point(12, 641);
            BtmNuevo.Name = "BtmNuevo";
            BtmNuevo.Size = new Size(75, 75);
            BtmNuevo.TabIndex = 10;
            BtmNuevo.Text = "+";
            BtmNuevo.UseVisualStyleBackColor = false;
            BtmNuevo.Click += BtmNuevo_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.FromArgb(150, 207, 190);
            BtnModificar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModificar.Location = new Point(546, 641);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(135, 75);
            BtnModificar.TabIndex = 11;
            BtnModificar.Text = "MODIFICAR";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += button2_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(150, 207, 190);
            BtnEliminar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(687, 641);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(135, 75);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += btnEliminar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(837, 728);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtmNuevo);
            Controls.Add(label2);
            Controls.Add(txtDocumento);
            Controls.Add(grillaUsuarios);
            Controls.Add(BtmBuscar);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "Usuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtmBuscar;
        private DataGridView grillaUsuarios;
        private TextBox txtDocumento;
        private Label label2;
        private Button BtmNuevo;
        private Button BtnModificar;
        private Button BtnEliminar;
    }
}