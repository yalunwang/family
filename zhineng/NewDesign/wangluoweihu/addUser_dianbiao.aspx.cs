using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using family.Class;
using System.Data.SqlClient;

namespace family.wangluoweihu
{
    public partial class addUser_dianbiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = "select * from Userdianbiao where 表地址='" + this.txtbiaoID.Text.Trim() + "'";
            DataTable dsTable = dbObj.GetDataSetStr(strSql, "WhAdminName");
            if (dsTable.Rows.Count > 0)
            {
                Response.Write(ccObj.MessageBoxPage("该电表号已存在！"));
            }
            else
            {

                string strbiaoID = this.txtbiaoID.Text.Trim();//表号
                string strUserID = this.txtUserID.Text.Trim();//生产公司


                //  string strDate = System.DateTime.Now.ToString("yyyy年MM月dd日");
                string strAddSql = "Insert into Userdianbiao(表地址,UserID)";
                strAddSql += "values('" + strbiaoID + "','" + strUserID + "')";
                SqlCommand myCmd = dbObj.GetCommandStr(strAddSql);
                dbObj.ExecNonQuery(myCmd);
                Response.Write(ccObj.MessageBoxPage("添加成功！"));
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
             this.txtbiaoID.Text = "";
             this.txtUserID.Text = "";
            
        }
    }
}