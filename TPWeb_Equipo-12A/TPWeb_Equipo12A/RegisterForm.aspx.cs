using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_Equipo12A
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        private bool nuevoUsuario = true;
        private Cliente cliente;
        ClienteNegocio negocio;
        Voucher voucher;
        VoucherNegocio voucherNegocio;
        Herramientas herramientas;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            negocio = new ClienteNegocio();
            voucherNegocio = new VoucherNegocio();
            herramientas = new Herramientas();
        }

        protected void inpDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cliente = negocio.buscarCliente(inpDni.Text);
                if (cliente != null && cliente.apellido != null)
                {
                    nuevoUsuario = false;
                    inpNombre.Text = cliente.nombre;
                    inpApellido.Text = cliente.apellido;
                    inpEmail.Text = cliente.email;
                    inpDireccion.Text = cliente.direccion;
                    inpCiudad.Text = cliente.ciudad;
                    inpCP.Text = cliente.cp.ToString();
                }
                else
                {
                    inpNombre.Text = string.Empty;
                    inpApellido.Text = string.Empty;
                    inpEmail.Text = string.Empty;
                    inpDireccion.Text = string.Empty;
                    inpCiudad.Text = string.Empty;
                    inpCP.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            cliente = negocio.buscarCliente(inpDni.Text);
            if (cliente.apellido == null)
            {
                cliente.nombre = inpNombre.Text;
                cliente.apellido = inpApellido.Text;
                cliente.email = inpEmail.Text;
                cliente.direccion = inpDireccion.Text;
                cliente.ciudad = inpCiudad.Text;
                cliente.cp = int.Parse(inpCP.Text);
                cliente.dni = inpDni.Text;
                negocio.agregarCliente(cliente);

                cliente = negocio.buscarCliente(inpDni.Text);
            }

            voucher = new Voucher();
            voucher.idCliente = cliente.id;
            voucher.fechaCanje = DateTime.Now;
            voucher.idArticulo = int.Parse(Request.QueryString["idArticulo"]);
            voucher.codigoVoucher = Request.QueryString["voucher"];

            if (string.IsNullOrWhiteSpace(inpDni.Text))
            {
                inpDni.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpDni.CssClass = inpDni.CssClass.Replace("border-danger", "").Trim(); // Remover borde rojo si se ha corregido
            }

            if (string.IsNullOrWhiteSpace(inpNombre.Text))
            {
                inpNombre.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpNombre.CssClass = inpNombre.CssClass.Replace("border-danger", "").Trim();
            }

            if (string.IsNullOrWhiteSpace(inpApellido.Text))
            {
                inpApellido.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpApellido.CssClass = inpApellido.CssClass.Replace("border-danger", "").Trim();
            }

            if (string.IsNullOrWhiteSpace(inpEmail.Text))
            {
                inpEmail.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpEmail.CssClass = inpEmail.CssClass.Replace("border-danger", "").Trim();
            }

            if (string.IsNullOrWhiteSpace(inpDireccion.Text))
            {
                inpDireccion.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpDireccion.CssClass = inpDireccion.CssClass.Replace("border-danger", "").Trim();
            }

            if (string.IsNullOrWhiteSpace(inpCiudad.Text))
            {
                inpCiudad.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpCiudad.CssClass = inpCiudad.CssClass.Replace("border-danger", "").Trim();
            }

            if (string.IsNullOrWhiteSpace(inpCP.Text))
            {
                inpCP.CssClass += " border-danger";
                isValid = false;
            }
            else
            {
                inpCP.CssClass = inpCP.CssClass.Replace("border-danger", "").Trim();
            }

            if (isValid)
            {
                if (chkAceptoTerminos.Checked)
                {
                    if(nuevoUsuario)
                    {
                        voucherNegocio.Editar(voucher);
                        herramientas.enviarMail(cliente.email, cliente.nombre);
                    }
                    else
                    {
                        voucherNegocio.Editar(voucher);
                        herramientas.enviarMail(cliente.email, cliente.nombre);
                    }

                    Response.Redirect("Congratulations.aspx");
                }
                else
                {
                    var script = "alert('" + "Acepte los terminos y condiciones." + "');";
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script, true);
                }
                }

            else
            {
                var script = "alert('" + "Ingrese todos los datos solicitados." + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script, true);
            }

            
        }
    }
}