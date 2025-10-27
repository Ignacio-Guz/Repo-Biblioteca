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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grillaUsuarios = new DataGridView();
            groupBOx1 = new GroupBox();
            label1 = new Label();
            txtDocumento = new TextBox();
            btnBuscarUsuario = new Button();
            btnBuscarlibro = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            grillaLibros = new DataGridView();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtFechaPrestamo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).BeginInit();
            groupBOx1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaLibros).BeginInit();
            SuspendLayout();
            // 
            // grillaUsuarios
            // 
            grillaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            grillaUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            grillaUsuarios.Location = new Point(23, 82);
            grillaUsuarios.Name = "grillaUsuarios";
            grillaUsuarios.RowHeadersWidth = 51;
            grillaUsuarios.Size = new Size(772, 200);
            grillaUsuarios.TabIndex = 8;
            // 
            // groupBOx1
            // 
            groupBOx1.Controls.Add(label1);
            groupBOx1.Controls.Add(txtDocumento);
            groupBOx1.Controls.Add(btnBuscarUsuario);
            groupBOx1.Controls.Add(grillaUsuarios);
            groupBOx1.Font = new Font("Consolas", 18F, FontStyle.Bold);
            groupBOx1.Location = new Point(15, 15);
            groupBOx1.Name = "groupBOx1";
            groupBOx1.Size = new Size(810, 286);
            groupBOx1.TabIndex = 9;
            groupBOx1.TabStop = false;
            groupBOx1.Text = "Buscar Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 41);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 10;
            label1.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Consolas", 15F);
            txtDocumento.Location = new Point(168, 38);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(486, 37);
            txtDocumento.TabIndex = 9;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(150, 207, 190);
            btnBuscarUsuario.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnBuscarUsuario.Location = new Point(660, 30);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(130, 50);
            btnBuscarUsuario.TabIndex = 0;
            btnBuscarUsuario.Text = "BUSCAR";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // btnBuscarlibro
            // 
            btnBuscarlibro.BackColor = Color.FromArgb(150, 207, 190);
            btnBuscarlibro.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnBuscarlibro.Location = new Point(660, 30);
            btnBuscarlibro.Name = "btnBuscarlibro";
            btnBuscarlibro.Size = new Size(130, 50);
            btnBuscarlibro.TabIndex = 1;
            btnBuscarlibro.Text = "BUSCAR";
            btnBuscarlibro.UseVisualStyleBackColor = false;
            btnBuscarlibro.Click += btnBuscarlibro_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnBuscarlibro);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Controls.Add(grillaLibros);
            groupBox2.Font = new Font("Consolas", 18F, FontStyle.Bold);
            groupBox2.Location = new Point(15, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(810, 284);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 41);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 10;
            label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Consolas", 15F);
            txtTitulo.Location = new Point(168, 38);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(486, 37);
            txtTitulo.TabIndex = 9;
            // 
            // grillaLibros
            // 
            grillaLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grillaLibros.DefaultCellStyle = dataGridViewCellStyle2;
            grillaLibros.Location = new Point(23, 82);
            grillaLibros.Name = "grillaLibros";
            grillaLibros.RowHeadersWidth = 51;
            grillaLibros.Size = new Size(772, 200);
            grillaLibros.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(150, 207, 190);
            btnGuardar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(675, 650);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 75);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(150, 207, 190);
            btnCancelar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(534, 650);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 75);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 603);
            label3.Name = "label3";
            label3.Size = new Size(251, 29);
            label3.TabIndex = 15;
            label3.Text = "Fecha de prestamo";
            // 
            // txtFechaPrestamo
            // 
            txtFechaPrestamo.Font = new Font("Consolas", 15F);
            txtFechaPrestamo.Location = new Point(295, 600);
            txtFechaPrestamo.Margin = new Padding(3, 4, 3, 4);
            txtFechaPrestamo.Name = "txtFechaPrestamo";
            txtFechaPrestamo.Size = new Size(515, 37);
            txtFechaPrestamo.TabIndex = 17;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 200, 202);
            ClientSize = new Size(837, 728);
            Controls.Add(txtFechaPrestamo);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBOx1);
            Font = new Font("Consolas", 11.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrestamo";
            Text = "Préstamo";
            Load += FrmPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).EndInit();
            groupBOx1.ResumeLayout(false);
            groupBOx1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaUsuarios;
        private GroupBox groupBOx1;
        private Button btnBuscarUsuario;
        private Button btnBuscarlibro;
        private TextBox txtDocumento;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtTitulo;
        private DataGridView grillaLibros;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label3;
        private Label label4;
        private TextBox txtFechaPrestamo;
    }
}