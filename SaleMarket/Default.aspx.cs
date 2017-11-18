using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    FarmLinqDataContext fldc = new FarmLinqDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        string currentUser = Page.User.Identity.Name;
        SqlDataSource1.SelectCommand = "SELECT foodstorage.seedid as sid,seedname,foodamount FROM foodstorage,seedinfo WHERE (username = '" + currentUser + "' and foodstorage.seedid=seedinfo.seedid)";
        GridView1.DataBind();
        var result = from r in fldc.userinfo
                     where r.UserName == currentUser
                     select new
                     {
                         r.usermoney
                     };
        lblLeftMoney.Text = result.ToList()[0].usermoney.ToString();
    }
    protected void lnkbtnSell_Click(object sender, EventArgs e)
    {
        String username = Page.User.Identity.Name, seedid = null;
        foreach (GridViewRow gvRow in GridView1.Rows)
            if (gvRow.FindControl("lnkbtnSell") == sender)
                seedid = ((HiddenField)gvRow.FindControl("hiddenField1")).Value;
        fldc.sell(seedid, username);
        Response.Redirect("~/SaleMarket/Default.aspx");
    }
}