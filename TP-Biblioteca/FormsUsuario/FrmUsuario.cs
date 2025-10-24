using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Biblioteca
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void BtmNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioNuevo frm = new FrmUsuarioNuevo();
            frm.Show();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUsuarioModificar frm = new FrmUsuarioModificar();
            frm.Show();
        }
    }
}
