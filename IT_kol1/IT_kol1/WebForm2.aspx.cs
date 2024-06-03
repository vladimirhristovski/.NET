using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_kol1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbValuti.Items.Add("Euro");
                lbVoD.Items.Add("60");

                lbValuti.Items.Add("Dollar");
                lbVoD.Items.Add("59");

                lbValuti.Items.Add("Pound");
                lbVoD.Items.Add("61");
            }
            lbVoD.SelectedIndex = lbValuti.SelectedIndex;
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            if(tbRange.Text.Length != 0 && RangeValidator1.IsValid && lbVoD.SelectedItem!=null)
            {
                var text = tbRange.Text;
                var text2 = lbVoD.SelectedItem.ToString();
                int number;
                int number2;
                var first = Int32.TryParse(text, out number);
                var second = Int32.TryParse(text2,out number2);
                int result = number * number2;
                lblPretvori.Text = result.ToString() + "денари";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbValuta.Text.Length!=0 && tbVoD.Text.Length != 0)
            {
                lbValuti.Items.Add(tbValuta.Text);
                lbVoD.Items.Add(tbVoD.Text);
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbValuti.SelectedItem!=null)
            {
                lbValuti.Items.Remove(lbValuti.SelectedItem);
                lbVoD.Items.Remove(lbVoD.SelectedItem);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            foreach(var item in lbValuti.Items)
            {
                lista.Add(item);
            }
            Session["Valuti"] = lista;
            Response.Redirect("WebForm3.aspx?broj=1&ime=Koli");
        }
    }
}