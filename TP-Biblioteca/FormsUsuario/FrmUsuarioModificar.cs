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
    public partial class FrmUsuarioModificar : Form
    {
        ClassUsuario CU = new ClassUsuario();
        int codUsuarioSeleccionado;
        public FrmUsuarioModificar(int codUsuario)
        {
            InitializeComponent();
            codUsuarioSeleccionado = codUsuario;
        }
        private void FrmUsuarioModificar_Load(object sender, EventArgs e)
        {
            ClassUsuario.CargarCombosUsuario(cmbTipoDoc, cmbBarrio);
            ClassUsuario.CargarDatosSeleccionadosUsuario(codUsuarioSeleccionado, txtCodUsuario, txtNombres,
            txtApellidos, cmbTipoDoc, txtDocumento, txtTelefono,
            txtEmail, cmbBarrio, txtCalle, txtAltura);
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
            CS.UpdateUsuario(codUsuarioSeleccionado, Nombre, Apellido, CodTipoDoc, Documento, Telefono, Email, CodBarrio, Calle, Altura);
            MessageBox.Show("Usuario actualizado con exito.");
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
