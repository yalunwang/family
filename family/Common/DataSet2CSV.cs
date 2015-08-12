using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ZKEShop.Common
{
        /// <summary>
        /// 将DataSet写成CSV文件
        /// </summary>
        public class DataSet2CSV
        {
            #region 001----将DataSet转换成CSV文件
            public static void Export2CSV(DataSet ds, string tableName, bool containColumName, string fileName)
            {
                string csvStr = "";
                if (ds.Tables.Count > 1)
                    csvStr = ConverDataSet2CSV(ds,containColumName);
                else
                    csvStr = ConverDataSet2CSV(ds, tableName, containColumName);
                if (csvStr == "") return;
                System.IO.StreamWriter wr = new StreamWriter(fileName,false ,System.Text.Encoding.Default);
                wr.Write(csvStr);
                wr.Close();
            }

            /// <summary>
            /// 将指定的数据集中指定的表转换成CSV字符串
            /// </summary>
            /// <param name="ds"></param>
            /// <param name="tableName"></param>
            /// <returns></returns>
            private static string ConverDataSet2CSV(DataSet ds, string tableName, bool containColumName)
            {
                //首先判断数据集中是否包含指定的表
                if (ds == null || !ds.Tables.Contains(tableName))
                {
                    //MessageBox.Show("指定的数据集为空或不包含要写出的数据表！", "系统提示：", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return "";
                }
                string csvStr = "";
                //下面写出数据
                DataTable tb = ds.Tables[tableName];
                //写表名
                //csvStr += tb.TableName + "\n";
                //第一步：写出列名
                if (containColumName)
                {
                    foreach (DataColumn column in tb.Columns)
                    {
                        csvStr += "\"" + column.ColumnName + "\"" + ",";
                    }
                    //去掉最后一个","
                    csvStr = csvStr.Remove(csvStr.LastIndexOf(","), 1);
                    csvStr += "\n";
                }
                //第二步：写出数据
                foreach (DataRow row in tb.Rows)
                {
                    foreach (DataColumn column in tb.Columns)
                    {
                        csvStr += "\"" + row[column].ToString() + "\"" + ",";
                    }
                    csvStr = csvStr.Remove(csvStr.LastIndexOf(","), 1);
                    csvStr += "\n";
                }
                return csvStr;
            }

            private static string ConverDataSet2CSV(DataSet ds, bool containColumName)
            {
                //首先判断数据集中是否包含指定的表
                if (ds == null || ds.Tables.Count == 0)
                {
                    //MessageBox.Show("指定的数据集为空或不包含要写出的数据表！", "系统提示：", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return "";
                }
                string csvStr = "";
                //写表名

                foreach (DataTable  item in ds.Tables)
                {
                    //csvStr += tb.TableName + "\n";
                    //第一步：写出列名
                    if (containColumName)
                    {
                        foreach (DataColumn column in item.Columns)
                        {
                            csvStr += "\"" + column.ColumnName + "\"" + ",";
                        }
                        //去掉最后一个","
                        csvStr = csvStr.Remove(csvStr.LastIndexOf(","), 1);
                        csvStr += "\n";
                    }
                    //第二步：写出数据
                    foreach (DataRow row in item.Rows)
                    {
                        foreach (DataColumn column in item.Columns)
                        {
                            csvStr += "\"" + row[column].ToString() + "\"" + ",";
                        }
                        csvStr = csvStr.Remove(csvStr.LastIndexOf(","), 1);
                        csvStr += "\n";
                    }
                }
                return csvStr;
            }

            #endregion

            #region 002----从CSV文件填充DataSet

            public static DataSet ConverCSV2DataSet(string fileName, string tableName)
            {
                DataSet ds = new DataSet();
                string _filePath, _fileName;
                _filePath = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                _fileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + _filePath + @"\" + ";Extended Properties=\"Text;HDR=Yes;FMT=Delimited\"";
                OleDbConnection oleCon = new OleDbConnection(conStr);
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from " + _fileName, oleCon);
                da.Fill(ds, tableName);
                oleCon.Close();
                return ds;
            }
            #endregion

        }


    }

