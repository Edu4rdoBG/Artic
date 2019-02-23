using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAutor : Conexion
    {
        public void AdminAutor(Entidades.EAutor _Autor)
        {
            using (var Conexion = ObtenerConexion())
            {
                Conexion.Open();
                using (var cmd = new SqlCommand("SP_Autores", Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = _Autor.Nombre;
                    cmd.Parameters.Add("@IdAutor", SqlDbType.Int).Value = _Autor.IdAutor;
                    cmd.Parameters.Add("@IdPais", SqlDbType.Int).Value = _Autor.Pais.IdPais;
                    cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = _Autor.I_Opcion;
                    cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100).Value = "";
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        //_Autor.O_Msg = cmd.Parameters["@O_msg"].Value.ToString();
                        throw;
                    }
                }
            }
        }
        public List<Entidades.EAutor> GetAll()
        {
            using (var Conexion = ObtenerConexion())
            {
                Conexion.Open();
                using (var cmd = new SqlCommand("SP_Autores", Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdAutor", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@IdPais", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "";
                    cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = "S";
                    cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100);
                    cmd.Parameters["@O_msg"].Direction = ParameterDirection.Output;
                    SqlDataReader leer = cmd.ExecuteReader();
                    List<Entidades.EAutor> listaPaises = new List<Entidades.EAutor>();
                    while (leer.Read())
                    {
                        Entidades.EAutor filaPaises = new Entidades.EAutor();
                        filaPaises.IdAutor = Convert.ToInt32(leer["IdAutor"].ToString());
                        filaPaises.IdPais = Convert.ToInt32(leer["IdPais"].ToString());
                        filaPaises.Pais.IdPais = Convert.ToInt32(leer["IdPais"].ToString());
                        filaPaises.Pais.Nombre = leer["Pais"].ToString();
                        filaPaises.Nombre = leer["Nombre"].ToString();
                        listaPaises.Add(filaPaises);
                    }
                    return listaPaises;
                }
            }
        }
    }
}
