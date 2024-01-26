using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplicacionEjemploCS3
{
    public partial class PanelUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debes loguearte para ingresar");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnUserNormal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1Login.aspx");
        }

        protected void btnUserAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2LoginAdmin.aspx");
        }
    }
}