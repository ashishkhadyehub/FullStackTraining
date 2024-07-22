using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class UploadMedia : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            foreach(var file in fugallery.PostedFiles)
            {
                string ext = System.IO.Path.GetExtension(file.FileName);
                Guid g = Guid.NewGuid();
                string imgName = g + ext;
               
                string pathimg = "Photos/" + imgName;
                file.SaveAs(Server.MapPath(pathimg));

                string imgPath1 = "ThumbPhotos/" + imgName;
                int widthC = 600;
                int heightC = 400;
                System.IO.Stream streamC = file.InputStream;
                System.Drawing.Bitmap imageC = new Bitmap(streamC);
                Bitmap targetC = new Bitmap(widthC, heightC);
                Graphics graphicC = Graphics.FromImage(targetC);
                graphicC.DrawImage(imageC, 0, 0, widthC, heightC);
                targetC.Save(Server.MapPath(imgPath1));

                con.Close();
                SqlCommand cmd = new SqlCommand("insert into DBPhotos values (@thumbpath,@imgpath,@dt)", con);
                cmd.Parameters.AddWithValue("@thumbpath", imgPath1);
                cmd.Parameters.AddWithValue("@imgpath", pathimg);
                cmd.Parameters.AddWithValue("@dt", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Photos uploaded..!')</script>");

            }
        }
    }
}