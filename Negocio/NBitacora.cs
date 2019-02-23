using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NBitacora
    {
        public void GuardarNuevo(Entidades.EBitacora Bitacora)
        {
            if (Bitacora.IdUser == 0)
                throw new ArgumentException("No se encontro el usuario");
            Datos.DBitacora guardarBitacora = new Datos.DBitacora();
            guardarBitacora.Insert(Bitacora);
        }
        public List<Entidades.EBitacora> ObtenerBitacora()
        {
            Datos.DBitacora getUsuario = new Datos.DBitacora();
            return getUsuario.GetAll();
        }
        public List<Entidades.EBitacora> ObtenerBitacoraUsuario(int IdUser)
        {
            Datos.DBitacora getbitacora = new Datos.DBitacora();
            return getbitacora.GetOne(IdUser);
        }
    }
}
