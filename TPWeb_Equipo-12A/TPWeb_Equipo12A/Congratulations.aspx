<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Congratulations.aspx.cs" Inherits="TPWeb_Equipo12A.Contratulations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
    history.pushState(null, null, location.href);
    window.onpopstate = function () {
        history.pushState(null, null, location.href);
    };
    </script>
    <div class="divMain">
        <h1 style="font-family:'Yu Gothic'">¡Felicitaciones ya estas participando en el sorteo!.</h1>
        <h4 style="font-family:'Yu Gothic'">En breves recibiras un correo de confirmacion, revisa tu casilla.</h4>
        <img src="https://media.tenor.com/HHPMFMlwwMIAAAAi/congratulations-congrats.gif" alt="Un osito bailando." />
    </div>
</asp:Content>
