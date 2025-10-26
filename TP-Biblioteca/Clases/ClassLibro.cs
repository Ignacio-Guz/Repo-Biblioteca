using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_Biblioteca.Clases
{
    internal class ClassLibro
    {        
        public DataTable Buscar(string Titulo)
        {
            string sql = $"select * From Libro ";
            DataTable tabla = db.Select(sql);
            return tabla;
        }
        public void Insertar(string Titulo, String Edicion, String AñoPubli, String CantTotal, string CantDisponible, int CodAutor, int CodEditorial, int CodCategoria)
        {
            string sql = $"insert into Libro(Titulo, Edicion, AñoPublicacion, CantidadTotal, CantidadDisponible, CodAutor, CodEditorial, CodCategoria) " +
                $"values ('{Titulo}','{Edicion}','{AñoPubli}','{CantTotal}','{CantDisponible}','{CodAutor}','{CodEditorial}','{CodCategoria}')";
            db.Grabar(sql);
        }
        public void Update(string Titulo, String Edicion, String AñoPubli, String CantTotal, string CantDisponible, int CodAutor, int CodEditorial, int CodCategoria, int CodLibro)
        {
            string sql = $"update Libro set Titulo = '{Titulo}', Edicion = '{Edicion}', AñoPublicacion = '{AñoPubli}', CantidadTotal = '{CantTotal}'," +
                $" CantidadDisponible = '{CantDisponible}', CodAutor = '{CodAutor}', CodEditorial = '{CodEditorial}', CodCategoria = '{CodCategoria}'" +
                $" where CodLibro = {CodLibro}";
            db.Grabar(sql);
        }
    }
}
