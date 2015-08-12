using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.information
{
    public partial class user : islogin
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();

        }
        protected void load()
        {
            DataAccess.user user = new DataAccess.user();
            user = LoginUser;
            userName.InnerHtml = "Hi," +" "+user.UserName;
            var userGroup = db.Usergroup.FirstOrDefault(o=>o.UsergroupID==LoginUser.UsergroupID);//获取用户所在用户组
            var userCompany = db.UserCompany.SingleOrDefault(o=>o.UserID==LoginUser.UserID&&o.iscurrent==true);
            if(userCompany!=null)
            mycompany.InnerHtml=userCompany.Company.CompanyName;
            myuserGroup.InnerHtml = userGroup.groupName;
        }

    }
}