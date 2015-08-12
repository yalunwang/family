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
namespace family.information
{
    public partial class user_add : System.Web.UI.Page
    {
        CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        string flag;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPassWord.Text = "";
            this.txtTrueName.Text = "";
            this.txtEmail.Text = "";
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = "select * from Users where UserName='" + this.txtName.Text.Trim() + "'";
            DataTable dsTable = dbObj.GetDataSetStr(strSql, "UserName");
            if (dsTable.Rows.Count > 0)
            {
                Response.Write(ccObj.MessageBoxPage("该用户名已存在！"));
            }
            else
            {
                string strsex = flag;//性别
                string strUserID = this.txtUserID.Text.Trim();//身份证号
                string strName = this.txtName.Text.Trim();//用户名
                string strPwd = this.txtPassWord.Text.Trim();//密码
                string strTrueName = this.txtTrueName.Text.Trim();//真实姓名
                string strEamil = this.txtEmail.Text.Trim();//邮件地址
                string straddress = this.txtaddress.Text.Trim();//详细地址
                string strCall = this.txtCall.Text.Trim();//修改int为string
                //  string strDate = System.DateTime.Now.ToString("yyyy年MM月dd日");
                string strAddSql = "Insert into Users(UserID,UserName,pwd,sex,RealName,Email,call,address)";
                strAddSql += "values('" + strUserID + "','" + strName + "','" + strPwd + "','" + strsex + "','" + strTrueName + "','" + strEamil + "','" + strCall + "','" + straddress + "')";
                SqlCommand myCmd = dbObj.GetCommandStr(strAddSql);
                dbObj.ExecNonQuery(myCmd);
                Response.Write(ccObj.MessageBoxPage("添加成功！"));
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                flag = this.RadioButton1.Text.Trim();
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                flag = this.RadioButton2.Text.Trim();
            }
        }

   

       
    }
}