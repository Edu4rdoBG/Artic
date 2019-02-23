using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DReportes
    {
        public List<Entidades.EReportes> GetAll(DateTime Inicio,DateTime Fin, string Report)
        {
            SqlConnection conexion = Conexion.Abrir();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(Report, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = Inicio;
            cmd.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = Fin;
            cmd.Connection = conexion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EReportes> listaReportes = new List<Entidades.EReportes>();
            while (leer.Read())
            {
                Entidades.EReportes filaReportes = new Entidades.EReportes();
                filaReportes.Reporte = leer["Report"].ToString();
                filaReportes.Domingo = leer["Domingo"].ToString();
                filaReportes.Lunes = leer["Lunes"].ToString();
                filaReportes.Martes = leer["Martes"].ToString();
                filaReportes.Miercoles = leer["Miercoles"].ToString();
                filaReportes.Jueves = leer["Jueves"].ToString();
                filaReportes.Viernes = leer["Viernes"].ToString();
                filaReportes.Sabado = leer["Sabado"].ToString();
                listaReportes.Add(filaReportes);
            }
            return listaReportes;
        }
    }
}
