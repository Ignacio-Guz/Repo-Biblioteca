using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Biblioteca.Clases;

namespace TP_Biblioteca
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
            CargarGrillaLibro();
            CargarGrillaUsuarios();
        }
        
        public void InsertPrestamo(DateTime FechaPrestamo, DateTime FechaDevolucion, int CodUsuario, int CodLibro)
        {
            string sql = $"insert into Prestamo(FechaPrestamo, FechaDevolucion, CodUsuario, CodLibro) " +
                $"values ('{FechaPrestamo}','{FechaDevolucion}',{CodUsuario},{CodLibro})";
            db.Grabar(sql);
        }
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string texto = txtDocumento.Text.Trim();
            CargarGrillaUsuarios(texto);
        }
        private void btnBuscarlibro_Click(object sender, EventArgs e)
        {
            string texto = txtTitulo.Text.Trim();
            CargarGrillaLibro(texto);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (grillaLibros.SelectedRows.Count == 0 || grillaLibros.SelectedRows.Count > 1 && 
                grillaUsuarios.SelectedRows.Count == 0 || grillaUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleccione un libro y un usuario", "Seleccion incoherente de elementos en la grilla");
                return;
            }
            
            DateTime FechaPrestamo = Convert.ToDateTime(txtFechaPrestamo.Text);
            DateTime FechaDevolucion = FechaPrestamo.AddDays(10);
            int CodUsuario = Convert.ToInt32(grillaUsuarios.CurrentRow.Cells["CodUsuario"].Value);
            int CodLibro = Convert.ToInt32(grillaLibros.CurrentRow.Cells["CodLibro"].Value); ;
            InsertPrestamo(FechaPrestamo, FechaDevolucion, CodUsuario, CodLibro);
            MessageBox.Show("Prestamo Guardado con exito.");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void CargarGrillaUsuarios(string filtro = "")//metodo interno
        {
            string sql = @"SELECT CodUsuario, Documento, Nombre, Apellido, Email 
                           FROM Usuario ";

            if (!string.IsNullOrEmpty(filtro))
            {
                sql += " WHERE Documento LIKE '%" + filtro + "%'";
            }

            DataTable tabla = db.Select(sql);
            grillaUsuarios.DataSource = tabla;
        }
        private void CargarGrillaLibro(string filtro = "")//metodo interno
        {
            string sql = @"SELECT L.CodLibro, L.Titulo, L.Edicion, A.Nombre AS Autor
                           FROM Libro L
                           JOIN Autor A ON L.CodAutor = A.CodAutor";

            if (!string.IsNullOrEmpty(filtro))
            {
                sql += " WHERE L.Titulo LIKE '%" + filtro + "%'";
            }

            DataTable tabla = db.Select(sql);
            grillaLibros.DataSource = tabla;
        }












        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
