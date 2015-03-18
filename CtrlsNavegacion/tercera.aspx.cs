using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CtrlsNavegacion
{
    public partial class tercera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            texto.Text = Session["texto"].ToString() +Session["numero"];

            Session.Timeout = 10;
            Session["texto"] = null;
            Session.Clear();
        }
    }
}