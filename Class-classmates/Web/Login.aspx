<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Maticsoft.Web.Login" %>

<%@ Register src="Controls/copyright.ascx" tagname="copyright" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登陆</title>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;

}
-->
</style>

<link href="images/skin.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
<table width="100%" height="166" border="0" cellpadding="0" cellspacing="0">
  <tr>
  
        </table></td>
        <td width="1%" >&nbsp;</td>
        <td width="50%" valign="bottom"><table width="100%" height="59" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="4%">&nbsp;</td>
              <td width="96%" height="38"><span class="login_txt_bt">登陆后台管理</span></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td height="21"><table cellSpacing="0" cellPadding="0" width="100%" border="0" id="table211" height="328">
                  <tr>
                    <td height="164" colspan="2" align="middle">
                        <table cellSpacing="0" cellPadding="0" width="100%" border="0" height="143" id="table212">
                          <tr>
                            <td width="13%" height="38" class="top_hui_text"><span class="login_txt">管理员：&nbsp;&nbsp; </span></td>
                            <td height="38" colspan="2" align="left" ><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
                          </tr>
                          <tr>
                            <td width="13%" height="35" class="top_hui_text"><span class="login_txt"> 密 码： &nbsp;&nbsp; </span></td>
                            <td height="35" colspan="2" align="left"><asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                            <td width="13%" height="35" >&nbsp;</td>
                            <td height="35" colspan="2" align="left">&nbsp;<asp:Button runat="server" 
                                    ID="btnLogin" CssClass="button" Text="登 陆" onclick="btnLogin_Click" />&nbsp;&nbsp;
                                <asp:Button runat="server" ID="btnCancel" CssClass="button" Text="取 消" 
                                    onclick="btnCancel_Click" /></td>
                          </tr>
</table>

    </form>

</body>
</html>
