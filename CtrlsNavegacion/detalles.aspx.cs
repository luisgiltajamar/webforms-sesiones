using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CtrlsNavegacion
{
    public partial class detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Texto.Text = Request.QueryString["texto"]+
                Request.QueryString["numero"];
        }
    }
}