using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.information
{
    public partial class userCompanylist :islogin
    {
        public IQueryable <DataAccess.UserCompany> usercompanylist;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        protected void load()
        {
           usercompanylist = db.UserCompany.Where(o=>o.UserID==LoginUser.UserID);

        
        }
    }
}