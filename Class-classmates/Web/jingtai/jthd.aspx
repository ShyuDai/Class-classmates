<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jthd.aspx.cs" Inherits="Maticsoft.Web.jingtai.jthd" %>
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
      <h1>集体活动</h1>
      
      




&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 游戏1、循环相克令 用具：无 人数：两人 方法：令词为“猎人、狗熊、枪”，两人同时说令词，在说最后一个字的同时做出一个动作——猎人的动作是双手叉腰；狗熊的动作是双手搭在胸前；枪的动作是双手举起呈手枪状。双方以此动作判定输赢，猎人赢枪、枪赢狗熊、狗熊赢猎人，动作相同则重新开始。 兴奋点：这个游戏的乐趣在于双方的动作大，非常滑稽 缺点：只是两个人的游戏  
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; 游戏2、幸运大白鲨 用具：幸运大白鲨 人数：两人 方法：幸运大白鲨的构造非常简单，但玩起来却趣味无穷。方式是将大白鲨的嘴掰开，然后按下它的下排牙齿，这些牙齿中只有一颗会牵动鲨鱼嘴，使其合上，如果你按到这一颗，鲨鱼嘴会突然合上，咬住你的手指。当然，鲨鱼牙是软塑料做的，不会咬痛您的。 你可以在酒桌上把它作为赌运气的酒具，几个人轮流按动，如果被鲨鱼咬到罚酒。 兴奋点：适合男孩女孩一起玩，对于胆小的女孩子来说比较惊险。 缺点：首先你要先去买一个“大白鲨”，虽然价钱不贵 

    </div>
  </div>
  <!--right.end-->
  
</div>

</asp:Content>
