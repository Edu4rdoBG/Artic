using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DBitacora
    {
        public void Insert(Entidades.EBitacora  Bitacora)
        {
            SqlConnection coneccion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_Bitacora", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = Bitacora.IdUser;
            cmd.Parameters.Add("@Accion", SqlDbType.NVarChar).Value = Bitacora.Accion;
            cmd.Parameters.Add("@Formulario", SqlDbType.NVarChar).Value = Bitacora.Formulario;
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Bitacora.Fecha;
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar).Value = Bitacora.I_Opcion;
            cmd.Parameters.Add("@O_msg", SqlDbType.VarChar).Value = "";
            try
            {
                coneccion.Open();
                cmd.ExecuteNonQuery();
                coneccion.Close();
            }
            catch (Exception) 
            {
                throw;
            }
        }
        public List<Entidades.EBitacora> GetAll()
        {
            SqlConnection coneccion = Conexion.Abrir();
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("SP_Bitacora", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Accion", SqlDbType.NVarChar).Value = "n";
            cmd.Parameters.Add("@Formulario", SqlDbType.NVarChar).Value = "n";
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Convert.ToDateTime("2018-02-15");
            cmd.Parameters.Add("@I_Opcion", SqlDbType.VarChar).Value = "S";
            cmd.Parameters.Add("@O_msg", SqlDbType.VarChar).Value = "";
            cmd.Connection = coneccion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EBitacora> listaBitacora = new List<Entidades.EBitacora>();
            while (leer.Read())
            {
                Entidades.EBitacora filaBitacora = new Entidades.EBitacora();
                filaBitacora.IdUser = Convert.ToInt32(leer["IdUser"].ToString());
                filaBitacora.Name_User = leer["Name_User"].ToString();
                filaBitacora.Accion = leer["Accion"].ToString();
                filaBitacora.Formulario = leer["Formulario"].ToString();
                filaBitacora.Fecha = Convert.ToDateTime(leer["Fecha"].ToString());
                listaBitacora.Add(filaBitacora);
            }
            return listaBitacora;
        }
        public List<Entidades.EBitacora> GetOne(int IdUser)
        {
            SqlConnection coneccion = Conexion.Abrir();
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("SP_TblBitacora_SelectUser", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = IdUser;
            cmd.Parameters.Add("@Accion", SqlDbType.NVarChar).Value = "n";
            cmd.Parameters.Add("@Formulario", SqlDbType.NVarChar).Value = "n";
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Convert.ToDateTime("2018-02-15");
            cmd.Connection = coneccion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EBitacora> listaBitacora = new List<Entidades.EBitacora>();
            while (leer.Read())
            {
                Entidades.EBitacora filaBitacora = new Entidades.EBitacora();
                filaBitacora.IdUser = Convert.ToInt32(leer["IdUser"].ToString());
                filaBitacora.Name_User = leer["Name_User"].ToString();
                filaBitacora.Accion = leer["Accion"].ToString();
                filaBitacora.Formulario = leer["Formulario"].ToString();
                filaBitacora.Fecha = Convert.ToDateTime(leer["Fecha"].ToString());
                listaBitacora.Add(filaBitacora);
            }
            return listaBitacora;
        }
    }
}
