using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZKEShop.Common;
namespace family.salary
{
    public partial class addSalary :pagebase
    {
        public IQueryable<DataAccess.UserCompany> usercompany;
        public IQueryable<DataAccess.YearMonth> yearmonth;
        protected void Page_Load(object sender, EventArgs e)
        {
            string operation = Request["operation"];
            switch(operation)
            {
                case "save":
                    save();
                    break;
            
            }
            load();
        }
        protected void load()
        {
            usercompany = from o in db.UserCompany select o;
            yearmonth = from o in db.YearMonth select o;
        
        }
        protected void save()
        {
            DataAccess.Saraly saralymodel = new DataAccess.Saraly();
            saralymodel.userCompanyID = ZKRequest.GetInt("usercompanyID",0);
            saralymodel.YearMonthID = ZKRequest.GetInt("yearMonthID", 0);
            saralymodel.saralyDate = Convert.ToDateTime(ZKRequest.GetString("saralyDate"));
            saralymodel.baseMoney=ZKRequest.GetDecimal("baseMoney",0);
            saralymodel.jixiaoMoney=  ZKRequest.GetDecimal("jixiaoMoney",0);
            saralymodel.jiabanFei = ZKRequest.GetDecimal("jiabanMoney", 0);
            saralymodel.butieMoney=   ZKRequest.GetDecimal("butieMoney",0);
            saralymodel.kouchuMoney= ZKRequest.GetDecimal("kouchuMoney",0);
            saralymodel.TotalMoney=   ZKRequest.GetDecimal("totalMoney",0);
            saralymodel.userFund= ZKRequest.GetDecimal("userFund",0);
            saralymodel.userShebao= ZKRequest.GetDecimal("userShebao",0);;
            saralymodel.logdate = DateTime.Now;
            saralymodel.Pretaxsaraly= ZKRequest.GetDecimal("PretaxMoney",0);
            saralymodel.usertax=ZKRequest.GetDecimal("userTax",0);
            saralymodel.RealMoney=   ZKRequest.GetDecimal("RealMoney",0)  ;                  
            saralymodel.comShebao=ZKRequest.GetDecimal("comShebao",0);
            saralymodel.comFund=   ZKRequest.GetDecimal("comFund",0);
            saralymodel.remark = ZKRequest.GetString("remark");
            db.Saraly.InsertOnSubmit(saralymodel);
            db.SubmitChanges();
            Response.Write("<script>alert('添加成功')</script>");
        }
       
       
    }
}