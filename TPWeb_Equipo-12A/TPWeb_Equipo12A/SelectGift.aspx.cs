using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace TPWeb_Equipo12A
{
    public partial class SelectGift : System.Web.UI.Page
    {
        private string voucher;
        protected void Page_Load(object sender, EventArgs e)
        {
            voucher = Request.QueryString["voucher"];
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> articulos = articuloNegocio.listar();
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.listar();
            imgMochila1.ImageUrl = lista[0].UrlImagen;
            imgMochila2.ImageUrl = lista[1].UrlImagen;
            imgMochila3.ImageUrl = lista[2].UrlImagen;
            imgMouse1.ImageUrl = lista[3].UrlImagen;
            imgMouse2.ImageUrl = lista[4].UrlImagen;
            imgMouse3.ImageUrl = lista[5].UrlImagen;
            imgTeclado1.ImageUrl = lista[6].UrlImagen;
            imgTeclado2.ImageUrl = lista[7].UrlImagen;
            imgTeclado3.ImageUrl = lista[8].UrlImagen;
            lblNombreProducto1.Text = articulos[0].Nombre;
            lblDescrpcionProducto1.Text = articulos[0].Descripcion;
            lblNombreProducto2.Text = articulos[1].Nombre;
            lblDescrpcionProducto2.Text = articulos[1].Descripcion;
            lblNombreProducto3.Text = articulos[2].Nombre;
            lblDescrpcionProducto3.Text = articulos[2].Descripcion;
        }

        protected void btnProducto1_Click(object sender, EventArgs e)
        {

            Response.Redirect("RegisterForm.aspx?voucher=" + voucher + "&idArticulo=" + 1);

        }

        protected void btnProducto2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterForm.aspx?voucher=" + voucher + "&idArticulo=" + 2);
        }

        protected void btnProducto3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterForm.aspx?voucher=" + voucher + "&idArticulo=" + 3);
        }
    }
}