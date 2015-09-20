<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="salarycount.aspx.cs" Inherits="family.salary.salarycount" %>

<%@ Register Src="~/include/topmenu.ascx" TagPrefix="uc1" TagName="topmenu" %>
<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>工资统计</title>
      
</head>
<body>
     <div>
       <uc1:topmenu ID="topmenu1" runat="server" />
   </div>
     <div class="main">
        <div class="new_main">
           <div class="contents">
               <div class="title1"><h2>我的工资</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="salarylist.aspx" title="东家列表">工资列表</a></li>
            
                    <li><a href="addSalary.aspx" title="添加东家">添加工资</a></li>
       
                    <li><a href="salarycount.aspx" title="删除用户">工资统计</a></li>
          
                    </ul>
               
               </div>
             
           </div>
             <div class="con-box">
                     <div class="margin40">
                         我的工资统计
                         <table  width="60%" border="0" cellspacing="0" cellpadding="0" style="border-top:1px solid #aaa"  >
                           <tbody style="border-top:1px solid #aaa ;text-align:center"> 
                               <tr><td>公司名字</td>
                                   <td>总收入</td>
                                   <td>工作月份</td>
                               </tr>
                                <%foreach (var item in mycountmodel) {%>
                               <tr><td><%=item.companyName %></td>
                                  <td><%=ZKEShop.Common.number.convTwo(item.totalucomMoney) %></td>
                                   <td><%=(item.monthcount) %>个月</td>
                               </tr>
                              <% } %>
                               <tr><td>合计</td>
                                   <td><%=ZKEShop.Common.number.convTwo(totalMoney) %></td>
                                   <td><%=totalMonth %>个月</td>
                               </tr>

                        </tbody>
                 </table>
              </div>
             </div>
          
        </div>
    </div>
     <uc1:foot runat="server" ID="foot" />
</body>
</html>
