using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class LitrelExample : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            getPhotos();
        }

        protected void getPhotos()
        {
           con.Close();
            SqlCommand cmd = new SqlCommand("select * from DBPhotos",con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while(sdr.Read())
                {
                    lgallery.Text += "<div class='col-sm-12 col-md-4'><a class='lightbox' href='" + sdr.GetValue(2).ToString() + "'><img src='" + sdr.GetValue(1).ToString() + "' /></a></div>";
                    
                }
            }
        }
    }
}