<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="suma.aspx.cs" Inherits="Web_Bustrap.suma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .jumbotron {
            height: 240px;
        }
        .lead {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <%-- JumboTrump --%>

        <div class="container main-container">
                <div class="jumbotron">
                <h1 class="display-4">Suma</h1>
                     <asp:Label ID="lbl1" runat="server" Text="Numero 1"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Numero 2"></asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
                <p class="lead">
                    <a class="btn btn-dark btn-lg" href="Default.aspx" role="button">Learn more</a>
                </p>
        </div>
    </div>
</asp:Content>

