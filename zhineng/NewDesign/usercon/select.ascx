<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="select.ascx.cs" Inherits="family.usercon.select" %>
<table  align="center" style="width:100%;">
    <tr>
        <td class="style1" colspan="6" align=left>
            地址选择</td>
      
    </tr>
    <tr align="center">
        <td >
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>郑州市</asp:ListItem>
                <asp:ListItem>开封市</asp:ListItem>
                <asp:ListItem>洛阳市</asp:ListItem>
                <asp:ListItem>新乡市</asp:ListItem>
                <asp:ListItem>安阳市</asp:ListItem>
                <asp:ListItem>信阳市</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td >
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>尉氏县</asp:ListItem>
                <asp:ListItem>开封县</asp:ListItem>
                <asp:ListItem>兰考县</asp:ListItem>
                <asp:ListItem>通许县</asp:ListItem>
                <asp:ListItem>杞县</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td >
            <asp:DropDownList ID="DropDownList3" runat="server" style="margin-left: 0px">
                <asp:ListItem>甲乡</asp:ListItem>
                <asp:ListItem>乙乡</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td >
            <asp:DropDownList ID="DropDownList4" runat="server" style="margin-left: 0px">
                <asp:ListItem>a村</asp:ListItem>
                <asp:ListItem>b村</asp:ListItem>
                <asp:ListItem>c村</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList6" runat="server">
                <asp:ListItem>A主站</asp:ListItem>
                <asp:ListItem>B主站</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList5" runat="server" style="margin-left: 0px">
                <asp:ListItem>1区</asp:ListItem>
                <asp:ListItem>2区</asp:ListItem>
                <asp:ListItem>3区</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    
</table>

