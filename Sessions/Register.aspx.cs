using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Steps to store form data in database
            //1.Create UI Form
            //2.Apply validation to form
            //3.Create database table with respective columns
            //4.Setup connection string in web.config file
            //5.Create connection class in code behind file
            //6.Write ado.net code to store data in database
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into DBUsers values (@name,@contact,@email,@city,@dt)", con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCities.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();

            txtContact.Text = "";
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            ddlCities.SelectedIndex = 0;

            Response.Write("<script>alert('Registered Successfully..!')</script>");

        }
    }
}