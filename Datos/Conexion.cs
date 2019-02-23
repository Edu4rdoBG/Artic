using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public abstract class Conexion//forma mas segura agrega abstract
    {
        //Proteccion de conexion
        private readonly string CadenaConexion;
        public Conexion()
        {
            CadenaConexion = "Data Source=.; Initial Catalog = ArticBD; Integrated Security = True";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
        /// <summary>
        /// Forma rapida de conexion
        /// </summary>
        public static SqlConnection Abrir()
        {
            SqlConnection Conectar = new SqlConnection("Data Source=.; Initial Catalog = ArticBD; Integrated Security = True");
            return Conectar;
        }

    }
    

}
