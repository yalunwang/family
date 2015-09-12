using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZKEShop.Common;
namespace family.user
{
    public partial class login : pagebase
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = db.user.Where(o =>o.CityID==9999999888 );
            foreach (var item in query)
            {
                item.CityID = 2;
            }
            string operation = ZKRequest.GetString("operation");
            FromUrl.Value = Convert.ToString(Server.UrlDecode(Request["FromUrl"]));
            switch(operation)
            {
                case "login":
                    Loginin();
                    break;
                case "loginout":
                    Loginout();
                    break;

            }
           
        }
        /// <summary>
        /// 登录
        /// </summary>
        protected void Loginin()
        {
           
            string userName=ZKRequest.GetString("userName");
            string userPwd=ZKRequest.GetString("userPwd");
            BAL.User.user user = new BAL.User.user(userName, userPwd);
            if (user.UserDal!= null)
            {
                LoginUser = user.UserDal;
                if (!string.IsNullOrEmpty(FromUrl.Value))
                    Response.Redirect(FromUrl.Value, true);
                else
                Response.Redirect("../index.aspx",true);
            }
        
        
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        protected void Loginout()
        {
            LoginUser = null;
            Response.Redirect("/user/login.aspx", true);
        }
    }
}