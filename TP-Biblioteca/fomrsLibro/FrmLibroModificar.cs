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
using TP_Biblioteca.AltasIndividuales;
using TP_Biblioteca.Clases;

namespace TP_Biblioteca
{
    public partial class FrmLibroModificar : Form
    {
        ClassLibro CL = new ClassLibro();
        int codLibroSeleccionado;
        public FrmLibroModificar(int CodLibro)
        {
            InitializeComponent();
            codLibroSeleccionado = CodLibro;
        }

        private void FrmLibroModificar_Load(object sender, EventArgs e)
        {
            ClassLibro.CargarCombosLibro(cmbCategoria, cmbEditorial, cmbAutor);
            ClassLibro.CargarDatosSeleccionadosLibro(codLibroSeleccionado, txtCodLibro, txtTitulo, txtEdicion, txtAñoPubli,
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
            CL.UpdateLibro(Titulo, Edicion, AñoPubli, CantTotal, CantDisponible, CodAutor, CodEditorial, CodCategoria, codLibroSeleccionado);
            MessageBox.Show("Libro actualizado con exito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            FrmEditorialNueva frmEN = new FrmEditorialNueva();
            frmEN.ShowDialog();
            ClassLibro.CargarCombosLibro(cmbCategoria, cmbEditorial, cmbAutor);
            ClassLibro.CargarDatosSeleccionadosLibro(codLibroSeleccionado, txtCodLibro, txtTitulo, txtEdicion, txtAñoPubli,
                txtCantTotal, txtCantDispo, cmbCategoria, cmbEditorial, cmbAutor);
        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            FrmAutorNuevo frmAN = new FrmAutorNuevo();
            frmAN.ShowDialog();
            ClassLibro.CargarCombosLibro(cmbCategoria, cmbEditorial, cmbAutor);
            ClassLibro.CargarDatosSeleccionadosLibro(codLibroSeleccionado, txtCodLibro, txtTitulo, txtEdicion, txtAñoPubli,
                txtCantTotal, txtCantDispo, cmbCategoria, cmbEditorial, cmbAutor);
        }
    }
}
