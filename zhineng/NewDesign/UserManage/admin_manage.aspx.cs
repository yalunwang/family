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
    public partial class admin_manage : System.Web.UI.Page
    {
        CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        int whclass;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
           // {

                gvMemberBind();




            //}
        }
        public void gvMemberBind()
        {
            string strSql = "select * from WhAdmin";
            DataTable dsTable = dbObj.GetDataSetStr(strSql, "WhAdmin");
            this.gvMemberList.DataSource = dsTable.DefaultView;
            this.gvMemberList.DataKeyNames = new string[] { "WhAdminID" };
            this.gvMemberList.DataBind();

        }
        protected void gvMemberList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMemberList.PageIndex = e.NewPageIndex;
            gvMemberBind();
        }
        protected void gvMemberList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //whclass = int.Parse(Session["WhClass"].ToString());
            // if (whclass != 10)
            //{

            //  Response.Write(ccObj.MessageBox("您没有权限操作，请申请高级权限！"));
            //return;

            // }

            //int classSqlx =int.Parse(gvMemberList.Rows[e.RowIndex].Cells[7].Text.ToString().Trim());

            // if (classSqlx== 10)
            // {
            // Response.Write(ccObj.MessageBox("对不起，不能删除高级管理员！"));
            //return;
            //   }

            //string strSql = "delete from WhAdmin where WhAdminID=" + Convert.ToInt32(gvMemberList.DataKeys[e.RowIndex].Value.ToString());
            //SqlCommand myCmd = dbObj.GetCommandStr(strSql);
            // dbObj.ExecNonQuery(myCmd);
            //gvMemberBind();
            int ClassID = Convert.ToInt32(gvMemberList.DataKeys[e.RowIndex].Value.ToString());
            string sqlStr = "delete from WhAdmin  where WhAdminID=" + ClassID;
            SqlConnection myConn = dbObj.GetConnection();
            myConn.Open();
            SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
            myCmd.ExecuteNonQuery();
            myCmd.Dispose();
            myConn.Close();
            gvMemberList.EditIndex = -1;
            this.gvMemberBind();
        }
        //protected void gvMemberList_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //((LinkButton)e.Row.Cells[0].Controls[0]).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
        // }
        //}
    }
}