<%@ Page Title="错误提示" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align: center">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/img/error.jpg" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="javascript:history.back();">返回上一页</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/Default.aspx">返回首页</asp:HyperLink>
    </p>
    <p>错误详细信息：<br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </p>
</asp:Content>

