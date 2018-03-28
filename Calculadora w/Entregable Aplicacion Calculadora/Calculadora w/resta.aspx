<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="resta.aspx.cs" Inherits="Calculadora_w.resta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container main-container">
        <div class="jumbotron">
            <h1>APP WEB conectada a WS</h1>
            <hr />
            <br />
            <br />
            <br />
            <h2>Restar con metodo web</h2>


            <asp:Label ID="lbl1" runat="server" Text="Numero 1"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Numero 2"></asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRestar" runat="server" Text="Restar" OnClick="btnRestar_Click" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>