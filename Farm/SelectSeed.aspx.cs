using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Farm_SelectSeed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string currentUser = Page.User.Identity.Name;
        SqlDataSource1.SelectCommand = "SELECT seedstorage.seedid as sid,seedname as sname,seedamount as samount FROM seedstorage,seedinfo WHERE (username = '" + currentUser + "' and seedstorage.seedid=seedinfo.seedid)";
        GridView1.DataBind();
        lblFID.Text = Request.QueryString["fid"].ToString();
    }
    protected void lnkbtnSubmit_Click(object sender, EventArgs e)
    {
        FarmLinqDataContext fldc = new FarmLinqDataContext();
        fldc.sowseed(Page.User.Identity.Name, GridView1.SelectedValue.ToString(), int.Parse(Request.QueryString["fid"].ToString()));
        Response.Redirect("~/Farm/Default.aspx");
    }
}