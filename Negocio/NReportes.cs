using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReportes
    {
        public List<Entidades.EReportes> ObtenerListaReportes(DateTime Inicio,DateTime Fin, string Report)
        {
            Datos.DReportes getReporte = new Datos.DReportes();
            return getReporte.GetAll(Inicio,Fin,Report);
        }
    }
}
