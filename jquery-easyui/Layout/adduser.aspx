<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adduser.aspx.cs" Inherits="jquery_easyui.Layout.adduser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" >
        <input name="operation" value="save" type="hidden" />
       <div >
           <span class="sp3">请输入用户名：</span>
           <input type="text" id="" name="userName"/>
       </div>
         <div>
           <span class="sp3">请输入密码：</span>
           <input type="text" id="" name="userPwd"/>
       </div>
        <div>
           <span class="sp3">请选择一个用户组：</span>
           <select name="usergroupID">
               <%foreach (var item in usergrouplist) { %>
                    <option value="<%=item.UsergroupID %>"><%=item.groupName %> </option>
               <%} %>
               
           </select>
       </div>
        <div>
            <span class="sp3">备注：</span>
            <input type="text" id="" name="remark"/>
        </div>
        <input type="submit" value="提交"/>
    </form>
</body>
</html>
