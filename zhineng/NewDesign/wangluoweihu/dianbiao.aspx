<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dianbiao.aspx.cs" Inherits="family.wangluoweihu.dianbiaomanage" %>

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
               <div class="title1"><h2>电表管理</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="dianbiao.aspx" title="查询检索">查询电表</a></li>
            
                    <li><a href="adddianbiao.aspx" title="添加用户">添加电表</a></li>
       
                    <li><a href="dianbiaomanage.aspx" title="删除用户">管理电表</a></li>
                     <li><a href="addUser_dianbiao.aspx" title="增加网络">增加网络</a></li>
                    </ul>
               
               </div>
           </div>
           <div class="con-box">
              <div class="sear">
                   <span class="sp3">请输入用户真实姓名：<asp:TextBox ID="txtName" runat="server" Width="78px"></asp:TextBox></span>
                   <span class="sp3 sp4">    <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
                       <asp:Button ID="btnJiansuo" runat="server"  Text="检索所有" 
                      onclick="btnJiansuo_Click" /></span>
                 
              </div>
              <div class="data">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                        BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="3" 
                      BorderStyle="None" Width="540px">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" 
                            HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" ForeColor="White" Font-Bold="True" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
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
