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
    public partial class FrmPreload : Form
    {
        public FrmPreload()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbload.Value < 100)
            {
                pbload.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                FrmLogin Login = new FrmLogin();
                Login.Show();
            }
        }
    }
}
