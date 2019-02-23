using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace Presentacion
{
    public partial class FrmInventario : Form
    {
        DOTA Logged = DOTA.Instance();
        public FrmInventario()
        {
            InitializeComponent();
        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void cbLibro_OnChange(object sender, EventArgs e)
        {
            txtLibro.Enabled = cbLibro.Checked;
        }
        private void cbAutor_OnChange(object sender, EventArgs e)
        {
            txtAutor.Enabled = cbAutor.Checked;
        }
        private void cbFecha_OnChange(object sender, EventArgs e)
        {
            dpFecha.Enabled = cbFecha.Checked;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.NLibro negocioLibro = new Negocio.NLibro();
                List<Entidades.ELibro> lista = negocioLibro.ObtenerListaLibro();
                if (cbLibro.Checked)
                {
                    lista = lista.Where(l => l.Titulo.StartsWith(txtLibro.Text)).ToList();
                }
                if (cbAutor.Checked)
                {
                    lista = lista.Where(l => l.Autor.Nombre.StartsWith(txtAutor.Text)).ToList();
                }
                if (cbFecha.Checked)
                {
                    lista = lista.Where(l => l.Fecha.ToShortDateString() == dpFecha.Value.ToShortDateString()).ToList();
                }
                var resulta = (from a in lista
                               select new { a.Categoria.IdCategoria, Categoria = a.Categoria.Nombre, Autor = a.Autor.Nombre, a.Autor.IdAutor, Pais = a.Pais.Nombre, a.Titulo, a.Editorial, a.Tematica, a.Coleccion, a.Paginas, a.Cantidad, a.ISBN, a.Fecha }).ToList();
                GVBitacora.DataSource = null;
                GVBitacora.DataSource = resulta;
                GVBitacora.Columns["IdCategoria"].Visible = false;
                GVBitacora.Columns["IdAutor"].Visible = false;
                GVBitacora.Columns["Categoria"].Visible = false;
                GVBitacora.Columns["ISBN"].Visible = false;
                GVBitacora.Columns["Pais"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            exporta_a_excel(GVBitacora);
            Logged.GuardarBitacora("Exporto el Inventario a Excel", "Inventario");
            Cursor.Current = Cursors.Default;
        }
        private void CargarGrid()
        {
            try
            {
                Negocio.NLibro negocioLibro = new Negocio.NLibro();
                List<Entidades.ELibro> lista = negocioLibro.ObtenerListaLibro();
                var resulta = (from e in lista
                               select new { e.Categoria.IdCategoria, Categoria = e.Categoria.Nombre, Autor = e.Autor.Nombre, e.Autor.IdAutor, Pais = e.Pais.Nombre, e.Titulo, e.Editorial, e.Tematica, e.Coleccion, e.Paginas, e.Cantidad, e.ISBN, e.Fecha }).ToList();
                GVBitacora.DataSource = null;
                GVBitacora.DataSource = resulta;
                GVBitacora.Columns["IdCategoria"].Visible = false;
                GVBitacora.Columns["IdAutor"].Visible = false;
                GVBitacora.Columns["Categoria"].Visible = false;
                GVBitacora.Columns["ISBN"].Visible = false;
                GVBitacora.Columns["Pais"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void exporta_a_excel(DataGridView dgView)
        {
            try
            {
                if (progressbar != null)
                {
                    progressbar.MaximumValue = dgView.RowCount;
                    progressbar.Value = 0;
                    if (!progressbar.Visible) progressbar.Visible = true;
                }
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int ColumnIndex = 0;
                foreach (DataGridViewColumn col in dgView.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[1, ColumnIndex] = col.Name;
                }
                int rowIndex = 0;
                foreach (DataGridViewRow row in dgView.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;
                    foreach (DataGridViewColumn col in dgView.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                    }
                    progressbar.Value += 1;
                }
                excel.Visible = true;
                Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                if (progressbar != null)
                {
                    progressbar.Value = 0;
                    progressbar.Visible = false;
                }
            }
        }
    }
}
