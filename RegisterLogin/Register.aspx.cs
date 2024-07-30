using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterLogin
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into EmpRegister values (@name,@email,@contact,@dept,@pwd)", con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@dept", ddldept.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            txtContact.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            ddldept.SelectedIndex= 0;

            this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Registered Successfully..!','','success');", true);

        }
    }
}