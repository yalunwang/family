using System.Data.OleDb;
using System.Data;

namespace ZKEShop.Common
{
    public class DataSet2Excel
    {
        public static System.Data.DataSet Excel2Dataset(string fileName, string tableName)
        {
            bool isOpen = true;
            try
            {
                return DataSet2CSV.ConverCSV2DataSet(fileName, tableName);
            }
            catch (System.Exception) { }

            OleDbConnection connStr = new OleDbConnection();
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
            connStr.ConnectionString = strConn;
            try
            {
                connStr.Open();
            }
            catch (System.Exception)
            {
                isOpen = false;
            }

            if (!isOpen)
            {
                isOpen = true;
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES';";
                connStr.ConnectionString = strConn;
                try
                {
                    connStr.Open();
                }
                catch (System.Exception)
                {
                    isOpen = false;
                }
            }

            if (!isOpen)
                return null;

            //动态表名
            DataTable tblSchema = connStr.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string sheetName = tblSchema.Rows[0]["TABLE_NAME"].ToString();
            OleDbDataAdapter cmd = new OleDbDataAdapter("select * from [" + sheetName + "]", connStr);

            DataSet ds = new DataSet();
            cmd.Fill(ds, tableName);
            
            connStr.Close();
            connStr = null;
            return ds;
        }
    }
}