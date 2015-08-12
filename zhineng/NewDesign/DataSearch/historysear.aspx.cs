using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace family.DataSearch
{
    public partial class historysear : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bind();
        }
        protected void bind()
        {
           
            SqlConnection myConn = db.GetConnection();

            myConn.Open();
            // string sqlStr = "select * from biaoshu";
            string sqlStr = "select UserName,RealName,Users.UserID,Userdianbiao.表地址,电量,电量*0.56 AS '电费(元)',抄录时间,操作时间 from biaoshu,Userdianbiao,Users Where biaoshu.表地址=Userdianbiao.表地址 and Userdianbiao.UserID=Users.UserID ";
            SqlDataAdapter myDa = new SqlDataAdapter(sqlStr, myConn);
            DataSet myDs = new DataSet();
            myDa.Fill(myDs);
            GridView1.DataSource = myDs;
            GridView1.DataBind();
            myDa.Dispose();
            myDs.Dispose();
            myConn.Close();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}