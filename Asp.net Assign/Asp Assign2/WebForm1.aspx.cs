using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListItems
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] { "Select ", "Jumpsuit", "Long Frock", "Skirt", "Jeans", "T-Shirt" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jpg";

        
            if (DropDownList1.Items.FindByText("Jumpsuit").Selected == true)
            {
                Label1.Text = "30000/-";
            }
            else if (DropDownList1.Items.FindByText("Skirt").Selected == true)
            {
                Label1.Text = "1000/-";
            }
            else if (DropDownList1.Items.FindByText("Long Frock").Selected == true)
            {
                Label1.Text = "1500/-";
            }
            else if (DropDownList1.Items.FindByText("T-Shirt").Selected == true)
            {
                Label1.Text = "800/-";
            }
            else
            {
                Label1.Text = "2000/-";
            }

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

    //DropDownList1.Items.FindByText("Jumpsuit").Selected = true;

    //DropDownList1.Items.FindByText("Skirt").Selected = true;
    //Label1.Text = "800/-";
    //DropDownList1.Items.FindByText("Long Frock").Selected = true;
    //Label1.Text = "1500/-";
    //DropDownList1.Items.FindByText("T-Shirt").Selected = true;
    //Label1.Text = "500/-";
    //DropDownList1.Items.FindByText("Jeans").Selected = true;
    //Label1.Text = "2000/-";
    //’DropDownList1.Items.FindByValue('<value>').Selected = true
    // }
}
}