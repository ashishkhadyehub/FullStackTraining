using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class GV : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gvdata.DataSource=getlist();
                gvdata.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into GVDemo values ('"+txtname.Text+"','"+txtcity.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();

            txtcity.Text = "";
            txtname.Text = "";
            gvdata.DataSource = getlist();
            gvdata.DataBind();
        }

        protected DataSet getlist()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from GVDemo",con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        protected void gvdata_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdata.EditIndex = e.NewEditIndex;
            gvdata.DataSource = getlist();
            gvdata.DataBind();
        }

        protected void gvdata_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdata.EditIndex = -1;
            gvdata.DataSource = getlist();
            gvdata.DataBind();
        }

        protected void gvdata_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            con.Close();
            GridViewRow row = gvdata.Rows[e.RowIndex];
            string name = (row.FindControl("txteName") as TextBox).Text;
            string city = (row.FindControl("txteCountry") as TextBox).Text;
            SqlCommand cmd = new SqlCommand("Update GVDemo set Name='" + name + "',City='" + city + "' where Srno='" + gvdata.DataKeys[e.RowIndex].Value + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            gvdata.EditIndex = -1;
            gvdata.DataSource = getlist();
            gvdata.DataBind();

        }

        protected void gvdata_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Delete from GVDemo where Srno='" + gvdata.DataKeys[e.RowIndex].Value + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            gvdata.DataSource = getlist();
            gvdata.DataBind();
        }
    }
}