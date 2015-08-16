<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userCompanylist.aspx.cs" Inherits="family.information.userCompanylist" %>
<%@ Register src="../include/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>
<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>

<!DOCTYPE html>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="../css/my.css" rel="Stylesheet" type="text/css" />
    <style>
       
    </style>
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
                    <li><a href="userCompanylist.aspx" title="东家列表">东家列表</a></li>
            
                    <li><a href="addCompany.aspx" title="添加东家">添加东家</a></li>
       
                    <li><a href="user_manage.aspx" title="删除用户">删除用户</a></li>
          
                    </ul>
               
               </div>
             
           </div>
           
           <div class="con-box">
               <div class="margin40">
                    <table  width="100%" border="0" cellspacing="0" cellpadding="0" style="border-top:1px solid #aaa" >
                        <tbody >
                              <tr style="text-align:center">
                                  <td width="16%" scope="col">公司名称</td> 
                                   <td width="20%" scope="col">公司地址</td> 
                                   <td width="10%" scope="col">公司网址</td>
                                   <td width="8%" scope="col">公司行业</td> 
                                   <td width="8%" scope="col">加入日期</td> 
                                   <td width="8%" scope="col">离开日期</td> 
                                  <td width="10%" scope="col">任职岗位</td>
                                   <td width="8%" scope="col">是否在职</td> 
                                    <td width="8%" scope="col">操作</td>
                              </tr>
                          </tbody>
                    
                        <tbody style="border-top:1px solid #aaa ;text-align:center">
                          <%foreach (var item in usercompanylist) {%>
                             <tr >
                                <td width="16%" scope="col"><%=item.Company.CompanyName %></td> 
                                   <td width="20%" scope="col"><%=item.Company.Province.ProvinceName+item.Company.City.CityName+item.Company.CityZone.CityZoneName+item.Company.Address %></td> 
                                   <td width="10%" scope="col"><a target="_blank" href="<%=item.Company.Website %>">官网</a></td>
                                   <td width="8%" scope="col"><%=item.Company.CompanyType.comTypename %></td> 
                                   <td width="12%" scope="col"><%=((DateTime)item.joinDate).ToString("yyy-MM-dd")%></td> 
                                   <td width="12%" scope="col"><%=item.leaveDate==null?"至今": ((DateTime)item.leaveDate).ToString("yyy-MM-dd") %></td> 
                                  <td width="10%" scope="col"><%=item.station %></td>
                                   <td width="8%" scope="col"><%=item.iscurrent==true?"是":"否" %></td> 
                                    <td width="8%" scope="col">编辑</td>
                              </tr>
                            
                          <% } %>
                        </tbody>
                      </table>
                   
                 
              </div>
           </div>
          
        </div>
    </div>
    <uc1:foot runat="server" ID="foot" />
</body>
</html>
