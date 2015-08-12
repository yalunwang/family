<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="daohang.aspx.cs" Inherits="family.daohang" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/test.css" rel="Stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div id="menu">
    <ul>
        <li><a href="#" title="首页">首页</a></li>
        <li><a href="#" title="用户管理">用户管理</a>
           <ul>
            <li ><a href="#" title="普通用户">普通用户</a></li>
            <li ><a href="#" title="管理员用户">管理员用户</a></li>
            </ul>
        </li>
        <li><a href="#" title="网络维护">网络维护</a>
              <ul>
                <li ><a href="#" title="普通用户">主站设置</a></li>
                <li ><a href="#" title="管理员用户">网络管理</a></li>
             
                <li ><a href="#" title="管理员用户">复位</a></li>
              </ul>
        </li>
        <li><a href="#" title="数据查询分析">数据查询分析</a>
             <ul>
                <li ><a href="#" title="普通用户">实时数据查询</a></li>
                <li ><a href="#" title="管理员用户">历史数据查询</a></li>
                <li ><a href="#" title="普通用户">终端设置</a></li>
                <li ><a href="#" title="管理员用户">定时上报设置</a></li>
             </ul>

        </li>
        <li><a href="login.aspx" title="电力控制">电力控制</a></li>
        <li><a href="login.aspx" title="报警记录">报警记录</a></li>
          <li><a href="login.aspx" title="电力控制">新闻管理</a></li>
    </ul>
    
    </div>
    </form>
</body>
</html>
