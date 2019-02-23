using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Presentacion
{
    public class DOTA
    {
        private static DOTA datos;

        private DOTA()
        {
        }

        public static DOTA Instance()
        {
            if (datos == null)
            {
                datos = new DOTA();
            }

            return datos;
        }

        public int IdUser { get; set; }
        public string Name_User { get; set; }
        public int Id { get; set; }
        public int IdAutor { get; set; }
        public string Pais { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string precio { get; set; }
        public string QuienLlama { get; set; }
        public bool Cargar { get; set; }
        //Metodo global para guardar bitacora
        public void GuardarBitacora(string Accion,string Formulario)
        {
            Entidades.EBitacora Bitacora = new Entidades.EBitacora();
            Bitacora.IdUser = IdUser; Bitacora.Accion = Accion; Bitacora.Formulario = Formulario; Bitacora.Fecha = DateTime.Now;Bitacora.I_Opcion = "I";
            Negocio.NBitacora Bit = new Negocio.NBitacora(); Bit.GuardarNuevo(Bitacora);
        }
        
        public  void Limpiartextbox(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item is ns1.BunifuMaterialTextbox)
                    {
                        ((ns1.BunifuMaterialTextbox)item).Text ="";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
