using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAutor
    {
        public void GuardarNuevo(Entidades.EAutor autor)
        {
            if (autor.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre del autor");
            Datos.DAutor guardarautor = new Datos.DAutor();
            guardarautor.AdminAutor(autor);
        }
        public List<Entidades.EAutor> ObtenerListaAutor()
        {
            Datos.DAutor getautor = new Datos.DAutor();
            return getautor.GetAll();
        }
        public void Modificar(Entidades.EAutor autor)
        {
            if (autor.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre del autor");
            Datos.DAutor modificarautor = new Datos.DAutor();
            modificarautor.AdminAutor(autor);
        }
        public void Eliminar(Entidades.EAutor autor)
        {
            if (autor.IdAutor == 0)
                throw new ArgumentException("Ningun autor seleccionada para eliminar");
            Datos.DAutor eliminarcategoria = new Datos.DAutor();
            eliminarcategoria.AdminAutor(autor);
        }
    }
}
