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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla(string filtro = "")
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
        private void BtmBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtDocumento.Text.Trim();
            CargarGrilla(texto);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (grillaUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para modificar.", "Ningun usuario seleccionado");
                return;
            }
            int codUsuario = Convert.ToInt32(grillaUsuarios.CurrentRow.Cells["CodUsuario"].Value);
            FrmUsuarioModificar frm = new FrmUsuarioModificar(codUsuario);
            frm.ShowDialog();
            CargarGrilla();
        }
        private void BtmNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioNuevo frm = new FrmUsuarioNuevo();
            frm.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grillaUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Ningun usuario seleccionado");
                return;
            }

            int codUsuario = Convert.ToInt32(grillaUsuarios.SelectedRows[0].Cells["CodUsuario"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Prestamo WHERE CodUsuario = " + codUsuario +
                             "DELETE FROM Usuario WHERE CodUsuario = " + codUsuario; //borra al usuario y a los prestamos a los que este relacionado
                db.Grabar(sql);
                MessageBox.Show("Usuario eliminado correctamente.");
                CargarGrilla();
            }
        }
        
    }
}
