<%@ Page Title="用户管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Management_Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowDeleting="GridView1_RowDeleting" OnRowDataBound="GridView1_RowDataBound">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="用户名" />
            <asp:BoundField HeaderText="账户类型" />
            <asp:BoundField HeaderText="E-mail" />
            <asp:BoundField DataField="CreationDate" HeaderText="注册时间" />
            <asp:BoundField DataField="LastLoginDate" HeaderText="最后登陆" />
            <asp:CheckBoxField DataField="IsOnline" HeaderText="在线" />
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkbtnDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确实要删除此用户吗？');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

