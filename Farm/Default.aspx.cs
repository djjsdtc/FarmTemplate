using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Farm_Default : System.Web.UI.Page
{
    FarmLinqDataContext fldc = new FarmLinqDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        string currentUser = Page.User.Identity.Name;
        SqlDataSource1.SelectCommand = "SELECT [FieldNo], [seedname], [leftgoods], [lefttime], [pic_location] FROM [onfarm] WHERE ([username] = '" + currentUser + "')";
        //GridView1.DataBind();
        //在asp2.0中数据控件会自动DataBind，如果手工调用可能会出问题。
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
                Button1.Text = "播种";
            }
            else
            {
                Button1.Text = "收获";
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
        if (((Button)sender).Text == "收获")
        {
            String username = Page.User.Identity.Name;
            foreach (GridViewRow gvRow in GridView1.Rows)
                if (gvRow.FindControl("Button1") == sender)
                {
                    int fieldID = int.Parse(((Label)gvRow.FindControl("lblFieldID")).Text);
                    fldc.harvest(username, fieldID);
                    break;
                }
            GridView1.DataBind();
        }
        else if (((Button)sender).Text == "播种")
        {
            String fieldID = null;
            foreach (GridViewRow gvRow in GridView1.Rows)
                if (gvRow.FindControl("Button1") == sender)
                {
                    fieldID = ((Label)gvRow.FindControl("lblFieldID")).Text;
                    break;
                }
            Response.Redirect("~/Farm/SelectSeed.aspx?fid=" + fieldID);
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
}