using System;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace ZKEShop.Common
{
   public class PageValidate
    {
        private static Regex RegCHZN;
        private static Regex RegDecimal;
        private static Regex RegDecimalSign;
        private static Regex RegEmail;
        private static Regex RegNumber;
        private static Regex RegNumberSign;
       static PageValidate()
       {
           RegNumber = new Regex("^[0-9]+$");
           RegNumberSign = new Regex("^[+-]?[0-9]+$");
           RegDecimal = new Regex("^[0-9]+[.]?[0-9]+$");
           RegDecimalSign = new Regex("^[+-]?[0-9]+[.]?[0-9]+$");
           RegEmail = new Regex(@"^[\w-]+@[\w-]+\.(com|net|org|edu|mil|tv|biz|info)$");
           RegCHZN = new Regex("[һ-��]");
       }
       public static string Decode(string str)
       {
           str = str.Replace("<br>", "\n");
           str = str.Replace("&gt;", ">");
           str = str.Replace("&lt;", "<");
           str = str.Replace("&nbsp;", " ");
           str = str.Replace("&quot;", "\"");
           return str;
       }
       public static string Encode(string str)
       {
           str = str.Replace("&", "&amp;");
           str = str.Replace("'", "''");
           str = str.Replace("\"", "&quot;");
           str = str.Replace(" ", "&nbsp;");
           str = str.Replace("<", "&lt;");
           str = str.Replace(">", "&gt;");
           str = str.Replace("\n", "<br>");
           return str;
       }
       public static string FetchInputDigit(HttpRequest req, string inputKey, int maxLen)
       {
           string sqlInput = string.Empty;
           if ((inputKey != null) && (inputKey != string.Empty))
           {
               sqlInput = req.QueryString[inputKey];
               if (sqlInput == null)
               {
                   sqlInput = req.Form[inputKey];
               }
               if (sqlInput != null)
               {
                   sqlInput = SqlText(sqlInput, maxLen);
                   if (!IsNumber(sqlInput))
                   {
                       sqlInput = string.Empty;
                   }
               }
           }
           if (sqlInput == null)
           {
               sqlInput = string.Empty;
           }
           return sqlInput;
       }
       public static string HtmlEncode(string inputData)
       {
           return HttpUtility.HtmlEncode(inputData);
       }
       public static string InputText(string inputString, int maxLength)
       {
           StringBuilder builder = new StringBuilder();
           if ((inputString != null) && (inputString != string.Empty))
           {
               inputString = inputString.Trim();
               if (inputString.Length > maxLength)
               {
                   inputString = inputString.Substring(0, maxLength);
               }
               for (int i = 0; i < inputString.Length; i++)
               {
                   switch (inputString[i])
                   {
                       case '<':
                           {
                               builder.Append("&lt;");
                               continue;
                           }
                       case '>':
                           {
                               builder.Append("&gt;");
                               continue;
                           }
                       case '"':
                           {
                               builder.Append("&quot;");
                               continue;
                           }
                   }
                   builder.Append(inputString[i]);
               }
               builder.Replace("'", " ");
           }
           return builder.ToString();
       }
       public static bool IsDateTime(string inputData)
       {
           try
           {
               Convert.ToDateTime(inputData);
               return true;
           }
           catch
           {
               return false;
           }
       }
       public static bool IsDecimal(string inputData)
       {
           return RegDecimal.Match(inputData).Success;
       }
       public static bool IsDecimalSign(string inputData)
       {
           return RegDecimalSign.Match(inputData).Success;
       }
       public static bool IsEmail(string inputData)
       {
           return RegEmail.Match(inputData).Success;
       }

       public static bool IsHasCHZN(string inputData)
       {
           return RegCHZN.Match(inputData).Success;
       }

       public static bool IsNumber(string inputData)
       {
           return RegNumber.Match(inputData).Success;
       }
       public static bool IsNumberSign(string inputData)
       {
           return RegNumberSign.Match(inputData).Success;
       }
       public static void SetLabel(Label lbl, object inputObj)
       {
           SetLabel(lbl, inputObj.ToString());
       }

       public static void SetLabel(Label lbl, string txtInput)
       {
           lbl.Text = HtmlEncode(txtInput);
       }
       public static string SqlText(string sqlInput, int maxLength)
       {
           if ((sqlInput != null) && (sqlInput != string.Empty))
           {
               sqlInput = sqlInput.Trim();
               if (sqlInput.Length > maxLength)
               {
                   sqlInput = sqlInput.Substring(0, maxLength);
               }
           }
           return sqlInput;
       }
    }
}
