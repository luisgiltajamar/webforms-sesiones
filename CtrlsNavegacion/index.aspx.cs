using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CtrlsNavegacion
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNusu.Text = Application["usuarios"].ToString();

            

            Session["texto"] = "Hola";
            Session["numero"] = 7;


            var c = Request.Cookies["agnos"];

            if (c != null)
            {
                Label1.Visible = false;
                txtAños.Visible = false;

                lblAños.Text=String.Format("Tienes {0} años", c.Value);
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var c = new HttpCookie("agnos");
            c.Value = txtAños.Text;
            c.Expires = DateTime.Now.AddMonths(1);

            Response.Cookies.Add(c);

            Response.Redirect("index.aspx");

        }
    }
}