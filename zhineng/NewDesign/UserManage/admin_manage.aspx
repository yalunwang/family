<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_manage.aspx.cs" Inherits="family.information.admin_manage" %>
<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
        
        <uc1:topmenu id="topmenu1" runat="server" />
        
    </div>
     <div class="new_main">
           <div class="contents">
               <div class="title1"><h2>管理员用户</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="admin.aspx" title="查询检索">查询检索</a></li>
            
                    <li><a href="adminadd.aspx" title="添加用户">添加管理员</a></li>
       
                    <li><a href="admin_manage.aspx" title="删除用户">删除管理员</a></li>
          
                    </ul>
               
               </div>
              
           </div>
           <div class="con-box margin10">
                <asp:GridView ID="gvMemberList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="5" DataKeyNames ="MemberID"  Width="99%" HorizontalAlign="Center"
							HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvMemberList_PageIndexChanging" 
                            OnRowDeleting="gvMemberList_RowDeleting"  
                            CellPadding="3" Height="207px" 
                            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                            CellSpacing="2">
							<FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
							<HeaderStyle Font-Bold="True" CssClass="summary-title" BackColor="#A55129" 
                                ForeColor="White"></HeaderStyle>
                            <Columns>
                                <asp:BoundField DataField="WhAdminID" HeaderText="管理员代号" />
                                <asp:BoundField DataField="WhAdminName" HeaderText="管理员名" ReadOnly="True" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WhRealName" HeaderText="真实姓名" >
                                    <ItemStyle HorizontalAlign="center" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WhCall" HeaderText="电话号码" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WhEmail" HeaderText="管理员Email" >
                                    <ItemStyle HorizontalAlign="center"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WhPassword" HeaderText="密码">
                                    <ItemStyle HorizontalAlign="center" />
                              
                                </asp:BoundField>
                                <asp:BoundField DataField="WhLoadDate" HeaderText="申请日期" >
                                    <ItemStyle HorizontalAlign="center" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WhClass" HeaderText="管理员级别" >
                                  <ItemStyle HorizontalAlign="center" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:CommandField ButtonType="Button" HeaderText="删除" ShowDeleteButton="True" />
                                                            </Columns>
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
           
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
