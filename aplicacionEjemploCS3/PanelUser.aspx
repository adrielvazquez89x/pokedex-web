<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PanelUser.aspx.cs" Inherits="aplicacionEjemploCS3.PanelUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        body {
            background-color: #f8f9fa;
        }

        .login-container {
            max-width: 400px;
            margin: auto;
            margin-top: 100px;
        }

        .login-header {
            text-align: center;
            margin-bottom: 20px;
        }

        .login-form {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0px 0px 10px 0px #000000;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .login-btn {
            width: 100%;
        }

        .user-type-btn {
            margin-bottom: 10px;
        }
    </style>
    <h1>Te logueate correctamente</h1>

    <div class="container login-container">
        <div class="login-header">
            <h2>Login</h2>
        </div>

        <!-- Botones para seleccionar tipo de usuario -->
        <div class="text-center">
            <asp:Button ID="btnUserNormal" runat="server" Text="Usuario Normal" CssClass="btn btn-secondary user-type-btn" OnClick="btnUserNormal_Click"/>

            <% if( Session["usuario"] != null && ((dominio.Usuario)Session["usuario"]).TipoUsuario == dominio.TipoUsuario.ADMIN ) {%>
            <asp:Button ID="btnUserAdmin" runat="server" Text="Usuario Admin" CssClass="btn btn-secondary user-type-btn" OnClick="btnUserAdmin_Click" />
           
            <%}%>


        </div>

    </div>

</asp:Content>
