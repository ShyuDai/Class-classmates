<%@ Page Title="Reply" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.Reply.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>回复内容：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:TemplateField HeaderText="留言编号">
		<ItemTemplate>
			<asp:Label ID="lblFk_Leaveword_Id" runat="server" Text='<%#Eval("Fk_Leaveword_Id") %>'  Visible="false"></asp:Label>
			<asp:Repeater ID="rptFk_Leaveword_Id" runat="server" DataSourceID="odsFk_Leaveword_Id"><ItemTemplate><%#Eval("Name") %></ItemTemplate></asp:Repeater>
			<asp:ObjectDataSource ID="odsFk_Leaveword_Id" runat="server" SelectMethod="GetModel" TypeName="Maticsoft.BLL.Leaveword"><SelectParameters><asp:ControlParameter ControlID="lblFk_Leaveword_Id" Name="Id" PropertyName="Text" Type="Int32" /></SelectParameters></asp:ObjectDataSource>
		</ItemTemplate>
		</asp:TemplateField>
		<asp:BoundField DataField="Contents" HeaderText="回复内容" SortExpression="Contents" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:TemplateField HeaderText="回复用户">
		<ItemTemplate>
			<asp:Label ID="lblFk_Users_Id" runat="server" Text='<%#Eval("Fk_Users_Id") %>'  Visible="false"></asp:Label>
			<asp:Repeater ID="rptFk_Users_Id" runat="server" DataSourceID="odsFk_Users_Id"><ItemTemplate><%#Eval("Name") %></ItemTemplate></asp:Repeater>
			<asp:ObjectDataSource ID="odsFk_Users_Id" runat="server" SelectMethod="GetModel" TypeName="Maticsoft.BLL.Users"><SelectParameters><asp:ControlParameter ControlID="lblFk_Users_Id" Name="Id" PropertyName="Text" Type="Int32" /></SelectParameters></asp:ObjectDataSource>
		</ItemTemplate>
		</asp:TemplateField>
		<asp:BoundField DataField="AddTimes" HeaderText="回复时间" SortExpression="AddTimes" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
