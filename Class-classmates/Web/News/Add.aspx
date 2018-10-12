<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.News.Add" Title="增加页" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="../js/ckeditor/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		新闻标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		新闻类别
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlFk_NewsType_Id" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllList" TypeName="Maticsoft.BLL.NewsType"></asp:ObjectDataSource>	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		新闻内容
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtContents"  runat="server" Width="200px"></asp:TextBox>
	   
    </td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发布用户
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlFk_Users_Id" runat="server" 
            DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" 
            Enabled="False"></asp:DropDownList>
		<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllList" TypeName="Maticsoft.BLL.Users"></asp:ObjectDataSource>	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发布时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtAddTime" runat="server" Width="70px"  onfocus="return Calendar('ctl00_ContentPlaceHolder1_txtAddTime')" onclick="return Calendar('ctl00_ContentPlaceHolder1_txtAddTime')"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
