using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZKEShop.Common;
namespace family.salary
{
    public partial class salaryList :islogin
    {
        public IQueryable <DataAccess.SaralyV> saralylist;
        public decimal? totalucom;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        protected void load()
        {
            saralylist = db.SaralyV.Where(o=>o.UserID==LoginUser.UserID).OrderByDescending(o=>o.saralyDate);
            totalucom = db.SaralyV.Where(o=>o.UserID==LoginUser.UserID).Sum(o=>o.RealMoney);
        }    
    }
}