using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DPais
    {
        public void AdminPais(Entidades.EPais _Pais)
        {
            SqlConnection conexion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_Paises", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdPais", SqlDbType.Int).Value = _Pais.IdPais;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = _Pais.Nombre;
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = _Pais.I_Opcion;
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
                _Pais.O_Msg = cmd.Parameters["@O_msg"].Value.ToString();
                throw;
            }
        }
        public List<Entidades.EPais> GetAll()
        {
            SqlConnection conexion = Conexion.Abrir();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_Paises", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdPais", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = "S";
            cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100);
            cmd.Parameters["@O_msg"].Direction = ParameterDirection.Output;
            cmd.Connection = conexion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EPais> listaPaises = new List<Entidades.EPais>();
            while (leer.Read())
            {
                Entidades.EPais filaPaises = new Entidades.EPais();
                filaPaises.IdPais = Convert.ToInt32(leer["IdPais"].ToString());
                filaPaises.Nombre = leer["Nombre"].ToString();
                listaPaises.Add(filaPaises);
            }
            return listaPaises;
        }
    }
}
