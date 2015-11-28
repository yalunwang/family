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
            int pageSize, pageNo, totalPage,listCount;//每页的数量，页码（第几页），一共的页码,数据的个数
            listCount = db.SaralyV.Count(o => o.UserID == LoginUser.UserID);
            pageSize = 10;
            //totalPage = (listCount / pageSize) + 1;
            totalPage = (int)Math.Ceiling((decimal)listCount/pageSize);
            totalPage = (totalPage == 0 ? 1 : totalPage);
            pageNo = ZKRequest.GetInt("pageNo",0);
            pageNo = pageNo < 1 ?1:pageNo;
            pageNo = pageNo > totalPage ? totalPage : pageNo;
            saralylist = db.SaralyV.Where(o => o.UserID == LoginUser.UserID).OrderByDescending(o => o.saralyDate);
            saralylist = saralylist.Skip((pageNo - 1) * pageSize).Take(pageSize);
            totalucom = db.SaralyV.Where(o=>o.UserID==LoginUser.UserID).Sum(o=>o.RealMoney);
            fenye.InnerHtml = ShowPages(totalPage, pageSize, pageNo);
        }    
    }
}