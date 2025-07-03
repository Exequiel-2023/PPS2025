using System;
using System.Drawing.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class FrmCorreo : Form
    {
        private string emailEmisor = "gymtucuman@gmail.com";
        private string passwordEmisor = "kuuo upin wduw ciqt";
        private string aliasEmisor = "GymTUC";
        private string[] archivos;
        private MailMessage correo;
        public FrmCorreo(string id, string email)
        {
            InitializeComponent();
            txtPara.Text = email;
        }

     

        private void AdjuntarArchivos()
        {
            string NombreArchivos = "";
            OpenFileDialog AbrirArchivo = new OpenFileDialog();
            AbrirArchivo.Multiselect = true;
            AbrirArchivo.Title = "Selecciona Archivos";

            if (AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                archivos = AbrirArchivo.FileNames;

            }
            for (int i = 0; i < archivos.Length; i++)
            {
                NombreArchivos = NombreArchivos + archivos[i];
                
            }
            lblArchivosCargados.Text = NombreArchivos;
        }

        private void CrearCuerpoCorreo ()
        {
            correo = new MailMessage();
            correo.From = new MailAddress(emailEmisor, aliasEmisor);
            correo.To.Add(txtPara.Text);
            correo.Subject = txtAsunto.Text;
            correo.Body = txtMensaje.Text;

            for (int i = 0; i < archivos.Length; i++)
            {
                correo.Attachments.Add(new Attachment(archivos[i]));
            }
        }

        private void EnviarEmail()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(emailEmisor, passwordEmisor);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
                {
                    return true;
                };
                smtp.EnableSsl = true;
                smtp.Send(correo);

                lblArchivosCargados.Text = "";
                MessageBox.Show("Correo enviado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarEmail();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el metodo:EnviarEmail" + ex.Message);
            }
        }

        private void LimpiarEmail ()
        {
            txtPara.Clear();
            txtAsunto.Clear();
            txtMensaje.Clear();
        }

        private void lblCargarArchivo_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            EnviarEmail();
        }
    }
}
