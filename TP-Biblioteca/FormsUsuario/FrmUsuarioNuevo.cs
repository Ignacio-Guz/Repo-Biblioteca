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
    public partial class FrmUsuarioNuevo : Form
    {
        ClassUsuario CU = new ClassUsuario();
        public FrmUsuarioNuevo()
        {
            InitializeComponent();
        }
        private void FrmUsuarioNuevo_Load(object sender, EventArgs e)
        {
            CU.CargarComboUsuario(cmbTipoDoc, "SELECT CodTipoDoc, Tipo FROM TipoDoc", "Tipo", "CodTipoDoc");
            CU.CargarComboUsuario(cmbBarrio, "SELECT CodBarrio, Nombre FROM Barrio", "Nombre", "CodBarrio");
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Apellido = txtApellidos.Text;
            string Nombre = txtNombres.Text;
            string Documento = txtDocumento.Text;
            string Telefono = txtTelefono.Text;
            string Email = txtEmail.Text;
            string Calle = txtCalle.Text;
            string Altura = txtAltura.Text;
            int CodTipoDoc = Convert.ToInt32(cmbTipoDoc.SelectedValue);
            int CodBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            ClassUsuario CS = new ClassUsuario();
            CS.InsertUsuario(Nombre, Apellido, CodTipoDoc, Documento, Telefono, Email, CodBarrio, Calle, Altura);
            MessageBox.Show("Usuario Guardado con exito.");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void label10_Click(object sender, EventArgs e)
        {

        }

        
    }
}
