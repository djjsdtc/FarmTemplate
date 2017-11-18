<%@ Page Title="查看日志" Language="C#" MasterPageFile="~/Farm/MasterPage.master" AutoEventWireup="true" CodeFile="Log.aspx.cs" Inherits="Farm_Log" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        以下是您最近的农场采摘日志：<asp:SqlDataSource ID="sdsStoleMe" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" ProviderName="<%$ ConnectionStrings:FarmConnectionString.ProviderName %>"></asp:SqlDataSource>
        <asp:SqlDataSource ID="sdsMyStolen" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" ProviderName="<%$ ConnectionStrings:FarmConnectionString.ProviderName %>"></asp:SqlDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="sdsStoleMe" EnableModelValidation="True">
            <Columns>
                <asp:TemplateField HeaderText="最近谁偷了我">
                    <ItemTemplate>
                        <asp:Label ID="lblUser" runat="server" Text='<%# Eval("source_user") %>'></asp:Label>
                        在<asp:Label ID="lblDate" runat="server" Text='<%# ((DateTime)Eval("stoledate")).ToString("yyyy年M月d日") %>'></asp:Label>
                        摘取了您的3个<asp:Label ID="lblSeedName" runat="server" Text='<%# Eval("seedname") %>'></asp:Label>。
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                最近都没有好友来偷你的菜。
            </EmptyDataTemplate>
        </asp:GridView>
    </p>
    <p>
        <asp:GridView ID="GridView4" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="sdsMyStolen" EnableModelValidation="True" style="margin-right: 1px">
            <Columns>
                <asp:TemplateField HeaderText="最近我偷了谁">
                     <ItemTemplate>
                        您在<asp:Label ID="lblDate" runat="server" Text='<%# ((DateTime)Eval("stoledate")).ToString("yyyy年M月d日") %>'></asp:Label>
                         摘取了<asp:Label ID="lblUser" runat="server" Text='<%# Eval("target_user") %>'></asp:Label>
                         的3个<asp:Label ID="lblSeedName" runat="server" Text='<%# Eval("seedname") %>'></asp:Label>。
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                您是个好公民，最近没有偷别人的菜。
            </EmptyDataTemplate>
        </asp:GridView>
    </p>
</asp:Content>

