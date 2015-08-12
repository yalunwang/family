using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace ZKEShop.Common
{
    public static class Tools
    {
        public static string rsPage(int PageCount, int pageNo, string path)
        {
            string OutHtml = "";

            OutHtml = "共<font color='red'>" + PageCount + "</font>条&nbsp;";
            if (PageCount > 1)
            {
                OutHtml += "转到:<select size=1 name='pageNo' onchange='goSearch()'>";
                for (int i = 1; i <= PageCount; i++)
                {
                    if (i == pageNo)
                        OutHtml += "<option value='" + i + "' selected>" + i + "</option>";
                    else
                        OutHtml += "<option value='" + i + "'>" + i + "</option>";
                }
                OutHtml += "</select>页&nbsp;";
            }
            else if (PageCount == 0)
            {
                pageNo = 0;
            }

            OutHtml += "<img language='javascript' border='0' src='" + path + "/left1.gif' alt='首页' style='cursor:hand'";
            if (pageNo > 1)
                OutHtml += " onclick=\"document.forms(0).pageNo.value='1';goSearch()\"";

            OutHtml += ">&nbsp;<img language='javascript' border='0' src='" + path + "/left.gif' alt='上一页' style='cursor:hand'";
            if (pageNo > 1)
                OutHtml += " onclick=\"document.forms(0).pageNo.value='" + (pageNo - 1) + "';goSearch()\"";

            OutHtml = OutHtml + ">&nbsp;<b>" + pageNo + "/" + PageCount + "</b>&nbsp;";

            OutHtml = OutHtml + "<img language='javascript' border='0' src='" + path + "/right.gif' alt='下一页' style='cursor:hand'";
            if (pageNo < PageCount)
                OutHtml += " onclick=\"document.forms(0).pageNo.value='" + (pageNo + 1) + "';goSearch()\"";

            OutHtml += ">&nbsp;<img language='javascript' border='0' src='" + path + "/right1.gif' alt='尾页' style='cursor:hand'";
            if (pageNo < PageCount)
                OutHtml += " onclick=\"document.forms(0).pageNo.value='" + PageCount + "';goSearch()\"";
            OutHtml += ">";

            return OutHtml;
        }
                
        #region 转换为日期格式


        public static DateTime ToDate(string DataStr)
        {
            if (DataType.IsDate(DataStr))
                return Convert.ToDateTime(DataStr);
            DateTime DataDate=DateTime.MinValue;
          

            DataStr = DateFix(DataStr);
            switch (DataStr.Length)
            {
                case 4:
                    DataDate = Convert.ToDateTime(DataStr + "-01" + "-01");
                    break;
                case 6:
                    DataDate = Convert.ToDateTime(DataStr.Substring(0, 4) +"-"+ DataStr.Substring(4, 2) + "-01");
                    break;
                case 8:
                    DataDate = Convert.ToDateTime(DataStr.Substring(0, 4) + "-" + DataStr.Substring(4, 2) + "-" + DataStr.Substring(6, 2));
                    break;
                default:
                    break;
            }
            return DataDate;
        }
        public static DateTime ToDate(int DataStrInt)
        {
            DateTime DataDate = DateTime.MinValue;
           string DataStr = DateFix(DataStrInt.ToString()).ToString();
            switch (DataStr.Length)
            {
                case 4:
                    DataDate = Convert.ToDateTime(DataStr + "-01" + "-01");
                    break;
                case 6:
                    DataDate = Convert.ToDateTime(DataStr.Substring(0, 4) + "-" + DataStr.Substring(4, 2) + "-01");
                    break;
                case 8:
                    DataDate = Convert.ToDateTime(DataStr.Substring(0, 4) + "-" + DataStr.Substring(4, 2) + "-" + DataStr.Substring(6, 2));
                    break;
                default:
                    break;
            }
            return DataDate;
        }
        public static string ShowDate(string DataStr)
        {
            string DataDate = "";
            DataStr = DateFix(DataStr);
            switch (DataStr.Length)
            {
                case 4:
                    DataDate = DataStr + "年";
                    break;
                case 6:
                    DataDate = DataStr.Substring(0, 4)+"年"+DataStr.Substring(4, 2)+"月";
                    break;
                case 8:
                    DataDate = DataStr.Substring(0, 4) + "年" + DataStr.Substring(4, 2) + "月" + DataStr.Substring(6, 2) + "日";
                    break;
                default:
                    break;
            }
            return DataDate;
        }
      

        #endregion

        public static string DateFix(string DataStr)
        {
            string str = DataStr.Replace(".", "");
            str = str.Replace("-", "");
            return str;
        }

        public static string foldDate(string date1,string date2)
        {
            return ShowDate(date1) + "至" + ShowDate(date2);
        }


        /// <summary>
        /// 去除前后字符
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <param name="ch">要去除的字符</param>
        /// <returns></returns>
        public static string TrimChar(string str, string ch)
        {
            string strSub = "";
            if (str.IndexOf(ch) == 0)
            {
                strSub = str.Substring(1);
            }
            if (strSub.LastIndexOf(ch) == strSub.Length - 1)
                strSub = strSub.Substring(0, strSub.Length - 1);

            return strSub;
        }

        /// <summary>
        /// 替换具有分隔标记的字符串
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <param name="ch1">要去除的字符</param>
        /// <param name="ch2">分隔符</param>
        /// <returns></returns>
        public static string ReplaceChar(string str, string ch1,string ch2)
        {
            string strSub = "";

            str = ch2 + str + ch2;
            str = str.Replace(ch2 + ch1 + ch2, "");
            str = TrimChar(str, ch2);

            return strSub;
        }

        public static string GetFileFixName(string filename)
        {
            int n = filename.LastIndexOf(".");
            if (n > -1)
                return filename.Substring(n + 1);
            return "";
        }

        #region 比较两个LIST是否相等
        /// <summary>
        /// Create By Minzw
        /// 比较两个LIST是否相等
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">第一个LIST</param>
        /// <param name="second">第二个LIST</param>
        /// <returns></returns>
        public static bool EqualAll<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            using (IEnumerator<T> e1 = first.GetEnumerator())
            {
                using (IEnumerator<T> e2 = second.GetEnumerator())
                {
                    while (e1.MoveNext())
                    {
                        if (!(e2.MoveNext() && object.Equals(e1.Current, e2.Current))) return false;
                    }
                    if (e2.MoveNext()) return false;
                }
            }
            return true;
        }
        #endregion

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="Path">string Path：文件夹路径</param>
        /// <returns></returns>
        public static void CreateDir(string Path)
        {

            if (Directory.Exists(Path) == false)
            {
                Directory.CreateDirectory(Path);

            }
        }

        #region 把汉字转换成拼音
        /// <summary>
        /// 把汉字转换成拼音
        /// </summary>
        private static int[] pyValue = new int[]
        {
            -20319,-20317,-20304,-20295,-20292,-20283,-20265,-20257,-20242,-20230,-20051,-20036,
            -20032,-20026,-20002,-19990,-19986,-19982,-19976,-19805,-19784,-19775,-19774,-19763,
            -19756,-19751,-19746,-19741,-19739,-19728,-19725,-19715,-19540,-19531,-19525,-19515,
            -19500,-19484,-19479,-19467,-19289,-19288,-19281,-19275,-19270,-19263,-19261,-19249,
            -19243,-19242,-19238,-19235,-19227,-19224,-19218,-19212,-19038,-19023,-19018,-19006,
            -19003,-18996,-18977,-18961,-18952,-18783,-18774,-18773,-18763,-18756,-18741,-18735,
            -18731,-18722,-18710,-18697,-18696,-18526,-18518,-18501,-18490,-18478,-18463,-18448,
            -18447,-18446,-18239,-18237,-18231,-18220,-18211,-18201,-18184,-18183, -18181,-18012,
            -17997,-17988,-17970,-17964,-17961,-17950,-17947,-17931,-17928,-17922,-17759,-17752,
            -17733,-17730,-17721,-17703,-17701,-17697,-17692,-17683,-17676,-17496,-17487,-17482,
            -17468,-17454,-17433,-17427,-17417,-17202,-17185,-16983,-16970,-16942,-16915,-16733,
            -16708,-16706,-16689,-16664,-16657,-16647,-16474,-16470,-16465,-16459,-16452,-16448,
            -16433,-16429,-16427,-16423,-16419,-16412,-16407,-16403,-16401,-16393,-16220,-16216,
            -16212,-16205,-16202,-16187,-16180,-16171,-16169,-16158,-16155,-15959,-15958,-15944,
            -15933,-15920,-15915,-15903,-15889,-15878,-15707,-15701,-15681,-15667,-15661,-15659,
            -15652,-15640,-15631,-15625,-15454,-15448,-15436,-15435,-15419,-15416,-15408,-15394,
            -15385,-15377,-15375,-15369,-15363,-15362,-15183,-15180,-15165,-15158,-15153,-15150,
            -15149,-15144,-15143,-15141,-15140,-15139,-15128,-15121,-15119,-15117,-15110,-15109,
            -14941,-14937,-14933,-14930,-14929,-14928,-14926,-14922,-14921,-14914,-14908,-14902,
            -14894,-14889,-14882,-14873,-14871,-14857,-14678,-14674,-14670,-14668,-14663,-14654,
            -14645,-14630,-14594,-14429,-14407,-14399,-14384,-14379,-14368,-14355,-14353,-14345,
            -14170,-14159,-14151,-14149,-14145,-14140,-14137,-14135,-14125,-14123,-14122,-14112,
            -14109,-14099,-14097,-14094,-14092,-14090,-14087,-14083,-13917,-13914,-13910,-13907,
            -13906,-13905,-13896,-13894,-13878,-13870,-13859,-13847,-13831,-13658,-13611,-13601,
            -13406,-13404,-13400,-13398,-13395,-13391,-13387,-13383,-13367,-13359,-13356,-13343,
            -13340,-13329,-13326,-13318,-13147,-13138,-13120,-13107,-13096,-13095,-13091,-13076,
            -13068,-13063,-13060,-12888,-12875,-12871,-12860,-12858,-12852,-12849,-12838,-12831,
            -12829,-12812,-12802,-12607,-12597,-12594,-12585,-12556,-12359,-12346,-12320,-12300,
            -12120,-12099,-12089,-12074,-12067,-12058,-12039,-11867,-11861,-11847,-11831,-11798,
            -11781,-11604,-11589,-11536,-11358,-11340,-11339,-11324,-11303,-11097,-11077,-11067,
            -11055,-11052,-11045,-11041,-11038,-11024,-11020,-11019,-11018,-11014,-10838,-10832,
            -10815,-10800,-10790,-10780,-10764,-10587,-10544,-10533,-10519,-10331,-10329,-10328,
            -10322,-10315,-10309,-10307,-10296,-10281,-10274,-10270,-10262,-10260,-10256,-10254
        };

        private static string[] pyName = new string[]
        {
            "a","ai","an","ang","ao","ba","bai","ban","bang","bao","bei","ben",
            "beng","bi","bian","biao","bie","bin","bing","bo","bu","ba","cai","can",
            "cang","cao","ce","ceng","cha","chai","chan","chang","chao","che","chen","cheng",
            "chi","chong","chou","chu","chuai","chuan","chuang","chui","chun","chuo","ci","cong",
            "cou","cu","cuan","cui","cun","cuo","da","dai","dan","dang","dao","de",
            "deng","di","dian","diao","die","ding","diu","dong","dou","du","duan","dui",
            "dun","duo","e","en","er","fa","fan","fang","fei","fen","feng","fo",
            "fou","fu","ga","gai","gan","gang","gao","ge","gei","gen","geng","gong",
            "gou","gu","gua","guai","guan","guang","gui","gun","guo","ha","hai","han",
            "hang","hao","he","hei","hen","heng","hong","hou","hu","hua","huai","huan",
            "huang","hui","hun","huo","ji","jia","jian","jiang","jiao","jie","jin","jing",
            "jiong","jiu","ju","juan","jue","jun","ka","kai","kan","kang","kao","ke",
            "ken","keng","kong","kou","ku","kua","kuai","kuan","kuang","kui","kun","kuo",
            "la","lai","lan","lang","lao","le","lei","leng","li","lia","lian","liang",
            "liao","lie","lin","ling","liu","long","lou","lu","lv","luan","lue","lun",
            "luo","ma","mai","man","mang","mao","me","mei","men","meng","mi","mian",
            "miao","mie","min","ming","miu","mo","mou","mu","na","nai","nan","nang",
            "nao","ne","nei","nen","neng","ni","nian","niang","niao","nie","nin","ning",
            "niu","nong","nu","nv","nuan","nue","nuo","o","ou","pa","pai","pan",
            "pang","pao","pei","pen","peng","pi","pian","piao","pie","pin","ping","po",
            "pu","qi","qia","qian","qiang","qiao","qie","qin","qing","qiong","qiu","qu",
            "quan","que","qun","ran","rang","rao","re","ren","reng","ri","rong","rou",
            "ru","ruan","rui","run","ruo","sa","sai","san","sang","sao","se","sen",
            "seng","sha","shai","shan","shang","shao","she","shen","sheng","shi","shou","shu",
            "shua","shuai","shuan","shuang","shui","shun","shuo","si","song","sou","su","suan",
            "sui","sun","suo","ta","tai","tan","tang","tao","te","teng","ti","tian",
            "tiao","tie","ting","tong","tou","tu","tuan","tui","tun","tuo","wa","wai",
            "wan","wang","wei","wen","weng","wo","wu","xi","xia","xian","xiang","xiao",
            "xie","xin","xing","xiong","xiu","xu","xuan","xue","xun","ya","yan","yang",
            "yao","ye","yi","yin","ying","yo","yong","you","yu","yuan","yue","yun",
            "za", "zai","zan","zang","zao","ze","zei","zen","zeng","zha","zhai","zhan",
            "zhang","zhao","zhe","zhen","zheng","zhi","zhong","zhou","zhu","zhua","zhuai","zhuan",
            "zhuang","zhui","zhun","zhuo","zi","zong","zou","zu","zuan","zui","zun","zuo"
        };

        /// <summary>
        /// 把汉字转换成拼音(全拼)
        /// </summary>
        /// <param name="hzString">汉字字符串</param>
        /// <returns>转换后的拼音(全拼)字符串</returns>
        public static string SpellTrans(string hzString)
        {
            // 匹配中文字符
            Regex regex = new Regex("^[\u4e00-\u9fa5]$");
            byte[] array = new byte[2];
            string pyString = "";
            int chrAsc = 0;
            int i1 = 0;
            int i2 = 0;
            char[] noWChar = hzString.ToCharArray();

            for (int j = 0; j < noWChar.Length; j++)
            {
                // 中文字符
                if (regex.IsMatch(noWChar[j].ToString()))
                {
                    array = System.Text.Encoding.Default.GetBytes(noWChar[j].ToString());
                    i1 = (short)(array[0]);
                    i2 = (short)(array[1]);
                    chrAsc = i1 * 256 + i2 - 65536;
                    if (chrAsc > 0 && chrAsc < 160)
                    {
                        pyString += noWChar[j];
                    }
                    else
                    {
                        // 修正部分文字
                        if (chrAsc == -9254)  // 修正“圳”字
                            pyString += "zhen";
                        else
                        {
                            for (int i = (pyValue.Length - 1); i >= 0; i--)
                            {
                                if (pyValue[i] <= chrAsc)
                                {
                                    pyString += pyName[i];
                                    break;
                                }
                            }
                        }
                    }
                }
                // 非中文字符

                else
                {
                    pyString += noWChar[j].ToString();
                }
            }
            return pyString;
        }
        #endregion


        /// <summary>
        /// 求当前日期是一年的中第几周
        /// </summary>
        /// <param name="curDay"></param>
        /// <returns></returns>
        public static int WeekOfYear(DateTime curDay)
        {
            int firstdayofweek = Convert.ToInt32(Convert.ToDateTime(curDay.Year.ToString() + "- " + "1-1 ").DayOfWeek);
            int days = curDay.DayOfYear;
            int daysOutOneWeek = days - (7 - firstdayofweek);
            if (daysOutOneWeek <= 0)
            {
                return 1;
            }
            else
            {
                int weeks = daysOutOneWeek / 7;
                if (daysOutOneWeek % 7 != 0)
                    weeks++;
                return weeks + 1;
            }
        }


        /// <summary>
        /// 求某年有多少周
        /// </summary>
        /// <param name="strYear"></param>
        /// <returns></returns>
        public static int GetYearWeekCount(int strYear)
        {
            System.DateTime fDt = DateTime.Parse(strYear.ToString() + "-01-01");
            int k = Convert.ToInt32(fDt.DayOfWeek);//得到该年的第一天是周几 
            if (k == 1)
            {
                int countDay = fDt.AddYears(1).AddDays(-1).DayOfYear;
                int countWeek = countDay / 7 + 1;
                return countWeek;
            }
            else
            {
                int countDay = fDt.AddYears(1).AddDays(-1).DayOfYear;
                int countWeek = countDay / 7 + 2;
                return countWeek;
            }
        }

        /// <summary>
        /// 得到一年中的某周的起始日和截止日
        /// </summary>
        /// <param name="nYear">年 nYear</param>
        /// <param name="nNumWeek">周数 nNumWeek</param>
        /// <param name="dtWeekStart">周始 out dtWeekStart</param>
        /// <param name="dtWeekeEnd">周终 out dtWeekeEnd</param>
        public static void GetWeek(int nYear, int nNumWeek, out   DateTime dtWeekStart, out   DateTime dtWeekeEnd)
        {
            DateTime dt = new DateTime(nYear, 1, 1);
            dt = dt + new TimeSpan((nNumWeek - 1) * 7, 0, 0, 0);
            dtWeekStart = dt.AddDays(-(int)dt.DayOfWeek + (int)DayOfWeek.Monday);
            dtWeekeEnd = dt.AddDays((int)DayOfWeek.Saturday - (int)dt.DayOfWeek + 1);
        }

        public static string ChgCSV(string str)
        {
            str = str.Replace("\"", "\"\"");
            str = "\"" + str + "\"";
            return str;
        }
        /// <summary>
        /// 判断URL是否http或https开头，没有则默认添加
        /// </summary>
        /// <param name="_url"></param>
        /// <param name="_defProtocol"></param>
        /// <returns></returns>
        public static string AddUrlProtocol(string _url, string _defProtocol)
        {

            if (!_url.StartsWith("http://") && !_url.StartsWith("https://"))
            {
                if (String.IsNullOrEmpty(_defProtocol))
                    _defProtocol = "http://";
                _url = _defProtocol + _url;
            }
            if (!_url.EndsWith("/"))
                _url = _url + "/";
            return _url;
        }
        /// <summary>
        /// 表单提交
        /// </summary>
        /// <param name="posturl">提交网站</param>
        /// <param name="postData">表单内容(XML)</param>
        /// <returns></returns>
        public static string PostData(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = System.Text.Encoding.GetEncoding("UTF-8");
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...   
            try
            {
                // 设置参数   
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据   
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求   
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码   
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }

        #region 读取或写入cookie
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = UrlEncode(strValue);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string key, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie[key] = UrlEncode(strValue);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string key, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie[key] = UrlEncode(strValue);
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="strValue">过期时间(分钟)</param>
        public static void WriteCookie(string strName, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = UrlEncode(strValue);
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
                return UrlDecode(HttpContext.Current.Request.Cookies[strName].Value.ToString());
            return "";
        }

        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName, string key)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null && HttpContext.Current.Request.Cookies[strName][key] != null)
                return UrlDecode(HttpContext.Current.Request.Cookies[strName][key].ToString());

            return "";
        }
        #endregion

        #region URL处理
        /// <summary>
        /// URL字符编码
        /// </summary>
        public static string UrlEncode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            str = str.Replace("'", "");
            return HttpContext.Current.Server.UrlEncode(str);
        }

        /// <summary>
        /// URL字符解码
        /// </summary>
        public static string UrlDecode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return HttpContext.Current.Server.UrlDecode(str);
        }

        /// <summary>
        /// 组合URL参数
        /// </summary>
        /// <param name="_url">页面地址</param>
        /// <param name="_keys">参数名称</param>
        /// <param name="_values">参数值</param>
        /// <returns>String</returns>
        public static string CombUrlTxt(string _url, string _keys, params string[] _values)
        {
            StringBuilder urlParams = new StringBuilder();
            try
            {
                string[] keyArr = _keys.Split(new char[] { '&' });
                for (int i = 0; i < keyArr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(_values[i]) && _values[i] != "0")
                    {
                        _values[i] = UrlEncode(_values[i]);
                        urlParams.Append(string.Format(keyArr[i], _values) + "&");
                    }
                }
                if (!string.IsNullOrEmpty(urlParams.ToString()) && _url.IndexOf("?") == -1)
                    urlParams.Insert(0, "?");
            }
            catch
            {
                return _url;
            }
            return _url + DelLastChar(urlParams.ToString(), "&");
        }
        #endregion

        #region URL请求数据
        /// <summary>
        /// HTTP POST方式请求数据
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="param">POST的数据</param>
        /// <returns></returns>
        public static string HttpPost(string url, string param)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

        /// <summary>
        /// HTTP GET方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            WebResponse response = null;
            string responseStr = null;

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                response = null;
            }

            return responseStr;
        }

        /// <summary>
        /// 执行URL获取页面内容
        /// </summary>
        public static string UrlExecute(string urlPath)
        {
            if (string.IsNullOrEmpty(urlPath))
            {
                return "error";
            }
            StringWriter sw = new StringWriter();
            try
            {
                HttpContext.Current.Server.Execute(urlPath, sw);
                return sw.ToString();
            }
            catch (Exception)
            {
                return "error";
            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }
        }
        #endregion

        #region 删除最后结尾的指定字符后的字符
        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        public static string DelLastChar(string str, string strchar)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            if (str.LastIndexOf(strchar) >= 0 && str.LastIndexOf(strchar) == str.Length - 1)
            {
                return str.Substring(0, str.LastIndexOf(strchar));
            }
            return str;
        }
        #endregion


    }
}
