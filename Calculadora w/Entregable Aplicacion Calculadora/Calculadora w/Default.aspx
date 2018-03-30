<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora_w.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .dropdown {
        width: 1270px;
    }
    .my-4 {
        width: 734px;
    }
    .lead {
        width: 1000px;
        text-align: center;
    }
    .display-4 {
        width: 1274px;
    }
    .auto-style1 {
        width: 1000px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%-- JumboTrump --%>

    <div class="container main-container">
        <div class="jumbotron">
            <h1 class="auto-style1">Bienvenidos a la calculadora Unicomfa</h1>
            <p class="lead">Hola, le presentamos la calculadora basica Unicomfa con la cual podra realizar operaciones matemáticas como: Sumar, Restar, Multiplicar y Dividir.</p>
           

            <div class="dropdown">
            </div>
            <%-- <a class="btn btn-primary btn-lg" href="#" role="button">Continuar</a> --%>
        </div>
    </div>
</asp:Content>
