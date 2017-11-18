<%@ Page Title="种子管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SeedShop.aspx.cs" Inherits="SeedShop_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2
        {
            width: 100%;
        }
        .auto-style3
        {
            width: 471px;
        }
    </style>
    <script type="text/javascript"'>
        function IDTest(source, args) {
            args.IsValid = (args.Value.length == 6);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" SelectCommand="SELECT * FROM [seedinfo]" DeleteCommand="DELETE FROM [seedinfo] WHERE [seedid] = @seedid" InsertCommand="INSERT INTO [seedinfo] ([seedid], [seedname], [describe], [buyprice], [mature_minute], [outamount], [sellprice], [isselling], [pic_location]) VALUES (@seedid, @seedname, @describe, @buyprice, @mature_minute, @outamount, @sellprice, @isselling, @pic_location)" UpdateCommand="UPDATE [seedinfo] SET [seedname] = @seedname, [describe] = @describe, [buyprice] = @buyprice, [mature_minute] = @mature_minute, [outamount] = @outamount, [sellprice] = @sellprice, [isselling] = @isselling, [pic_location] = @pic_location WHERE [seedid] = @seedid">
        <DeleteParameters>
            <asp:Parameter Name="seedid" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="seedid" Type="String" />
            <asp:Parameter Name="seedname" Type="String" />
            <asp:Parameter Name="describe" Type="String" />
            <asp:Parameter Name="buyprice" Type="Int32" />
            <asp:Parameter Name="mature_minute" Type="Int32" />
            <asp:Parameter Name="outamount" Type="Int32" />
            <asp:Parameter Name="sellprice" Type="Int32" />
            <asp:Parameter Name="isselling" Type="Boolean" />
            <asp:Parameter Name="pic_location" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="seedname" Type="String" />
            <asp:Parameter Name="describe" Type="String" />
            <asp:Parameter Name="buyprice" Type="Int32" />
            <asp:Parameter Name="mature_minute" Type="Int32" />
            <asp:Parameter Name="outamount" Type="Int32" />
            <asp:Parameter Name="sellprice" Type="Int32" />
            <asp:Parameter Name="isselling" Type="Boolean" />
            <asp:Parameter Name="pic_location" Type="String" />
            <asp:Parameter Name="seedid" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:FarmConnectionString %>" DeleteCommand="DELETE FROM [seedinfo] WHERE [seedid] = @seedid" InsertCommand="INSERT INTO [seedinfo] ([seedid], [seedname], [describe], [buyprice], [mature_minute], [outamount], [sellprice], [isselling], [pic_location]) VALUES (@seedid, @seedname, @describe, @buyprice, @mature_minute, @outamount, @sellprice, @isselling, @pic_location)" SelectCommand="SELECT * FROM [seedinfo] WHERE ([seedid] = @seedid)" UpdateCommand="UPDATE [seedinfo] SET [seedname] = @seedname, [describe] = @describe, [buyprice] = @buyprice, [mature_minute] = @mature_minute, [outamount] = @outamount, [sellprice] = @sellprice, [isselling] = @isselling, [pic_location] = @pic_location WHERE [seedid] = @seedid" ProviderName="<%$ ConnectionStrings:FarmConnectionString.ProviderName %>">
        <DeleteParameters>
            <asp:Parameter Name="seedid" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="seedid" Type="String" />
            <asp:Parameter Name="seedname" Type="String" />
            <asp:Parameter Name="describe" Type="String" />
            <asp:Parameter Name="buyprice" Type="Int32" />
            <asp:Parameter Name="mature_minute" Type="Int32" />
            <asp:Parameter Name="outamount" Type="Int32" />
            <asp:Parameter Name="sellprice" Type="Int32" />
            <asp:Parameter Name="isselling" Type="Boolean" />
            <asp:Parameter Name="pic_location" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="seedid" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="seedname" Type="String" />
            <asp:Parameter Name="describe" Type="String" />
            <asp:Parameter Name="buyprice" Type="Int32" />
            <asp:Parameter Name="mature_minute" Type="Int32" />
            <asp:Parameter Name="outamount" Type="Int32" />
            <asp:Parameter Name="sellprice" Type="Int32" />
            <asp:Parameter Name="isselling" Type="Boolean" />
            <asp:Parameter Name="pic_location" Type="String" />
            <asp:Parameter Name="seedid" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:LinkButton ID="lnkbtnCreate" runat="server" OnClick="lnkbtnCreate_Click">创建新种子</asp:LinkButton>
    <br />
    <table class="auto-style2">
        <tr style="text-align: left; vertical-align: top">
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="seedid" DataSourceID="SqlDataSource1" EnableModelValidation="True" Width="470px" OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="seedid" HeaderText="种子ID" ReadOnly="True" SortExpression="seedid" />
                        <asp:BoundField DataField="seedname" HeaderText="种子名称" SortExpression="seedname" />
                        <asp:TemplateField HeaderText="操作">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="查看/修改"></asp:LinkButton>
                                &nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确实要删除吗？我们建议您不使用“删除”功能，而取消“客户端可见”选项。')"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                	<EmptyDataTemplate>
						当前没有种子，请单击上方的“创建新种子”链接创建一个种子。
					</EmptyDataTemplate>
                </asp:GridView>
            </td>
            <td>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="seedid" DataSourceID="SqlDataSource2" EnableModelValidation="True" Height="50px" Width="329px" OnItemCreated="DetailsView1_ItemCreated" OnItemInserted="DetailsView1_ItemInserted" OnItemDeleted="DetailsView1_ItemDeleted">
        <EmptyDataTemplate>
            从左边选择一项以进行查看和修改。
        </EmptyDataTemplate>
        <Fields>
            <asp:TemplateField HeaderText="种子ID" SortExpression="seedid">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("seedid") %>'></asp:Label>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="txtID" runat="server" MaxLength="6" Text='<%# Bind("seedid") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtID" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True" ClientValidationFunction="IDTest">长度不足6</asp:CustomValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("seedid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="种子名称" SortExpression="seedname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("seedname") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("seedname") %>'></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("seedname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="种子描述" SortExpression="describe">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Height="58px" Text='<%# Bind("describe") %>' TextMode="MultiLine" Width="242px"></asp:TextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Height="59px" Text='<%# Bind("describe") %>' TextMode="MultiLine" Width="249px"></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("describe") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="买入价格" SortExpression="buyprice">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEditPrice" runat="server" Text='<%# Bind("buyprice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEditPrice" runat="server" ControlToValidate="txtEditPrice">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvEditPrice" runat="server" ControlToValidate="txtEditPrice" MinimumValue="0" MaximumValue="100000" Type="Integer">不能小于0</asp:RangeValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="txtInsertPrice" runat="server" Text='<%# Bind("buyprice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvInsertPrice" runat="server" ControlToValidate="txtInsertPrice">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvInsertPrice" runat="server" ControlToValidate="txtInsertPrice" MinimumValue="0" MaximumValue="100000" Type="Integer">不能小于0</asp:RangeValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("buyprice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="成熟时间(分钟)" SortExpression="mature_minute">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEditTime" runat="server" Text='<%# Bind("mature_minute") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEditTime" runat="server" ControlToValidate="txtEditTime">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvEditTime" runat="server" ControlToValidate="txtEditTime" MinimumValue="0" MaximumValue="100000" Type="Integer">不能小于0</asp:RangeValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="txtInsertTime" runat="server" Text='<%# Bind("mature_minute") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvInsertTime" runat="server" ControlToValidate="txtInsertTime">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvInsertTime" runat="server" ControlToValidate="txtInsertTime" MinimumValue="0" MaximumValue="100000" Type="Integer">不能小于0</asp:RangeValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("mature_minute") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="产量" SortExpression="outamount">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEditAmount" runat="server" Text='<%# Bind("outamount") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEditAmount" runat="server" ControlToValidate="txtEditAmount">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvEditAmount" runat="server" ControlToValidate="txtEditAmount" MinimumValue="1" MaximumValue="100000" Type="Integer">不能小于1</asp:RangeValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="txtInsertAmount" runat="server" Text='<%# Bind("outamount") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvInsertAmount" runat="server" ControlToValidate="txtInsertAmount">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvInsertAmount" runat="server" ControlToValidate="txtInsertAmount" MinimumValue="1" MaximumValue="100000" Type="Integer">不能小于1</asp:RangeValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("outamount") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="卖出价格" SortExpression="sellprice">
                <EditItemTemplate>
                    <asp:TextBox ID="txtEditSell" runat="server" Text='<%# Bind("sellprice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEditSell" runat="server" ControlToValidate="txtEditSell">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvEditSell" runat="server" ControlToValidate="txtEditSell" MinimumValue="1" MaximumValue="100000" Type="Integer">不能小于1</asp:RangeValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="txtInsertSell" runat="server" Text='<%# Bind("sellprice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvInsertSell" runat="server" ControlToValidate="txtInsertSell">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvInsertSell" runat="server" ControlToValidate="txtInsertSell" MinimumValue="1" MaximumValue="100000" Type="Integer">不能小于1</asp:RangeValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("sellprice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CheckBoxField DataField="isselling" HeaderText="客户端可见" SortExpression="isselling" />
            <asp:TemplateField HeaderText="种子图片" SortExpression="pic_location">
                <EditItemTemplate>
                    <asp:Image ID="imgEdit" runat="server" ImageUrl='<%# Bind("pic_location") %>' />
                    <br />
                    <asp:FileUpload ID="fuEdit" runat="server" />
                    <br />
                    <asp:Button ID="btnEdit" runat="server" Text="上传" OnClick="UploadImage"/>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:Image ID="imgInsert" runat="server" ImageUrl='<%# Bind("pic_location") %>' />
                    <br />
                    <asp:FileUpload ID="fuInsert" runat="server" />
                    <br />
                    <asp:Button ID="btnInsert" runat="server" Text="上传" OnClick="UploadImage" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="imgShow" runat="server" ImageUrl='<%# Eval("pic_location") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" NewText="" />
        </Fields>
    </asp:DetailsView>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>

