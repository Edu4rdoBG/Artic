using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCategoria
    {
        public void GuardarNuevo(Entidades.ECategoria categoria)
        {
            if (categoria.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre de la categoria");
            Datos.DCategoria guardarcategoria = new Datos.DCategoria();
            guardarcategoria.AdminCategoria(categoria);
        }
        public List<Entidades.ECategoria> ObtenerListaCategoria()
        {
            Datos.DCategoria getcategoria = new Datos.DCategoria();
            return getcategoria.GetAll();
        }
        public void Modificar(Entidades.ECategoria categoria)
        {
            if (categoria.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre de la categoria");
            Datos.DCategoria modificarcategoria = new Datos.DCategoria();
            modificarcategoria.AdminCategoria(categoria);
        }
        public void Eliminar(Entidades.ECategoria categoria)
        {
            if (categoria.IdCategoria == 0)
                throw new ArgumentException("Ninguna categoria seleccionada para eliminar");
            Datos.DCategoria eliminarcategoria = new Datos.DCategoria();
            eliminarcategoria.AdminCategoria(categoria);
        }
    }
}
