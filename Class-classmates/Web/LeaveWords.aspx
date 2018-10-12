<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaveWords.aspx.cs" Inherits="Maticsoft.Web.LeaveWords" %>

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
<uc1:left ID="left1" runat="server" />
  <!--left.end-->
  
  <!--right.start-->
  <div class="pright">
    <div class="prplace">
      <a href="index.aspx">主页</a>
    </div>
    <dl class="p2">
      <dd>
        <ul class="b3">
          <asp:Repeater ID="rptList" runat="server" DataSourceID="ObjectDataSource2">
          <ItemTemplate>
          <li><a href="Newss.aspx?id=<%#Eval("Id").ToString()%>"><%#Eval("Name").ToString()%></a><small>(<%#Convert.ToDateTime(Eval("AddTime")).ToString("yyyy-MM-dd")%>)</small></li>
          </ItemTemplate>
          </asp:Repeater> 
          <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetAllList" TypeName="Maticsoft.BLL.News">
        </asp:ObjectDataSource>
        </ul>
      </dd>
    </dl>
    <div class="pagebox">
      <div id="Pagination" class="flickr right"></div>
        
    </div>
  </div>
  <!--right.end-->
</div>
</asp:Content>


