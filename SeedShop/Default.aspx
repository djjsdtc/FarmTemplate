<%@ Page Title="种子商店" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
	border-width: 0;
            text-align: left;
        }
        .auto-style3
        {
            border-width: 0;
            width: 143px;
        }
        .auto-style4
        {
            border-width: 0;
            text-align: left;
            width: 427px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        您好，欢迎光临种子商店！您当前持有的金币数为<asp:Label ID="lblLeftMoney" runat="server"></asp:Label>
        。欢迎您的选购。</p>
    <p>
    <asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" SelectCommand="SELECT [pic_location], [sellprice], [outamount], [mature_minute], [buyprice], [describe], [seedname], [seedid] FROM [seedinfo] WHERE ([isselling] = @isselling)">
        <SelectParameters>
            <asp:Parameter DefaultValue="True" Name="isselling" Type="Boolean" />
        </SelectParameters>
	</asp:SqlDataSource>
    </p>
	<p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="seedid" DataSourceID="SqlDataSource1" EnableModelValidation="True" ShowHeader="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table style="width: 97%">
                            <tr>
                                <td class="auto-style3" rowspan="7">
                                    <asp:Image ID="imgPic" runat="server" ImageUrl='<%# Eval("pic_location") %>' />
                                </td>
                                <td class="auto-style4">种子编号：<asp:Label ID="lblID" runat="server" Text='<%# Eval("seedid") %>'></asp:Label>
                                </td>
                                <td class="auto-style2" rowspan="7">
                                    数量<br />
                                    <asp:TextBox ID="txtAmount" runat="server" Width="47px"></asp:TextBox>
                                    <br />
                                    <asp:Button ID="btnSubmit" runat="server" Text="购买" OnClick="btnSubmit_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">名称：<asp:Label ID="lblName" runat="server" Text='<%# Eval("seedname") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">价格：<asp:Label ID="lblPrice" runat="server" Text='<%# Eval("buyprice") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">预计成熟时间：<asp:Label ID="lblMatureMinute" runat="server" Text='<%# Eval("mature_minute") %>'></asp:Label>
                                    分钟</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">预计产量：<asp:Label ID="lblAmount" runat="server" Text='<%# Eval("outamount") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">果实卖出单价：<asp:Label ID="lblSellPrice" runat="server" Text='<%# Eval("sellprice") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">简述：<asp:Label ID="lblDescription" runat="server" Text='<%# Eval("describe") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
	</p>
    <p>
	&nbsp;</p>
    </asp:Content>

