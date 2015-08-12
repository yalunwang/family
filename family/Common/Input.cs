using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ZKEShop.Common
{
    public class Input
    {
        /// <summary>
        /// ����Ƿ�����������
        /// </summary>
        /// <param name="Num">���������</param>
        /// <returns></returns>
        public static bool IsInteger(string Input)
        {
            if (Input == null)
            {
                return false;
            }
            else
            {
                return IsInteger(Input, true);
            }
        }

        /// <summary>
        /// �Ƿ�ȫ��������
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static bool IsInteger(string Input, bool Plus)
        {
            if (Input == null)
            {
                return false;
            }
            else
            {
                string pattern = "^-?[0-9]+$";
                if (Plus)
                    pattern = "^[0-9]+$";
                if (Regex.Match(Input, pattern, RegexOptions.Compiled).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// �ж������Ƿ�Ϊ��������
        /// </summary>
        /// <param name="s">���������</param>
        /// <returns></returns>
        public static bool IsDate(string s)
        {
            try
            {
                DateTime d = DateTime.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// �����ַ����е�html����
        /// </summary>
        /// <param name="Str"></param>
        /// <returns>���ع���֮����ַ���</returns>
        public static string LostHTML(string Str)
        {
            string Re_Str = "";
            if (Str != null)
            {
                if (Str != string.Empty)
                {
                    string Pattern = "<\\/*[^<>]*>";
                    Re_Str = Regex.Replace(Str, Pattern, "");
                }
            }
            return (Re_Str.Replace("\\r\\n", "")).Replace("\\r", "");
        }

        public static string LostPage(string Str)
        {
            string Re_Str = "";
            if (Str != null)
            {
                if (Str != string.Empty)
                {
                    string Pattern = "\\[NT:PAGE\\/*[^<>]*\\$\\]";
                    Re_Str = Regex.Replace(Str, Pattern, "");
                }
            }
            return Re_Str;
        }

        public static string LostVoteStr(string Str)
        {
            string Re_Str = "";
            if (Str != null)
            {
                if (Str != string.Empty)
                {
                    string Pattern = "\\[NT:unLoop\\/*[^<>]*\\[\\/NT:unLoop\\]";
                    Re_Str = Regex.Replace(Str, Pattern, "");
                }
            }
            return Re_Str;
        }

        /// <summary>
        /// �������ű�����������÷������ú�ı���
        /// </summary>
        /// <param name="Title">����</param>
        /// <param name="TitleColor">������ɫ</param>
        /// <param name="IsB">�Ƿ����</param>
        /// <param name="IsI">�Ƿ�б��</param>
        /// <param name="TitleNum">���ر�������</param>
        /// <returns>�������ú�ı���</returns>
        public static string GetColorTitleSubStr(string Title, string TitleColor, int IsB, int IsI, int TitleNum)
        {
            string Return_title = "";
            string FormatTitle = LostHTML(Title);
            if (FormatTitle != null && FormatTitle != string.Empty)
            {
                FormatTitle = GetSubString(FormatTitle, TitleNum);
                if (IsB == 1)
                {
                    FormatTitle = "<b>" + FormatTitle + "</b>";
                }
                if (IsI == 1)
                {
                    FormatTitle = "<i>" + FormatTitle + "</i>";
                }
                if (TitleColor != null && TitleColor != string.Empty)
                {
                    FormatTitle = "<font style=\"color:" + TitleColor + ";\">" + FormatTitle + "</font>";
                }
                Return_title = FormatTitle;
            }
            return Return_title;
        }


        /// <summary>
        /// ��ȡ�ַ�������
        /// </summary>
        /// <param name="Str">��Ҫ��ȡ���ַ���</param>
        /// <param name="Num">��ȡ�ַ����ĳ���</param>
        /// <returns></returns>
        public static string GetSubString(string Str, int Num)
        {
            if (Str == null || Str == "")
                return "";
            string outstr = "";
            int n = 0;
            foreach (char ch in Str)
            {
                n += System.Text.Encoding.Default.GetByteCount(ch.ToString());
                if (n > Num)
                    break;
                else
                    outstr += ch;
            }
            return outstr;
        }
        /// <summary>
        /// ��ȡ�ַ�������
        /// </summary>
        /// <param name="Str">��Ҫ��ȡ���ַ���</param>
        /// <param name="Num">��ȡ�ַ����ĳ���</param>
        /// <param name="Num">��ȡ�ַ�����ʡ�Բ��ֵ��ַ���</param>
        /// <returns></returns>
        public static string GetSubString(string Str, int Num, string LastStr)
        {
            return (Str.Length > Num) ? Str.Substring(0, Num) + LastStr : Str;
        }

        /// <summary>
        /// ��֤�ַ����Ƿ���ͼƬ·��
        /// </summary>
        /// <param name="Input">�������ַ���</param>
        /// <returns>����true �� false</returns>
        public static bool IsImgString(string Input)
        {
            return IsImgString(Input, "/{@dirfile}/");
        }

        public static bool IsImgString(string Input, string checkStr)
        {
            bool re_Val = false;
            if (Input != string.Empty)
            {
                string s_input = Input.ToLower();
                if (s_input.IndexOf(checkStr.ToLower()) != -1 && s_input.IndexOf(".") != -1)
                {
                    string Ex_Name = s_input.Substring(s_input.LastIndexOf(".") + 1).ToString().ToLower();
                    if (Ex_Name == "jpg" || Ex_Name == "gif" || Ex_Name == "bmp" || Ex_Name == "png")
                    {
                        re_Val = true;
                    }
                }
            }
            return re_Val;
        }


        /// <summary>
        ///  ���ַ�ת��ΪHTML����
        /// </summary>
        /// <param name="str">��������ַ���</param>
        /// <returns></returns>
        public static string HtmlEncode(string Input)
        {
            return HttpContext.Current.Server.HtmlEncode(Input);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string HtmlDecode(string Input)
        {
            return HttpContext.Current.Server.HtmlDecode(Input);
        }

        /// <summary>
        /// URL��ַ����
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string URLEncode(string Input)
        {
            return HttpContext.Current.Server.UrlEncode(Input);
        }

        /// <summary>
        /// URL��ַ����
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string URLDecode(string Input)
        {
            return HttpContext.Current.Server.UrlDecode(Input);
        }

        /// <summary>
        /// �����ַ�
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string Filter(string sInput)
        {
            if (sInput == null || sInput == "")
                return null;
            string sInput1 = sInput.ToLower();
            string output = sInput;
            string pattern = @"*|and|exec|insert|select|delete|update|count|master|truncate|declare|char(|mid(|chr(|'";
            if (Regex.Match(sInput1, Regex.Escape(pattern), RegexOptions.Compiled | RegexOptions.IgnoreCase).Success)
            {
                throw new Exception("�ַ����к��зǷ��ַ�!");
            }
            else
            {
                output = output.Replace("'", "''");
            }
            return output;
        }

        /// <summary>
        /// ���������ַ�/ǰ̨��Ա
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string Htmls(string Input)
        {
            if (Input != string.Empty && Input != null)
            {
                string ihtml = Input.ToLower();
                ihtml = ihtml.Replace("<script", "&lt;script");
                ihtml = ihtml.Replace("script>", "script&gt;");
                ihtml = ihtml.Replace("<%", "&lt;%");
                ihtml = ihtml.Replace("%>", "%&gt;");
                ihtml = ihtml.Replace("<$", "&lt;$");
                ihtml = ihtml.Replace("$>", "$&gt;");
                return ihtml;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// �ַ����ַ�����
        /// </summary>
        /// <param name="chr">�ȴ�������ַ���</param>
        /// <returns>�������ַ���</returns>
        /// //��HTML����ת����TXT��ʽ
        public static String ToTxt(String Input)
        {
            StringBuilder sb = new StringBuilder(Input);
            sb.Replace("&nbsp;", " ");
            sb.Replace("<br>", "\r\n");
            sb.Replace("<br>", "\n");
            sb.Replace("<br />", "\n");
            sb.Replace("<br />", "\r\n");
            sb.Replace("&lt;", "<");
            sb.Replace("&gt;", ">");
            sb.Replace("&amp;", "&");
            return sb.ToString();
        }

        /// <summary>
        /// �ַ����ַ�����
        /// </summary>
        /// <param name="chr">�ȴ�������ַ���</param>
        /// <returns>�������ַ���</returns>
        /// //��HTML����ת����TXT��ʽ
        public static String ToshowTxt(String Input)
        {
            StringBuilder sb = new StringBuilder(Input);
            sb.Replace("&lt;", "<");
            sb.Replace("&gt;", ">");
            return sb.ToString();
        }

        /// <summary>
        /// ���ַ�ת��Ϊ�ı���ʽ
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string ForTXT(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);
            sb.Replace("<font", " ");
            sb.Replace("<span", " ");
            sb.Replace("<style", " ");
            sb.Replace("<div", " ");
            sb.Replace("<p", "");
            sb.Replace("</p>", "");
            sb.Replace("<label", " ");
            sb.Replace("&nbsp;", " ");
            sb.Replace("<br>", "");
            sb.Replace("<br />", "");
            sb.Replace("<br />", "");
            sb.Replace("&lt;", "");
            sb.Replace("&gt;", "");
            sb.Replace("&amp;", "");
            sb.Replace("<", "");
            sb.Replace(">", "");
            return sb.ToString();
        }
        /// <summary>
        /// �ַ����ַ�����
        /// </summary>
        /// <param name="chr">�ȴ�������ַ���</param>
        /// <returns>�������ַ���</returns>
        /// //��TXT����ת����HTML��ʽ

        public static String ToHtml(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);
            sb.Replace("&", "&amp;");
            sb.Replace("<", "&lt;");
            sb.Replace(">", "&gt;");
            sb.Replace("\r\n", "<br />");
            sb.Replace("\n", "<br />");
            sb.Replace("\t", " ");
            //sb.Replace(" ", "&nbsp;");
            return sb.ToString();
        }

        /// <summary>
        /// MD5�����ַ�������
        /// </summary>
        /// <param name="Half">������16λ����32λ�����ΪtrueΪ16λ</param>
        /// <param name="Input">���������ַ���</param>
        /// <returns></returns>
        public static string MD5(string Input, bool Half)
        {
            string output = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(Input, "MD5").ToLower();
            if (Half)//16λMD5���ܣ�ȡ32λ���ܵ�9~25�ַ���
                output = output.Substring(8, 16);
            return output;
        }

        public static string MD5(string Input)
        {
            return MD5(Input, true);
        }

        /// <summary>
        /// �ַ�������  ����λ�Ʋ���
        /// </summary>
        /// <param name="str">����������</param>
        /// <returns>���ܺ������</returns>
        public static string EncryptString(string Input)
        {
            string _temp = "";
            int _inttemp;
            char[] _chartemp = Input.ToCharArray();
            for (int i = 0; i < _chartemp.Length; i++)
            {
                _inttemp = _chartemp[i] + 1;
                _chartemp[i] = (char)_inttemp;
                _temp += _chartemp[i];
            }
            return _temp;
        }

        /// <summary>
        /// �ַ�������
        /// </summary>
        /// <param name="str">����������</param>
        /// <returns>���ܳɹ��������</returns>
        public static string NcyString(string Input)
        {
            string _temp = "";
            int _inttemp;
            char[] _chartemp = Input.ToCharArray();
            for (int i = 0; i < _chartemp.Length; i++)
            {
                _inttemp = _chartemp[i] - 1;
                _chartemp[i] = (char)_inttemp;
                _temp += _chartemp[i];
            }
            return _temp;
        }

        /// <summary>
        /// ��⺬�����ַ���ʵ�ʳ���
        /// </summary>
        /// <param name="str">�������ַ���</param>
        /// <returns>����������</returns>
        public static int NumChar(string Input)
        {
            ASCIIEncoding n = new ASCIIEncoding();
            byte[] b = n.GetBytes(Input);
            int l = 0;
            for (int i = 0; i <= b.Length - 1; i++)
            {
                if (b[i] == 63)//�ж��Ƿ�Ϊ���ֻ�ȫ�ŷ���
                {
                    l++;
                }
                l++;
            }
            return l;
        }

        /// <summary>
        /// ����Ƿ�Ϸ�����
        /// </summary>
        /// <param name="str">�������ַ���</param>
        /// <returns></returns>
        public static bool ChkDate(string Input)
        {
            try
            {
                DateTime t1 = DateTime.Parse(Input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// ת������ʱ�亯��
        /// </summary>
        /// <returns></returns>        
        public static string ReDateTime()
        {
            return System.DateTime.Now.ToString("yyyyMMdd");
        }



        /// <summary>
        /// ȥ���ַ������һ��','��
        /// </summary>
        /// <param name="chr">:Ҫ��������ַ���</param>
        /// <returns>�����Ѵ�����ַ���</returns>
        /// /// CreateTime:2007-03-26 Code By DengXi
        public static string CutComma(string Input)
        {
            return CutComma(Input, ",");
        }

        public static string CutComma(string Input, string indexStr)
        {
            if (Input.IndexOf(indexStr) >= 0)
                return Input.Remove(Input.LastIndexOf(indexStr));
            else
                return Input;
        }

        /// <summary>
        /// ȥ����βP
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string RemovePor(string Input)
        {
            if (Input != string.Empty && Input != null)
            {
                string TMPStr = Input;
                if (Input.ToLower().Substring(0, 3) == "<p>")
                {
                    TMPStr = TMPStr.Substring(3);
                }
                if (TMPStr.Substring(TMPStr.Length - 4) == "</p>")
                {
                    TMPStr = TMPStr.Remove(TMPStr.ToLower().LastIndexOf("</p>"));
                }
                return TMPStr;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// �жϲ����Ƿ�Ϸ�
        /// </summary>
        /// <param name="ID">Ҫ�жϵĲ���</param>
        /// <returns>�����Ѵ�����ַ���</returns>

        public static string checkID(string ID)
        {
            if (ID == null && ID == string.Empty)
                throw new Exception("�������ݴ���!<li>��������Ϊ��</li>");
            return ID;
        }

        /// <summary>
        /// ȥ������ַ����е�'-1'
        /// </summary>
        /// <param name="id"></param>
        /// <returns>���Ϊ���򷵻�'IsNull'</returns>

        public static string Losestr(string id)
        {
            if (id == null || id == "" || id == string.Empty)
                return "IsNull";

            id = id.Replace("'-1',", "");

            if (id == null || id == "" || id == string.Empty)
                return "IsNull";
            else
                return id;
        }

        public static string FilterHTML(string html)
        {
            if (html == null)
                return "";
            System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(@"<script[\s\S]+</script *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(@" href *= *[\s\S]*script *:", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex(@" on[\s\S]*=", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex4 = new System.Text.RegularExpressions.Regex(@"<iframe[\s\S]+</iframe *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex5 = new System.Text.RegularExpressions.Regex(@"<frameset[\s\S]+</frameset *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex6 = new System.Text.RegularExpressions.Regex(@"\<img[^\>]+\>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex7 = new System.Text.RegularExpressions.Regex(@"</p>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex8 = new System.Text.RegularExpressions.Regex(@"<p>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex9 = new System.Text.RegularExpressions.Regex(@"<[^>]*>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //����<script></script>���
            html = regex2.Replace(html, ""); //����href=javascript: (<A>) ����
            html = regex3.Replace(html, " _disibledevent="); //���������ؼ���on...�¼�
            html = regex4.Replace(html, ""); //����iframe
            html = regex5.Replace(html, ""); //����frameset
            html = regex6.Replace(html, ""); //����frameset
            html = regex7.Replace(html, ""); //����frameset
            html = regex8.Replace(html, ""); //����frameset
            html = regex9.Replace(html, "");
            html = html.Replace(" ", "");
            html = html.Replace("</strong>", "");
            html = html.Replace("<strong>", "");
            return html;
        }


        /// <summary>
        /// �ж��ַ����Ƿ�ͼƬ��ַ
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        //public static string isPicStr(string inputStr)
        //{
        //    string dimm = FuZeeCMS.Config.UIConfig.dirDumm;
        //    if (dimm.Trim() != string.Empty)
        //    {
        //        dimm = "/" + dimm;
        //    }
        //    string gStr = string.Empty;
        //    if (inputStr == string.Empty && inputStr == null)
        //    {
        //        gStr = string.Empty;
        //    }
        //    else
        //    {
        //        if (inputStr.IndexOf(".") > -1)
        //        {
        //            int dotPosition = inputStr.IndexOf(".");
        //            string getFile = inputStr.Substring(dotPosition);
        //            int PType = 0;
        //            switch (getFile.ToLower())
        //            {
        //                case ".jpg":
        //                    PType = 1;
        //                    break;
        //                case ".gif":
        //                    PType = 1;
        //                    break;
        //                case ".jpeg":
        //                    PType = 1;
        //                    break;
        //                case ".png":
        //                    PType = 1;
        //                    break;
        //                case ".bmp":
        //                    PType = 1;
        //                    break;
        //                case ".ico":
        //                    PType = 1;
        //                    break;
        //                default:
        //                    break;
        //            }
        //            if (PType == 1)
        //            {
        //                gStr = "<img src=\"" + dimm + inputStr.ToLower().Replace("{@dirfile}", FuZeeCMS.Config.UIConfig.dirFile) + "\" border=\"0\" />";
        //            }
        //            else
        //            {
        //                gStr = inputStr;
        //            }
        //        }
        //        else
        //        {
        //            gStr = inputStr;
        //        }
        //    }
        //    return gStr;
        //}
    }
}
