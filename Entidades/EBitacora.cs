using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EBitacora
    {
        public int IdUser { get; set; }
        public string Name_User { get; set; }
        public string Accion { get; set; }
        public string Formulario { get; set; }
        public DateTime Fecha { get; set; }
        public string I_Opcion { get; set; }
        public string O_msg { get; set; }
    }
}
