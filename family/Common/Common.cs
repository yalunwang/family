using System;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;

namespace ZKEShop.Common
{
    public class Common
    {
        #region 正则表达式取值

        /// <summary>
        /// 正则表达式取值

        /// </summary>
        /// <param name="HtmlCode">源码</param>
        /// <param name="RegexString">正则表达式</param>
        /// <param name="GroupKey">正则表达式分组关键字</param>
        /// <param name="RightToLeft">是否从右到左</param>
        /// <returns></returns>
        public static string[] GetRegValue(string HtmlCode, string RegexString, string GroupKey, bool RightToLeft)
        {
            MatchCollection m;
            Regex r;
            if (RightToLeft == true)
            {
                r = new Regex(RegexString, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            }
            else
            {
                r = new Regex(RegexString, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            m = r.Matches(HtmlCode);
            string[] MatchValue = new string[m.Count];
            for (int i = 0; i < m.Count; i++)
            {
                MatchValue[i] = m[i].Groups[GroupKey].Value;
            }
            return MatchValue;
        }
        #endregion

        #region 替换所有的Html标记
        /// <summary>
        /// create by minzw
        /// 替换所有的Html标记
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DisHtml(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            else
            {
                //替换所有的Html
                str = Regex.Replace(str, "<[^>]*>", "");

                //替换SQL
                str = SqlFix(str);

                //xss注入
                str = NoJavaScript(str, 1, "&#");

                return str;
            }
        }
        #endregion

        #region 显示规定一行数量的文字，返回处理后的文本

        /// <summary>
        /// 显示规定一行数量的文字，返回处理后的文本
        /// </summary>
        /// <param name="text">需要处理的文本</param>
        /// <param name="shoucount">数量</param>
        /// <returns>返回处理后的文本</returns>
        public static String Left(string text, int shucount)
        {
            int num = 0;
            if (string.IsNullOrEmpty(text))
                return "";

            if (text.Length > shucount)
            {
                num = text.Length / shucount;
                for (int j = 1; j < num; j++)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (j > 0)
                        {
                            if (j == 1)
                            {
                                text = text.Substring(0, shucount * j) + "<br/>" + text.Substring(shucount * j);
                                break;
                            }
                            if (i == shucount * j + 5 * (j - 1))
                            {
                                text = text.Substring(0, shucount * j + 5 * (j - 1)) + "<br/>" + text.Substring(shucount * j + 5 * (j - 1));
                                break;
                            }
                        }
                    }
                }

                if (num == 1)
                {
                    text = text.Substring(0, shucount) + "<br/>" + text.Substring(shucount);
                }
            }
            return text;
        }
        #endregion
        


        #region 动态排序

        /// <summary>
        /// create by minzw
        /// 动态排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">数据源</param>
        /// <param name="sortExpression">排序字段名</param>
        /// <param name="sortDirection">排序方式</param>
        /// <returns></returns>
        public static IQueryable<T> DataSorting<T>(IQueryable<T> source, string sortExpression, string sortDirection)
        {
            string sortingDir = string.Empty;
            if (sortDirection.ToUpper().Trim() == "ASC")
                sortingDir = "OrderBy";
            else if (sortDirection.ToUpper().Trim() == "DESC")
                sortingDir = "OrderByDescending";

            ParameterExpression param = Expression.Parameter(typeof(T), sortExpression);
            PropertyInfo pi = typeof(T).GetProperty(sortExpression);
            Type[] types = new Type[2];
            types[0] = typeof(T);
            types[1] = pi.PropertyType;
            Expression expr = Expression.Call(typeof(Queryable), sortingDir, types, source.Expression, Expression.Lambda(Expression.Property(param, sortExpression), param));
            IQueryable<T> query = source.AsQueryable().Provider.CreateQuery<T>(expr);
            return query;
        }

        #endregion

        #region 截取指定长度中英文字符串方法
        /// <summary>
        /// 截取指定长度中英文字符串方法
        /// </summary>
        /// <param name="stringToSub">待截取的字符串</param>
        /// <param name="length">输出字符串最大的长度</param>
        /// <returns>字符串(string)</returns>
        public static string CutString(string stringToSub, int length)
        {
            if (string.IsNullOrEmpty(stringToSub))
                return "";
            if (length == -1)
                return stringToSub;
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = stringToSub.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                return sb.ToString() + "...";
            else
                return sb.ToString();
        }
        #endregion

        #region 检查文件名是否规范
        /// <summary>
        /// 检查文件名是否规范
        /// </summary>
        /// <param name="pathNames"></param>
        /// <returns></returns>
        public static bool IsValidFileName(string pathNames)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(pathNames))
                flag = false;
            else
            {
                pathNames = pathNames.ToLower();
                string errChar = "\\/:*?\"<>|";
                for (int i = 0; i < errChar.Length; i++)
                {
                    if (pathNames.Contains(errChar[i].ToString()))
                    { flag = false; break; }
                }

                if (!flag)
                {
                    //string[] errStr = new string[] { "/","\\",":","*","\"","<",">","|",",","?","asp","jsp","php","aspx" };
                    string[] errStr = new string[] { "asp", "jsp", "php", "aspx" };
                    for (int i = 0; i < errStr.Length; i++)
                    {
                        if (pathNames.Contains(errStr[i]))
                        { flag = false; break; }
                    }
                }
            }
            return flag;
        }
        #endregion

        #region 获取文件扩展名
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fpath"></param>
        /// <returns></returns>
        public static string GetExtension(String fpath)
        {
            string _rv = string.Empty;
            if ((!string.IsNullOrEmpty(fpath)) && (fpath.Length > 0))
            {
                int i = fpath.LastIndexOf('.');
                if ((i > 0) && (i < (fpath.Length - 1)))
                {
                    _rv = fpath.Substring(i);
                }
            }
            return _rv.ToLower();
        }
        #endregion

        #region 检查图片文件扩展名是否规范
        public static bool isValidExt(string fileExit)
        {
            if (string.IsNullOrEmpty(fileExit))
                return false;

            bool flag = false;
            string[] allowedExts = { ".gif", ".jpg", ".jpeg", ".png" };
            fileExit = fileExit.ToLower();
            for (int i = 0; i < allowedExts.Length; i++)
            {
                if (fileExit == allowedExts[i])
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
        #endregion

        #region 检查办公文件扩展名是否规范
        public static bool isValidExt(string fileExit, bool isoa)
        {
            if (string.IsNullOrEmpty(fileExit))
                return false;

            bool flag = false;
            string[] allowedExts = { ".doc", ".xls", ".pdf", ".txt", ".ppt" };
            fileExit = fileExit.ToLower();
            for (int i = 0; i < allowedExts.Length; i++)
            {
                if (fileExit == allowedExts[i])
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
        #endregion

        #region 检查压缩文件扩展名是否规范
        public static bool isValidExt(string fileExit, bool isoa, bool israr)
        {
            if (string.IsNullOrEmpty(fileExit))
                return false;

            bool flag = false;
            string[] allowedExts = { ".rar", ".zip" };
            fileExit = fileExit.ToLower();
            for (int i = 0; i < allowedExts.Length; i++)
            {
                if (fileExit == allowedExts[i])
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
        #endregion

        #region 替换SQL语句中的特殊字符
        /// <summary>
        /// 替换SQL语句中的特殊字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SqlFix(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            else
            {
                string rand = "#" + System.Guid.NewGuid().ToString().Substring(0, 5);
                str = str.ToLower();
                str = str.Replace("'", "’");
                str = str.Replace("\"", rand);
                str = str.Replace(";", rand);
                str = str.Replace("&", rand);
                str = str.Replace("declare", rand);
                str = str.Replace("update", rand);
                str = str.Replace("delete", rand);
                str = str.Replace("select", rand);
                str = str.Replace("insert", rand);
                str = str.Replace("set", rand);
                str = str.Replace("create", rand);
                str = str.Replace("%20", rand);
                str = str.Replace("--", rand);
                str = str.Replace("==", rand);
                str = str.Replace("<", rand);
                str = str.Replace(">", rand);
                str = str.Replace("%", rand);
                return str;
            }
        }
        #endregion

        #region 提取HTML代码中文字

        ///<summary>
        ///提取HTML代码中文字
        ///</summary>
        public static string StripHTML(string strHtml)
        {
            string[] aryReg ={
           @"<script[^>]*?>.*?</script>",
           @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>",
           @"([\r\n])[\s]+",
           @"&(quot|#34);",
           @"&(amp|#38);",
           @"&(lt|#60);",
           @"&(gt|#62);",
           @"&(nbsp|#160);",
           @"&(iexcl|#161);",
           @"&(cent|#162);",
           @"&(pound|#163);",
           @"&(copy|#169);",
           @"&#(\d+);",
           @"-->",
           @"<!--.*\n"
          };
            string[] aryRep =   {
             "",
             "",
             "",
             "\"",
             "&",
             "<",
             ">",
             "   ",
             "\xa1",//chr(161), 
             "\xa2",//chr(162), 
             "\xa3",//chr(163), 
             "\xa9",//chr(169), 
             "",
             "\r\n",
             ""
            };
            string newReg = aryReg[0];
            string strOutput = strHtml;
            for (int i = 0; i < aryReg.Length; i++)
            {
                Regex regex = new Regex(aryReg[i], RegexOptions.IgnoreCase);
                strOutput = regex.Replace(strOutput, aryRep[i]);
            }
            strOutput.Replace("<", "");
            strOutput.Replace(">", "");
            strOutput.Replace("\r\n", "");
            return strOutput;
        }
        #endregion

        #region 按字节长度截取字符串(支持截取带HTML代码样式的字符串)
        /// <summary>
        /// 按字节长度截取字符串(支持截取带HTML代码样式的字符串)
        /// </summary>
        /// <param name="param">将要截取的字符串参数</param>
        /// <param name="length">截取的字节长度</param>
        /// <param name="end">字符串末尾补上的字符串</param>
        /// <returns>返回截取后的字符串</returns>
        public static string SubstringToHTML(string param, int length, string end)
        {
            string Pattern = null;
            MatchCollection m = null;
            StringBuilder result = new StringBuilder();
            int n = 0;
            char temp;
            bool isCode = false; //是不是HTML代码
            bool isHTML = false; //是不是HTML特殊字符,如&nbsp;
            char[] pchar = param.ToCharArray();
            for (int i = 0; i < pchar.Length; i++)
            {
                temp = pchar[i];
                if (temp == '<')
                {
                    isCode = true;
                }
                else if (temp == '&')
                {
                    isHTML = true;
                }
                else if (temp == '>' && isCode)
                {
                    n = n - 1;
                    isCode = false;
                }
                else if (temp == ';' && isHTML)
                {
                    isHTML = false;
                }

                if (!isCode && !isHTML)
                {
                    n = n + 1;
                    //UNICODE码字符占两个字节
                    if (System.Text.Encoding.Default.GetBytes(temp + "").Length > 1)
                    {
                        n = n + 1;
                    }
                }

                result.Append(temp);
                if (n >= length)
                {
                    break;
                }
            }
            result.Append(end);
            //取出截取字符串中的HTML标记
            string temp_result = result.ToString().Replace("(>)[^<>]*(<?)", "$1$2");
            //去掉不需要结素标记的HTML标记
            temp_result = temp_result.Replace(@"</?(AREA|BASE|BASEFONT|BODY|BR|COL|COLGROUP|DD|DT|FRAME|HEAD|HR|HTML|IMG|INPUT|ISINDEX|LI|LINK|META|OPTION|P|PARAM|TBODY|TD|TFOOT|TH|THEAD|TR|area|base|basefont|body|br|col|colgroup|dd|dt|frame|head|hr|html|img|input|isindex|li|link|meta|option|p|param|tbody|td|tfoot|th|thead|tr)[^<>]*/?>", "");
            //去掉成对的HTML标记
            temp_result = temp_result.Replace(@"<([a-zA-Z]+)[^<>]*>(.*?)</\1>", "$2");
            //用正则表达式取出标记
            Pattern = ("<([a-zA-Z]+)[^<>]*>");
            m = Regex.Matches(temp_result, Pattern);
            ArrayList endHTML = new ArrayList();
            foreach (Match mt in m)
            {
                endHTML.Add(mt.Result("$1"));
            }
            //补全不成对的HTML标记
            for (int i = endHTML.Count - 1; i >= 0; i--)
            {
                result.Append("</");
                result.Append(endHTML[i]);
                result.Append(">");
            }
            return result.ToString();
        }
        #endregion

        #region xss注入

        private static string unwantedTags = "</*(table|drop|delete|applet|meta|xml|blink|link|style|script|embed|object|iframe|frame|frameset|ilayer|layer|bgsound|title|base)[^>]*>";
        private static string nojavascript = ("([a-z]*)[\\x00-\\x20]*=[\\x00-\\x20]*([\\`\\\'\\\\\"]*)[\\x00-\\x20]*j[\\x00-\\x20]*a[\\x00-\\x20]*v[\\x0" + "0-\\x20]*a[\\x00-\\x20]*s[\\x00-\\x20]*c[\\x00-\\x20]*r[\\x00-\\x20]*i[\\x00-\\x20]*p[\\x00-\\x20]*t[\\x00-\\x20]*");
        //private string nojavascript = @("([a-z]*)[\x00-\x20]*=[\x00-\x20]*([\`\\'\\\"]*)[\x00-\x20]*j[\x00-\x20]*a[\x00-\x20]*v[\x0" + "0-\x20]*a[\x00-\x20]*s[\x00-\x20]*c[\x00-\x20]*r[\x00-\x20]*i[\x00-\x20]*p[\x00-\x20]*t[\x00-\x20]*");
        /// <summary>
        /// xss注入
        /// lblMessage.Text = NoJavaScript(txtTextBox.Text,"&#");
        /// </summary>
        /// <param name="strIn"></param>
        /// <param name="replaceChar"></param>
        /// <returns></returns>
        public static string NoJavaScript(string strIn, int notype, string replaceChar)
        {
            string pattern = string.Empty;
            pattern = notype == 1 ? nojavascript : unwantedTags;
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;
            Regex regex = new Regex(pattern, options);
            string result = regex.Replace(strIn.ToLower(), replaceChar);

            result = result.Replace("alert", replaceChar);
            result = result.Replace("ActiveXObject", replaceChar);
            result = result.Replace("XMLHttpRequest", replaceChar);

            return result;
        }

        #endregion

        #region 获取客户端IP地址
        /// <summary>
        /// 获取客户端IP地址
        /// </summary>
        /// <returns>字符串</returns>
        public static string GetIp()
        {
            string result = null;
            System.Web.HttpContext contxt = System.Web.HttpContext.Current;

            result = contxt.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(result))
            {
                result = contxt.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (string.IsNullOrEmpty(result))
            {
                result = contxt.Request.UserHostAddress;
            }
            /*
            if (null == result || result == String.Empty)
            {
                return "0.0.0.0";
            }
             */
            return result;
        }
        #endregion

        #region 转换为JS方式的输出

        public static string ChgJavaStr(string js)
        {
            if (string.IsNullOrEmpty(js))
            {
                return "";
            }

            js = js.Replace("\r\n", "");
            js = js.Replace("\n", "");
            js = js.Replace("\r", "");
            js = js.Replace("'", "\\'");
            js = js.Replace("\"", "\\\"");
            return js;
        }
        #endregion

        public static string VBLeft(string str, int length)
        {
            if (str.Length > length)
                return str.Substring(0, length - 1);
            else
                return str;
        }

        public static string ReplaceStr(string strhtml)
        {
            if (string.IsNullOrEmpty(strhtml))
                return "";
            strhtml = strhtml.Replace(">", "&lt;");
            strhtml = strhtml.Replace("<", "&gt;");
            return strhtml;
        }

        public static string GetSearchKeyword(string sRefererUrl)
        {
            int pos;
            string words = "";
            if (sRefererUrl.IndexOf("google.com") > 0)
            {
                pos = sRefererUrl.IndexOf("q=");
                if (pos == -1)
                    return "";
                words = sRefererUrl.Substring(pos + 2);
                pos = words.IndexOf("&");
                if (pos > -1)
                    words = words.Substring(0, pos);
                return System.Web.HttpUtility.UrlDecode(words, System.Text.Encoding.UTF8);
            }
            else if (sRefererUrl.IndexOf("baidu.com") > 0)
            {
                pos = sRefererUrl.IndexOf("wd=");
                if (pos == -1)
                    return "";
                words = sRefererUrl.Substring(pos + 3);
                pos = words.IndexOf("&");
                if (pos > -1)
                    words = words.Substring(0, pos);
                return System.Web.HttpUtility.UrlDecode(words, System.Text.Encoding.Default);
            }
            return words;
        }

        /// <summary>
        /// 将IP地址换算成数字
        /// </summary>
        /// <param name="sIp"></param>
        /// <returns></returns>
        public static int ipToNumber(string sIp)
        {
            //计算IP值

            string[] a;
            int iNumber = 0;
            int i = 0;
            a = sIp.Split('.');
            if (a.Length != 3)
            {
                return iNumber;
            }
            for (i = 0; i < 3; i++)
            {
                iNumber = iNumber + Convert.ToInt32(a[i]) * 256 ^ (3 - i);
            }
            return iNumber - 1;
        }

        public static string GetObjectPropertyValue(object obj, string propertyname)
        {
            Type t = obj.GetType();
            var property = t.GetProperty(propertyname);
            if (property == null) return "";
            var revalue = property.GetValue(obj, null);
            return revalue == null ? "" : revalue.ToString();
        }
    }
}
