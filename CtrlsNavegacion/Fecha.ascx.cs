using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CtrlsNavegacion
{
    public partial class Fecha : System.Web.UI.UserControl
    {

        public event EventHandler FechaActualizada;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String FechaActual
        {
            set { txtFecha.Text = value; }
            get { return txtFecha.Text; }
        }

        public int Fondo
        {
            get { return txtFecha.BackColor.ToArgb(); }
           
        }

        protected void btnComprobar_Click(object sender, EventArgs e)
        {
            if(FechaActualizada!=null)
                FechaActualizada(this, EventArgs.Empty);
        }
    }
}