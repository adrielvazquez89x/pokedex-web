using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

namespace aplicacionEjemploCS3
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailService emailService = new EmailService();
            emailService.armarCorreo(txtEmail.Text, txtNombre.Text, txtMensaje.Text);

            try
            {
                emailService.enviarEmail();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}