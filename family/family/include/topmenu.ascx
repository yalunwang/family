<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="topmenu.ascx.cs" Inherits="family.usercon.topmenu" %>
<link href="../css/login.css" rel="Stylesheet" type="text/css" />
<link href="../css/my.css" rel="Stylesheet" type="text/css" />
     <div id="menu">
     <ul>
        <li><a href="../index.aspx" title="首页">首页</a></li>
        <li class="line"></li>
        <li><a href="#" title="用户管理">信息设置</a>
           <ul>
            <li ><a href="../information/userindex.aspx" title="公司管理">东家们</a></li>
            <li ><a href="../UserManage/admin.aspx"title="我的用户组">我的用户组</a></li>
            </ul>
        </li>
        <li class="line"></li>
        <li><a href="#" title="工资管理">工资管理</a>
              <ul>
                <li ><a href="/salary/salarylist.aspx" title="工资列表">工资列表</a></li>
                <li ><a href="/salary/addSalary.aspx" title="添加工资">添加工资</a></li>
             
                <li ><a href="#" title="工资统计">工资统计</a></li>
              </ul>
        </li>
        <li class="line"></li>
        <li><a href="#" title="数据查询分析">数据查询</a>
             <ul>
                <li ><a href="/DataSearch/current_dianliang.aspx" title="数据抄录">数据抄录</a></li>
                <li ><a href="../DataSearch/historysear.aspx" title="数据查询分析">数据查询分析</a></li>
                <li ><a href="#" title="终端设置">终端设置</a></li>
                <li ><a href="#" title="定时上报设置">定时上报设置</a></li>
             </ul>

        </li>
        <li class="line"></li>
        <li><a href="../login.aspx" title="电力控制">电力控制</a></li>
        <li class="line"></li>
        <li><a href="../login.aspx" title="报警记录">报警记录</a></li>
        <li class="line"></li>
        <li><a href="../login.aspx" title="新闻管理">新闻管理</a></li>
        <li class="line"></li>
        <li><a href="/user/login.aspx?operation=loginout" title="退出登录">退出登录</a></li>
    </ul>
    
    </div>