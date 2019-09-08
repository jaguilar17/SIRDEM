using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class exprem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                TextBox1.MaxLength = 10;
                DateTime dia = DateTime.Parse(TextBox1.Text);
                DateTime diahoy = DateTime.Today;
                if (dia > diahoy)
                {
                    Label1.Text = "Xo";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "XD";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() == "2") { 
                TextBox2.Text="aabcde";
                }
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() == "2")
            {
                TextBox2.Text = "aabcde";
            }
        }
    }
}