<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="Maticsoft.Web.UsersList" %>
<%@ Register src="left.ascx" tagname="left" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="/css/style.css" />
<link href="/images/library/msg.css" rel="stylesheet" type="text/css" />
<link href="/css/custom-theme/jquery-ui-1.7.2.custom.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="/js/jquery-ui-1.7.2.custom.min.js"></script>
<script type="text/javascript" src="/images/library/msg.js"></script>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="main">
  <!--left.start-->
  <!--left.end-->
        
  <!--right.start-->
            
              <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td >
                         <b>&nbsp; 帐号：</b>
                         <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp; 姓名：</b>&nbsp;<asp:TextBox 
                             ID="txtTrueName" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>           
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
		<asp:TemplateField HeaderText="角色名称">
		<ItemTemplate>
			<asp:Label ID="lblFk_Roles_Id" runat="server" Text='<%#Eval("Fk_Roles_Id") %>'  Visible="false"></asp:Label>
			<asp:Repeater ID="rptFk_Roles_Id" runat="server" DataSourceID="odsFk_Roles_Id"><ItemTemplate><%#Eval("Name") %></ItemTemplate></asp:Repeater>
			<asp:ObjectDataSource ID="odsFk_Roles_Id" runat="server" SelectMethod="GetModel" TypeName="Maticsoft.BLL.Roles"><SelectParameters><asp:ControlParameter ControlID="lblFk_Roles_Id" Name="Id" PropertyName="Text" Type="Int32" /></SelectParameters></asp:ObjectDataSource>
		</ItemTemplate>
		</asp:TemplateField>
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" 
                            DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Userss.aspx?id={0}"
                                Text="详细"  >
<ControlStyle Width="50px"></ControlStyle>
                        </asp:HyperLinkField>
                        </Columns>

<RowStyle HorizontalAlign="Center"></RowStyle>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
  <!--right.end-->
</div>
</asp:Content>

