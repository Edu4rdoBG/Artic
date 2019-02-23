using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPais
    {
        public void GuardarNuevo(Entidades.EPais pais)
        {
            if (pais.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre del pais");
            Datos.DPais guardarpais = new Datos.DPais();
            guardarpais.AdminPais(pais);
        }
        public List<Entidades.EPais> ObtenerListaPais()
        {
            Datos.DPais getUsuario = new Datos.DPais();
            return getUsuario.GetAll();
        }
        public void Modificar(Entidades.EPais pais)
        {
            if (pais.Nombre == "")
                throw new ArgumentException("Ingrese el Nombre del pais");
            Datos.DPais modificarpais = new Datos.DPais();
            modificarpais.AdminPais(pais);
        }
        public void Eliminar(Entidades.EPais pais)
        {
            Datos.DPais eliminarpais = new Datos.DPais();
            eliminarpais.AdminPais(pais);
        }
    }
}
