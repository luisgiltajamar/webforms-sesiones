using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CtrlsNavegacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ManejarFechaActualizada(object sender, EventArgs e)
        {
            Label1.Text = Fecha.FechaActual;
        }


    }
}