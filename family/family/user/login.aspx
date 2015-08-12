<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="family.user.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录智能电网管理系统</title>
    <link href="../css/login.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
      
    </style>
</head>
<body>
    <form id="form1" method="post">
   
    <div id="container">
     <input name="FromUrl" id="FromUrl" type="hidden" runat="server"/>
        <input  type="hidden" name="operation"  value="login" />
        <div id="main_login">
            
            <div id="right_login" >
                <h2>登录管理系统</h2>
                <div id="kuang">
                 <input  id="userName" name="userName" class="txt" type="text"  placeholder="输入用户名/邮箱" 
                        MaxLength="15" />
               
                 <input id="userPwd" name="userPwd" class="txt" type="password" placeholder="6-26位密码" 
                         MaxLength="26" />
          
                <input type="text" ID="yanzheng" class="txt"  placeholder="验证码" >
                    <div id="forget" class="forget-passd">
                        
                    <span class="sp1"><a href="forget.aspx" target="_blank">忘记密码</a></span><span class="sp2"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>
                    </div>
                 <input type="submit" id="denglu"   value="登录"   />
              </div>
            </div>
            <div id="left_login" >
            <img src="../image/xixi.png" alt="电力宣传画"  />
            </div>
             
         
        </div>
   
    </div>
     <div id="footer"> 
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