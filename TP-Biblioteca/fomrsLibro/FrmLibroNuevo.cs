using Microsoft.Data.SqlClient;
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
    public partial class FrmLibroNuevo : Form
    {
        ClassMetodos CM = new ClassMetodos();
        public FrmLibroNuevo()
        {
            InitializeComponent();
        }
        private void FrmLibroNuevo_Load(object sender, EventArgs e)
        {
            CM.CargarCombo(cmbCategoria, "SELECT CodCategoria, Nombre FROM Categoria", "Nombre", "CodCategoria");
            CM.CargarCombo(cmbEditorial, "SELECT CodEditorial, Nombre FROM Editorial", "Nombre", "CodEditorial");
            CM.CargarCombo(cmbAutor, "SELECT CodAutor, (Nombre + ' ' + Apellido) AS NombreCompleto FROM Autor", "NombreCompleto", "CodAutor");
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Titulo = txtTitulo.Text;
            string Edicion = txtEdicion.Text;
            string AñoPubli = txtAñoPubli.Text;
            string CantTotal = txtCantTotal.Text;
            string CantDisponible = CantTotal;
            int CodAutor = Convert.ToInt32(cmbAutor.SelectedValue);
            int CodEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);
            int CodCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            ClassLibro CL = new ClassLibro();
            CL.Insertar(Titulo, Edicion, AñoPubli, CantTotal, CantDisponible, CodAutor, CodEditorial, CodCategoria);
            MessageBox.Show("Libro guardado con exito.");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
