using System.IO;
namespace ZKEShop.Common
{
   public class DataToExcel
    {
       private void ClearFile(string FilePath)
       {
           string[] files = Directory.GetFiles(FilePath);
           if (files.Length > 10)
           {
               for (int i = 0; i < 10; i++)
               {
                   try
                   {
                       File.Delete(files[i]);
                   }
                   catch
                   {
                   }
               }
           }
       }


       //public void CreateExcel()
       //{
       //    Application application = new ApplicationClass();
       //    application.get_Application().get_Workbooks().Add(true);
       //    application.get_Cells().set__Default(1, 1, "第1行第1列");
       //    application.get_Cells().set__Default(1, 2, "第1行第2列");
       //    application.get_Cells().set__Default(2, 1, "第2行第1列");
       //    application.get_Cells().set__Default(2, 2, "第2行第2列");
       //    application.get_Cells().set__Default(3, 1, "第3行第1列");
       //    application.get_Cells().set__Default(3, 2, "第3行第2列");
       //    application.get_ActiveWorkbook().SaveAs("./tt.xls", (XlFileFormat)0x2b, null, null, false, false, 1, null, null, null, null, null);
       //    application.set_Visible(true);
       //}

       //public string DataExcel(DataTable dt, string strTitle, string FilePath, Hashtable nameList)
       //{
       //    cExcelFile file = new cExcelFile();
       //    this.ClearFile(FilePath);
       //    string str = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
       //    file.CreateFile(FilePath + str);
       //    file.set_PrintGridLines(false);
       //    cExcelFile.MarginTypes types = 40;
       //    cExcelFile.MarginTypes types2 = 0x26;
       //    cExcelFile.MarginTypes types3 = 0x27;
       //    cExcelFile.MarginTypes types4 = 0x29;
       //    double num = 1.5;
       //    file.SetMargin(ref types, ref num);
       //    file.SetMargin(ref types2, ref num);
       //    file.SetMargin(ref types3, ref num);
       //    file.SetMargin(ref types4, ref num);
       //    cExcelFile.FontFormatting formatting = 0;
       //    string str2 = "宋体";
       //    short num2 = 9;
       //    file.SetFont(ref str2, ref num2, ref formatting);
       //    byte num3 = 1;
       //    byte num4 = 12;
       //    short num5 = 12;
       //    file.SetColumnWidth(ref num3, ref num4, ref num5);
       //    string str3 = "页眉";
       //    string str4 = "页脚";
       //    file.SetHeader(ref str3);
       //    file.SetFooter(ref str4);
       //    cExcelFile.ValueTypes types5 = 2;
       //    cExcelFile.CellFont font = 0;
       //    cExcelFile.CellAlignment alignment = 2;
       //    cExcelFile.CellHiddenLocked locked = 0;
       //    int num6 = 1;
       //    int num7 = 1;
       //    int num8 = 0;
       //    foreach (DataColumn column in dt.Columns)
       //    {
       //        num8++;
       //        string str5 = column.ColumnName.Trim();
       //        object obj2 = str5;
       //        IDictionaryEnumerator enumerator = nameList.GetEnumerator();
       //        while (enumerator.MoveNext())
       //        {
       //            if (enumerator.Key.ToString().Trim() == str5)
       //            {
       //                obj2 = enumerator.Value;
       //            }
       //        }
       //        file.WriteValue(ref types5, ref font, ref alignment, ref locked, ref num7, ref num8, ref obj2, ref num6);
       //    }
       //    foreach (DataRow row in dt.Rows)
       //    {
       //        num7++;
       //        num8 = 0;
       //        foreach (DataColumn column2 in dt.Columns)
       //        {
       //            num8++;
       //            if (column2.DataType == Type.GetType("System.DateTime"))
       //            {
       //                object obj3 = Convert.ToDateTime(row[column2.ColumnName].ToString()).ToString("yyyy-MM-dd");
       //                file.WriteValue(ref types5, ref font, ref alignment, ref locked, ref num7, ref num8, ref obj3, ref num6);
       //            }
       //            else
       //            {
       //                object obj4 = row[column2.ColumnName].ToString();
       //                file.WriteValue(ref types5, ref font, ref alignment, ref locked, ref num7, ref num8, ref obj4, ref num6);
       //            }
       //        }
       //    }
       //    file.CloseFile();
       //    return str;
       //}
       //public void KillExcelProcess()
       //{
       //    foreach (Process process in Process.GetProcessesByName("Excel"))
       //    {
       //        DateTime time = process.get_StartTime();
       //        if ((time > this.beforeTime) && (time < this.afterTime))
       //        {
       //            process.Kill();
       //        }
       //    }
       //}
       //public string OutputExcel(DataTable dt, string strTitle, string FilePath)
       //{
       //    this.beforeTime = DateTime.Now;
       //    int num = 4;
       //    int num2 = 1;
       //    Application o = new ApplicationClass();
       //    _Workbook workbook = o.get_Workbooks().Add(true);
       //    _Worksheet worksheet = (_Worksheet)workbook.get_ActiveSheet();
       //    foreach (DataColumn column in dt.Columns)
       //    {
       //        num2++;
       //        o.get_Cells().set__Default(4, num2, column.ColumnName);
       //        worksheet.get_Range(o.get_Cells().get__Default(4, num2), o.get_Cells().get__Default(4, num2)).get_Font().set_Bold(true);
       //        worksheet.get_Range(o.get_Cells().get__Default(4, num2), o.get_Cells().get__Default(4, num2)).set_HorizontalAlignment((XlVAlign)(-4108));
       //        worksheet.get_Range(o.get_Cells().get__Default(4, num2), o.get_Cells().get__Default(4, num2)).Select();
       //        worksheet.get_Range(o.get_Cells().get__Default(4, num2), o.get_Cells().get__Default(4, num2)).get_Interior().set_ColorIndex(this.titleColorindex);
       //    }
       //    foreach (DataRow row in dt.Rows)
       //    {
       //        num++;
       //        num2 = 1;
       //        foreach (DataColumn column2 in dt.Columns)
       //        {
       //            num2++;
       //            if (column2.DataType == Type.GetType("System.DateTime"))
       //            {
       //                o.get_Cells().set__Default(num, num2, Convert.ToDateTime(row[column2.ColumnName].ToString()).ToString("yyyy-MM-dd"));
       //                worksheet.get_Range(o.get_Cells().get__Default(num, num2), o.get_Cells().get__Default(num, num2)).set_HorizontalAlignment((XlVAlign)(-4108));
       //            }
       //            else
       //            {
       //                if (column2.DataType == Type.GetType("System.String"))
       //                {
       //                    o.get_Cells().set__Default(num, num2, "'" + row[column2.ColumnName].ToString());
       //                    worksheet.get_Range(o.get_Cells().get__Default(num, num2), o.get_Cells().get__Default(num, num2)).set_HorizontalAlignment((XlVAlign)(-4108));
       //                    continue;
       //                }
       //                o.get_Cells().set__Default(num, num2, row[column2.ColumnName].ToString());
       //            }
       //        }
       //    }
       //    int num3 = num + 1;
       //    int num4 = 2;
       //    o.get_Cells().set__Default(num3, 2, "合计");
       //    worksheet.get_Range(o.get_Cells().get__Default(num3, 2), o.get_Cells().get__Default(num3, 2)).set_HorizontalAlignment((XlHAlign)(-4108));
       //    worksheet.get_Range(o.get_Cells().get__Default(num3, num4), o.get_Cells().get__Default(num3, num2)).Select();
       //    o.get_Cells().set__Default(2, 2, strTitle);
       //    worksheet.get_Range(o.get_Cells().get__Default(2, 2), o.get_Cells().get__Default(2, 2)).get_Font().set_Bold(true);
       //    worksheet.get_Range(o.get_Cells().get__Default(2, 2), o.get_Cells().get__Default(2, 2)).get_Font().set_Size(0x16);
       //    worksheet.get_Range(o.get_Cells().get__Default(4, 2), o.get_Cells().get__Default(num3, num2)).Select();
       //    worksheet.get_Range(o.get_Cells().get__Default(4, 2), o.get_Cells().get__Default(num3, num2)).get_Columns().AutoFit();
       //    worksheet.get_Range(o.get_Cells().get__Default(2, 2), o.get_Cells().get__Default(2, num2)).Select();
       //    worksheet.get_Range(o.get_Cells().get__Default(2, 2), o.get_Cells().get__Default(2, num2)).set_HorizontalAlignment((XlHAlign)7);
       //    worksheet.get_Range(o.get_Cells().get__Default(4, 2), o.get_Cells().get__Default(num3, num2)).get_Borders().set_LineStyle(1);
       //    worksheet.get_Range(o.get_Cells().get__Default(4, 2), o.get_Cells().get__Default(num3, 2)).get_Borders().get__Default(7).set_Weight((XlBorderWeight)4);
       //    worksheet.get_Range(o.get_Cells().get__Default(4, 2), o.get_Cells().get__Default(4, num2)).get_Borders().get__Default(8).set_Weight((XlBorderWeight)4);
       //    worksheet.get_Range(o.get_Cells().get__Default(4, num2), o.get_Cells().get__Default(num3, num2)).get_Borders().get__Default(10).set_Weight((XlBorderWeight)4);
       //    worksheet.get_Range(o.get_Cells().get__Default(num3, 2), o.get_Cells().get__Default(num3, num2)).get_Borders().get__Default(9).set_Weight((XlBorderWeight)4);
       //    this.afterTime = DateTime.Now;
       //    this.ClearFile(FilePath);
       //    string str = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
       //    o.get_ActiveWorkbook().SaveAs(FilePath + str, (XlFileFormat)0x2b, null, null, false, false, 1, null, null, null, null, null);
       //    workbook.Close(null, null, null);
       //    o.get_Workbooks().Close();
       //    o.Quit();
       //    if (worksheet != null)
       //    {
       //        Marshal.ReleaseComObject(worksheet);
       //        worksheet = null;
       //    }
       //    if (workbook != null)
       //    {
       //        Marshal.ReleaseComObject(workbook);
       //        workbook = null;
       //    }
       //    if (o != null)
       //    {
       //        Marshal.ReleaseComObject(o);
       //        o = null;
       //    }
       //    GC.Collect();
       //    return str;
       //}

    }
}
