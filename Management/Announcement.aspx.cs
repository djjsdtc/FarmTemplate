using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_Announcement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            StreamReader reader = new StreamReader(Server.MapPath("~/Announcement.txt"));
            txtInfo.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        StreamWriter writer = new StreamWriter(Server.MapPath("~/Announcement.txt"));
        writer.Write(txtInfo.Text);
        writer.Flush();
        writer.Close();
        Response.Redirect("~/Default.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}