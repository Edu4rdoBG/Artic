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
    public partial class FrmCategoria : Form
    {
        string accion = "";
        Entidades.ECategoria Categoria = new Entidades.ECategoria();
        DOTA Logged = DOTA.Instance();
        public FrmCategoria()
        {
            InitializeComponent(); Logged.Limpiartextbox(gpnlControl);
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        /// <summary>
        /// Controles
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "N";
            gpnlControl.Visible = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar los datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Entidades.ECategoria eliminarCategoria = new Entidades.ECategoria();
                        eliminarCategoria.IdCategoria = Categoria.IdCategoria;
                        eliminarCategoria.Nombre = Categoria.Nombre;
                        eliminarCategoria.I_Opcion = "D";
                        Negocio.NCategoria negocioCategoria = new Negocio.NCategoria();
                        negocioCategoria.Eliminar(eliminarCategoria);
                        Logged.GuardarBitacora("Elimino Categoria: " + Categoria.IdCategoria + "|" + Categoria.Nombre, "Categorias");
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
            txtCategoria.Text = Categoria.Nombre;
            gpnlControl.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "N")
            {
                try
                {
                    Categoria.I_Opcion = "I"; Guardar(); MessageBox.Show("Se guardo correctamente"); ;
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
                    { Categoria.I_Opcion = "U"; Guardar(); MessageBox.Show("Se modifico correctamente"); }
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
        private void gvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria.IdCategoria = Convert.ToInt32(gvCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value.ToString());
            Categoria.Nombre = gvCategoria.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            btnEditar.Visible = true; btnEliminar.Visible = true;
        }
        /// <summary>
        /// Metodos
        /// </summary>
        private void CargarGrid()
        {
            try
            {
                Negocio.NCategoria negocioCategoria = new Negocio.NCategoria();
                List<Entidades.ECategoria> lista = negocioCategoria.ObtenerListaCategoria();
                var resulta = (from e in lista
                               select new { e.IdCategoria, e.Nombre }).ToList();
                gvCategoria.DataSource = null;
                gvCategoria.DataSource = resulta;
                gvCategoria.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Guardar()
        {
            Categoria.Nombre = txtCategoria.Text.Trim();
            Negocio.NCategoria NuevoCategoria = new Negocio.NCategoria();
            NuevoCategoria.GuardarNuevo(Categoria);
            btnEditar.Visible = false; btnEliminar.Visible = false;
        }
    }
}
