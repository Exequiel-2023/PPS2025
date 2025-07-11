using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = System.Drawing.Image;

namespace _01_CapaPresentacion
{
    public partial class frmVerSocioActivo : Form
    {
        public frmVerSocioActivo(string nombreCompleto, string Dni, string email, string Clase, DateTime FechaIngreso, DateTime ProximoVencimiento, string ImagenURL)
        {
            InitializeComponent();

        

            txtNombreCompleto.Text = nombreCompleto;
            txtDocumento.Text = Dni;
            txtEmail.Text = email;
            txtClase.Text = Clase;
            txtFechaAlta.Text = FechaIngreso.ToString("dd/MM/yyyy");
            txtProximoVencimiento.Text = ProximoVencimiento.ToString("dd/MM/yyyy");
            pbImagenSocio.Image = Image.FromFile(ImagenURL);
            
        }

        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal V1 = new VentanaPrincipal();
            V1.ShowDialog();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog UbicacionArchivo = new SaveFileDialog();
            UbicacionArchivo.Filter = "PDF file(*.pdf)|*.pdf";
            UbicacionArchivo.FileName = "InformacionPersonalSocio.pdf";

            if (UbicacionArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document documento = new Document(PageSize.A4,10,10,10,10);
                    PdfWriter.GetInstance(documento, new FileStream(UbicacionArchivo.FileName, FileMode.Create));

                    documento.Open();

                    Paragraph titulo = new Paragraph("Informacion Detallada del Socio", FontFactory.GetFont("Times New Roman"));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);
                    documento.Add(new Paragraph("\n"));

                   
                    PdfPTable TablaPdf = new PdfPTable(6);
                    TablaPdf.WidthPercentage = 100;

                    TablaPdf.AddCell("Nombre Completo");
                    TablaPdf.AddCell("Documento");
                    TablaPdf.AddCell("E-mail");
                    TablaPdf.AddCell("Deporte");
                    TablaPdf.AddCell("Fecha de alta");
                    TablaPdf.AddCell("Proximo Vencimiento");
                   

                    TablaPdf.AddCell(txtNombreCompleto.Text);
                    TablaPdf.AddCell(txtDocumento.Text);
                    TablaPdf.AddCell(txtEmail.Text);
                    TablaPdf.AddCell(txtClase.Text);
                    TablaPdf.AddCell(txtFechaAlta.Text);
                    TablaPdf.AddCell(txtProximoVencimiento.Text);
                

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
