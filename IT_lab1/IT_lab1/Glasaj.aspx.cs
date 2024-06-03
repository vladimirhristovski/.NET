using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var predmeti = new ArrayList();
                predmeti.Add(new ListItem("Интернет Технологии", "Проф. д-р Гоце Арменски"));
                predmeti.Add(new ListItem("Напредно програмирање", "Проф. д-р Ѓорѓи Маџаров"));
                predmeti.Add(new ListItem("Визуелно Програмирање", "Проф. д-р Дејан Ѓорѓевиќ"));

                lbPredmeti.DataTextField = "Text";
                lbPredmeti.DataTextField = "Value";
                lbPredmeti.DataSource = predmeti;
                lbPredmeti.DataBind();

                lbKrediti.Items.Add(new ListItem("6"));
                lbKrediti.Items.Add(new ListItem("6"));
                lbKrediti.Items.Add(new ListItem("6"));
            }
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfesor.Text = lbPredmeti.SelectedValue;

        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedItem != null)
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSubject.Text) && !string.IsNullOrEmpty(tbCredits.Text) && !string.IsNullOrEmpty(tbProfesor.Text))
            {
                //var obj = new ListItem();
                //obj.Text=tbSubject.Text;
                //obj.Value = tbProfesor.Text;
                lbPredmeti.Items.Add(new ListItem(tbSubject.Text, tbProfesor.Text));
                lbKrediti.Items.Add(new ListItem(tbCredits.Text));
                tbSubject.Text = "";
                tbProfesor.Text = "";
                tbCredits.Text = "";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = lbPredmeti.SelectedItem;
            var selectedIndex = lbKrediti.SelectedIndex;
            lbPredmeti.Items.Remove(selectedItem);
            lbKrediti.Items.RemoveAt(selectedIndex);
        }
    }
}