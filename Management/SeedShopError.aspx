<%@ Page Title="错误提示" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SeedShopError.aspx.cs" Inherits="SeedShop_ErrorInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="viewInsert" runat="server">
                刚才插入的种子记录有错误，请检查您的种子ID是否和已有种子重复，然后再试一次。
            </asp:View>
            <asp:View ID="viewDelete" runat="server">
                删除不成功，您要删除的种子在农场和/或种子仓库还有存余，请在没有存余的情况下进行删除操作。<br /> 建议：您可以修改种子的“客户端可见”选项为不可见来达到在种子商店删去种子的目的。
            </asp:View>
        </asp:MultiView>
    </p>
    <p>
        数据库返回的错误信息：<asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/Management/SeedShop.aspx">单击此处返回上一页</asp:LinkButton>
    </p>
</asp:Content>

