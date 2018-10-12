<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xxhd.aspx.cs" Inherits="Maticsoft.Web.jingtai.xxhd" %>
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
      <h1>学校活动</h1>
      
       &nbsp;&nbsp;&nbsp;&nbsp;<span style="color: rgb(51, 51, 51); font-family: Arial, &quot;Microsoft YaHei&quot;; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">【“智造未来，一见氢锌”迎新晚会】四川文理学院智能制造学院与化学化工学院共同举办的迎新晚会圆满落幕啦！<br />
        <br />
&nbsp;&nbsp;&nbsp; 由智能制造学院与化学化工学院一起举办的迎新晚会在2017年12月12号开幕，现场其乐融融，十分精彩。</span></div>
  </div>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
