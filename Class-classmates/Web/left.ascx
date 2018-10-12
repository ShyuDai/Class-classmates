<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left.ascx.cs" Inherits="Maticsoft.Web.left" %>
  <!--left.start-->
  <div class="pleft">
    
    <dl class="p1 mtop">
      <dt><strong>热点新闻</strong></dt>
      <dd>
        <ul class="b2">
          <asp:Repeater ID="Repeater3" runat="server" DataSourceID="ObjectDataSource3">
                <ItemTemplate>
                    <li>
                        <a target="_blank" title='<%#Eval("Name") %>' href='/Newss.aspx?id=<%#Eval("Id") %>'><%#Eval("Name") %></a>
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
      </dd>
    </dl>
  </div>
  <!--left.end-->