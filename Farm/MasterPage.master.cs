using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Farm_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HyperLink hlUser = (HyperLink)e.Row.Cells[0].FindControl("hlUser");
            if(hlUser.Text != Page.User.Identity.Name)
                hlUser.NavigateUrl = "~/Farm/FriendFarm.aspx?username=" + hlUser.Text;
        }  
    }
}
