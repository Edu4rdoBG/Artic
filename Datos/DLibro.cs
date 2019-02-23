using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DLibro
    {
            public void AdminLibro(Entidades.ELibro _Libro)
            {
                SqlConnection conexion = Conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_Libros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar,10).Value = _Libro.ISBN;
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = _Libro.Categoria.IdCategoria;
                cmd.Parameters.Add("@IdAutor", SqlDbType.Int).Value = _Libro.Autor.IdAutor;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar, 100).Value = _Libro.Titulo;
                cmd.Parameters.Add("@Editorial", SqlDbType.VarChar, 150).Value = _Libro.Editorial;
                cmd.Parameters.Add("@Tematica", SqlDbType.VarChar, 150).Value = _Libro.Tematica;
                cmd.Parameters.Add("@Coleccion", SqlDbType.VarChar, 150).Value = _Libro.Coleccion;
                cmd.Parameters.Add("@Paginas", SqlDbType.Int).Value = _Libro.Paginas;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = _Libro.Cantidad;
                cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = _Libro.I_Opcion;
                cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100);
                cmd.Parameters["@O_msg"].Direction = ParameterDirection.Output;
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception)
                {
                    //_Libro.O_Msg = cmd.Parameters["@O_msg"].Value.ToString();
                    throw;
                }
            }
            public List<Entidades.ELibro> GetAll()
            {
                SqlConnection conexion = Conexion.Abrir();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_Libros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar,10).Value = "";
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@IdAutor", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar, 100).Value = "";
                cmd.Parameters.Add("@Editorial", SqlDbType.VarChar, 150).Value = "";
                cmd.Parameters.Add("@Tematica", SqlDbType.VarChar, 150).Value = "";
                cmd.Parameters.Add("@Coleccion", SqlDbType.VarChar, 150).Value = "";
                cmd.Parameters.Add("@Paginas", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = "S";
                cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100);
                cmd.Parameters["@O_msg"].Direction = ParameterDirection.Output;
                cmd.Connection = conexion;
                SqlDataReader leer = cmd.ExecuteReader();
                List<Entidades.ELibro> listaLibro = new List<Entidades.ELibro>();
                while (leer.Read())
                {
                    Entidades.ELibro filaLibro = new Entidades.ELibro();
                    filaLibro.ISBN = leer["ISBN"].ToString();
                    filaLibro.Categoria.IdCategoria = Convert.ToInt32(leer["IdCategoria"].ToString());
                    filaLibro.Autor.IdAutor = Convert.ToInt32(leer["IdAutor"].ToString());
                    filaLibro.Titulo = leer["Titulo"].ToString();
                    filaLibro.Editorial = leer["Editorial"].ToString();
                    filaLibro.Tematica = leer["Tematica"].ToString();
                    filaLibro.Coleccion = leer["Coleccion"].ToString();
                    filaLibro.Autor.Nombre = leer["Autor"].ToString();
                    filaLibro.Categoria.Nombre = leer["Categoria"].ToString();
                    filaLibro.Pais.Nombre = leer["Pais"].ToString();
                    filaLibro.Paginas = Convert.ToInt32(leer["Paginas"].ToString());
                    filaLibro.Cantidad = Convert.ToInt32(leer["Cantidad"].ToString());
                    filaLibro.Fecha = Convert.ToDateTime(leer["Fecha"].ToString());
                    listaLibro.Add(filaLibro);
                }
                return listaLibro;
            }
        }
}
