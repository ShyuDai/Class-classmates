<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="txds.aspx.cs" Inherits="Maticsoft.Web.jingtai.txds" %>
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
      <h1>天下大事</h1>
      
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
      10月，中国工商银行（亚洲）有限公司（简称“工银亚洲”）发行了5亿美元10年期美元债券，成为《巴塞尔协议Ⅲ》在中国落地后，首批在境外发行的符合该协议的美元债券之一。这批美元债券可以在5年后赎回，利率为4.5%，用作补充工银亚洲的二级资本。
 
 
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2013年1月1日起，中国正式实施《商业银行资本管理办法》，作为中国版的《巴塞尔协议Ⅲ》。早于工银亚洲，天津滨海农村商业银行（简称“滨海银行”）在6月份发行了中国银行业首单符合《巴塞尔协议Ⅲ》要求的人民币二级资本债券。发行总额15亿元，期限10年，利率6.5%。在《巴塞尔协议Ⅲ》实施以前，工银亚洲2011年底在香港发行过一批符合框架要求的人民币二级资本债券。发行量15亿人民币，年利率6%，10年期。
 
不仅是在中国，全球银行业都在开发新金融框架下符合《巴塞尔协议Ⅲ》的资本工具。<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 据高盛（亚洲）董事总经理陈妍妮调查，截至今年6月，全球范围内已经发行了符合《巴塞尔协议Ⅲ》资本工具的国家及地区，其中包括意大利、荷兰、瑞士、澳大利亚、巴西、中国香港地区等地。据公开报道，马来西亚联昌银行9月份发售了7.5亿林吉特（约合2.28亿美元）的混合二级债券，收益率在4.8%。
 
在已经发行了新资本工具的案例中，既有混合一级资本的发行，也有二级资本的发行。在亚洲的已发行案例，都是二级资本工具。<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 这些已发行的债券中除了澳大利亚ANZ银行和麦格理银行(Macquarie　Bank)发行的混合一级资本（在中国称为“其他一级资本”）以及瑞信银行发行的二级资本工具是有转股特征，其他五例发行都是具有减记特征的债券。

    </div>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
