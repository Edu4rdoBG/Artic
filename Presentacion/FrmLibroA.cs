using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FrmLibroA : Form
    {
        public Entidades.ELibro _Libro = new Entidades.ELibro();
        DOTA Logged = DOTA.Instance();

        public FrmLibroA()
        {
            InitializeComponent();
        }
        private void FrmLibroA_Load(object sender, EventArgs e)
        {
            CargarCombobox();
            if (_Libro.I_Opcion == "I"){
                lblAccion.Text = "Nuevo Libro";
            }
            else
            {
                lblAccion.Text = "Editar Libro";
                txtTitulo.Text = _Libro.Titulo;
                txtTematica.Text = _Libro.Tematica;
                txtPaginas.Text = _Libro.Paginas.ToString();
                txtCantidad.Text = _Libro.Cantidad.ToString();
                txtCaoleccion.Text = _Libro.Coleccion;
                txtEditorial.Text = _Libro.Editorial;
                txtISBN.Text = _Libro.ISBN;
                cmbAutor.SelectedValue = _Libro.Autor.IdAutor;
                cmbCategoria.SelectedValue = _Libro.Categoria.IdCategoria;
            }
        }
        /// <summary>
        /// Controles
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_Libro.I_Opcion == "I")
            {
                try
                {
                    _Libro.I_Opcion = "I"; Guardar(); MessageBox.Show("Se guardo correctamente");
                    this.Close();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea modificar los datos?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { _Libro.I_Opcion = "U"; Guardar(); MessageBox.Show("Se modifico correctamente"); this.Close(); }
                    else { }
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodos
        /// </summary>
        private void Guardar()
        {
            _Libro.ISBN = txtISBN.Text.Trim();
            _Libro.Titulo = txtTitulo.Text.Trim();
            _Libro.Tematica = txtTematica.Text.Trim();
            _Libro.Editorial = txtEditorial.Text.Trim();
            _Libro.Coleccion = txtCaoleccion.Text.Trim();
            _Libro.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            _Libro.Paginas = Convert.ToInt32(txtPaginas.Text.Trim());
            _Libro.Autor.IdAutor = Convert.ToInt32(cmbAutor.SelectedValue);
            _Libro.Categoria.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            Negocio.NLibro NuevoCategoria = new Negocio.NLibro();
            NuevoCategoria.GuardarNuevo(_Libro);
        }
        private void CargarCombobox()
        {
            Negocio.NAutor negocioAutor = new Negocio.NAutor();
            List<Entidades.EAutor> listaAutor = negocioAutor.ObtenerListaAutor();
            cmbAutor.ValueMember = "IdAutor";
            cmbAutor.DisplayMember = "Nombre";
            cmbAutor.DataSource = listaAutor;

            Negocio.NCategoria negocioCat = new Negocio.NCategoria();
            List<Entidades.ECategoria> listaCat = negocioCat.ObtenerListaCategoria();
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.DataSource = listaCat;
        }

    }
}
