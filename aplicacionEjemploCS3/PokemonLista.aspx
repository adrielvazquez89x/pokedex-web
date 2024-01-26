<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PokemonLista.aspx.cs" Inherits="aplicacionEjemploCS3.PokemonLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Lista de Pokémon</h1>
    <%-- Filtro Sencillo --%>
    <asp:Label Text="Filtrar" runat="server" />
    <div class="row">
        <div class="col-4">
            <asp:TextBox runat="server" ID="txtFiltro" AutoPostBack="true" CssClass="form-control my-3" OnTextChanged="txtFiltro_TextChanged" />
        </div>
        <div class="col-4 my-auto">
            <asp:CheckBox Text="Filtro Avanzado" ID="chkAvanzado" 
                AutoPostBack="true" 
                OnCheckedChanged="chkAvanzado_CheckedChanged" 
                runat="server" />

        </div>
    </div>

    <%-- Filtro Avanzado --%>
    <% if (FiltroAvanzado)
        {%>
    <div class="row mb-3">
        <div class="col-3">
            <asp:Label  Text="Campo" runat="server" />
            <asp:DropDownList ID="ddlCampo" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Nombre" />
                <asp:ListItem Text="Tipo" />
                <asp:ListItem Text="Número" />
            </asp:DropDownList>
        </div>
        <div class="col-3">
            <asp:Label Text="Criterio" runat="server" />
            <asp:DropDownList ID="ddlCriterio" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlCriterio_SelectedIndexChanged" />
        </div>
        <div class="col-3">
            <asp:Label Text="Filtro" runat="server" />
            <asp:TextBox ID="txtFiltroAvanzado" runat="server" CssClass="form-control" />
        </div>
        <div class="col-3 mb-3">
            <asp:Label Text="Estado" runat="server" />
            <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control">
                <asp:ListItem Text="Todos" />
                <asp:ListItem Text="Activo" />
                <asp:ListItem Text="Inactivo" />
            </asp:DropDownList>
        </div>
        <div class="col-3 mb-3">
        <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" CssClass="btn btn-primary" />

        </div>
    </div>
    <%}%>

    <%-- Listado de pokemon --%>
    <asp:GridView ID="dgvPokemon" runat="server" CssClass="table" DataKeyNames="Id"
        AutoGenerateColumns="false"
        OnSelectedIndexChanged="dgvPokemon_SelectedIndexChanged" OnPageIndexChanging="dgvPokemon_PageIndexChanging"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Número" DataField="Numero" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
            <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
            <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Modificar" />

        </Columns>
    </asp:GridView>
    <a href="FormularioPokemon.aspx" class="btn btn-primary">Agregar</a>
</asp:Content>

