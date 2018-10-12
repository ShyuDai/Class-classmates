<%@ Page Title="Users" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.Users.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>帐号：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" 
        Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" 
        OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>

<ControlStyle Width="30px"></ControlStyle>
                            </asp:TemplateField> 
                            
	<asp:TemplateField HeaderText="照片">
		<ItemTemplate>
			
        <asp:Image ID="iPhoto" runat="server" ImageUrl='<%#Eval("Photo") %>' Width="64px" Height="64px" >
        </asp:Image>
        
		</ItemTemplate>
	</asp:TemplateField>
                            
		<asp:BoundField DataField="Name" HeaderText="帐号" SortExpression="Name" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Password" HeaderText="密码" SortExpression="Password" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="TrueName" HeaderText="姓名" SortExpression="TrueName" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Phone" HeaderText="电话" SortExpression="Phone" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Email" HeaderText="邮箱" SortExpression="Email" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Birthday" HeaderText="生日" SortExpression="Birthday" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="IsActivity" HeaderText="是否激活" SortExpression="IsActivity" 
                            ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:TemplateField HeaderText="角色名称">
		<ItemTemplate>
			<asp:Label ID="lblFk_Roles_Id" runat="server" Text='<%#Eval("Fk_Roles_Id") %>'  Visible="false"></asp:Label>
			<asp:Repeater ID="rptFk_Roles_Id" runat="server" DataSourceID="odsFk_Roles_Id"><ItemTemplate><%#Eval("Name") %></ItemTemplate></asp:Repeater>
			<asp:ObjectDataSource ID="odsFk_Roles_Id" runat="server" SelectMethod="GetModel" TypeName="Maticsoft.BLL.Roles"><SelectParameters><asp:ControlParameter ControlID="lblFk_Roles_Id" Name="Id" PropertyName="Text" Type="Int32" /></SelectParameters></asp:ObjectDataSource>
		</ItemTemplate>
		</asp:TemplateField>
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" 
                            DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  >
<ControlStyle Width="50px"></ControlStyle>
                        </asp:HyperLinkField>
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" 
                            DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  >
<ControlStyle Width="50px"></ControlStyle>
                        </asp:HyperLinkField>
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>

<ControlStyle Width="50px"></ControlStyle>
                            </asp:TemplateField>
                        </Columns>

<RowStyle HorizontalAlign="Center"></RowStyle>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
