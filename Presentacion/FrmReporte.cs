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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DateTime Fechai = DateTime.Now; string Reporte;string col;
        private void FrmReporte_Load(object sender, EventArgs e)
        {
            dpFechaini.Value = Fechai;
            dpFechafin.Value = Fechai.AddDays(6);
            toolTip1.SetToolTip(rbBitacora, "Actividad de usuarios en el sistema");
        }
        private void dpFechaini_onValueChanged_1(object sender, EventArgs e)
        {
            dpFechafin.Value = dpFechaini.Value.AddDays(6);
        }
        private void dpFechafin_onValueChanged(object sender, EventArgs e)
        {
            dpFechaini.Value = (dpFechafin.Value.AddDays(-6));
        }

        private void CargarGrid()
        {
            try
            {
                Negocio.NReportes negocioBitacora = new Negocio.NReportes();
                List<Entidades.EReportes> lista = negocioBitacora.ObtenerListaReportes(dpFechaini.Value,dpFechafin.Value,Reporte);
                var resulta = (from e in lista
                               select new { e.Reporte, e.Domingo,e.Lunes,e.Martes,e.Miercoles,e.Jueves,e.Viernes,e.Sabado }).ToList();
                GVReporte.DataSource = null;
                GVReporte.DataSource = resulta;
                GVReporte.Columns[0].HeaderText = col;
                GVReporte.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbBitacora.Checked || rbAutor.Checked || rbCategoria.Checked){
                    SelectRadioB(); CargarGrid(); btnExcel.Visible = true;
                }else { MessageBox.Show("Selecione el tipo de reporte a generar","Importante",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            }
            catch (Exception){
                    throw;
            }
        }

        private void SelectRadioB()
        {
            if (rbCategoria.Checked){
                Reporte = rbCategoria.Tag.ToString(); col = "Categoria";
            }
            else if (rbAutor.Checked){
                Reporte = rbAutor.Tag.ToString(); col = "Autor";
            }
            else if (rbBitacora.Checked){
                Reporte = rbBitacora.Tag.ToString(); col = "Usuario";
            }
        }
        DOTA Logged = DOTA.Instance();
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            exporta_a_excel(GVReporte);
            Logged.GuardarBitacora("Exporto el reporte de "+Reporte+" a Excel", "Reportes");
            Cursor.Current = Cursors.Default;
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
