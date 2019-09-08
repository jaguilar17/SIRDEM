using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class HorarioMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:3914/Default.aspx", true);

            //Response.Redirect("http://localhost:3914/Default.aspx", true);
            //Response.Redirect("http://localhost:32566/Default.aspx",true);
            //Response.Redirect("http://localhost:32566/Default.aspx", true);
            
        }
    }
}