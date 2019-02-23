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
    public partial class FrmAutor : Form
    {
        string accion=""; 

        Entidades.EAutor Autor = new Entidades.EAutor();
        DOTA Logged = DOTA.Instance();

        public FrmAutor()
        {
            InitializeComponent(); Logged.Limpiartextbox(gpnlControl);
        }
        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CargarGrid(); CargarCombobox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpnlControl.Visible = false; btnEditar.Visible = false;btnEliminar.Visible = false;
            Logged.Limpiartextbox(gpnlControl);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "N";
            gpnlControl.Visible = true;
        }
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion=="N")
            {
                try{ Autor.I_Opcion = "I";Guardar(); MessageBox.Show("Se guardo correctamente"); ;
                }catch (Exception){
                    throw;}
            }
            else
            {
                try{
                    if (MessageBox.Show("¿Seguro que desea modificar los datos?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {Autor.I_Opcion = "U"; Guardar(); MessageBox.Show("Se modifico correctamente");}
                    else{}
                }
                catch (Exception){
                    throw;}
            }
            CargarGrid();
            gpnlControl.Visible = false;
            Logged.Limpiartextbox(gpnlControl);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "E";
            txtAutor.Text = Autor.Nombre; cmbPais.SelectedValue = Autor.Pais.IdPais;
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
                        Entidades.EAutor eliminarAutor = new Entidades.EAutor();
                        eliminarAutor.IdAutor = Autor.IdAutor;
                        eliminarAutor.Nombre = Autor.Nombre;
                        eliminarAutor.I_Opcion = "D";
                        Negocio.NAutor negocioAutor = new Negocio.NAutor();
                        negocioAutor.Eliminar(eliminarAutor);
                        Logged.GuardarBitacora("Elimino Autor: " + Autor.IdAutor + "|" + Autor.Nombre + "|" + Autor.Pais.Nombre, "Autores");
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
        private void gvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Autor.IdAutor = Convert.ToInt32(gvAutor.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString());
            Autor.Pais.IdPais = Convert.ToInt32(gvAutor.Rows[e.RowIndex].Cells["IdPais"].Value.ToString());
            Autor.Nombre = gvAutor.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            Autor.Pais.Nombre = gvAutor.Rows[e.RowIndex].Cells["Pais"].Value.ToString();
            btnEditar.Visible = true; btnEliminar.Visible = true;
        }

        private void CargarCombobox()
        {
            Negocio.NPais negocioPais = new Negocio.NPais();
            List<Entidades.EPais> listauser = negocioPais.ObtenerListaPais();
            cmbPais.ValueMember = "IdPais";
            cmbPais.DisplayMember = "Nombre";
            cmbPais.DataSource = listauser;
        }
        private void CargarGrid()
        {
            try
            {
                Negocio.NAutor negocioCliente = new Negocio.NAutor();
                List<Entidades.EAutor> lista = negocioCliente.ObtenerListaAutor();
                var resulta = (from e in lista
                               select new { e.IdAutor, e.Nombre, e.IdPais,Pais = e.Pais.Nombre}).ToList();
                gvAutor.DataSource = null;
                gvAutor.DataSource = resulta;
                gvAutor.Columns["IdAutor"].Visible = false;
                gvAutor.Columns["IdPais"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Guardar()
        {
            Autor.Nombre = txtAutor.Text.Trim();
            Autor.Pais.IdPais = Convert.ToInt32(cmbPais.SelectedValue);
            Negocio.NAutor NuevoAutor = new Negocio.NAutor();
            NuevoAutor.GuardarNuevo(Autor);
            btnEditar.Visible = false; btnEliminar.Visible = false;
        }

        
    }
}
