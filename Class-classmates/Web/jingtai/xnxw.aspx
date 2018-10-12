<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xnxw.aspx.cs" Inherits="Maticsoft.Web.jingtai.xnxw" %>
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
      <h1>校内新闻</h1>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p style="font-size: 16px; color: rgb(0, 0, 0); font-family: 宋体; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); line-height: 30px; text-indent: 2em;">
            <strong>四川新闻网达州11月27日讯(甘玉锋)</strong>近<a name="_GoBack"></a>日，四川文理学院隆重举行新媒体联盟成立大会暨易班工作站授牌仪式，校园新媒体联盟正式成立。该联盟旨在融合各二级单位新媒体公众平台，共同做好信息发布、舆论引导、思政教育工作，为学校大思政格局的构建增添力量。</p>
        <p style="font-size: 16px; color: rgb(0, 0, 0); font-family: 宋体; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); line-height: 30px; text-indent: 2em;">
            据统计，目前四川文理学院各二级单位共开通了44个新媒体公众平台，为规范管理、整合资源、凝聚力量，学校党委经过深入考察论证，决定成立新媒体联盟。会上，党委书记王成端、校长刁永锋、党委副书记侯忠明、雷超共同为学校各二级学院易班工作站授牌。大会宣布了新媒体联盟副理事长单位名单，新媒体联盟成员名单。经过评选，招生就业处、教务处、文学与传播学院、马克思主义学院&amp;政法学院等10个二级单位当选新媒体联盟副理事长单位，武装保卫处、工会、人事处、科技处、审计处、发展规划处等22个部门入选成为新媒体联盟成员。</p>
        <p style="font-size: 16px; color: rgb(0, 0, 0); font-family: 宋体; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); line-height: 30px; text-indent: 2em;">
            大会还对《四川文理学院新媒体联盟章程》、《新媒体管理暂行办法》、《网络舆情监控及应急处理预案》、《四川文理学院二级学院易班建设方案》作了深入解读。</p>


    </div>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
