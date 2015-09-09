using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace family
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //ZKEShop.Common.LogHelper.Write("EBSWebSite发生了未处理异常:", ZKEShop.Common.LogHelper.LogMessageType.Error, HttpContext.Current.Server.GetLastError());
            System.Text.StringBuilder _errorMsg = new System.Text.StringBuilder("EBSWebSite发生了未处理异常:");
            _errorMsg.Append("Request Infomation : \n ");
            _errorMsg.AppendFormat("RequestUrl:{0} \n ", HttpContext.Current.Request.Url.ToString());
            _errorMsg.AppendFormat("Request Path:{0}", HttpContext.Current.Request.PhysicalPath);
            _errorMsg.AppendFormat("Request UserHostAddress:{0}", HttpContext.Current.Request.UserHostAddress);
            //_errorMsg.AppendFormat("Request Cookies:{0}", HttpContext.Current.Request.Cookies.ToString());
            //_errorMsg.AppendFormat("Request QueryString:{0}", HttpContext.Current.Request.QueryString);
            Exception ex = HttpContext.Current.Server.GetLastError();
            ZKEShop.Common.LogHelper.Write(_errorMsg.ToString(), ZKEShop.Common.LogHelper.LogMessageType.Error, ex);
            Server.ClearError();
           // Response.Redirect(ZKEShop.BizFacade.Domain.MainDomain.TrimEnd('/') + "/error.aspx", true);
           // Response.End();
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}