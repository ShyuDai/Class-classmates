<%@ Page Language="C#"  MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Newss.aspx.cs" Inherits="Maticsoft.Web.Newss" %>

<%@ Register src="left.ascx" tagname="left" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="/css/style.css" />
<link href="/images/library/msg.css" rel="stylesheet" type="text/css" />
<link href="/css/custom-theme/jquery-ui-1.7.2.custom.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="/js/jquery-ui-1.7.2.custom.min.js"></script>
<script type="text/javascript" src="/images/library/msg.js"></script>
<style type="text/css">
    .style1
    {
        color: #FF0000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
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
      <h1><asp:Label runat="server" ID="lblName"></asp:Label></h1>
      <div class="note">作者：<asp:Label runat="server" ID="lblFk_Users_Id"></asp:Label>  发布时间：<asp:Label runat="server" ID="lblAddTime"></asp:Label></div>
      <asp:Label runat="server" ID="lblContents"></asp:Label>
    </div>
  </div>
    <div class="pright">
    <div class="prplace">
      &nbsp;<span class="style1"><strong>留言建议</strong></span>&nbsp;
    </div>
    <div class="pageInfo">
      <div class="listMsg">
        <asp:Repeater ID="rptList" runat="server" onitemdatabound="rptList_ItemDataBound" 
              DataSourceID="ObjectDataSource1">
          <ItemTemplate>
          <dl>
            <dt><span>发表时间：<%#Eval("AddTimes").ToString()%></span><b><asp:Label runat="server" ID="lblleaveusername" Text='<%#Eval("Fk_Users_Id").ToString()%>'></asp:Label></dt>
            <dd>
              <%#Eval("Contents").ToString()%>
            </dd>
          </dl>
          </ItemTemplate>
        </asp:Repeater>
          <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
              SelectMethod="GetListByNewsId" TypeName="Maticsoft.BLL.Leaveword">
              <SelectParameters>
                  <asp:QueryStringParameter Name="newsid" QueryStringField="id" Type="Int32" />
              </SelectParameters>
          </asp:ObjectDataSource>
        
      </div>
      
      <div class="line10"></div>
      <div class="addMsg">
        <h2>发表留言</h2>
        <table cellpadding="0" cellspacing="0" border="0" width="100%" class="questionTable">
        <tr>
          <td width="15%" align="right">帐号 *</td>
          <td width="85%">
              <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
          <td align="right">留言内容 *</td>
          <td>
        
        <div class="pagebox"><div id="Pagination" class="flickr right"></div></div>
              <asp:TextBox ID="txtContent" runat="server" style="width:400px;height:100px;" TextMode="MultiLine" CssClass="textarea required"></asp:TextBox></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td><asp:Button ID="btnSend" runat="server" Text="提交留言" onclick="btnSend_Click" CssClass="submit"  /></td>
        </tr> 
        </table>
      </div>
      
    </div>
  </div>
  <!--right.end-->
</div>
</asp:Content>


