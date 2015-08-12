<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="salaryList.aspx.cs" Inherits="family.salary.salaryList" %>
<%@ Register src="../include/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="../css/my.css" rel="Stylesheet" type="text/css" />
</head>
<body>
   
  
    <div>
    
        <uc1:topmenu ID="topmenu1" runat="server" />
    
    </div>

    <div class="main">
        <div class="new_main">
           <div class="contents">
               <div class="title1"><h2>我的东家们</h2></div>
               <div class="contents-r">
                    <ul>
                    <li><a href="salarylist.aspx" title="东家列表">工资列表</a></li>
            
                    <li><a href="addSalary.aspx" title="添加东家">添加工资</a></li>
       
                    <li><a href="user_manage.aspx" title="删除用户">删除用户</a></li>
          
                    </ul>
               
               </div>
             
           </div>
             <div class="con-box">
                     <div class="margin40">
                         

                         <div id="userName" runat="server"></div>
                         <div><span class="sp3">我属于的用户组：</span>
                             <span id="myuserGroup" runat="server"></span>
                         </div>
                         <div><span class="sp3">我的当前公司：</span>
                             <span id="mycompany" runat="server"></span>
                         </div>
                   
                 
              </div>
             </div>
          
        </div>
    </div>
    <uc1:foot runat="server" ID="foot" />
</body>
</html>
