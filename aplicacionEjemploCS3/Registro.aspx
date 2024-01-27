<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="aplicacionEjemploCS3.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container contact-container">
        <div class="contact-form">
            <h2 class="text-center mb-3">Registro de nuevo usuario Entrenador</h2>

            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" type="email" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPasword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" type="password"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" CssClass="btn btn-primary submit-btn" OnClick="btnRegistrar_Click"/>
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
