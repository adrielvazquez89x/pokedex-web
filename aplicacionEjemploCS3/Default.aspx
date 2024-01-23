<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aplicacionEjemploCS3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Pokedex Web</h1>
    <div class="row row-cols-1 row-cols-md-3 g-4">

        <%
            foreach (dominio.Pokemon pokemon in ListaPokemon)
            { %>
        <div class="col">
            <div class="card">
                <img src="<%:pokemon.UrlImagen %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%: pokemon.Nombre %></h5>
                    <p class="card-text"><%:pokemon.Descripcion %></p>
                    <a href="Detalle.aspx?id<%:pokemon.Id %>">Detalles</a>
                </div>
            </div>
        </div>

        <% }%>
    </div>
</asp:Content>
