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

namespace family.wangluoweihu
{
    public partial class dianbiaomanage : System.Web.UI.Page
    {
        CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bind();
        }
        protected void bind()
        {
           SqlConnection myConn =dbObj.GetConnection();

            myConn.Open();
            string sqlStr = "select * from dianbiao";
            SqlDataAdapter myDa = new SqlDataAdapter(sqlStr, myConn);
            DataSet myDs = new DataSet();
            myDa.Fill(myDs);
            GridView1.DataSource = myDs;
            GridView1.DataBind();
            myDa.Dispose();
            myDs.Dispose();
            myConn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (this.txtName.Text != "")
            {
                 SqlConnection myConn =dbObj.GetConnection();
             
                myConn.Open();
                string sqlStr = "select * from dianbiao where 表地址=@电表号";
                SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
                myCmd.Parameters.Add("@电表号", SqlDbType.VarChar, 20).Value = this.txtName.Text.Trim();
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
                }
                myDa.Dispose();
                myDs.Dispose();
                myConn.Close();
            }
            //else
            // this.bind();
            else
            {

                Response.Write("<script>alert('请输入您要查询的电表表号')</script>");//新增
            }
        }
        protected void btnJiansuo_Click(object sender, EventArgs e)//新增
        {
            this.bind();
        }

      
       
    }
}