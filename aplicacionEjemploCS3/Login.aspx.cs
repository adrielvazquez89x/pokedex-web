using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

namespace aplicacionEjemploCS3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //   Usuario usuario;
            // UsuarioNegocio negocio = new UsuarioNegocio();

            Trainee trainee = new Trainee();
            TraineeNegocio negocio = new TraineeNegocio();
            try
            {
                trainee.Email = txtUsername.Text;
                trainee.Pass = txtPassword.Text;
                if(negocio.Login(trainee) )
                {
                    Session.Add("trainee", trainee);
                    Response.Redirect("MiPerfil.aspx", false );
                }
                else
                {
                    Session.Add("error", "User o pass incorrectos");
                    Response.Redirect("Error.aspx");
                }

                /*    usuario = new Usuario(txtUsername.Text, txtPassword.Text, false);
                    if (negocio.Loguear(usuario))
                    {
                        Session.Add("usuario", usuario);
                        Response.Redirect("PanelUser.aspx");

                    }
                    else
                    {
                        Session.Add("error", "user o pass incorrectos");
                        Response.Redirect("Error.aspx", false);
                    }
                */

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx");
               
            }
        }
    }
}