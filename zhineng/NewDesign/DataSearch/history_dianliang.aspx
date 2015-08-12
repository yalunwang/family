<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="history_dianliang.aspx.cs" Inherits="family.DataSearch.history_dianliang" %>

<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
             <div >
                <asp:Button ID="Button1" runat="server" Text="曲线图" />
             
               
             </div> 
             <div><p class="dscr">
				<asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
				</p></div>    
             <div>    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="360px" BackColor="211, 223, 240" 
                BackGradientStyle="TopBottom" BackSecondaryColor="White">
                 <borderskin skinstyle="Emboss"></borderskin>
                <series>
                    <asp:Series ChartType="Line" Name="Series1" XValueMember="RealName" MarkerStyle="Circle"
                        YValueMembers="电量" YValuesPerPoint="2">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
                <Titles>
                    <asp:Title Name="Title1" Text="尉氏县用电统计表" Font="Microsoft Sans Serif, 12pt" 
                        ForeColor="Teal">
                    </asp:Title>
                </Titles>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="Data Source=DELL-PC;database=Wire_Store;User ID=sa;password=1;" 
                ProviderName="System.Data.SqlClient" 
                
                     SelectCommand="SELECT Users.RealName, biaoshu.电量 FROM biaoshu INNER JOIN Userdianbiao ON biaoshu.表地址 = Userdianbiao.表地址 INNER JOIN Users ON Userdianbiao.UserID = Users.UserID"></asp:SqlDataSource>
                            <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick">
                            </asp:Timer>
                  </ContentTemplate>
                      </asp:UpdatePanel>
                 <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2" BackColor="211, 223, 240"
                     Width="360px">
                     <Series>
                         <asp:Series Name="Series1" XValueMember="表地址" YValueMembers="电量">
                         </asp:Series>
                     </Series>
                     <ChartAreas>
                         <asp:ChartArea Name="ChartArea1">
                         </asp:ChartArea>
                     </ChartAreas>
                     <BorderSkin SkinStyle="Emboss" />
                 </asp:Chart>
                 <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                     ConnectionString="Data Source=DELL-PC;Initial Catalog=Wire_Store;Persist Security Info=True;User ID=sa;Password=1" 
                     ProviderName="System.Data.SqlClient" 
                     SelectCommand="SELECT [表地址], [电量] FROM [biaoshu]"></asp:SqlDataSource>
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
