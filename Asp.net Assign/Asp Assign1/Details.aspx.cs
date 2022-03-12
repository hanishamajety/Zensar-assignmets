using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssign
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (uname.Text.Trim() != fname.Text.Trim())
            //{
            //    // MessageBox.Show("same");  
            //}
            //else
            //{
            //    Messagebox.Show("Confirm password is not matched with password..?");
            //    return;
            //}
            if (Page.IsValid)
            {
                Response.Redirect("Validaton.html");

            }
            else
            {
                Response.Write("InValid  Information......");
            }
        }
    }
}