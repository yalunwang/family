using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.Layout
{
    public partial class usergroup : pagebase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string operation=Request["operation"];
            switch(operation)
            {
                case "save":
                    save();
                    break;
            
            }

        }
        protected void save()
        {
            DataAccess.Usergroup usergroup = new DataAccess.Usergroup();
            usergroup.groupName = ZKEShop.Common.ZKRequest.GetString("usergroupName");
            usergroup.logdate = DateTime.Now;
            usergroup.remark = ZKEShop.Common.ZKRequest.GetString("remark");
            db.Usergroup.InsertOnSubmit(usergroup);
            db.SubmitChanges();
            Response.Write("<script>alert('保存成功')</script>");

        }
    }
}