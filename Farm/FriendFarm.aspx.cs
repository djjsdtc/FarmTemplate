using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Farm_FriendFarm : System.Web.UI.Page
{
    FarmLinqDataContext fldc = new FarmLinqDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        string User = Request.QueryString["username"].ToString();
        SqlDataSource1.SelectCommand = "SELECT [FieldNo], [seedname], [leftgoods], [lefttime], [pic_location] FROM [onfarm] WHERE ([username] = '" + User + "')";
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblName = (Label)e.Row.Cells[0].FindControl("lblName");
            Button Button1 = (Button)e.Row.Cells[0].FindControl("Button1");
            if (lblName.Text == "")
            {
                lblName.Text = "没有种子";
                ((Label)e.Row.Cells[0].FindControl("lblStatus")).Visible = false;
                Button1.Visible = false;
            }
            else
            {
                string status;
                int lefttime = int.Parse(((HiddenField)e.Row.Cells[0].FindControl("hfLeftTime")).Value);
                if (lefttime == 0)
                {
                    status = "已成熟";
                }
                else
                {
                    int day = lefttime / (60 * 24);
                    int hour = (lefttime - (day * 60 * 24)) / 60;
                    int minute = lefttime % 60;
                    status = "还有" + (day == 0 ? "" : day + "天") + (hour == 0 ? "" : hour + "小时") + minute + "分钟成熟";
                    Button1.Enabled = false;
                }
                ((Label)e.Row.Cells[0].FindControl("lblStatus")).Text = status;
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        const int AMOUNT_TOO_LOW = 1;
        const int FOOD_NOT_FOUND = 2;
        const int TODAY_ALREADY = 3;
        String source = Page.User.Identity.Name;
        String target = Request.QueryString["username"].ToString();

       foreach (GridViewRow gvRow in GridView1.Rows)
           if (gvRow.FindControl("Button1") == sender)
           {
               int fieldID = int.Parse(((Label)gvRow.FindControl("lblFieldID")).Text);
               switch (fldc.stole(source, target, fieldID))
               {
                   case AMOUNT_TOO_LOW:
                       Response.Write("<script>alert('请您行行好，给主人留点吧！')</script>");
                       break;
                   case FOOD_NOT_FOUND:
                       Response.Write("<script>alert('您下手不够快哦！这块地已经被主人收走了。')</script>");
                       break;
                   case TODAY_ALREADY:
                       Response.Write("<script>alert('今天已经偷过了，明天再来吧！')</script>");
                       break;
               }
               Response.Write("<script>document.location=document.location;</script>");
           }
       GridView1.DataBind();
       }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
}