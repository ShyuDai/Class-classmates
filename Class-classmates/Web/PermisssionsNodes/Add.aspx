<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.PermisssionsNodes.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		权限编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlFk_Permissions_Id" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllList" TypeName="Maticsoft.BLL.Permissions"></asp:ObjectDataSource>	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		节点编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlFk_Nodes_Id" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
		<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllList" TypeName="Maticsoft.BLL.Nodes"></asp:ObjectDataSource>	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
