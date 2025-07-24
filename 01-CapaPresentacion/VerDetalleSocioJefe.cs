using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Image = System.Drawing.Image;

namespace _01_CapaPresentacion
{
    public partial class VerDetalleSocioJefe : Form
    {
        public VerDetalleSocioJefe()
        {
            InitializeComponent();

        }

        public void CargarDatos(string id, string nombreCompleto, string dni, string email, string clase, DateTime FechaIngreso, DateTime ProximoVencimiento, string estado, string imagenURL)
        {
            txtNombreCompletoSocio.Text = nombreCompleto;
            txtDocumentoSocio.Text = dni;
            txtEmailSocio.Text = email;
            txtClaseSocio.Text = clase;
            txtFechaAltaSocio.Text = FechaIngreso.ToString("dd/MM/yyyy");
            txtProximoVencimientoSocio.Text = ProximoVencimiento.ToString("dd/MM/yyyy");

            if (!string.IsNullOrEmpty(imagenURL))
            {
                pbImagenSocioPersonal.ImageLocation = imagenURL; // O cargarla desde archivo o recurso
            }
        }

        private void btnPDFSocio_Click(object sender, EventArgs e)
        {
            SaveFileDialog UbicacionArchivo = new SaveFileDialog();
            UbicacionArchivo.Filter = "PDF file(*.pdf)|*.pdf";
            UbicacionArchivo.FileName = "InformacionPersonalSocio.pdf";

            if (UbicacionArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document documento = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter.GetInstance(documento, new FileStream(UbicacionArchivo.FileName, FileMode.Create));

                    documento.Open();

                    Paragraph titulo = new Paragraph("Informacion Detallada del Socio", FontFactory.GetFont("Times New Roman"));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);
                    documento.Add(new Paragraph("\n"));


                    PdfPTable TablaPdf = new PdfPTable(2);
                    TablaPdf.WidthPercentage = 100;
                    TablaPdf.DefaultCell.Padding = 5;

                    TablaPdf.AddCell("Nombre Completo");
                    TablaPdf.AddCell(txtNombreCompletoSocio.Text);

                    TablaPdf.AddCell("Documento");
                    TablaPdf.AddCell(txtDocumentoSocio.Text);

                    TablaPdf.AddCell("E-mail");
                    TablaPdf.AddCell(txtEmailSocio.Text);

                    TablaPdf.AddCell("Deporte");
                    TablaPdf.AddCell(txtClaseSocio.Text);

                    TablaPdf.AddCell("Fecha de alta");
                    TablaPdf.AddCell(txtFechaAltaSocio.Text);

                    TablaPdf.AddCell("Proximo Vencimiento");
                    TablaPdf.AddCell(txtProximoVencimientoSocio.Text);


                    documento.Add(TablaPdf);
                    documento.Close();

                    MessageBox.Show("PDF generado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al generar el PDF" + ex.Message);
                }
            }
        }

        
    }
}
