using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace aplicacionEjemploCS3
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee user = new Trainee();
                TraineeNegocio negocio = new TraineeNegocio();
                EmailService emailService = new EmailService();

                user.Email  = txtEmail.Text;
                user.Pass = txtPassword.Text;

                int id = negocio.insertarNuevo(user);

                emailService.armarCorreo(user.Email, "Bienvenido trainee", "Te damos la bienvenida!");
                emailService.enviarEmail();
                Response.Redirect("Default.aspx",false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                
            }
        }
    }
}