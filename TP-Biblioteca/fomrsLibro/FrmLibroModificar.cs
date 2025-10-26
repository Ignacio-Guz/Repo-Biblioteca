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
    public partial class FrmLibroModificar : Form
    {
        ClassMetodos CM = new ClassMetodos();
        int codLibroSeleccionado;
        public FrmLibroModificar(int CodLibro)
        {
            InitializeComponent();
            codLibroSeleccionado = CodLibro;
        }

        private void FrmLibroModificar_Load(object sender, EventArgs e)
        {
            ClassMetodos.CargarCombos(cmbCategoria, cmbEditorial, cmbAutor);
            ClassMetodos.CargarDatosLibro(codLibroSeleccionado, txtCodLibro, txtTitulo, txtEdicion, txtAñoPubli,
                txtCantTotal, txtCantDispo, cmbCategoria, cmbEditorial, cmbAutor);
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
            CL.Update(Titulo, Edicion, AñoPubli, CantTotal, CantDisponible, CodAutor, CodEditorial, CodCategoria, codLibroSeleccionado);
            MessageBox.Show("Libro actualizado con exito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
