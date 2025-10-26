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

namespace TP_Biblioteca.AltasIndividuales
{
    public partial class FrmEditorialNueva : Form
    {
        public FrmEditorialNueva()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void InsertarEditorial(string Nombre, string Email, string Telefono)
        {
            string sql = $"insert into Editorial(Nombre, Email, Telefono) " +
                $"values ('{Nombre}','{Email}','{Telefono}')";
            db.Grabar(sql);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Email = txtEmail.Text;
            string Telefono = txtTelefono.Text;
            InsertarEditorial(Nombre, Email, Telefono);
            MessageBox.Show("Editorial guardada con exito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
