using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DCategoria
    {
        public void AdminCategoria(Entidades.ECategoria _Categoria)
        {
            SqlConnection conexion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = _Categoria.IdCategoria;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = _Categoria.Nombre;
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = _Categoria.I_Opcion;
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
                _Categoria.O_Msg = cmd.Parameters["@O_msg"].Value.ToString();
                throw;
            }
        }
        public List<Entidades.ECategoria> GetAll()
        {
            SqlConnection conexion = Conexion.Abrir();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar, 1).Value = "S";
            cmd.Parameters.Add("@O_msg", SqlDbType.VarChar, 100);
            cmd.Parameters["@O_msg"].Direction = ParameterDirection.Output;
            cmd.Connection = conexion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.ECategoria> listaCategoria = new List<Entidades.ECategoria>();
            while (leer.Read())
            {
                Entidades.ECategoria filaCategoria = new Entidades.ECategoria();
                filaCategoria.IdCategoria = Convert.ToInt32(leer["IdCategoria"].ToString());
                filaCategoria.Nombre = leer["Nombre"].ToString();
                listaCategoria.Add(filaCategoria);
            }
            return listaCategoria;
        }
    }
}
