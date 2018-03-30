<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Web_Bustrap.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- JumboTrump --%>

    <div class="container main-container">
        <div class="jumbotron">
            <h1>Suma</h1>
            
        </div>
    </div>
             <asp:Label ID="lbl1" runat="server" Text="Numero 1"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Numero 2"></asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Sumar" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>

</asp:Content>
