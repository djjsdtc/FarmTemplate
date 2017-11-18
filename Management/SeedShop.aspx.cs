using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SeedShop_Management : System.Web.UI.Page
{
    private string UploadPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        UploadPath = Server.MapPath("~/img/seedimg/");
    }
    protected void lnkbtnCreate_Click(object sender, EventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.Insert);
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = (args.Value.Length == 6);
    }

    protected void DetailsView1_ItemCreated(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
    protected void UploadImage(object sender, EventArgs e)
    {
        FileUpload Uploader;
        Image img;
        if (DetailsView1.CurrentMode == DetailsViewMode.Insert)
        {
            img = (Image)DetailsView1.FindControl("imgInsert");
            Uploader = (FileUpload)DetailsView1.FindControl("fuInsert");
        }
        else
        {
            img = (Image)DetailsView1.FindControl("imgEdit");
            Uploader = (FileUpload)DetailsView1.FindControl("fuEdit");
        }
        if (Uploader.PostedFile.FileName == "") Response.Write("<script>alert('没有选择文件。')</script>");
        else if (Uploader.PostedFile.ContentLength > 2097152) Response.Write("<script>alert('文件大小不能超过2MB。')</script>");
        else
        {
            string extension = Path.GetExtension(Uploader.PostedFile.FileName);
            switch (extension.ToLower())
            {
                case ".gif":case ".jpg":case ".jpeg":case ".png":
                    break;
                default:
                    Response.Write("<script>alert('仅支持gif、jpg、jpeg、png格式图像。')</script>");
                    return;
            }
            string ServerFileName = Path.GetFileName(Uploader.PostedFile.FileName);
            string fullUploadPath = Path.Combine(UploadPath, ServerFileName);
            try
            {
                Uploader.PostedFile.SaveAs(fullUploadPath);
                img.ImageUrl = "~/img/seedimg/" + ServerFileName;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            string tempStr = e.Exception.Message.Replace((char)13, (char)0).Replace((char)10, (char)0);
            Response.Redirect("~/Management/SeedShopError.aspx?type=insert&message=" + tempStr);
        }
    }
    protected void ItemDeleted(Exception e)
    {
        if (e != null)
        {
            string tempStr = e.Message.Replace((char)13, (char)0).Replace((char)10, (char)0);
            Response.Redirect("SeedShopError.aspx?type=delete&message=" + tempStr);
        }
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        ItemDeleted(e.Exception);
    }
    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        ItemDeleted(e.Exception);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
    }
}