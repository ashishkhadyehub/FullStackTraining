using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class RepeaterExample : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            showgalleryphotos();
        }

        protected void showgalleryphotos()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from DBPhotos", conn))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            rgallery.DataSource = dt;
                            rgallery.DataBind();
                        }
                    }
                }
            }
            catch (Exception es)
            {

            }

            //con.Close();
            //SqlCommand cmd = new SqlCommand("Select * from DBPhotos", con);
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //rgallery.DataSource = dt;
            //rgallery.DataBind();

        }

        protected void lbtndelete_Click(object sender, EventArgs e)
        {
            try
            {

                RepeaterItem a = (sender as LinkButton).Parent as RepeaterItem;

                int b = int.Parse((a.FindControl("photoid") as Label).Text.ToString());
                con.Close();
                string qrys = "Select ThumbPhoto from DBPhotos where Srno=" + b;
                con.Open();
                SqlCommand cmd1 = new SqlCommand(qrys, con);
                SqlDataReader sdr = cmd1.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    string thumbpath = sdr.GetValue(0).ToString();

                    System.IO.File.Delete(Server.MapPath(thumbpath));
                }

                con.Close();
                string qry = "delete from DBPhotos where Srno=" + b;
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();


                string message = "Photo Deleted Successfully!";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += Request.Url.AbsoluteUri;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            }
            catch (Exception es)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}