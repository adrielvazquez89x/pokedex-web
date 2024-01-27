using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("6352faef12ce14", "3d9a4016450559");
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "sandbox.smtp.mailtrap.io";
        }

        public void armarCorreo(string emailDestino, string nombre, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@pokedexweb.com");
            email.To.Add(emailDestino);
            email.Subject = nombre;
            email.IsBodyHtml = true;
            email.Body = cuerpo;
            
        }
        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
