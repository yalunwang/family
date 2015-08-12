<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="family.information.user" %>

<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="../css/my.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
  
    <div>
    
        <uc1:topmenu ID="topmenu1" runat="server" />
    
    </div>

    <div class="main">
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
             <div class="con-box"></div>
          
        </div>
    </div>
    </form>
</body>
</html>
