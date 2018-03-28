<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora_w.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%-- JumboTrump --%>

    <div class="container main-container">
        <div class="jumbotron">
            <h1 class="display-4">Bienvenidos a la calculadora Unicomfa</h1>
            <p class="lead">Con esta calculadora podra realizar operaciones de Suma ,Resta ,Multiplicacion y Division.</p>
            <hr class="my-4">
            <p>En este proyecto se emplean el JumboTrump y los diferentes tipos de paginas al igual que un Servidor para realizar las operaciones.</p>
            <hr class="my-4">

            <div class="dropdown">
                <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Menú
                </button>
                <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                    <a class="dropdown-item" href="suma">Sumar</a>
                    <a class="dropdown-item" href="resta">Restar</a>
                    <a class="dropdown-item" href="multiplicar">Multiplicar</a>
                    <a class="dropdown-item" href="dividir">Dividir</a>
                </div>
            </div>
            <%-- <a class="btn btn-primary btn-lg" href="#" role="button">Continuar</a> --%>
        </div>
    </div>
</asp:Content>
