<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="family.index" %>

<%@ Register Src="usercon/topmenu.ascx" TagName="topmenu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/login.css" rel="Stylesheet" type="text/css" />
    <link href="css/my.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wraper">
        <div>
            <uc1:topmenu ID="topmenu1" runat="server" />
        </div>
        <div class=" main">
            <div id="left" class="left ">
                <div id="xuanchuan">
                    <img src="image/xuanchuan.png" alt="宣传" />
                </div>
                <div id="run" class="margin10">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                运行信息</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                    </div>
                </div>
                <div id="notice" class="margin10">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                公司公告</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                        <div class="list">
                            <ul>
                                <li><a href="#">关于做好各台区电线防冻工作的安排</a><span>2014-12-20</span></li>
                                <li><a href="#">2014年春节放假安排</a><span>2014-12-05</span></li>
                                <li><a href="#">2014年元旦放假及值班安排</a><span>2014-11-16</span></li>
                                <li><a href="#">冬季作息制度安排</a><span>2014-10-08</span></li>
                                <li><a href="#">2014年国庆节放假安排</a><span>2014-09-29</span></li>
                                <li><a href="#">2014年中秋节放假安排</a><span>2014-09-20</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div id="news" class="margin10">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                公司要闻</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                        <div class="list">
                            <ul>
                                <li><a href="#">我局成功在城关乡试点部署无线抄录</a><span>2014-12-20</span></li>
                                <li><a href="#">我局于志辉在昨晚抢修中表现突出</a><span>2014-12-16</span></li>
                                <li><a href="#">学习十八大精神研讨会昨日成功举行</a><span>2014-12-03</span></li>
                                <li><a href="#">我局与宽波景源达成战略合作伙伴</a><span>2014-11-20</span></li>
                                <li><a href="#">欢迎河南省省长莅临指导工作</a><span>2014-10-20</span></li>
                                <li><a href="#">我局在昨天的县委大会上获得表扬</a><span>2014-10-10</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div id="kepu" class="margin10">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                电力科普</h3>
                        </div>
                        <div class="science">
                        </div>
                    </div>
                </div>
                <div id="worker" class="margin10">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                            </h3>
                        </div>
                        <div class="science">
                        </div>
                    </div>
                </div>
                <div>
                </div>
            </div>
            <div id="right">
                <div id="rili">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                        Font-Size="8pt" ForeColor="#003399" Height="184px" Width="272px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                            Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </div>
                <div id="warning" class="right-width">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                报警记录</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                        <div class="list">
                            <ul>
                                <li><a href="#">1台区变压器故障</a><span>2014-12-20</span></li>
                                <li><a href="#">2台区有电表故障</a><span>2014-12-16</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div id="rizhi" class="margin10 right-width">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                事件日志</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                    </div>
                </div>
                <div id="zhuanti" class="margin10 right-width">
                    <div class="mokuai">
                        <div class="title">
                            <h3>
                                专题专栏</h3>
                            <span class="more"><a href="#">更多</a></span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="footer" style="margin-top: 20px; width: 1000px;">
            <p>
                <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col6/column_6_1.html">互动交流</a>|
                <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col110/column_110_1.html">
                    法律声明</a>| <a target="_self" href="http://www.miibeian.gov.cn/">版权声明</a>| <a target="_self"
                        href="http://www.sd.sgcc.com.cn/html/main/col112/column_112_1.html">网站标识</a>|
                <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col51/column_51_1.html">
                    常见问题</a>| <a target="_self" href="http://www.sd.sgcc.com.cn/html/main/col52/column_52_1.html">
                        联系我们</a>
            </p>
            <p>
                版权所有@宽波景源软件研发&nbsp;国网安备0612A6HCO号
            </p>
            <p>
                Copyright@2013-2014 State Grid Corportation of China,All Rights Reserved.</p>
        </div>
    </div>
    </form>
</body>
</html>
