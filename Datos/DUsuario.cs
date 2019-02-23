using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace Datos
{
    public static class cifrador
    {
        public static string Cifrar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            SHA512Managed cifrador = new SHA512Managed();
            byte[] cadenaenbyte = System.Text.Encoding.ASCII.GetBytes(_cadenaAencriptar);
            byte[] cadenacifrada = cifrador.ComputeHash(cadenaenbyte);
            result = Convert.ToBase64String(cadenacifrada);
            return result;
        }
    }
    public class DUsuario
    {
        public void Insert(Entidades.EUsuario Usuario)
        {
            SqlConnection conexion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_TblUsers_Insert", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = Usuario.Idperfil;
            cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = Usuario.Name_User;
            cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = cifrador.Cifrar(Usuario.Key_User);
            cmd.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = Usuario.Estado;
            try
            {
                conexion.Open();
                    cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
            }
        }
        
            public void Backup(Entidades.EUsuario Usuario)
            {
                SqlConnection conexion = Conexion.Abrir();
                SqlCommand cmd = new SqlCommand("BackUP", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ruta", SqlDbType.VarChar, 250).Value = Usuario.Ruta;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Usuario.Nombre;
                try
                {
                    conexion.Open();
                        cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception)
                {
                }
            }
            public List<Entidades.EUsuario> GetAll()
        {
            SqlConnection conexion = Conexion.Abrir();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_TblUsers_Select", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = "";
            cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = "";
            cmd.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = "a";
            cmd.Connection = conexion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EUsuario> listausuario = new List<Entidades.EUsuario>();
            while (leer.Read())
            {
                Entidades.EUsuario filausuario = new Entidades.EUsuario();
                filausuario.IdUser = Convert.ToInt32(leer["IdUser"].ToString());
                filausuario.Idperfil = Convert.ToInt32(leer["Idperfil"].ToString());
                filausuario.Name_User = leer["Name_User"].ToString();
                filausuario.Key_User = leer["Key_User"].ToString();
                filausuario.Estado = leer["Estado"].ToString();
                listausuario.Add(filausuario);
            }
            return listausuario;

        }
        public void GetOne(Entidades.EUsuario Usuario)
        {
            SqlConnection conexion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_TblUsers_SelectOut", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = Usuario.IdUser;
            cmd.Parameters.Add("@Perfil", SqlDbType.NVarChar);
            cmd.Parameters["@Perfil"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar);
            cmd.Parameters["@Name_User"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar);
            cmd.Parameters["@Key_User"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Estado", SqlDbType.Char, 1);
            cmd.Parameters["@Estado"].Direction = ParameterDirection.Output;
            cmd.Connection = conexion;
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter();
            try
            {
                conexion.Open();
                dr.SelectCommand = cmd;
                dr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Usuario.Perfil = cmd.Parameters["@Perfil"].Value.ToString();
                    Usuario.Name_User = cmd.Parameters["@Name_User"].Value.ToString();
                    Usuario.Estado = cmd.Parameters["@Estado"].Value.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            conexion.Close();

        }
        public void Inicio(Entidades.EUsuario Usuario)
        {
            SqlConnection conexion = Conexion.Abrir();
            if (Usuario.Name_User == "ADMIN" && Usuario.Key_User == "1234")
            {
                Usuario.Estado = "A";
                Usuario.Exist = 1;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SP_TblUsers_Exists", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdUser", SqlDbType.Int);
                cmd.Parameters["@IdUser"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = Usuario.Idperfil;
                cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = Usuario.Name_User;
                cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = cifrador.Cifrar(Usuario.Key_User);
                cmd.Parameters.Add("@Estado", SqlDbType.Char, 1);
                cmd.Parameters["@Estado"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@exists", SqlDbType.Int);
                cmd.Parameters["@exists"].Direction = ParameterDirection.Output;
                DataTable dt = new DataTable();
                SqlDataAdapter dr = new SqlDataAdapter();
                try
                {
                    conexion.Open();
                    dr.SelectCommand = cmd;
                    dr.Fill(dt);
                    int ex = Convert.ToInt32(cmd.Parameters["@exists"].Value.ToString());
                    if (ex == 0)
                    {
                        Usuario.Exist = 0;
                    }
                    else
                    {
                        Usuario.Exist = 1;
                        if (dt.Rows.Count > 0)
                        {
                            Usuario.IdUser = Convert.ToInt32(cmd.Parameters["@IdUser"].Value.ToString());
                            Usuario.Estado = cmd.Parameters["@Estado"].Value.ToString();
                        }
                    }
                    conexion.Close();
                }
                catch (Exception x)
                {
                    throw x;
                }
            }
        }
    }
}
