using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspwebform
{
    public partial class Webapp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("page is loaded");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "you clicked";
        }
    }
}