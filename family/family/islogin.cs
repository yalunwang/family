using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace family
{
    public class islogin:pagebase
    {
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (LoginUser == null)
            {
                Response.Redirect("http://" + System.Configuration.ConfigurationSettings.AppSettings["MainWebUrl"] + "/user/login.aspx?FromUrl=" + Server.UrlEncode(Request.Url.AbsoluteUri));
                Response.End();
            }
        }
    }
}