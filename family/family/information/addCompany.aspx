<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCompany.aspx.cs" Inherits="family.information.addCompany" %>

<%@ Register Src="~/include/topmenu.ascx" TagPrefix="uc1" TagName="topmenu" %>
<%@ Register Src="~/include/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script  type="text/javascript" src="/js/My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <div>
    <uc1:topmenu runat="server" ID="topmenu" />
    </div>
    
       
    <div class="main">
        <div class="new_main">
            <!--左侧导航-->
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
             <!--左侧导航结束-->
             <!--右侧开始-->
            <div class="con-box margin40">
                <input id="qiehuan"  type="button" value="切换添加方式"/ >
                <!--手动添加公司信息-->
                <div id="shoudong" >
                     <form autocomplete="off">
                       <input type="hidden"  value="shoudongSave" name="operation"/> 
                   <div>
                        <span class="sp3">请输入公司名字：</span>
                       <input type="text" id="" name="companyName"/>
                   </div>
                   
                   <div>
                          <span class="sp3">是否是当前就职：</span>
                       <input type="checkbox" id="" value="1" name="iscurrent"/>
                   </div>
                   <div>
                        <span class="sp3">公司行业：</span>
                       <select id="" name="companyType" >
                          <option value="3">电子</option>
                           <option value="4">电商</option>
                           <option value="5">互联网金融</option>
                        </select>
                   </div>
                   <div>
                        <span class="sp3">公司地址：</span>
                       <select id="S1" name="province" >
                            <option value="-1">请选择</option>
                        </select>
                       <select id="S2"    name="city">
                            
                        </select>
                       <select id="S3" name="cityZone">
                             
                       </select>
                   </div>
                   <div>
                       <span class="sp3">详细地址：</span>
                       <input type="text" id="" name="address"/>
                   </div>
                   <div>
                       <span class="sp3">任职岗位：</span>
                       <input type="text" id="" name="station"/>
                   </div>
                   <div>
                       <span class="sp3">入职备注：</span>
                       <input type="text" id="" name="station"/>
                   </div>
                   <div>
                    <span class="sp3">加入日期：</span>
                   <input type="text" id="" onClick="WdatePicker()" name="joindate"/>
                 </div>
                   <div>
                    <span class="sp3">离开日期：</span>
                   <input type="text" id=""   onClick="WdatePicker()" name="leavedate"/>
               </div>
                   <div>
                        <span class="sp3">公司网址：</span>
                       <input type="text" id="" name="weburl"/>
                   </div>
                   <div>
                        <span class="sp3">公司电话：</span>
                       <input type="text" id="" name="companyTel"/>
                   </div>
                   <div>
                        <span class="sp3">公司电描述：</span>
                       <input type="text" id="" name="describe"/>
                   </div>
                   <div>
                    
                   <input type="submit" id="" value="提交" name=""/>
               </div>
               </form>
            </div>
               
                <!--从公司库里添加-->
               <div id="zidong" class="dn">
                <form autocomplete="off">
                     <input type="hidden"  value="zidongSave" name="operation"/> 
                 <div>
                    <span class="sp3">请选择一家公司：</span>
                   <select id="" name="companyID" >
                       <%foreach (var item in companylist)
                         { %>
                          <option value="<%=item.CompanyID %>"><%=item.CompanyName %></option>
                       
                       <%} %>
                    
                      
                    </select>
                </div>
                <div>
                   <span class="sp3">是否是当前就职：</span>
                   <input type="checkbox" id="" value="1" name="iscurrent"/>
                </div>
                    <div>
                       <span class="sp3">任职岗位：</span>
                       <input type="text" id="" name="station"/>
                   </div>
                   <div>
                       <span class="sp3">入职备注:</span>
                       <input type="text" id="" name="remark"/>
                   </div>
               <div>
                    <span class="sp3">加入日期：</span>
                   <input type="text" id="" onClick="WdatePicker()" name="joindate"/>
               </div>
                <div>
                    <span class="sp3">离开日期：</span>
                   <input type="text" id=""   onClick="WdatePicker()" name="leavedate"/>
               </div>
                <div>
                    
                   <input type="submit" id="" value="提交" name=""/>
               </div>
                  </form>
            </div>
            </div>
             <!--右侧结束-->
        </div>
   
      </div>  
    <uc1:foot runat="server" id="foot" />
     <script type="text/javascript" src="../js/jquery.min.js"></script>
      <script type="text/javascript" src="../js/address.js"></script>
    <script>
        $("#qiehuan").click(function () {
            //alert("ni");
            $("#shoudong").toggleClass('dn');
            $("#zidong").toggleClass("dn");

        })

    </script>
</body>
</html>
