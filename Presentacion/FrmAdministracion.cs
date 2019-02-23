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
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FrmBitacora Bit = new FrmBitacora();
            Bit.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario User = new FrmUsuario();
            User.ShowDialog();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            FrmBackup Back = new FrmBackup();
            Back.ShowDialog();
        }
    }
}
