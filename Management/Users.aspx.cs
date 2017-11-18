using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Management_Users : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindUsers();
        }
    }
    protected void BindUsers()
    {
        MembershipUserCollection muc = Membership.GetAllUsers();
        GridView1.DataSource = muc;
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow gvRow = GridView1.Rows[e.RowIndex];
        string username = gvRow.Cells[0].Text;
        Membership.DeleteUser(username);
        FarmLinqDataContext fldc = new FarmLinqDataContext();
        var results = from r in fldc.userinfo
                      where r.UserName == username
                      select r;
        fldc.userinfo.DeleteAllOnSubmit(results);
        fldc.SubmitChanges();
        BindUsers();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string username = e.Row.Cells[0].Text;
            string email=Membership.GetUser(username).Email;
            if (Roles.IsUserInRole(username, "Player")) e.Row.Cells[1].Text = "用户";
            else if (Roles.IsUserInRole(username, "GM"))
            {
               e.Row.Cells[1].Text = "管理员";
               ((LinkButton)e.Row.Cells[6].FindControl("lnkbtnDelete")).Visible = false;
            }
            e.Row.Cells[2].Text = "<a href=\"mailto:" + email + "\">" + email + "</a>";
        }
        
    }
}