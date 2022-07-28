using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2VanessaAlvaradoSarmiento
{
    public partial class Facturacion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tNom.Text = ClaseCliente.GetNombre();
            tCed.Text = ClaseCliente.GetCedula();
            tDireccion.Text = ClaseCliente.GetDireccion();
            tTel.Text = ClaseCliente.GetTelefono();
            tfactura.Text = ClaseCliente.GetFactura().ToString();    
            tservicio.Text = ClaseCliente.GetServicio();

        }

        protected void bVolver_Click(object sender, EventArgs e)
            {
            Response.Redirect("WebForm1.aspx");
            }

        protected void bAgregar_Click1(object sender, EventArgs e)
        {
           
            tmonto2.Text = tmonto.Text;
            tdesc2.Text = tdesc.Text;
            Double m = Convert.ToDouble(tmonto2.Text);
            Double d = Convert.ToDouble(tdesc2.Text);
            //Calculo subtotal
            Double r = m - ((m * d) / 100);
            tsubtotal.Text = Convert.ToString(r);
           //Calculo total
            tiva.Text = Convert.ToString(13);
            Double s = Convert.ToDouble(tsubtotal.Text);
            Double i = Convert.ToDouble(tiva.Text);
            Double re = (s * i)/100 + s;
            ttotal.Text = Convert.ToString(re);
        }
        public void Salvar()
        {
            String strConnString = ConfigurationManager.ConnectionStrings["Examen2VanessaAlvaradoConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand command = new SqlCommand("sp_AgregarCliente", con);
            command.Parameters.Add(new SqlParameter("nombre", tNom.Text));
            command.Parameters.Add(new SqlParameter("cedula", tCed.Text));
            command.Parameters.Add(new SqlParameter("direccion", tDireccion.Text));
            command.Parameters.Add(new SqlParameter("telefono", tTel.Text));
            command.Parameters.Add(new SqlParameter("costo", tmonto2));
            command.Parameters.Add(new SqlParameter("descuento", tdesc2.Text));
            command.Parameters.Add(new SqlParameter("subtotal", tsubtotal.Text));
            command.Parameters.Add(new SqlParameter("iva", tiva.Text));
            command.Parameters.Add(new SqlParameter("total", ttotal.Text));
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        protected void ConsultaFiltro()
        {
            String strConnString = ConfigurationManager.ConnectionStrings["Examen2VanessaAlvarado.ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand command = new SqlCommand("sp_ConsultarCliente", con);
            command.Parameters.Add(new SqlParameter("nombre", tNom.Text));
            command.Parameters.Add(new SqlParameter("cedula", tCed.Text));
            command.Parameters.Add(new SqlParameter("direccion", tDireccion.Text));
            command.Parameters.Add(new SqlParameter("telefono", tTel.Text));
            command.Parameters.Add(new SqlParameter("costo", tmonto2));
            command.Parameters.Add(new SqlParameter("descuento", tdesc2.Text));
            command.Parameters.Add(new SqlParameter("subtotal", tsubtotal.Text));
            command.Parameters.Add(new SqlParameter("iva", tiva.Text));
            command.Parameters.Add(new SqlParameter("total", ttotal.Text));
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        protected void tCed_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetCedula(tNom.Text);
        }

        protected void tmonto2_TextChanged(object sender, EventArgs e)
        {
            tmonto2.Text = tmonto.Text;
        }

        protected void tdesc2_TextChanged(object sender, EventArgs e)
        {
            tdesc2.Text= tdesc.Text;
        }

        protected void tsubtotal_TextChanged(object sender, EventArgs e)
        {
        }

        protected void tiva_TextChanged(object sender, EventArgs e)
        {
        }

        protected void ttotal_TextChanged(object sender, EventArgs e)
        { 
        }

        protected void tservicio_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetSevicio(tservicio.Text);
        }

        protected void bSalvar_Click(object sender, EventArgs e)
        {
          //  Salvar();
            ConsultaFiltro();
        }

        protected void tfactura_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetFactura();
        }

        protected void tNom_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetNombre(tNom.Text);
        }

        protected void tDireccion_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetDireccion(tDireccion.Text);
        }

        protected void tTel_TextChanged(object sender, EventArgs e)
        {
            ClaseCliente.SetTelefono(tTel.Text);
        }

        protected void tmonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
