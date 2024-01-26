using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;



namespace aplicacionEjemploCS3
{

    public partial class PokemonLista : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FiltroAvanzado = chkAvanzado.Checked;
            PokemonNegocio negocio = new PokemonNegocio();
            Session.Add("listaPokemons", negocio.listarConSP());

            dgvPokemon.DataSource = Session["listaPokemons"];
            dgvPokemon.DataBind();

        }

        protected void dgvPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvPokemon.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioPokemon.aspx?id=" + id);
        }

        protected void dgvPokemon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPokemon.PageIndex = e.NewPageIndex;
            dgvPokemon.DataBind();
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> lista = (List<Pokemon>)Session["listaPokemons"];
            List<Pokemon> listafiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));

            dgvPokemon.DataSource = listafiltrada;
            dgvPokemon.DataBind();
        }

        protected void chkAvanzado_CheckedChanged(object sender, EventArgs e)
        {
                  
                FiltroAvanzado = chkAvanzado.Checked;
                txtFiltro.Enabled = !FiltroAvanzado;
            
        }

        protected void ddlCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();

            if(ddlCampo.SelectedItem.ToString() == "Número")
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");
            }
            else
            {
                ddlCriterio.Items.Add("Comienza con ");
                ddlCriterio.Items.Add("Termina con ");
                ddlCriterio.Items.Add("Contiene ");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                dgvPokemon.DataSource = negocio.filtrar(ddlCampo.SelectedItem.ToString(),
                    ddlCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text, ddlEstado.SelectedItem.ToString());
                dgvPokemon.DataBind();
            } 
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}