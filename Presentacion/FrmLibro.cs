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
    public partial class FrmLibro : Form
    {
        public Entidades.ELibro _Libro = new Entidades.ELibro();
        DOTA Logged = DOTA.Instance();
        public FrmLibro()
        {
            InitializeComponent(); Logged.Limpiartextbox(gpnlControl);
        }
        private void FrmLibro_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        /// <summary>
        /// Controles
        /// </summary>
        private void gvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Libro.ISBN = gvLibro.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            _Libro.Titulo = gvLibro.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
            _Libro.Autor.IdAutor = Convert.ToInt32(gvLibro.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString());
            _Libro.Categoria.IdCategoria = Convert.ToInt32(gvLibro.Rows[e.RowIndex].Cells["IdCategoria"].Value.ToString());
            _Libro.Editorial = gvLibro.Rows[e.RowIndex].Cells["Editorial"].Value.ToString();
            _Libro.Coleccion = gvLibro.Rows[e.RowIndex].Cells["Coleccion"].Value.ToString();
            _Libro.Tematica = gvLibro.Rows[e.RowIndex].Cells["Tematica"].Value.ToString();
            _Libro.Paginas = Convert.ToInt32(gvLibro.Rows[e.RowIndex].Cells["Paginas"].Value.ToString());
            _Libro.Cantidad = Convert.ToInt32(gvLibro.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
            btnEditar.Visible = true; btnEliminar.Visible = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar los datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Libro.ISBN = _Libro.ISBN;
                        _Libro.Titulo = _Libro.Titulo;
                        _Libro.I_Opcion = "D";
                        Negocio.NLibro negocioPais = new Negocio.NLibro();
                        negocioPais.Eliminar(_Libro);
                        Logged.GuardarBitacora("Elimino Libro: " + _Libro.ISBN + "|" + _Libro.Titulo +" by Autor ID:"+ _Libro.Autor.IdAutor,"Libros");
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
            btnEditar.Visible = false; btnEliminar.Visible = false; gpnlControl.Visible = false;
            CargarGrid();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            _Libro.I_Opcion = "U";
            FrmLibroA LibroA = new FrmLibroA();
            LibroA._Libro = _Libro;
            LibroA.ShowDialog();
            btnEditar.Visible = false; btnEliminar.Visible = false; gpnlControl.Visible = false;
            CargarGrid();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _Libro.I_Opcion = "I";
            FrmLibroA Lib = new FrmLibroA();
            Lib._Libro = _Libro;
            Lib.ShowDialog();
            btnEditar.Visible = false; btnEliminar.Visible = false; gpnlControl.Visible = false;
            CargarGrid();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpnlControl.Visible = false; btnEditar.Visible = false; btnEliminar.Visible = false;
            Logged.Limpiartextbox(gpnlControl);
            CargarGrid();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gpnlControl.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.NLibro negocioLibro = new Negocio.NLibro();
                List<Entidades.ELibro> lista = negocioLibro.ObtenerListaLibro();
                lista = lista.Where(l => l.Titulo.StartsWith(txtPais.Text)).ToList();
                var resulta = (from a in lista
                               select new { a.Categoria.IdCategoria, Categoria = a.Categoria.Nombre, Autor = a.Autor.Nombre, a.Autor.IdAutor, Pais = a.Pais.Nombre, a.Titulo, a.Editorial, a.Tematica, a.Coleccion, a.Paginas, a.Cantidad, a.ISBN,a.Fecha }).ToList();
                gvLibro.DataSource = null;
                gvLibro.DataSource = resulta;
                gvLibro.Columns["IdCategoria"].Visible = false;
                gvLibro.Columns["IdAutor"].Visible = false;
                gvLibro.Columns["Categoria"].Visible = false;
                gvLibro.Columns["Cantidad"].Visible = false;
                gvLibro.Columns["Editorial"].Visible = false;
                gvLibro.Columns["Pais"].Visible = false;
                gvLibro.Columns["Coleccion"].Visible = false;
                gvLibro.Columns["Fecha"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodos
        /// </summary>
        private void CargarGrid()
        {
            try
            {
                Negocio.NLibro negocioLibro = new Negocio.NLibro();
                List<Entidades.ELibro> lista = negocioLibro.ObtenerListaLibro();
                var resulta = (from e in lista
                               select new { e.Categoria.IdCategoria,Categoria = e.Categoria.Nombre,Autor = e.Autor.Nombre, e.Autor.IdAutor ,Pais = e.Pais.Nombre, e.Titulo,e.Editorial,e.Tematica,e.Coleccion,e.Paginas,e.Cantidad,e.ISBN,e.Fecha}).ToList();
                gvLibro.DataSource = null;
                gvLibro.DataSource = resulta;
                gvLibro.Columns["IdCategoria"].Visible = false;
                gvLibro.Columns["IdAutor"].Visible = false;
                gvLibro.Columns["Categoria"].Visible = false;
                gvLibro.Columns["Cantidad"].Visible = false;
                gvLibro.Columns["Editorial"].Visible = false;
                gvLibro.Columns["Pais"].Visible = false;
                gvLibro.Columns["Coleccion"].Visible = false;
                gvLibro.Columns["Fecha"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
