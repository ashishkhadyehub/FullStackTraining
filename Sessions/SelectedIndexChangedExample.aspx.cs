using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class SelectedIndexChangedExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlCity.SelectedItem.Text=="KOP")
            {
                txtCity.Text = "Kolhapur";
            }
            else if(ddlCity.SelectedItem.Text == "PUN")
            {
                txtCity.Text = "Pune";
            }
            else if(ddlCity.SelectedItem.Text == "DEL")
            {
                txtCity.Text = "Delhi";
            }
        }
    }
}