using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.salary
{
    public partial class salarycount : pagebase
    {
        public List<countmodel> mycountmodel;
        public decimal? totalucom;
        public int totalMonth;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();

        }
        protected void load()
        {
            mycountmodel=new List<countmodel>();
            
            var comlist = (from o in db.SaralyV
                           where o.UserID == LoginUser.UserID 
                           select new { 
                                comID=o.userCompanyID,
                                comName=o.CompanyName
                           }).Distinct().ToList();
            foreach (var item in comlist)
            {
                countmodel a = new countmodel();
                var s = db.SaralyV.Where(o => o.userCompanyID == item.comID);
                a.totalucomMoney=s.Sum(o => o.RealMoney);
                a.monthcount = s.Count();
                a.companyName = item.comName;
                mycountmodel.Add(a);
            }
            totalucom = mycountmodel.Sum(o=>o.totalucomMoney);
            totalMonth = mycountmodel.Sum(o => o.monthcount);
        }
        public class countmodel
        {
            public decimal? totalucomMoney{get; set;}
            public string companyName { set; get; }
            public int monthcount { get; set; }
        }
    }
}