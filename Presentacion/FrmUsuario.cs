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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        DOTA Logged = DOTA.Instance();
        string estado = "";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtVPass.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Asegurece de llenar todos los campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (swestado.Value == true) { estado = "A"; } else { estado = "B"; }
            if (txtPass.Text == txtVPass.Text)
            {
                try
                {
                    Entidades.EUsuario insertarUsuario = new Entidades.EUsuario();
                    insertarUsuario.Idperfil = Convert.ToInt32(1);
                    insertarUsuario.Name_User = txtNombre.Text.Trim();
                    insertarUsuario.Key_User = txtVPass.Text.Trim();
                    insertarUsuario.Estado = estado;
                    Negocio.NUsuario negocioCliente = new Negocio.NUsuario();
                    negocioCliente.GuardarNuevo(insertarUsuario);
                    MessageBox.Show("Se han guardado correctamente los datos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logged.GuardarBitacora("Registro: "+txtNombre.Text+" como nuevo usuario","Usuario");
                    Limpiartextbox();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Limpiartextbox();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiartextbox();
            }
        }
        public void Limpiartextbox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
