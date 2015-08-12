using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.Layout
{
    public partial class usergroupList : pagebase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        protected void load()
        {
            var usergrouplist = from s in db.Usergroup select s;
          
           StringBuilder sb=new StringBuilder();
           
           sb.Append("<table ><tr><td>用户组名字</td><td>备注</td> <td>创建时间</td></tr>");
           foreach (var item in usergrouplist)
           {
               
               sb.Append("<tr>");
               sb.Append("<td>" + item.groupName + "</td>");
               sb.Append("<td>" + item.remark + "</td>");
               sb.Append("<td>" + item.logdate + "</td>");
               sb.Append("</tr>");
             
              
           
           }
           sb.Append("</table>");
          list.InnerHtml=sb.ToString();
        }
    }
}