using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.IO;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        Roles.AddUserToRole(CreateUserWizard1.UserName, "Player");
        FarmLinqDataContext fldc = new FarmLinqDataContext();
        userinfo user_info = new userinfo();
        user_info.UserName = CreateUserWizard1.UserName;
        user_info.usermoney = 50000;
        user_info.fieldnum = 9;
        fldc.userinfo.InsertOnSubmit(user_info);
        fldc.SubmitChanges();
    }
    protected void TextBox1_Load(object sender, EventArgs e)
    {
        StreamReader reader = new StreamReader(Server.MapPath("~/License.txt"));
        TextBox1.Text = reader.ReadToEnd();
        reader.Close();
    }
}