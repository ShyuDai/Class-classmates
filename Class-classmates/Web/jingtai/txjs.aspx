<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="txjs.aspx.cs" Inherits="Maticsoft.Web.jingtai.txjs" %>
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
      <h1>同学介绍</h1>
     <br> ①班长：全面负责组织和管理本班的各项工作，负责召集班委会议，关心同学，传达院系思想等。
<br>③学习委员：负责领取本班的教材，作业的收发，以及点名，帮助同学解答学习上的问题。
<br>④体育委员：积极配合学校开展的各种体育活动，如校运会，体操比赛等。 
<br>⑤劳动委员：负责卫生安排，以及班费的开支。 
<br>⑥生活委员：负责本班的生活与团结的管理，以及班费的开支。 
<br>⑦文娱委员：负责策划班级文化活动，如班会活动、文娱联欢等。 
<br>⑧团支书：负责团组织活动的组织与安排
        <br>⑨以及各位可爱的同学们
    </div>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
