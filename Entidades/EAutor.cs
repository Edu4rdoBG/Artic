using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EAutor
    {
        public int IdAutor { get; set; }
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public string I_Opcion { get; set; }
        public string O_Msg { get; set; }
        public EPais Pais { get; set; }
        public EAutor()
        {
            Pais = new EPais();
        }
    }
}
