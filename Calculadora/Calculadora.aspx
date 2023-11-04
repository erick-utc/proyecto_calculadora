<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Proyecto de Programacion 2 Grupo5</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <header class="container">
            <div class="row">
                <div class="col-2"></div>
                <h1 class="col-8">Calculadora</h1>
                <div class="col-2"></div>
            </div>
        </header>
        <section class="container">
        <div class="row g-2">
        <div class="col-2"></div>
            <asp:Label ID="lblResultado" class="col-8" runat="server" ></asp:Label>
            <div class="col-2"></div>
        </div>
        <div class="row">
            <div class="col-2"></div>
            <asp:TextBox ID="txtNumero1" runat="server" class="col-8"></asp:TextBox>
            <div class="col-2"></div>
        </div>
        
        <div class="row">
            <div class="col-1"></div>
            <asp:Button ID="btnSqrt" runat="server" Text="sqrt(x)" class="col-2 btn btn-light shadow-sm p-4 m-1" />
            <asp:Button ID="btnClear" runat="server" Text="C" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="bntDelete" runat="server" Text="Del" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnFactorial" runat="server" Text="x!" class="col-2 btn btn-light shadow-sm m-1" />
            <asp:Button ID="btnDivision" runat="server" Text="/" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <div class="col-1"></div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            <asp:Button ID="btnpow" runat="server" Text="x^y" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnSiete" runat="server" Text="7" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnOcho" runat="server" Text="8" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnNueve" runat="server" Text="9" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnMultiplicacion" runat="server" Text="x" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <div class="col-1"></div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            <asp:Button ID="btnPow10" runat="server" Text="10^x" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnCuatro" runat="server" Text="4" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnCinco" runat="server" Text="5" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnSeis" runat="server" Text="6" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnResta" runat="server" Text="-" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <div class="col-1"></div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            <asp:Button ID="btnLog" runat="server" Text="log(x)" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnUno" runat="server" Text="1" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnDos" runat="server" Text="2" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnTres" runat="server" Text="3" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnSuma" runat="server" Text="+" class="col-2 btn btn-light p-4 shadow-sm m-1" OnClick="btnSuma_Click" />
            <div class="col-1"></div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            <asp:Button ID="btnPow2" runat="server" Text="x^2" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnInverse" runat="server" Text="-/+" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnCero" runat="server" Text="0" class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnPunto" runat="server" Text="." class="col-2 btn btn-light p-4 shadow-sm m-1" />
            <asp:Button ID="btnIgual" runat="server" Text="=" class="col-2 btn btn-dark p-4 shadow-sm m-1" />
            <div class="col-1"></div>
        </div>
        </section>
        
    </form>
</body>
</html>
