using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class TextChangedExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text=="1")
            {
                txtusername.Text = "user1";
            }
            else if(txtId.Text == "2")
            {
                txtusername.Text = "user2";
            }
            else if(txtId.Text == "3")
            {
                txtusername.Text = "user3";
            }
        }
    }
}