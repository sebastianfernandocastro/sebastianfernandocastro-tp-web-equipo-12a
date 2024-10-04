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
                            <input type="number" class="form-control" id="inpDni" placeholder="XXXXXXXX">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpNombre" class="form-label">Nombre</label>
                            <input type="text" class="form-control" id="inpNombre" placeholder="Juan">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpApellido" class="form-label">Apellido</label>
                            <input type="email" class="form-control" id="inpApellido" placeholder="Solis">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                       <div class="mb-3">
                          <label for="inpEmail" class="form-label">Email</label>
                          <div class="input-group">
                            <span class="input-group-text" id="basic-addon3">@</span>
                            <input type="email" class="form-control" id="inpEmail" placeholder="name@example.com" aria-describedby="basic-addon3 basic-addon4">
                          </div>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpDireccion" class="form-label">Direccion</label>
                            <input type="email" class="form-control" id="inpDireccion" placeholder="Av. Siempre Viva 123">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpCiudad" class="form-label">Ciudad</label>
                            <input type="email" class="form-control" id="inpCiudad" placeholder="Springfield">
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div class="mb-3">
                            <label for="inpCP" class="form-label">Codigo Postal</label>
                            <input type="email" class="form-control" id="inpCP" placeholder="XXXX">
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </div>
</asp:Content>
