using Dataacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adressDEMO
{
    public partial class address : System.Web.UI.Page
    {
       
        DataClasses1DataContext db = new DataClasses1DataContext(System.Configuration.ConfigurationSettings.AppSettings["ConnStr.net"]);
        public IQueryable<Province>province;
      
        protected void Page_Load(object sender, EventArgs e)
        {
           string operation=Request["operation"];
           string result = "";
           switch (operation)
           {
               case "province":
                   result=getProvince();
                   break;
               case "city":
                   result = getCity();
                   break;
               case "cityZone":
                   result = getcityZone();
                   break;
           }
            if(!string.IsNullOrEmpty(result))
            {
                Response.ContentType="application/json";
                Response.Write(result);
                Response.End();
            }

        }
        protected string getProvince()
        {
            province = from o in db.Province where o.CountryID==1 orderby o.ProvinceCode select o;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[");
            foreach (var item in province)
            {
                sb.Append("{");
                sb.Append("\"ProvinceID\":\"" + item.ProvinceID + "\",\"ProvinceName\":\"" + item.ProvinceName + "\"");
                sb.Append("},");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
        protected string getCity()
        {
            IQueryable<City> city;

            int provinceID = int.Parse(Request["provinceID"]);
            if (provinceID<1)
            {
                //return;
            }
            city = db.City.Where(o => o.ProvinceID == provinceID);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[");
            foreach (var item in city)
            {
                sb.Append("{");
                sb.Append("\"CityID\":\"" + item.CityID + "\",\"CityName\":\"" + item.CityName + "\"");
                sb.Append("},");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
        protected string getcityZone()
        {
            IQueryable<CityZone> cityZone;
            int  cityID = int.Parse(Request["cityID"]);
            cityZone = db.CityZone.Where(o => o.CityID == cityID);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[");
            foreach (var item in cityZone)
            {
                sb.Append("{");
                sb.Append("\"cityZoneID\":\"" + item.CityZoneID + "\",\"cityZoneName\":\"" + item.CityZoneName + "\"");
                sb.Append("},");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
        
    }
}