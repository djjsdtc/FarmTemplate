using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Xml.Linq;
using System.Data;

public partial class Help_MasterPage : System.Web.UI.MasterPage
{
    public readonly Color unselectBg = Color.FromArgb(204, 255, 204);
    public readonly Color selectBg = Color.FromArgb(102, 153, 255);
    
    protected void Page_Load(object sender, EventArgs e)
    {
        BindFavor();
        lblTitle.Text = this.Page.Title;
    }

    private void BindFavor()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("title");
        dt.Columns.Add("url");
        for (int i = 0; i < Profile.title.Count; i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = Profile.title[i];
            dr[1] = Profile.url[i];
            dt.Rows.Add(dr);
        }
        gvFavor.DataSource = dt;
        gvFavor.DataBind();
    }
    protected void btnContent_Click(object sender, EventArgs e)
    {
        btnFavor.BackColor = unselectBg;
        btnFavor.ForeColor = Color.Black;
        btnContent.BackColor = selectBg;
        btnContent.ForeColor = Color.White;
        MultiView1.SetActiveView(View1);
    }
    protected void btnFavor_Click(object sender, EventArgs e)
    {
        btnContent.BackColor = unselectBg;
        btnContent.ForeColor = Color.Black;
        btnFavor.BackColor = selectBg;
        btnFavor.ForeColor = Color.White;
        MultiView1.SetActiveView(View2);
    }
    protected void lnkbtnAdd_Click(object sender, EventArgs e)
    {
        if (!Profile.title.Contains(this.Page.Title))
        {
            Profile.title.Add(this.Page.Title);
            Profile.url.Add(this.Page.Request.Path);
            BindFavor();
        }
    }
    protected void gvFavor_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Profile.title.RemoveAt(e.RowIndex);
        Profile.url.RemoveAt(e.RowIndex);
        BindFavor();
    }
}
