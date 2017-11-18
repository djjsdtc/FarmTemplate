<%@ Page Title="我的农场" Language="C#" MasterPageFile="~/Farm/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Farm_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" SelectCommand="SELECT * FROM [farmtable]"></asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="False">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick">
        </asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" ShowHeader="False" style="margin-right: 0px">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table style="width: 97%">
                                    <tr>
                                        <td class="auto-style3" rowspan="3">
                                            <asp:Image ID="imgPic" runat="server" ImageUrl='<%# Eval("pic_location") %>' />
                                        </td>
                                        <td class="auto-style10" style="width: 154px">土地<asp:Label ID="lblFieldID" runat="server" Text='<%# Eval("FieldNo") %>'></asp:Label>
                                        </td>
                                        <td class="auto-style11" rowspan="3">
                                            <asp:HiddenField ID="hfLeftTime" runat="server" Value='<%# Eval("lefttime") %>' />
                                            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style10" style="width: 154px">
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("seedname") %>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style10" style="width: 154px">
                                            <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>

