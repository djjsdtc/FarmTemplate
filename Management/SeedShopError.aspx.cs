using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SeedShop_ErrorInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["type"] == "insert") MultiView1.ActiveViewIndex = 0;
        else if (Request.QueryString["type"] == "delete") MultiView1.ActiveViewIndex = 1;
        lblMessage.Text = Request.QueryString["message"];
    }
}