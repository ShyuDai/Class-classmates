﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="grzlxg.aspx.cs" Inherits="Maticsoft.Web.jingtai.grzlxg" %>
<%@ Register src="../left.ascx" tagname="left" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="/css/style.css" />
<link href="/images/library/msg.css" rel="stylesheet" type="text/css" />
<link href="/css/custom-theme/jquery-ui-1.7.2.custom.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="/js/jquery-ui-1.7.2.custom.min.js"></script>
<script type="text/javascript" src="/images/library/msg.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
  <!--left.start-->
  <uc1:left ID="left1" runat="server" />
  <!--left.end-->
  
  <!--right.start-->
  <div class="pright">
    <div class="prplace">
      <a href="/Default.aspx">主页</a>
        
    </div>
    <div class="pageInfo">
      <table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		帐号
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblName" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPassword" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTrueName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlSex" runat="server"><asp:ListItem>男</asp:ListItem><asp:ListItem>女</asp:ListItem></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		照片
	：</td>
	<td height="25" width="*" align="left">
		<asp:FileUpload ID="fuPhoto" runat="server" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		邮箱
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		生日
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtBirthday" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否激活
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsActivity" Text="是否激活" runat="server" Checked="True" 
            Enabled="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		角色名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlFk_Roles_Id" runat="server" 
            DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" 
            Enabled="False"></asp:DropDownList>
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllList" TypeName="Maticsoft.BLL.Roles"></asp:ObjectDataSource>	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
        </td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
            </td>
        </tr>
    </table>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
