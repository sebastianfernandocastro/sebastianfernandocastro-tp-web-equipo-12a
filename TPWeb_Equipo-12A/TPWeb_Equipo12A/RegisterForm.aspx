<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="TPWeb_Equipo12A.RegisterForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divMain">
        <div class="cajaDatos">
            <h2>Ingresá tus datos.</h2>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpDni" class="form-label">DNI</label>
                            <asp:TextBox TextMode="Number" ID="inpDni" runat="server" OnTextChanged="inpDni_TextChanged" AutoPostBack="true" CssClass="form-control"  placeholder="XXXXXXXX"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                    <div class="mb-3"></div>
                </asp:TableCell>
                    <asp:TableCell>
                    <div class="mb-3"></div>
                </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpNombre" class="form-label">Nombre</label>
                            <asp:TextBox TextMode="SingleLine" ID="inpNombre" runat="server" CssClass="form-control" placeholder="Juan"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpApellido" class="form-label">Apellido</label>
                            <asp:TextBox TextMode="SingleLine" ID="inpApellido" runat="server" CssClass="form-control" placeholder="Solis"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpEmail" class="form-label">Email</label>
                            <asp:TextBox TextMode="Email" ID="inpEmail" runat="server" CssClass="form-control" placeholder="name@example.com"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpDireccion" class="form-label">Dirección</label>
                            <asp:TextBox TextMode="SingleLine" ID="inpDireccion" runat="server" CssClass="form-control" placeholder="Av. Siempre Viva 123"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpCiudad" class="form-label">Ciudad</label>
                            <asp:TextBox TextMode="SingleLine" ID="inpCiudad" runat="server" CssClass="form-control" placeholder="Springfield"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpCP" class="form-label">Código Postal</label>
                            <asp:TextBox TextMode="Number" ID="inpCP" runat="server" CssClass="form-control" placeholder="XXXX"></asp:TextBox>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <div class="form-group">
                <asp:CheckBox ID="chkAceptoTerminos" runat="server" Text="Acepto los términos y condiciones" />
                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-outline-primary" Text="ACEPTAR" OnClick="btnAceptar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
