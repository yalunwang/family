<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="topmenu.ascx.cs" Inherits="family.usercon.topmenu" %>
<link href="../css/login.css" rel="Stylesheet" type="text/css" />
<link href="../css/my.css" rel="Stylesheet" type="text/css" />
     <div id="menu">
     <ul>
        <li><a href="../index.aspx" title="首页">首页</a></li>
        <li class="line"></li>
        <li><a href="#" title="用户管理">用户管理</a>
           <ul>
            <li ><a href="../UserManage/user_chaxun.aspx" title="普通用户">普通用户</a></li>
            <li ><a href="../UserManage/admin.aspx"title="管理员用户">管理员用户</a></li>
            </ul>
        </li>
        <li class="line"></li>
        <li><a href="#" title="网络维护">网络维护</a>
              <ul>
                <li ><a href="#" title="主站设置">主站设置</a></li>
                <li ><a href="../wangluoweihu/dianbiao.aspx" title="网络管理">网络管理</a></li>
             
                <li ><a href="#" title="复位">复位</a></li>
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
        <li><a href="../login.aspx" title="退出登录">退出登录</a></li>
    </ul>
    
    </div>