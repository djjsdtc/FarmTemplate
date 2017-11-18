<%@ Page Title="首页" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align: center">
        <asp:LoginView ID="LoginView2" runat="server">
            <AnonymousTemplate>
                <asp:Image ID="Image1" runat="server" Height="699px" ImageUrl="~/img/splash.jpg" Width="556px" />
            </AnonymousTemplate>
            <LoggedInTemplate>
                <table class="auto-style2">
                    <tr style="vertical-align: top">
                        <td style="width: 114px; height: 71px">
                            <asp:Image ID="Image2" runat="server" Height="71px" ImageUrl="~/img/information_title.jpg" style="ali" Width="114px" />
                        </td>
                        <td>
                            <asp:Label ID="lblInfo" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
            </LoggedInTemplate>
        </asp:LoginView>
    </p>
</asp:Content>

