using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_kol1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["brojac"] = 0;
                lbl1.Text=Request.QueryString[0];
                lbl2.Text = Request.QueryString[1];
                //foreach(ListItem item in (ArrayList)Session["Valuti"])
                //{
                //    lb11.Items.Add(item);
                //}
                lb11.DataSource = (ArrayList)Session["Valuti"];
                lb11.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ViewState["brojac"] = (int)ViewState["brojac"] + 1;
            int broj = (int)ViewState["brojac"];
            lblPlus.Text = broj.ToString();
        }
    }
}