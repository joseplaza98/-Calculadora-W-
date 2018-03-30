<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dividir.aspx.cs" Inherits="Calculadora_w.dividir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        font-size: xx-large;
    }
    .auto-style2 {
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container main-container">
        <div class="jumbotron">
            <h1 style="background-color: #FFFF66">Calculadora Web</h1>
            <hr />
            <div class="auto-style2">
            <br />
            <strong><span class="auto-style1">División</span></strong><br />
            <br />
            </div>
            <h2 style="width: 984px; text-align: center;">Ingrese los valores dentro de las casillas, luego presione el boton para realizar su operación. </h2>
            <h2 style="width: 984px; text-align: center;">OJO: Tenga en cuenta que la división entre 0 no esta estipulada, por lo tanto no podremos realizarla.</h2>


            <asp:Label ID="lbl1" runat="server" Text="Valor 1" style="margin-left: 79px" Width="61px"></asp:Label>
            <br />
            <asp:TextBox ID="txtNumero1" runat="server" style="margin-left: 48px" Width="117px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Valor 2" style="margin-left: 79px" Width="61px"></asp:Label>
            <asp:Label ID="lblResultado" runat="server" Text="Resultado" style="margin-left: 247px; font-weight: 700;" Width="78px"></asp:Label>
            <br />
            <asp:TextBox ID="txtNumero2" runat="server" style="margin-left: 48px" Width="117px"></asp:TextBox>
            <asp:TextBox ID="txtResultado" runat="server" style="margin-left: 200px" Width="117px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnDividir" runat="server" Text="Dividir" style="margin-left: 53px; font-weight: 700;" Width="105px"/>
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
