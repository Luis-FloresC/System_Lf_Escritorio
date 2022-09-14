using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Datos.Servicios_Coreeo
{
  public abstract  class Correos
    {
        private SmtpClient smtpClient;
        protected string sender_mail { get; set; }
        protected string contraseña { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }


        /// <summary>
        /// Iniciar Protocolo de gmail
        /// </summary>
        protected void inicial_smtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(sender_mail,contraseña);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }


        /// <summary>
        /// Envio de Correo Electronico
        /// </summary>
        /// <param name="sujeto"></param>
        /// <param name="body"></param>
        /// <param name="receptor"></param>
        public void Enviar_Email(string sujeto,string body, List<string> receptor)
        {
            var msj_email = new MailMessage();
            try
            {
                msj_email.From = new MailAddress(sender_mail);
                foreach(string mail in receptor)
                {
                    msj_email.To.Add(mail);
                }
                msj_email.Subject = sujeto;
                msj_email.Body = body;
                msj_email.Priority = MailPriority.Normal;
                smtpClient.Send(msj_email);
            }
            catch (Exception ex) { }
            finally
            {
                msj_email.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
