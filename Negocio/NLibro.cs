using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NLibro
    {
        public void GuardarNuevo(Entidades.ELibro libro)
        {
            if (libro.ISBN == "")
                throw new ArgumentException("Ingrese el ISBN del Libro");
            if (libro.Titulo == "")
                throw new ArgumentException("Ingrese el Titulo del Libro");
            if (libro.Editorial == "")
                throw new ArgumentException("Ingrese el Editorial del Libro");
            if (libro.Coleccion == "")
                throw new ArgumentException("Ingrese la Coleccion del Libro");
            if (libro.Tematica == "")
                throw new ArgumentException("Ingrese la Tematica del Libro");
            if (libro.Paginas == 0)
                throw new ArgumentException("Ingrese la cantidad de paginas del Libro");
            if (libro.Cantidad == 0)
                throw new ArgumentException("Ingrese la cantidad de Libros en existencias");
            if (libro.Categoria.IdCategoria == 0)
                throw new ArgumentException("Seleccione la categoria del Libro");
            if (libro.Autor.IdAutor == 0)
                throw new ArgumentException("Seleccione el Autor del Libro");
            Datos.DLibro guardarautor = new Datos.DLibro();
            guardarautor.AdminLibro(libro);
        }
        public List<Entidades.ELibro> ObtenerListaLibro()
        {
            Datos.DLibro getlibro = new Datos.DLibro();
            return getlibro.GetAll();
        }
        public void Modificar(Entidades.ELibro libro)
        {
            if (libro.ISBN == "")
                throw new ArgumentException("Ingrese el ISBN del Libro");
            if (libro.Titulo == "")
                throw new ArgumentException("Ingrese el Titulo del Libro");
            if (libro.Editorial == "")
                throw new ArgumentException("Ingrese el Editorial del Libro");
            if (libro.Coleccion == "")
                throw new ArgumentException("Ingrese la Coleccion del Libro");
            if (libro.Tematica == "")
                throw new ArgumentException("Ingrese la Tematica del Libro");
            if (libro.Paginas == 0)
                throw new ArgumentException("Ingrese la cantidad de paginas del Libro");
            if (libro.Cantidad == 0)
                throw new ArgumentException("Ingrese la cantidad de Libros en existencias");
            if (libro.Categoria.IdCategoria == 0)
                throw new ArgumentException("Seleccione la categoria del Libro");
            if (libro.Autor.IdAutor == 0)
                throw new ArgumentException("Seleccione el Autor del Libro");
            Datos.DLibro modificarautor = new Datos.DLibro();
            modificarautor.AdminLibro(libro);
        }
        public void Eliminar(Entidades.ELibro libro)
        {
            if (libro.ISBN == "")
                throw new ArgumentException("Ningun Libro seleccionada para eliminar");
            Datos.DLibro eliminarcategoria = new Datos.DLibro();
            eliminarcategoria.AdminLibro(libro);
        }
    }
}
