using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_Equipo12A
{
    public partial class VoucherCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string voucherIngresado = txbVoucher.Text;
            string script = "vacio";

            VoucherNegocio voucher = new VoucherNegocio();

            if(voucher.buscar(voucherIngresado))
            {
                Response.Redirect("RegisterForm.aspx");
            }
            else
            {
                script = "alert('" + "El voucher es incorrecto." + "');";
                txbVoucher.Text = string.Empty;
            }

            ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script, true);
        }
    }
}