<%@ Page Title="选择种子" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SelectSeed.aspx.cs" Inherits="Farm_SelectSeed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2
        {
            width: 100%;
        }
        .auto-style3
        {
            width: 267px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        请选择您要播种在土地<asp:Label ID="lblFID" runat="server"></asp:Label>
        上的种子：</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" SelectCommand="SELECT [seedid], [seedname], [describe], [mature_minute], [outamount], [sellprice], [pic_location] FROM [seedinfo] WHERE ([seedid] = @seedid)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="seedid" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <table class="auto-style2">
        <tbody style="vertical-align: top">
        <tr>
            <td class="auto-style3">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True" DataKeyNames="sid" Width="259px">
            <Columns>
                <asp:BoundField DataField="sid" HeaderText="种子ID" />
                <asp:BoundField DataField="sname" HeaderText="种子名称" />
                <asp:BoundField DataField="samount" HeaderText="种子存量" />
                <asp:CommandField HeaderText="操作" SelectText="查看详细信息" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
            </td>
            <td>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="201px" AutoGenerateRows="False" DataKeyNames="seedid" DataSourceID="SqlDataSource2" EnableModelValidation="True">
            <Fields>
                <asp:BoundField DataField="seedid" HeaderText="种子ID" ReadOnly="True" SortExpression="seedid" />
                <asp:BoundField DataField="seedname" HeaderText="种子名称" SortExpression="seedname" />
                <asp:BoundField DataField="describe" HeaderText="种子描述" SortExpression="describe" />
                <asp:BoundField DataField="mature_minute" HeaderText="成熟时间" SortExpression="mature_minute" />
                <asp:BoundField DataField="outamount" HeaderText="预计产量" SortExpression="outamount" />
                <asp:BoundField DataField="sellprice" HeaderText="卖出单价" SortExpression="sellprice" />
                <asp:TemplateField HeaderText="种子图片" SortExpression="pic_location">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("pic_location") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("pic_location") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("pic_location") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
            <FooterTemplate>
                <asp:LinkButton ID="lnkbtnSubmit" runat="server" OnClick="lnkbtnSubmit_Click">播种</asp:LinkButton>
            </FooterTemplate>
        </asp:DetailsView>
            </td>
        </tr>
    </table>
</asp:Content>

