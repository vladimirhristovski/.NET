using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbName != null && tbEmail != null && tbPassword != null && RegularExpressionValidator1.IsValid)
            {
                if (Session["email"] == null)
                {
                    Session["email"] = tbEmail.Text;
                }
                Response.Redirect("Glasaj.aspx");
            }
        }
    }
}