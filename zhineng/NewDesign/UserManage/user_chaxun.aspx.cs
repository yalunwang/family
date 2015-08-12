using System;
using System.Data;
using System.Configuration;
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
    public partial class user_chaxun : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
           this.bind();
        }
        protected void bind()
        {
          //  SqlConnection myConn = new SqlConnection("server=DELL-PC;uid=sa;pwd=1;database=Wire_Store");//新增
            SqlConnection myConn = db.GetConnection();

            myConn.Open();
            string sqlStr = "select * from dbo.Users";
            SqlDataAdapter myDa = new SqlDataAdapter(sqlStr, myConn);
            DataSet myDs = new DataSet();
            myDa.Fill(myDs);
            GridView1.DataSource = myDs;
            GridView1.DataBind();
            myDa.Dispose();
            myDs.Dispose();
            myConn.Close();
        }

        protected void btnJiansuo_Click(object sender, EventArgs e)//新增
        {
            this.bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "")
            {
             
                SqlConnection myConn = db.GetConnection();
               // SqlConnection myConn = new SqlConnection("server=KJY-452B036A3D4;uid=sa;pwd=1;database=Wire_Store");//新增
                myConn.Open();
                string sqlStr = "select * from Users where UserName=@UserName";
                SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
                myCmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = this.txtName.Text.Trim();
                SqlDataAdapter myDa = new SqlDataAdapter(myCmd);
                DataSet myDs = new DataSet();
                myDa.Fill(myDs);
                if (myDs.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = myDs;
                    GridView1.DataBind();
                }
                else
                {

                   Response.Write("<script>alert('没有相关记录')</script>");
                    //Response.Write("<script>window.open('Login.aspx','','width=336,height=241')</script>");
                }
                myDa.Dispose();
                myDs.Dispose();
                myConn.Close();
            }
            //else
             //<a href="#" onclick ="javascript:window.open('Login.aspx','','width=336,height=241')" ><font color =black>后台入口</font></a>
            // this.bind();
            else
            {

                Response.Write("<script>alert('请输入您要查询的名字')</script>");//新增
            }
        }

        

        
    }
}