using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplicacionEjemploCS3
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trainee trainee = Session["trainee"] != null ? (Trainee)Session["trainee"] : null;

            if(!(trainee != null && trainee.Id != 0))
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}