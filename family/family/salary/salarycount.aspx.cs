using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.salary
{
    public partial class salarycount : pagebase
    {
        public List<countmodel> mycountmodel;
        public decimal? totalMoney;//总收入
        public string totalMonth;//中月份
        //public int totalMonth;//中月份
        protected void Page_Load(object sender, EventArgs e)
        {
            load();

        }
        protected void load()
        {
            mycountmodel=new List<countmodel>();
            
            /*var comlist = (from o in db.SaralyV
                           where o.UserID == LoginUser.UserID 
                           select new { 
                                comID=o.userCompanyID,
                                comName=o.CompanyName
                           }).Distinct().ToList();*/
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var comlist = (from o in db.UserCompany
                           where o.UserID == LoginUser.UserID
                           select new
                           {
                               comID = o.userCompanyID,
                               comName = o.Company.CompanyName
                           });
            foreach (var item in comlist)
            {
                countmodel a = new countmodel();
                var s = db.SaralyV.Where(o => o.userCompanyID == item.comID);
                a.totalucomMoney=s.Sum(o => o.RealMoney);
                a.monthcount = s.Count();
                a.companyName = item.comName;
                mycountmodel.Add(a);
            }
            sw.Stop();
            totalMonth = sw.ElapsedMilliseconds.ToString();
            //var jj = from o in db.SaralyV
            //         where o.UserID == LoginUser.UserID
            //         group o by o.userCompanyID into g
            //         select new { shh=g.Sum(o=>o.RealMoney),
            //        };
           
            var test = from s in db.SaralyV where 
                       s.UserID == LoginUser.UserID group s by s.CompanyName;
            foreach (var item in test)
            {
                countmodel a = new countmodel();
                a.monthcount = item.Count();
                a.companyName =item.Key;
                a.totalucomMoney=item.Sum(o=>o.RealMoney);
                mycountmodel.Add(a);
            }

       
            //totalMoney = mycountmodel.Sum(o=>o.totalucomMoney);
            //totalMonth = mycountmodel.Sum(o => o.monthcount);
        }
        public class countmodel
        {
            public decimal? totalucomMoney{get; set;}
            public string companyName { set; get; }
            public int monthcount { get; set; }
        }
    }
}