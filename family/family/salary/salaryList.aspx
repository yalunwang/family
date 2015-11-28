<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="salaryList.aspx.cs" Inherits="family.salary.salaryList" %>
<%@ Register src="../include/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>工资列表</title>
      <link href="../css/my.css" rel="Stylesheet" type="text/css" />
    <script src="../js/jquery.min.js"></script>
    <style type="text/css">
        td {
        font:14px/1.5 Tahoma,Helvetica,Arial,'\5b8b\4f53',sans-serif;
        }
        .page {
            /*background:#f3f3f3;*/
        }
       .page a.btn_b {
                border:1px solid #ccc;
                background:#fff;
                padding:0px 7px;
            }
     .page .no {border:1px solid #e4e4e4; background:#f3f3f3;color:#7f7f7f }
          
      .pag .btn_b:hover{text-decoration:none;border-color: darkorange;color: darkorange;}
    </style>
</head>
<body>
   <div>
       <uc1:topmenu ID="topmenu1" runat="server" />
   </div>
    <form id="pageForm">
        <input type="hidden" name="pageNo" id="pageNo" value="1"/>
   <div class="main">
       
        <div class="new_main">
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
             <div class="con-box">
                     <div class="margin40">
                         
                     <table  width="100%" border="0" cellspacing="0" cellpadding="0" style="border-top:1px solid #aaa" >
                        <tbody >
                              <tr style="text-align:center">
                                  <td width="14%" scope="col">公司名称</td> 
                                   <td width="8%" scope="col">工资月份</td> 
                                   <td width="10%" scope="col">实发工资</td>
                                  <td width="10%" scope="col">基本工资</td>
                                   <td width="8%" scope="col">个人所得税</td> 
                                   <td width="8%" scope="col">个人社保</td> 
                                   <td width="8%" scope="col">公积金</td> 
                                  <td width="10%" scope="col">发工资日期</td>
                                  
                                   <td width="10%" scope="col">是否任职</td> 
                                    <td width="10%" scope="col">操作</td>
                              </tr>
                          </tbody>
                    
                        <tbody style="border-top:1px solid #aaa ;text-align:center">
                          <%foreach (var item in saralylist)
                            {%>
                             <tr >
                                <td width="14%" scope="col"><%=item.CompanyName %></td> 
                                   <td width="8%" scope="col"><%=item.Yearmonthvalue%></td> 
                                   <td width="10%" scope="col"><%=ZKEShop.Common.number.convTwo(item.RealMoney) %></td>
                                 <td width="10%" scope="col"><%=ZKEShop.Common.number.convTwo(item.baseMoney) %></td> 
                                   <td width="8%" scope="col"><%=ZKEShop.Common.number.convTwo(item.usertax) %></td> 
                                   <td width="8%" scope="col"><%=ZKEShop.Common.number.convTwo(item.userShebao)%></td> 
                                   <td width="12%" scope="col"><%=ZKEShop.Common.number.convTwo(item.userFund) %></td> 
                                  <td width="10%" scope="col"><%=((DateTime)item.saralyDate).ToString("yyy-MM-dd")%></td>
                                <%-- <td width="10%" scope="col"><%=((DateTime)item.logdate).ToString("yyy-MM-dd") %></td> --%>
                                   <td width="10%" scope="col"><%=item.iscurrent==true?"是":"否" %></td> 
                                    <td width="10%" scope="col">编辑</td>
                              </tr>
                            
                          <% } %>
                        </tbody>
                        <tbody style="border-top:1px solid #aaa ;text-align:center"> 
                            <tr><td colspan="5" >合计</td>
                                  <td colspan="5" ><%=totalucom %></td>
                            </tr>
                           
                        </tbody>
                        <tbody style="border-top:1px solid #aaa ;text-align:center">
                            <tr>
                                
                                  <td colspan="10" >
                                      <div id="fenye" class="page" runat="server"></div>

                                  </td>
                               
                            </tr>

                           
                        </tbody>
                      </table>
                 
                      </div>
             </div>
         </div>
          
        
    </div>
        </form>
    <uc1:foot runat="server" ID="foot" />
</body>
</html>
<script>
    function GoPage(pageNo)
    {
        var pageForm = $("#pageForm");
        $("#pageNo").val(pageNo);
        pageForm.submit();
    }
</script>
