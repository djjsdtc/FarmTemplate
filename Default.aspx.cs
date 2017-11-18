using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.Identity.IsAuthenticated)
        {
            StreamReader reader = new StreamReader(Server.MapPath("~/Announcement.txt"));
            Label lblInfo = (Label)LoginView2.FindControl("lblInfo");
            lblInfo.Text = reader.ReadToEnd().Replace("\n","<br />");
            reader.Close();
        }
        Membership.GetUser("admin").UnlockUser();
    }
}