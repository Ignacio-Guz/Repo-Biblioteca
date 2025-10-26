using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Biblioteca;

namespace TP_Biblioteca.Clases
{
    internal class ClassLibro
    {
        public void InsertLibro(string Titulo, String Edicion, String AñoPubli, String CantTotal, string CantDisponible, int CodAutor, int CodEditorial, int CodCategoria)
        {
            string sql = $"insert into Libro(Titulo, Edicion, AñoPublicacion, CantidadTotal, CantidadDisponible, CodAutor, CodEditorial, CodCategoria) " +
                $"values ('{Titulo}','{Edicion}','{AñoPubli}','{CantTotal}','{CantDisponible}','{CodAutor}','{CodEditorial}','{CodCategoria}')";
            db.Grabar(sql);
        }
        public void UpdateLibro(string Titulo, String Edicion, String AñoPubli, String CantTotal, string CantDisponible, int CodAutor, int CodEditorial, int CodCategoria, int CodLibro)
        {
            string sql = $"update Libro set Titulo = '{Titulo}', Edicion = '{Edicion}', AñoPublicacion = '{AñoPubli}', CantidadTotal = '{CantTotal}'," +
                $" CantidadDisponible = '{CantDisponible}', CodAutor = '{CodAutor}', CodEditorial = '{CodEditorial}', CodCategoria = '{CodCategoria}'" +
                $" where CodLibro = {CodLibro}";
            db.Grabar(sql);
        }
        public static void CargarCombosLibro(ComboBox cmbCategoria, ComboBox cmbEditorial, ComboBox cmbAutor)
        {
            cmbCategoria.DataSource = db.Select("SELECT CodCategoria, Nombre FROM Categoria ORDER BY Nombre");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "CodCategoria";

            cmbEditorial.DataSource = db.Select("SELECT CodEditorial, Nombre FROM Editorial ORDER BY Nombre");
            cmbEditorial.DisplayMember = "Nombre";
            cmbEditorial.ValueMember = "CodEditorial";

            cmbAutor.DataSource = db.Select("SELECT CodAutor, (Nombre + ' ' + Apellido) AS Autor FROM Autor ORDER BY Nombre");
            cmbAutor.DisplayMember = "Autor";
            cmbAutor.ValueMember = "CodAutor";
        }

        // Cargar los datos de un libro en los controles del formulario
        public static void CargarDatosSeleccionadosLibro(
            int codLibro,
            TextBox txtCodLibro,
            TextBox txtTitulo,
            TextBox txtEdicion,
            TextBox txtAnioPublicacion,
            TextBox txtCantidadTotal,
            TextBox txtCantidadDisponible,
            ComboBox cmbCategoria,
            ComboBox cmbEditorial,
            ComboBox cmbAutor)
        {
            string sql = $"SELECT * FROM Libro WHERE CodLibro = {codLibro}";
            DataTable dt = db.Select(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                txtCodLibro.Text = fila["CodLibro"].ToString();
                txtTitulo.Text = fila["Titulo"].ToString();
                txtEdicion.Text = fila["Edicion"].ToString();
                txtAnioPublicacion.Text = fila["AñoPublicacion"].ToString();
                txtCantidadTotal.Text = fila["CantidadTotal"].ToString();
                txtCantidadDisponible.Text = fila["CantidadDisponible"].ToString();

                cmbCategoria.SelectedValue = Convert.ToInt32(fila["CodCategoria"]);
                cmbEditorial.SelectedValue = Convert.ToInt32(fila["CodEditorial"]);
                cmbAutor.SelectedValue = Convert.ToInt32(fila["CodAutor"]);
            }
            else
            {
                MessageBox.Show("No se encontró el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarComboLibro(ComboBox combo, string sql, string displayMember, string valueMember)
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
