using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Biblioteca.Clases;


namespace TP_Biblioteca
{
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla(string filtro = "")
        {
            string sql = @"SELECT L.CodLibro, L.Titulo, L.Edicion, A.Nombre AS Autor
                           FROM Libro L
                           JOIN Autor A ON L.CodAutor = A.CodAutor";

            if (!string.IsNullOrEmpty(filtro))
            {
                sql += " WHERE L.Titulo LIKE '%" + filtro + "%'";
            }

            DataTable tabla = db.Select(sql);
            GrillaLibros.DataSource = tabla;
        }

        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtTitulo.Text.Trim();
            CargarGrilla(texto);
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmLibroModificar frm = new FrmLibroModificar();
            frm.Show();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmLibroNuevo frm = new FrmLibroNuevo();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GrillaLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar.", "Atención");
                return;
            }

            int codLibro = Convert.ToInt32(GrillaLibros.SelectedRows[0].Cells["CodLibro"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Libro WHERE CodLibro = " + codLibro;
                db.Grabar(sql);
                MessageBox.Show("Libro eliminado correctamente.");
                CargarGrilla();
            }
        }
    }
}
