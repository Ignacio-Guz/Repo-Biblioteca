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
        public void Insertar(string Titulo, String Edicion, String AñoPubli, String CantTotal, String CodAutor, String CodEditorial, String CodCategoria)
        {
            //insert into Cliente(Nombre, Apellido, NroDoc) values ('Diego','Gomez','45343775')  --> esto es un ejemplo
            string sql = $"insert into Libro(Titulo, Edicion, AñoPublicacion, CantidadTotal, CodAutor, CodEditorial, CodCategoria) " +
                $"values ('{Titulo}','{Edicion}','{AñoPubli}','{CantTotal}','{CodAutor}','{CodEditorial}','{CodCategoria})";
            db.Grabar(sql);
        }

    }
}
