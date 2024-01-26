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
            server.Credentials = new NetworkCredential("myg.productosgranja@gmail.com", "nazca845");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo(string emailDestino, string nombre, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@emcommerceprogramacioniii.com");
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
