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
    public partial class user_manage : System.Web.UI.Page
    {
        CommonClass ccObj = new CommonClass();
        DBClass dbObj = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvMemberBind();
            }
        }
        //数据绑定
        public void gvMemberBind()
        {
            string strSql = "select * from Users";
            DataTable dsTable = dbObj.GetDataSetStr(strSql, "Users");
            this.gvMemberList.DataSource = dsTable.DefaultView;
            this.gvMemberList.DataKeyNames = new string[] { "UserID" };
            this.gvMemberList.DataBind();
        }
        //分页
        protected void gvMemberList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMemberList.PageIndex = e.NewPageIndex;
            gvMemberBind();
        }
        //删除操作
        protected void gvMemberList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strSql = "delete from Users where UserID=" + (gvMemberList.DataKeys[e.RowIndex].Value.ToString());
            SqlCommand myCmd = dbObj.GetCommandStr(strSql);
            dbObj.ExecNonQuery(myCmd);
            gvMemberBind();
        }
        //弹出确认是否删除对话框
        // protected void gvMemberList_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //  if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //  ((Button)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "return confirm('确定要删除吗?')");
        //}
        //}
    }
}