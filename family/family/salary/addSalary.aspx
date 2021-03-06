﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addSalary.aspx.cs" Inherits="family.salary.addSalary" %>

<%@ Register Src="~/include/topmenu.ascx" TagPrefix="uc1" TagName="topmenu" %>
<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script  type="text/javascript" src="/js/My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <div>
    <uc1:topmenu runat="server" ID="topmenu" />
    </div>
    
       
    <div class="main">
        <div class="new_main">
            <!--左侧导航-->
            <div class="contents">
               <div class="title1"><h2>我的工资</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="salarylist.aspx" title="东家列表">工资列表</a></li>
            
                    <li><a href="addSalary.aspx" title="添加东家">添加工资</a></li>
       
                    <li><a href="user_manage.aspx" title="删除用户">删除用户</a></li>
          
                    </ul>
               
               </div>
             
           </div>
             <!--左侧导航结束-->
             <!--右侧开始-->
            <div class="con-box margin40">
               
                <!--手动添加公司信息-->
                <div id="shoudong" >
                     <form autocomplete="off" method="post">
                       <input type="hidden"  value="save" name="operation"/> 
                       <div>
                    <span class="sp3">请选择一家公司：</span>
                    <select id="" name="usercompanyID" >
                       <%foreach (var item in usercompany)
                         { %>
                          <option value="<%=item.userCompanyID %>"><%=item.Company.CompanyName %></option>
                       
                       <%} %>
                    
                      
                    </select>
                  </div>
                       <div>
                    <span class="sp3">请选择工资年月：</span>
                    <select id="" name="yearMonthID" >
                       <%foreach (var item in yearmonth)
                         { %>
                          <option value="<%=item.YearMonthID %>"><%=item.Yearmonthvalue %></option>
                       
                       <%} %>
                    
                      
                    </select>
                  </div>
                       <div>
                          <span class="sp3">发工资日期：</span>
                          <input type="text" readonly id="" onClick="WdatePicker()" name="saralyDate"/>
                      </div>
                       <div>----------------------------------------------------------------</div>
                       <div>
                           <span class="sp3">基本工资：</span>
                          <input type="text" id="" name="baseMoney"/>
                       </div>
                       <div>
                           <span class="sp3">绩效工资：</span>
                          <input type="text" id="" name="jixiaoMoney"/>
                       </div>
                       <div>
                           <span class="sp3">加班工资：</span>
                          <input type="text" id="" name="jiabanMoney"/>
                       </div>
                       <div>
                           <span class="sp3">补贴工资：</span>
                          <input type="text" id="" name="butieMoney"/>
                       </div>
                       <div>
                           <span class="sp3">请假扣除工资：</span>
                          <input type="text" id="" name="kouchuMoney"/>
                       </div>
                        
                        <div>
                           <span class="sp3">1、应发工资：</span>
                          <input type="text" id="" name="totalMoney"/>
                       </div>
                         <div>----------------------------------------------------------------</div>
                          <div>
                           <span class="sp3">个人公积金：</span>
                          <input type="text" id="" name="userFund"/>
                       </div>
                          <div>
                           <span class="sp3">个人社保：</span>
                          <input type="text" id="" name="userShebao"/>
                       </div>

               
                   <div>
                        <span class="sp3">2、税前工资：</span>
                       <input type="text" id="" name="PretaxMoney"/>
                   </div>
                      <div>----------------------------------------------------------------</div>
                         <div>
                        <span class="sp3">个人所得税：</span>
                       <input type="text" id="" name="userTax"/>
                   </div>

                     <div>
                        <span class="sp3">3、实发工资：</span>
                       <input type="text" id="" name="RealMoney"/></div>
                    <div>
                     <div>----------------------------------------------------------------</div>
                       <span class="sp3">公司社保：</span>
                       <input type="text" id="" name="comShebao"/> </div>
                  
                    <div>
                        <span class="sp3">公司公积金：</span>
                       <input type="text" id="" name="comFund"/>  </div>
                   <div>


                        <span class="sp3">备注：</span>
                       <input type="text" id="" name="remark"/>  </div>
                 
                   
                   <div>
                    
                   <input type="submit" id="" value="提交" name=""/>
               </div>
               </form>
            </div>
               
              
            </div>
             <!--右侧结束-->
        </div>
   
      </div>  
    <uc1:foot runat="server" id="foot" />
     <script type="text/javascript" src="../js/jquery.min.js"></script>
      <script type="text/javascript" src="../js/address.js"></script>
   
</body>
</html>
