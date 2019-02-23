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
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }
        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            CargarGrid(); CargarCombobox();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrid()
        {
            try
            {
                Negocio.NBitacora negocioBitacora = new Negocio.NBitacora();
                List<Entidades.EBitacora> lista = negocioBitacora.ObtenerBitacora();
                var resulta = (from e in lista
                               select new { e.IdUser, e.Name_User, e.Accion, e.Formulario, e.Fecha }).ToList();
                GVBitacora.DataSource = null;
                GVBitacora.DataSource = resulta;
                //GVBitacora.Columns["IdUser"].Visible = false;//se oculta el campo Id para no ser visible en el datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAccion_OnChange(object sender, EventArgs e)
        {
            txtAccion.Enabled = cbAccion.Checked;
        }

        private void cbForm_OnChange(object sender, EventArgs e)
        {
            txtFormulario.Enabled = cbForm.Checked;
        }

        private void cbFecha_OnChange(object sender, EventArgs e)
        {
            dpFecha.Enabled = cbFecha.Checked;
        }

        private void cbUsuario_OnChange(object sender, EventArgs e)
        {
            cmbUsuario.Enabled = cbUsuario.Checked;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Negocio.NBitacora negocioBitacora = new Negocio.NBitacora();
            List<Entidades.EBitacora> lista = negocioBitacora.ObtenerBitacora();
            if (cbAccion.Checked)
            {
                lista = lista.Where(l => l.Accion.StartsWith(txtAccion.Text)).ToList();
            }
            if (cbForm.Checked)
            {
                lista = lista.Where(l => l.Formulario.StartsWith(txtFormulario.Text)).ToList();
            }
            if (cbFecha.Checked)
            {
                lista = lista.Where(l => l.Fecha.ToShortDateString() == dpFecha.Value.ToShortDateString()).ToList();
            }
            if (cbUsuario.Checked)
            {
                lista = lista.Where(l => l.Name_User.StartsWith(cmbUsuario.SelectedText)).ToList();
            }
            var resulta = (from a in lista
                           select new { a.IdUser, a.Name_User, a.Accion, a.Formulario, a.Fecha}).ToList();
            GVBitacora.DataSource = null;
            GVBitacora.DataSource = resulta;
        }
        private void CargarCombobox()
        {
            Negocio.NUsuario negocioUsuario = new Negocio.NUsuario();
            List<Entidades.EUsuario> listaUsuario = negocioUsuario.ObtenerListaUsuario();
            cmbUsuario.ValueMember = "IdUser";
            cmbUsuario.DisplayMember = "Name_User";
            cmbUsuario.DataSource = listaUsuario;
        }
    }
}
