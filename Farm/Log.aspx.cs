using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Farm_Log : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String currentUser = Page.User.Identity.Name;
        sdsStoleMe.SelectCommand = "select source_user,seedname,stoledate from stoleinfo where target_user='" + currentUser+"'";
        sdsMyStolen.SelectCommand = "select target_user,seedname,stoledate from stoleinfo where source_user='" + currentUser+"'";
    }
}