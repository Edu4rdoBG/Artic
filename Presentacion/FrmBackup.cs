using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmBackup : Form
    {
        DOTA Logged = DOTA.Instance();
        public FrmBackup()
        {
            InitializeComponent();
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                 CrearRespaldo();
                 MessageBox.Show("El respaldo se realizo con exito","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 Logged.GuardarBitacora("Respaldo de Base de datos","BackUP");
            }
            catch (Exception)
            {

                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void CrearRespaldo()
        {
            Entidades.EUsuario Backup = new Entidades.EUsuario();
            Backup.Ruta = txtRuta.Text;
            Backup.Nombre = txtNombre.Text;
            Negocio.NUsuario NegocioBackup = new Negocio.NUsuario();
            NegocioBackup.CrearRespaldo(Backup);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
