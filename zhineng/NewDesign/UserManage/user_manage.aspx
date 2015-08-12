<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_manage.aspx.cs" Inherits="family.information.user_manage" %>

<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
    
        <uc1:topmenu ID="topmenu1" runat="server" />
    
    </div>

     
        <div class="new_main">
            <div class="contents">
               <div class="title1"><h2>普通用户</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="user_chaxun.aspx" title="查询检索">查询检索</a></li>
            
                    <li><a href="useradd.aspx" title="添加用户">添加用户</a></li>
       
                    <li><a href="user_manage.aspx" title="删除用户">删除用户</a></li>
          
                    </ul>
               
               </div>
           </div>

            <div class="con-box ">
        
				    
				<div class="margin40">
                       <asp:GridView ID="gvMemberList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="5" DataKeyNames ="MemberID"  Width="100%" HorizontalAlign="Center"
							HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvMemberList_PageIndexChanging" 
                            OnRowDeleting="gvMemberList_RowDeleting" CellPadding="4" 
                            ForeColor="#333333" GridLines="None" 
                            Height="298px">
							<EditRowStyle BackColor="#2461BF" />
							<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
							<HeaderStyle Font-Bold="True" CssClass="summary-title" BackColor="#507CD1" 
                                ForeColor="White"></HeaderStyle>
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="UserID" HeaderText="用户ID" >
                                   <ItemStyle HorizontalAlign="center"  />
                                    </asp:BoundField>
                                <asp:BoundField DataField="UserName" HeaderText="用户名" ReadOnly="True" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="RealName" HeaderText="真实姓名" >
                                    <ItemStyle HorizontalAlign="center" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="call" HeaderText="电话号码" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Email" HeaderText="用户Email" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="pwd" HeaderText="密码" >
                                 <ItemStyle HorizontalAlign="center" />
                                    </asp:BoundField>
                                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" HeaderText="删除" >
                                   <ItemStyle HorizontalAlign="center"  />
                                     </asp:CommandField >
                            </Columns>
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
				
			</div>
		
            </div>
          
        </div>
        
        <div id="footer" style="margin-top:20px;width:1000px;"> 
            <p><a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col6/column_6_1.html">互动交流</a>|
		    <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col110/column_110_1.html">法律声明</a>|
	        <a target="_self" href="http://www.miibeian.gov.cn/">版权声明</a>|
		    <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col112/column_112_1.html">网站标识</a>|
		    <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col51/column_51_1.html">常见问题</a>|
		    <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col52/column_52_1.html">联系我们</a>
	        </p>
            <p>版权所有@宽波景源软件研发&nbsp;国网安备0612A6HCO号 </p>
            <p>Copyright@2013-2014 State Grid Corportation of China,All Rights Reserved.</p>
        </div>

     
    </form>
</body>
</html>
