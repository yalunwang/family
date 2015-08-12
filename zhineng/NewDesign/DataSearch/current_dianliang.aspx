<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="current_dianliang.aspx.cs" Inherits="family.DataSearch.current_dianliang" %>
<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>


<%@ Register src="../usercon/select.ascx" tagname="select" tagprefix="uc3" %>

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
          <div class="title1"><h2>数据抄录</h2></div>  
          
          <div class="contents-r"> 
              <ul>
                    <li><a href="current_dianliang.aspx" title="实时数据抄录">实时数据</a></li>
            
                    <li><a href="history_dianliang.aspx" title="历史数据抄录">历史数据</a></li>
       
                  
          
              </ul>          
          </div> 
        </div>
        <div class="con-box">
           <uc3:select ID="select1" runat="server" />
           
           <table  style="width:100%;">
            <tr>
                <td align="center">
                    时段选择:</td>
                <td> <asp:RadioButton ID="dangqian" runat="server" Text="当前" GroupName="d" />
      
      &nbsp; <asp:RadioButton ID="dangri" runat="server" Text="当日" GroupName="d" />

       &nbsp;  <asp:RadioButton ID="dangyue" runat="server" Text="当月" GroupName="d" />

      &nbsp;   <asp:RadioButton ID="shangyue" runat="server" Text="上月" GroupName="d" />
                   </td>
              
            </tr>
            <tr>
                <td align="center">
                                                                  功向:</td>
                <td><asp:RadioButton ID="zhengxiang" runat="server" Text="正向" GroupName="c" />&nbsp; 

        <asp:RadioButton ID="fanxiang" runat="server" Text="反向" GroupName="c" />&nbsp; 

        <asp:RadioButton ID="zongjia" runat="server" Text="总加" GroupName="c" />&nbsp;&nbsp;&nbsp; 

        <asp:TextBox ID="TextBox1" runat="server" Height="21px"></asp:TextBox>
                   </td>
               
            </tr>
            <tr>
                <td align="center">
                    有/无功:</td>
                <td>
                     <asp:RadioButton 
                   ID="yougong" runat="server" Text="有功" GroupName="b" />&nbsp; 
     
        
                <asp:RadioButton ID="wugong" runat="server" Text="无功" GroupName="b" />
                     <asp:TextBox ID="TextBox4" runat="server" Width="54px">33</asp:TextBox>
                     <asp:TextBox ID="TextBox5" runat="server" Width="54px">33</asp:TextBox>
                     <asp:TextBox ID="TextBox6" runat="server" Width="54px">34</asp:TextBox>
                     <asp:TextBox ID="TextBox7" runat="server" Width="54px">33</asp:TextBox>
               </td>
              
            </tr>
              <tr>
                <td align="center">
                    类型:</td>
                <td>
                     <asp:RadioButton 
                   ID="dianzhi" runat="server" Text="电能示值" GroupName="a" />&nbsp; 
     
        
                <asp:RadioButton ID="dian" runat="server" Text="电能量" GroupName="a" />
               </td>
              
            </tr>
        </table>
        
        <table style="width: 100%;">
            <tr>
                <td class="style2">
                   <div align="center">
           
                       <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="打开信息" 
                           Height="31px" Width="66px"  BackColor="#66FF33"  />
           
                    <asp:Button ID="Button3" runat="server" BackColor="#66FF33" Height="31px" 
                        onclick="Button3_Click" Text="清空信息" Width="66px" />      
                         <asp:Button ID="Button4" runat="server" Text="抄表" Width="66px" Height="31px" 
                             BackColor="#66FF33" onclick="Button4_Click" Visible="False" />
        <asp:Button ID="Button1" runat="server"  Height="31px" 
                   Width="66px" Text="抄表" onclick="Button1_Click1" BackColor="Lime"  />

     
                       <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="初始化" 
                           BackColor="#0066FF" Height="31px" Width="67px" />

                    </div>
                     </td>
                 
               
            </tr>
          
          
              

                  
                   
                                          
       
         
        </table>
           
         <div class="mokuai"style="height:63%">
                  <div class="title">
                    <h3>数据显示</h3>
                  
                  </div>
                   <div class="list">
                     <asp:TextBox ID="TextBox3" runat="server" Height="341px" TextMode="MultiLine" 
                                Width="647px" style="margin-left: 39px" BorderStyle="None" 
                           ></asp:TextBox>
                   </div> 
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
