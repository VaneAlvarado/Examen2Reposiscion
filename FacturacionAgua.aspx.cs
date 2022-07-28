using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2VanessaAlvaradoSarmiento
{
    public partial class FacturacionAgua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaseCliente.SetSevicio("Agua");
        }
    }
}