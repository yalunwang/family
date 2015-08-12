<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="historysear.aspx.cs" Inherits="family.DataSearch.historysear" %>

<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<%@ Register src="../usercon/select.ascx" tagname="select" tagprefix="uc2" %>

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
              <div class="title1"><h2>数据查询分析</h2></div>
              
              <div class="contents-r">
                  <ul>
                    <li><a href="../DataSearch/historysear.aspx" title="查询检索">查询检索</a></li>
            
                    <li><a href="../DataSearch/analysis1.aspx" title="添加用户">数据分析</a></li>
       
                    
          
                    </ul>
              </div>
        </div>
        
        <div class="con-box margin10">
            <div>
                <uc2:select ID="select1" runat="server" />
            </div>


            <div style="margin-left:35px">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                   BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging"
                   PageSize="15" Width="647px" Height="452px">
                   <FooterStyle BackColor="White" ForeColor="#000066" />
                   <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                   <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" 
                       BorderColor="#FF6699" />
                   <RowStyle ForeColor="#000066" />
                   <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
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
