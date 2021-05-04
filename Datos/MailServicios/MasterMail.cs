using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Datos.MailServicios
{
    public abstract class MasterMail
    {
        private SmtpClient smtpClient;
        protected string enviarMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int  port { get; set; }
        protected bool ssl { get; set; }

        protected void IniciarClienteSmtp()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(enviarMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        
        public void enviaMail(string asunto, string cuerpo, List <string> destinatarios)
        {
            var mailMensaje = new MailMessage();
            try
            {
                mailMensaje.From = new MailAddress(enviarMail);
                foreach (string correos in destinatarios)
                {
                    mailMensaje.To.Add(correos);
                }
                mailMensaje.Subject = asunto;
                mailMensaje.Body = cuerpo;
                mailMensaje.Priority = MailPriority.Normal;
                smtpClient.Send(mailMensaje);
            }
            catch (Exception ex){ }
            finally
            {
                mailMensaje.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
