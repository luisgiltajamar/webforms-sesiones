using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CtrlsNavegacion
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["usuarios"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["Usuarios"] = 
                Convert.ToInt32(Application["usuarios"]) + 1;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["Usuarios"] =
                Convert.ToInt32(Application["usuarios"]) - 1;
        }


    }
}