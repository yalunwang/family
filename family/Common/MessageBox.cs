using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormWare.Common
{
   public class MessageBox
    {
       public static void ResponseScript(Page page, string script)
       {
           page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript' defer>" + script + "</script>");
       }

       public static void Show(Page page, string msg)
       {
           page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript' defer>alert('" + msg + "');</script>");
       }
       public static void ShowAndRedirect(Page page, string msg, string url)
       {
           StringBuilder builder = new StringBuilder();
           builder.Append("<script type='text/javascript' defer>");
           builder.AppendFormat("alert('{0}');", msg);
           builder.AppendFormat("top.location.href='{0}'", url);
           builder.Append("</script>");
           page.ClientScript.RegisterStartupScript(page.GetType(), "message", builder.ToString());
       }

       public static void ShowConfirm(WebControl Control, string msg)
       {
           Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
       }

       //public static void ShowAjax(Control contorl, string msg)
       //{
       //    Type type = contorl.GetType();
       //    ScriptManager.RegisterStartupScript(contorl, type, "Alert ", "alert( ' " + msg + " '); ", true);
       //}
    }
}
