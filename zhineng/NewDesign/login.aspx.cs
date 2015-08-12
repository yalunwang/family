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
using System.Linq;
using family.Class;


namespace family
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private readonly string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        CommonClass ComObj = new CommonClass();
        protected void denglu_Click(object sender, EventArgs e)
        {
            //string temp = Session["suijishu"].ToString();//新增，新建一个变量将session读走
            // string num = this.TextBox3.Text.Trim();//新增
            string str;
            str = "select WhPassword  from WhAdmin where WhAdminName=@name";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 20);
            cmd.Parameters["@name"].Value = this.usertxt.Text.Trim();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                string WhPassword = dr[0].ToString().Trim();
                dr.Close();
                //判断用户输入的验证码是否正确
                if (this.yanzheng.Text.Trim() == this.yanzheng.Text.Trim())//新增，将产生的随机验证码和输入的验证码都转为大写来进行判断
                {
                    if (WhPassword != passdtxt.Text.Trim())
                    {
                        this.yanzheng.Text = "输入的密码不正确！";
                    }
                    else
                    {
                        Session["Admin"] = this.usertxt.Text.Trim();
                        Response.Redirect("index.aspx");
                    }
                }
                else
                {
                    Response.Write(ComObj.MessageBox("验证码输入有误，请重新输入！"));
                    this.yanzheng.Text = ComObj.RandomNum(4);
                }
            }
            else
            {
                this.yanzheng.Text = "抱歉,你没有权限操作!";
                this.yanzheng.Text = ComObj.RandomNum(4);
                con.Close();
            }


        }
    }
}
