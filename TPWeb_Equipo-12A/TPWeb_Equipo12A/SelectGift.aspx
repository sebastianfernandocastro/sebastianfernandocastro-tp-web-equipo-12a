<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SelectGift.aspx.cs" Inherits="TPWeb_Equipo12A.SelectGift" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divMain">
        <div class="cajaDatos" style="--width: 1200px; --height: 350px; display: flex; border: 0; text-align: center;">
            <div id="cajaPremio1" class="cajaDatos" style="--width: 300px; --height: 420px;">
                <div id="carousel1" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <asp:Image runat="server" imgUrl="" ID="imgMochila1" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgMochila2" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgMochila3" class="d-block w-100" alt="..." />
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carousel1" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carousel1" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                    <br />
                    <asp:Label ID="lblNombreProducto1" CssClass="nombre" runat="server" Text=""></asp:Label>
                    <br />
                    <div style="text-align: justify; margin-bottom: 10px;">
                        <asp:Label ID="lblDescrpcionProducto1" CssClass="descripcion" runat="server" Text=""></asp:Label>
                    </div>
                    <asp:Button ID="btnProducto1" CssClass="btn btn-primary" runat="server" Text="¡LO QUIERO!" OnClick="btnProducto1_Click" />

                </div>
            </div>
            <br />
            <div id="cajaPremio2" class="cajaDatos" style="--width: 300px; --height: 370px;">
                <div id="carousel2" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <asp:Image runat="server" imgUrl="" ID="imgMouse1" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgMouse2" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgMouse3" class="d-block w-100" alt="..." />
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carousel2" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carousel2" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                    <asp:Label ID="lblNombreProducto2" CssClass="nombre" runat="server" Text=""></asp:Label>
                    <br />
                    <div style="text-align: justify; margin-bottom: 10px;">
                        <asp:Label ID="lblDescrpcionProducto2" CssClass="descripcion" runat="server" Text=""></asp:Label>
                    </div>
                    <asp:Button ID="btnProducto2" CssClass="btn btn-primary" runat="server" Text="¡LO QUIERO!" OnClick="btnProducto2_Click" />
                </div>
            </div>
            <br />
            <div id="cajaPremio3" class="cajaDatos" style="--width: 300px; --height: 400px;">
                <div id="carousel3" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <asp:Image runat="server" imgUrl="" ID="imgTeclado1" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgTeclado2" class="d-block w-100" alt="..." />
                        </div>
                        <div class="carousel-item">
                            <asp:Image runat="server" imgUrl="" ID="imgTeclado3" class="d-block w-100" alt="..." />
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carousel3" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carousel3" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                    <asp:Label ID="lblNombreProducto3" CssClass="nombre" runat="server" Text=""></asp:Label>
                    <br />
                    <div style="text-align: justify; margin-bottom: 10px;">
                        <asp:Label ID="lblDescrpcionProducto3" CssClass="descripcion" runat="server" Text=""></asp:Label>
                    </div>
                    <asp:Button ID="btnProducto3" CssClass="btn btn-primary" runat="server" Text="¡LO QUIERO!" OnClick="btnProducto3_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
