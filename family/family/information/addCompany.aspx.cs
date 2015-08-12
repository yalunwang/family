using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZKEShop.Common;

namespace family.information
{
    public partial class addCompany : islogin
    {
      public IQueryable<DataAccess.Company> companylist;
        protected void Page_Load(object sender, EventArgs e)
        {
            string  operation=Request["operation"];
            switch (operation)
            {
                case "shoudongSave": saveShoudong();
                    break;
                case "zidongSave": saveZidong();
                    break;

            
            }
            load();
        }
        protected void load()
        {
            companylist = from o in db.Company select o;
            
        
        }
        protected void saveShoudong()
        {
            DataAccess.UserCompany userCompany = new DataAccess.UserCompany();
            DataAccess.Company company = new DataAccess.Company();
            //公司信息
            company.CompanyName = ZKRequest.GetString("companyName");
            company.CompanyTypeID = short.Parse(ZKEShop.Common.ZKRequest.GetString("companyType"));
            company.ProvinceID = ZKRequest.GetInt("province",0);
            company.CityID = ZKRequest.GetInt("city", 0);
            company.CityZoneID = ZKRequest.GetInt("cityZone", 0);
            company.Address = ZKRequest.GetString("address");
            company.Tellphone = ZKRequest.GetString("companyTel");
            company.Website = ZKRequest.GetString("weburl");
            company.Describe = ZKRequest.GetString("describe");
            //用户与公司的关系
            userCompany.iscurrent =ZKRequest.GetString("iscurrent")=="1"?true:false;
            userCompany.UserID = LoginUser.UserID;
            userCompany.Company = company;
            userCompany.logDate = DateTime.Now;
            userCompany.remark = ZKRequest.GetString("remark");//备注
            userCompany.station = ZKRequest.GetString("station");//职位
            string joindate = ZKRequest.GetString("joindate");//加入日期
            if(!string.IsNullOrEmpty(joindate))
            userCompany.joinDate = Convert.ToDateTime(joindate);
            string leavedate = ZKEShop.Common.ZKRequest.GetString("leavedate");//离开日期
            if (!string.IsNullOrEmpty(leavedate))
                userCompany.leaveDate = Convert.ToDateTime(leavedate);
            db.Company.InsertOnSubmit(company);
            db.SubmitChanges();
            Response.Write("<script>alert('保存成功')</script>");
           
        }
        protected void saveZidong()
        {

            DataAccess.UserCompany userCompany = new DataAccess.UserCompany();
            string joindate = ZKEShop.Common.ZKRequest.GetString("joindate");
            if (!string.IsNullOrEmpty(joindate))
                userCompany.joinDate = Convert.ToDateTime(joindate);
            string leavedate = ZKEShop.Common.ZKRequest.GetString("leavedate");
            if (!string.IsNullOrEmpty(leavedate))
                userCompany.leaveDate= Convert.ToDateTime(leavedate);
            userCompany.iscurrent = ZKEShop.Common.ZKRequest.GetString("iscurrent") == "1" ? true : false;
            userCompany.UserID = LoginUser.UserID;
            userCompany.CompanyID = ZKEShop.Common.ZKRequest.GetInt("companyID",0);
            userCompany.logDate = DateTime.Now;
            userCompany.remark = ZKRequest.GetString("remark");//备注
            userCompany.station = ZKRequest.GetString("station");//职位
            db.UserCompany.InsertOnSubmit(userCompany);
            db.SubmitChanges();
            Response.Write("<script>alert('保存成功')</script>");

        }
     }
}