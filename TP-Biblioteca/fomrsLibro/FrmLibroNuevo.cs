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
        db db = new db();

        public FrmLibroNuevo()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Titulo = txtTitulo.Text;
            string Edicion = txtEdicion.Text;
            string AñoPubli = txtAñoPubli.Text;
            string CantTotal = txtCantTotal.Text;
            string CodAutor = txtCodAutor.Text;
            string CodEditorial = txtCodEditorial.Text;
            string CodCategoria = txtCodCategoria.Text;
            ClassLibro CL = new ClassLibro();
            CL.Insertar(Titulo, Edicion, AñoPubli, CantTotal, CodAutor, CodEditorial, CodCategoria);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
