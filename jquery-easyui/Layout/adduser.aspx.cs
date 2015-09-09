using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZKEShop.Common;
namespace jquery_easyui.Layout
{
    public partial class adduser : pagebase
    {
        public IQueryable<DataAccess.Usergroup> usergrouplist;
        protected void Page_Load(object sender, EventArgs e)
        {
            string operation = Request["operation"];
            switch (operation)
            {
                case "save":
                    save();
                    break;

            }
            load();

        }
        protected void load()
        {
             usergrouplist = from s in db.Usergroup select s;
        
        }
        protected void save()
        {

            DataAccess.user usermodel = new DataAccess.user();
            usermodel.UserName = ZKRequest.GetString("userName");
            usermodel.LogDate = DateTime.Now;
            usermodel.LastActive =DateTime.Now;
            usermodel.isActive = true;
            usermodel.UserPwd = ZKRequest.GetString("userPwd");
            usermodel.Remark = ZKRequest.GetString("remark");
            usermodel.UsergroupID = ZKRequest.GetInt("usergroupID",0);
            db.user.InsertOnSubmit(usermodel);
            db.SubmitChanges();
            Response.Write("<script>alert('保存成功')</script>");

        }
    }
}