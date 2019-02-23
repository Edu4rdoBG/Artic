using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPais : Form
    {
        string accion = "";
        Entidades.EPais Pais = new Entidades.EPais();
        DOTA Logged = DOTA.Instance();

        public FrmPais()
        {
            InitializeComponent(); Logged.Limpiartextbox(gpnlControl);
        }
        private void FrmPaises_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        /// <summary>
        /// Controles
        /// </summary>
        private void gvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pais.IdPais = Convert.ToInt32(gvPais.Rows[e.RowIndex].Cells["IdPais"].Value.ToString());
            Pais.Nombre = gvPais.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            btnEditar.Visible = true; btnEliminar.Visible = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar los datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Entidades.EPais eliminarPais = new Entidades.EPais();
                        eliminarPais.IdPais = Pais.IdPais;
                        eliminarPais.Nombre = Pais.Nombre;
                        eliminarPais.I_Opcion = "D";
                        Negocio.NPais negocioPais = new Negocio.NPais();
                        negocioPais.Eliminar(eliminarPais);
                        Logged.GuardarBitacora("Elimino Pais: " + Pais.IdPais + "|" + Pais.Nombre, "Paises");
                        CargarGrid();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnEditar.Visible = false; btnEliminar.Visible = false;
            CargarGrid();
            Logged.Limpiartextbox(gpnlControl);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "E";
            txtPais.Text = Pais.Nombre;
            gpnlControl.Visible = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "N";
            gpnlControl.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "N")
            {
                try
                {
                    Pais.I_Opcion = "I"; Guardar(); MessageBox.Show("Se guardo correctamente"); ;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea modificar los datos?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { Pais.I_Opcion = "U"; Guardar(); MessageBox.Show("Se modifico correctamente"); }
                    else { }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            CargarGrid();
            gpnlControl.Visible = false;
            Logged.Limpiartextbox(gpnlControl);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpnlControl.Visible = false; btnEditar.Visible = false; btnEliminar.Visible = false;
            Logged.Limpiartextbox(gpnlControl);
        }
        /// <summary>
        /// Metodos
        /// </summary>
        private void CargarGrid()
        {
            try
            {
                Negocio.NPais negocioCliente = new Negocio.NPais();
                List<Entidades.EPais> lista = negocioCliente.ObtenerListaPais();
                var resulta = (from e in lista
                               select new { e.IdPais, e.Nombre }).ToList();
                gvPais.DataSource = null;
                gvPais.DataSource = resulta;
                gvPais.Columns["IdPais"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Guardar()
        {
            Pais.Nombre = txtPais.Text.Trim();
            Negocio.NPais NuevoPais = new Negocio.NPais();
            NuevoPais.GuardarNuevo(Pais);
            btnEditar.Visible = false; btnEliminar.Visible = false;
        }
    }
}
