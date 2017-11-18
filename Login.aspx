<%@ Page Title="用户登录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" Style="text-align: center" CreateUserText="还是新用户？马上注册" HelpPageText="查看关于注册的帮助" PasswordRecoveryText="忘记密码了？立刻找回" BorderPadding="4" ForeColor="#333333" CreateUserUrl="~/UserSettings/Register.aspx" PasswordRecoveryUrl="~/UserSettings/ForgetPassword.aspx" DestinationPageUrl="~/Default.aspx">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" Font-Size="0.9em" />
        </asp:Login>
</asp:Content>

