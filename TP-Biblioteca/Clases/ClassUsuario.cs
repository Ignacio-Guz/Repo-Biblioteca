using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Biblioteca.Clases
{
    internal class ClassUsuario
    {
        public void InsertUsuario(string Nombre, string Apellido, int CodTipoDoc, string Documento, string Telefono, 
            string Email, int CodBarrio, string Calle, string Altura)
        {
            string sql = $"insert into Usuario(Nombre, Apellido, CodTipoDoc, Documento, Telefono, Email, CodBarrio, Calle, Altura) " +
                $"values ('{Nombre}','{Apellido}', {CodTipoDoc},'{Documento}','{Telefono}','{Email}',{CodBarrio},'{Calle}', '{Altura}')";
            db.Grabar(sql);
        }
        public void UpdateUsuario(int CodUsuario, string Nombre, string Apellido, int CodTipoDoc, 
            string Documento, string Telefono, string Email, int CodBarrio, string Calle, string Altura)
        {
            string sql = $"update Usuario set  Nombre = '{Nombre}', Apellido = '{Apellido}', CodTipoDoc = {CodTipoDoc}, Documento = '{Documento}'," +
                $" Telefono = '{Telefono}', Email = '{Email}', CodBarrio = {CodBarrio}, Calle = '{Calle}', Altura = '{Altura}'" +
                $" where CodUsuario = {CodUsuario}";
            db.Grabar(sql);
        }


        public static void CargarCombosUsuario(ComboBox cmbTipoDoc, ComboBox cmbBarrio)
        {
            cmbTipoDoc.DataSource = db.Select("SELECT CodTipoDoc, Tipo FROM TipoDoc ORDER BY Tipo");
            cmbTipoDoc.DisplayMember = "Tipo";
            cmbTipoDoc.ValueMember = "CodTipoDoc";

            cmbBarrio.DataSource = db.Select("SELECT CodBarrio, Nombre FROM Barrio ORDER BY Nombre");
            cmbBarrio.DisplayMember = "Nombre";
            cmbBarrio.ValueMember = "CodBarrio";
        }

        // Cargar los datos de un libro en los controles del formulario
        public static void CargarDatosSeleccionadosUsuario(int codUsuario, TextBox txtCodUsuario, TextBox txtNombres, 
            TextBox txtApellidos, ComboBox cmbTipoDoc, TextBox txtDocumento, TextBox txtTelefono, 
            TextBox txtEmail, ComboBox cmbBarrio, TextBox txtCalle, TextBox txtAltura)
        {
            string sql = $"SELECT * FROM Usuario WHERE CodUsuario = {codUsuario}";
            DataTable dt = db.Select(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                txtCodUsuario.Text = fila["CodUsuario"].ToString();
                txtNombres.Text = fila["Nombre"].ToString();
                txtApellidos.Text = fila["Apellido"].ToString();
                txtDocumento.Text = fila["Documento"].ToString();
                txtTelefono.Text = fila["Telefono"].ToString();
                txtEmail.Text = fila["Email"].ToString();
                txtCalle.Text = fila["Calle"].ToString();
                txtAltura.Text = fila["Altura"].ToString();

                cmbTipoDoc.SelectedValue = Convert.ToInt32(fila["CodTipoDoc"]);
                cmbBarrio.SelectedValue = Convert.ToInt32(fila["CodBarrio"]);
            }
            else
            {
                MessageBox.Show("No se encontró el Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        public void CargarComboUsuario(ComboBox combo, string sql, string displayMember, string valueMember)
        {
            DataTable tabla = new DataTable();
            tabla = db.Select(sql);

            combo.DataSource = tabla;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

            // Permitir escribir y buscar
            combo.DropDownStyle = ComboBoxStyle.DropDown;
            combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Llenar autocompletado
            AutoCompleteStringCollection datosAuto = new AutoCompleteStringCollection();
            foreach (DataRow fila in tabla.Rows)
            {
                datosAuto.Add(fila[displayMember].ToString());
            }
            combo.AutoCompleteCustomSource = datosAuto;
        }
    }
}
