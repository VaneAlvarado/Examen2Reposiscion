using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2VanessaAlvaradoSarmiento
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ClaseCliente.SetNombre(tNom1.Text);
            ClaseCliente.SetCedula(tCed1.Text);
            ClaseCliente.SetDireccion(tDireccion1.Text);
            ClaseCliente.SetTelefono(tTel1.Text);
            ClaseCliente.SetFactura();
            Response.Redirect("FacturacionAgua.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ClaseCliente.SetNombre(tNom1.Text);
            ClaseCliente.SetCedula(tCed1.Text);
            ClaseCliente.SetDireccion(tDireccion1.Text);
            ClaseCliente.SetTelefono(tTel1.Text);
            ClaseCliente.SetFactura(); 
            Response.Redirect("FacturacionLuz.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ClaseCliente.SetNombre(tNom1.Text);
            ClaseCliente.SetCedula(tCed1.Text);
            ClaseCliente.SetDireccion(tDireccion1.Text);
            ClaseCliente.SetTelefono(tTel1.Text);
            ClaseCliente.SetFactura(); 
            Response.Redirect("FacturacionCable.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            ClaseCliente.SetNombre(tNom1.Text);
            ClaseCliente.SetCedula(tCed1.Text);
            ClaseCliente.SetDireccion(tDireccion1.Text);
            ClaseCliente.SetTelefono(tTel1.Text);
            ClaseCliente.SetFactura(); 
            Response.Redirect("Facturacion Tel.aspx");
        }

        protected void tNom1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tCed1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}