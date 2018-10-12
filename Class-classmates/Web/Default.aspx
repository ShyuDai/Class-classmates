<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maticsoft.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="css/style.css" />
    <script type="text/javascript" src="js/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="js/flash.js"></script>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <!--content.Start-->
    <div style=" clear:both;"></div>
    
<div class="main">
  <div class="line10"></div>
  <div class="nleft">
    
    <div class="mode">
      <div class="rm_u">&nbsp;</div>
      <div class="container">
        <h2 class="title">新闻列表<span class="more"><a href="NewsList.aspx">更多 &gt;&gt;</a></span></h2>
        <div class="ul_txt">
          <ul>
            <asp:Repeater ID="Repeater3" runat="server" DataSourceID="ObjectDataSource3">
                <ItemTemplate>
                    <li>
                        <a target="_blank" title='<%#Eval("Name") %>' href='Newss.aspx?id=<%#Eval("Id") %>'><%#Eval("Name") %></a>
                    </li>
                </ItemTemplate>
              </asp:Repeater>
              <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                  SelectMethod="GetListOnExt" TypeName="Maticsoft.BLL.News">
                  <SelectParameters>
                      <asp:Parameter DefaultValue="select top 10 * from News order by Id desc" 
                          Name="strSql" Type="String" />
                  </SelectParameters>
              </asp:ObjectDataSource>
          </ul>
          <div class="clear"></div>
        </div>
      </div>
      <div class="rm_d">&nbsp;</div>
    </div>
    
    <div class="line10"></div>
    
    <div class="tool" style="margin-right:10px;float:left;width:336px;">
      <div class="rn_u">&nbsp;</div>
        <div class="container">
          <h2><span class="border_line">最新留言</span></h2>
          <ul class="ul_txt">
              <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource2">
                <ItemTemplate>
                    <li>
                        <a target="_blank" title='<%#Eval("Contents") %>' href='Newss.aspx?id=<%#Eval("Fk_News_Id") %>'><%#Eval("Contents")%></a>
                    </li>
                </ItemTemplate>
              </asp:Repeater>
              <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                  SelectMethod="GetListOnExt" TypeName="Maticsoft.BLL.Leaveword">
                  <SelectParameters>
                      <asp:Parameter DefaultValue="select top 10 * from Leaveword order by Id desc" 
                          Name="strSql" Type="String" />
                  </SelectParameters>
              </asp:ObjectDataSource>
          </ul>
        </div>
        <div class="rn_d">&nbsp;</div>
    </div>
    <div class="tool" style="float:left;width:336px;">
      <div class="rn_u">&nbsp;</div>
        <div class="container">
          <h2><span class="border_line">通讯录</span><span class="more"><a href="UsersList.aspx">更多 &gt;&gt;</a></span></h2>
          <ul class="ul_txt">
            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="ObjectDataSource1">
                <ItemTemplate>
                    <li>
                        <a target="_blank" title='<%#Eval("TrueName") %>' href='Userss.aspx?id=<%#Eval("Id") %>'><%#Eval("TrueName") %></a>
                    </li>
                </ItemTemplate>
              </asp:Repeater>
              <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                  SelectMethod="GetListOnExt" TypeName="Maticsoft.BLL.Users">
                  <SelectParameters>
                      <asp:Parameter DefaultValue="select top 10 * from Users order by Id desc" 
                          Name="strSql" Type="String" />
                  </SelectParameters>
              </asp:ObjectDataSource>
          </ul>
        </div>
        <div class="rn_d">&nbsp;</div>
    </div>
    
  </div>
  <!--left.end-->
  
  <!--right.start-->
  <div class="nright">
    <div class="tool">
        <div class="container">
          <h2><span class="border_line" style="width:205px;">用户模块</span></h2>
      
      <table cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server" id="tr1">
	<tr>
	<td height="25" width="30%" align="right">
		帐号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
                <asp:Button ID="btnSave" runat="server" Text="登陆"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                &nbsp;&nbsp;
                <asp:Button ID="btnCancle" runat="server" Text="注册"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
        </td></tr>
</table>
    <table cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server" id="tr2">
	<tr>
	<td height="25" width="30%" align="right">
		欢迎您
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label runat="server" ID="lblUsersName"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
                <asp:Button ID="Button1" runat="server" Text="个人中心"
                     class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'" onclick="Button1_Click"></asp:Button>
                &nbsp;&nbsp;<br />
                <asp:Button ID="Button3" runat="server" Text="后台登陆"
                     class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'" onclick="Button3_Click" ></asp:Button>
                <br />
<asp:Button ID="Button2" runat="server" Text="注销退出"
                     class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'" onclick="Button2_Click"></asp:Button>
        </td></tr>
</table>
        </div>
        <div class="rs_d">&nbsp;</div>
    </div>
    
    <div class="line10"></div>
    <div class="tool">
      <div class="rs_u">&nbsp;</div>
        <div class="container">
          <h2><span class="border_line">网站介绍</span></h2>
      <div class="rs_u">&nbsp;</div>
            <span style=" padding:20px">
            该同学录由2015级1班代栩同制作</span></div>
        <div class="rs_d">&nbsp;</div>
    </div>
    
  </div>
  
</div>
<!--content.End-->
</asp:Content>


