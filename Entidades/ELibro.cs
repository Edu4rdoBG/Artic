using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ELibro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Tematica { get; set; }
        public string Coleccion { get; set; }
        public int Paginas { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public EAutor Autor { get; set; }
        public ECategoria Categoria { get; set; }
        public EPais Pais { get; set; }
        public string I_Opcion { get; set; }
        public string O_Msg { get; set; }
        public ELibro()
        {
            Autor = new EAutor();
            Pais = new EPais();
            Categoria = new ECategoria();
        }
    }
}
