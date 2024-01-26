<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="aplicacionEjemploCS3.Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container contact-container">
        <div class="contact-form">
            <h2 class="text-center mb-3">Formulario de Contacto</h2>

            <div class="form-group">
                <label for="txtNombre">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" type="email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtMensaje">Mensaje:</label>
                <asp:TextBox ID="txtMensaje" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary submit-btn" OnClick="btnEnviar_Click" />
            </div>
        </div>
    </div>

    <style>
        body {
            background-color: #f8f9fa;
        }

        .contact-container {
            max-width: 400px;
            margin: auto;
            margin-top: 50px;
        }

        .contact-form {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0px 0px 10px 0px #000000;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .submit-btn {
            width: 100%;
        }
    </style>
</asp:Content>
