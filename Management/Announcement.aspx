<%@ Page Title="公告管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Announcement.aspx.cs" Inherits="Management_Announcement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style2
        {
            width: 100%;
        }
        .auto-style3
        {
            height: 58px;
        }
        .auto-style4
        {
            text-align: right;
        }
        .auto-style5
        {
            height: 19px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2" __designer:mapid="740">
        <tr __designer:mapid="741">
            <td style="width: 114px; height: 71px" __designer:mapid="742" rowspan="3">
                <asp:Image ID="Image2" runat="server" Height="71px" ImageUrl="~/img/information_title.jpg" style="ali" Width="114px" />
            </td>
            <td __designer:mapid="744" class="auto-style5" style="background-color: #3333FF; color: #FFFFFF; font-weight: bold">修改公告</td>
        </tr>
        <tr __designer:mapid="741">
            <td __designer:mapid="744" class="auto-style3">
                <asp:TextBox ID="txtInfo" runat="server" Height="303px" TextMode="MultiLine" Width="632px"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="741">
            <td __designer:mapid="744" class="auto-style4">
                <br />
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />
&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" OnClientClick="return confirm('将丢弃全部修改，确定吗？')" Text="取消" />
&nbsp;</td>
        </tr>
    </table>
</asp:Content>

