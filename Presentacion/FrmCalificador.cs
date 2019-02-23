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
    public partial class FrmCalificador : Form
    {
        public FrmCalificador()
        {
            InitializeComponent();
        }
        private void FrmCalificador_Load(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmDashboard());
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmAutor());
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmDashboard());
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

        private void btnPais_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmPais());
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmLibro());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmCategoria());
        }

        
    }
}
