using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using family.Class;
namespace family.wangluoweihu
{
    public partial class adddianbiao : System.Web.UI.Page
    {
        CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtbiaoID.Text = "";
            this.txtcompany.Text = "";
            this.txtstand.Text = "";
            this.txtriqi.Text = "";
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = "select * from dianbiao where 表地址='" + this.txtbiaoID.Text.Trim() + "'";
            DataTable dsTable = dbObj.GetDataSetStr(strSql, "WhAdminName");
            if (dsTable.Rows.Count > 0)
            {
                Response.Write(ccObj.MessageBoxPage("该电表号已存在！"));
            }
            else
            {
                
                string strbiaoID = this.txtbiaoID.Text.Trim();//表号
                string strCompany = this.txtcompany.Text.Trim();//生产公司
                string strriqi = this.txtriqi.Text.Trim();//输入日期
                DateTime da = DateTime.Parse(strriqi);
                string strStand = this.txtstand.Text.Trim();//国家标准
                //  string strDate = System.DateTime.Now.ToString("yyyy年MM月dd日");
                string strAddSql = "Insert into dianbiao(表地址,生产日期,生产公司,国家标准)";
                strAddSql += "values('" + strbiaoID + "','" + da + "','" + strCompany + "','" + strStand + "')";
                SqlCommand myCmd = dbObj.GetCommandStr(strAddSql);
                dbObj.ExecNonQuery(myCmd);
                Response.Write(ccObj.MessageBoxPage("添加成功！"));
            }
        }
    }
}