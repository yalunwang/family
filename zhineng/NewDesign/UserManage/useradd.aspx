<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="useradd.aspx.cs" Inherits="family.information.user_add" %>

<%@ Register src="../usercon/topmenu.ascx" tagname="topmenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <uc1:topmenu ID="topmenu1" runat="server" />

    </div>
     
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
           
           <div class="con-box">
           <div class="margin40">
           <table cellSpacing="1" cellPadding="1" align="center" border="0" 
            style="height: 241px; width: 352px;">
			<tr>
			<td  height="25" align="left" style ="font-size :9pt; font-family :宋体;">
			    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 添加用户
			</td>
			</tr>
				<tr>
					<td>
						<table style ="font-size :9pt; font-family :宋体; width: 98%;" cellSpacing="0" 
                            cellPadding="0" align="center" border="0">
                            <tr >
								<td align="left" style="height: 24px ;font-size :9pt; font-family :宋体;">
									身份证号：
								</td>
								<td style="height: 24px">
									<asp:TextBox id="txtUserID" runat="server"></asp:TextBox>
									
								</td>
							</tr>
							<tr >
								<td align="left" style="height: 24px ;font-size :9pt; font-family :宋体;">
									用户名：
								</td>
								<td style="height: 24px">
									<asp:TextBox id="txtName" runat="server"></asp:TextBox>
									
								</td>
							</tr>
                            <tr>
                                <td align="left" style="height: 24px;font-size :9pt; font-family :宋体;">
                                    密码：
                                </td>
                                <td style="height: 24px">
                                    <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
								<td align="left" style="height: 24px";font-size :9pt; font-family :宋体;>
									真实姓名：
								</td>
								<td style="height: 24px">
									<asp:TextBox id="txtTrueName" runat="server"></asp:TextBox>
								</td>
							</tr>
                            <tr>
                                <td align="left" style="height: 24px";font-size :9pt; font-family :宋体;>
                                    性别：
                                </td>
                                <td style="height: 24px">
                                    <asp:RadioButton ID="RadioButton1" runat="server" Text="男" GroupName="key" oncheckedchanged="RadioButton1_CheckedChanged" 
                                   />
                                    <asp:RadioButton ID="RadioButton2" runat="server" Text="女" GroupName="key"  oncheckedchanged="RadioButton2_CheckedChanged"
                                       />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" ;font-size :9pt; font-family :宋体; class="style1">
                                   Email：
                                </td>
                                <td class="style1">
                                   <asp:TextBox ID="txtEmail" runat="server" Height="19px" Width="148px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="height: 24px";font-size :9pt; font-family :宋体;>
                                   联系电话：
                                </td>
                                <td style="height: 24px">
                                   <asp:TextBox ID="txtCall" runat="server" Height="19px" Width="148px"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td align="left" style="height: 24px";font-size :9pt; font-family :宋体;>
                                   地址选择：
                                </td>
                                <td style="height: 24px">
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>河南省</asp:ListItem>
                                        <asp:ListItem>广东省</asp:ListItem>
                                        <asp:ListItem>浙江省</asp:ListItem>
                                        <asp:ListItem>安徽省</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                        <asp:ListItem>郑州市</asp:ListItem>
                                        <asp:ListItem>开封市</asp:ListItem>
                                        <asp:ListItem>洛阳市</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownList3" runat="server">
                                        <asp:ListItem>开封县</asp:ListItem>
                                        <asp:ListItem>通许县</asp:ListItem>
                                        <asp:ListItem>杞县</asp:ListItem>
                                        <asp:ListItem>尉氏县</asp:ListItem>
                                        <asp:ListItem>兰考县</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                              <tr>
                                <td align="left" style="height: 24px";font-size :9pt; font-family :宋体;>
                                   详细地址：
                                </td>
                                <td style="height: 24px">
                                   <asp:TextBox ID="txtaddress" runat="server" Height="19px" Width="148px"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
								<td align="center" colspan="2">
                                    <br />
									<asp:Button id="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" ></asp:Button>
									<asp:Button id="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" CausesValidation="False" ></asp:Button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
            </div>
           </div>
          
        </div>
        <div id="footer" style="margin-top:20px;width:1000px;"> 
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
