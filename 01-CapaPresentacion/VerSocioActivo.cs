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

namespace _01_CapaPresentacion
{
    public partial class frmVerSocioActivo : Form
    {
        public frmVerSocioActivo(string id, string nombre, string apellido, string dni, string telefono, string fechaIngreso)
        {
            InitializeComponent();

            txtId.Text = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDni.Text = dni;
            txtTelefono.Text = telefono;
            txtFechaAlta.Text = fechaIngreso;

        }

        
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Socios V1 = new Socios();
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

                    Paragraph titulo = new Paragraph("Informacion Detalla del Socio", FontFactory.GetFont("Times New Roman"));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);
                    documento.Add(new Paragraph("\n"));

                    //string nombre = txtNombre.Text;
                    PdfPTable TablaPdf = new PdfPTable(5);
                    TablaPdf.WidthPercentage = 100;

                    TablaPdf.AddCell("Nombre Socio");
                    TablaPdf.AddCell("Apellido Socio");
                    TablaPdf.AddCell("Dni Socio");
                    TablaPdf.AddCell("Telefono Socio");
                    TablaPdf.AddCell("Fecha Alta del Socio");



                    TablaPdf.AddCell(txtNombre.Text);
                    TablaPdf.AddCell(txtApellido.Text);
                    TablaPdf.AddCell(txtDni.Text);
                    TablaPdf.AddCell(txtTelefono.Text);
                    TablaPdf.AddCell(txtFechaAlta.Text);


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
