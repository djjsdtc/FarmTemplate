<%@ Page Title="农贸集市" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        您好，欢迎来到农贸集市！您当前的金币数为<asp:Label ID="lblLeftMoney" runat="server"></asp:Label>
        ，请选择您要卖出的产品：</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" ProviderName="<%$ ConnectionStrings:FarmConnectionString.ProviderName %>"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="seedname" HeaderText="作物名" />
                <asp:BoundField DataField="foodamount" HeaderText="库存数量" />
                <asp:TemplateField HeaderText="操作">
                    <ItemTemplate>
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("sid") %>' />
                        <asp:LinkButton ID="lnkbtnSell" runat="server" OnClick="lnkbtnSell_Click">卖出</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                仓库里空空的，连老鼠都不愿意来光顾哦！快去种植作物吧！
            </EmptyDataTemplate>
        </asp:GridView>
    </p>
</asp:Content>

