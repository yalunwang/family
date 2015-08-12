using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace family.salary
{
    public partial class addSalary :pagebase
    {
        public IQueryable<DataAccess.UserCompany> usercompany;
        public IQueryable<DataAccess.YearMonth> yearmonth;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        protected void load()
        {
            usercompany = from o in db.UserCompany select o;
            yearmonth = from o in db.YearMonth select o;
        
        }
       
       
    }
}