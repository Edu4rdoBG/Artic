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
    public partial class FrmPrincipal : Form
    {
        DOTA Logged = DOTA.Instance();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                Invoke(new Action(() => this.panelContenedor.Controls.RemoveAt(0)));
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Invoke(new Action(() => this.panelContenedor.Controls.Add(fh)));
            this.panelContenedor.Tag = fh;
            Invoke(new Action(() => fh.Show()));
        }

        private void btnsystem_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Frm404());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logged.GuardarBitacora("Cerro la aplicacion y sesion", "Principal");
                Application.Exit();
            }
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmCalificador());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmAdministracion());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmReporte());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la sesion?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logged.GuardarBitacora("Cerro la sesion", "Principal");
                FrmLogin l =new FrmLogin();
                l.Show();
                this.Close();
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmInventario());
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Frm404());
        }
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            
        }

        int lx, ly;
        int sw, sh;
        private void btnMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //btnMaximizar.Visible = false;
            //btnNormal.Visible = true;
        }
    }
}
