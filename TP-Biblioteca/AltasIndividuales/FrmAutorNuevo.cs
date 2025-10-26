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
    public partial class FrmAutorNuevo : Form
    {
        public FrmAutorNuevo()
        {
            InitializeComponent();
        }
        private void InsertarAutor(string Nombre, string Apellido)
        {
            string sql = $"insert into Autor(Apellido, Nombre) " +
                $"values ('{Apellido}','{Nombre}')";
            db.Grabar(sql);
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            string Nombre = txtNombres.Text;
            string Apellido = txtApellidos.Text;
            InsertarAutor(Nombre, Apellido);
            MessageBox.Show("Autor guardado con exito.");
            this.Close();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        private void FrmAutorNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
