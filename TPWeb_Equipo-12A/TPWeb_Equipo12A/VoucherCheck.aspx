<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VoucherCheck.aspx.cs" Inherits="TPWeb_Equipo12A.VoucherCheck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divMain">
        <div class="voucher">
            <asp:Label ID="lblVooucher" runat="server" Text="Ingrese el codigo de su Voucher."></asp:Label>
            <asp:TextBox cssClass="form-control" ID="txbVoucher" runat="server"></asp:TextBox>
            <div>
                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="ACEPTAR" OnClick="btnAceptar_Click" />
            </div>
         </div>
    </div>
</asp:Content>
