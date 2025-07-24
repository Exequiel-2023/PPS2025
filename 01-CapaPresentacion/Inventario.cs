using _02_CapaNegocio;
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;

namespace _01_CapaPresentacion
{
    public partial class Inventario : Form
    {
        CN_Inventario inventario = new CN_Inventario();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ListarInventario();
        }

        public void ListarInventario()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventario.ListarInventario();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void ExportarExcel()
        {
           Excel.Application aplicacion = new Excel.Application();
            aplicacion.Visible = true;
            Workbook hoja = aplicacion.Workbooks.Add();
            Worksheet ObtenerHoja = (Worksheet)hoja.Sheets[1];
            
            int ColumnaDgv = dgvInventario.ColumnCount;
            int FilaDgv = dgvInventario.RowCount;

            for (int i = 0; i < ColumnaDgv; i++)
            {
                ObtenerHoja.Cells[1, i + 1] = dgvInventario.Columns[i].HeaderText;
            }

            for (int i = 0; i < FilaDgv; i++)
            {
                for (int j = 0; j < ColumnaDgv; j++)
                {
                ObtenerHoja.Cells[i + 2, j + 1] = dgvInventario.Rows[i].Cells[j].Value;
                }

            }

            string Archivo = System.IO.Path.GetTempFileName() + ".xls";
            hoja.SaveAs(Archivo);
            MessageBox.Show("Archivo descargado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
