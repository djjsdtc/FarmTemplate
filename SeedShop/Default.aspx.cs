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
    const int FAIL = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        var result = from r in fldc.userinfo
                     where r.UserName == Page.User.Identity.Name
                     select new
                     {
                         r.usermoney
                     };
        lblLeftMoney.Text = result.ToList()[0].usermoney.ToString();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            String username = Page.User.Identity.Name, seedid=null;
            int amount=0;
            foreach (GridViewRow gvRow in GridView1.Rows)
                if (gvRow.FindControl("btnSubmit") == sender)
                {
                    seedid = ((Label)gvRow.FindControl("lblID")).Text;
                    amount = int.Parse(((TextBox)gvRow.FindControl("txtAmount")).Text);
                    if (amount <= 0) throw new FormatException();
                }
            if(fldc.buyseed(username, seedid, amount)==FAIL) throw new ArgumentOutOfRangeException();
        }
        catch (FormatException)
        {
            Response.Write("<script>alert('输入的数量不正确，请重新输入！')</script>");
        }
        catch (ArgumentOutOfRangeException)
        {
            Response.Write("<script>alert('您的金币数不足以购买这么多的种子，请仔细核对！')</script>");
        }
        Response.Write("<script>document.location=document.location;</script>");
    }
}