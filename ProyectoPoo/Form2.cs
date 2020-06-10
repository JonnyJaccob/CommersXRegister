using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Form2 : Form
    {
        static string Echis = @"C:\Users\doloresmargarita\source\repos\ProyectoP\Informacion2.dat";
        MailMessage miMensaje;
        bool SeAdjunto = false;
        public int Puerto;
        public string DireccionServidor;
        public string Password;
        bool Oculto=true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
        public void Enviar(System.Net.Mail.MailMessage miMensaje)
        {
            System.Net.Mail.SmtpClient miCliente = new System.Net.Mail.SmtpClient(DireccionServidor, Puerto);
            // Autenticación con el servidor
            miCliente.Credentials = new System.Net.NetworkCredential(txtEnviador.Text, Password);
            // Establece una conexión segura
            miCliente.EnableSsl = true;
            // Envía el correo electrónicomiCliente.Send(miMensaje);}
        }
        private void DetectarDireccionServidor()//out string strDireccionServidor, out int intPuerto) 
        {/* Cliente SMTP* Gmail   : smtp.gmail.com  puerto:587* Hotmail : smtp.live.com   puerto:25* Yahoo ! : smtp.yahoo.com                            */
            switch (cmbNombreServer.Text) 
            { 
                case "Hotmail": Puerto = 25; DireccionServidor = "smtp.live.com"; break;
                case "Yahoo !": Puerto = 587; DireccionServidor = "smtp.yahoo.com"; break;
                case "Gmail": Puerto = 25; DireccionServidor = "smtp.gmail.com"; break; 
                default: throw new Exception("Servidor desconocido"); 
            } 
        }
        public void MetodoGestor()
        {
            try
            {
                miMensaje = new MailMessage();
                miMensaje.Subject = txtAsunto.Text;
                miMensaje.To.Add(new MailAddress(txtEnviador.Text));
                miMensaje.From = new MailAddress(txtRecibidor.Text);
                miMensaje.Body = rtbCuerpo.Text;
                Password = txtContraseña.Text;
                DetectarDireccionServidor();
                if(SeAdjunto)
                {
                    miMensaje.Attachments.Add(new Attachment(Echis));
                }
                CorreoElectronico miCorreoElectronico = new CorreoElectronico(DireccionServidor,Puerto,txtEnviador.Text,Password);
                miCorreoElectronico.Enviar(miMensaje);
                MessageBox.Show("Mensaje Enviado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Echis = saveFileDialog1.FileName;
                SeAdjunto = true;
            }
        
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rtbCuerpo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if(Oculto)
            {
                txtContraseña.PasswordChar = '*';
                Oculto = false;
            }else
            {
                txtContraseña.PasswordChar = '\0';
                Oculto = true;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MetodoGestor();
            this.Close();
        }
    }
}
