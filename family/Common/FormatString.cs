using System;
using System.Text;
using System.Collections;
namespace ZKEShop.Common
{
    public class FormatString
    {
        /// <summary>
        /// �ַ�������
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string HandleString(string s)
        {
            if (s != null)
            {
                string ss = s.Replace("'", "");
                ss = ss.Replace(";", "");
                ss = ss.Replace("-", "");
                ss = ss.Replace("/*", "");
                return ss;
            }
            else
            {
                return s;
            }
        }
        /// <summary>
        /// ��ȡ�ַ���
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string getSubString(string str, int i)
        {
            if (str.Length < i)
            {
                return str;
            }
            str = str.Substring(0, i) + "...";
            return str;
        }
        /// <summary>
        /// �����ַ�������
        /// </summary>
        /// <param name="s">�����ַ���</param>
        /// <returns></returns>
        public static string HandleParameterString(string s)
        {
            if (s != null)
            {
                string ss = s.Replace("'", "");
                ss = ss.Replace("~", "");
                ss = ss.Replace("!", "");
                ss = ss.Replace("@", "");
                ss = ss.Replace("#", "");
                ss = ss.Replace("$", "");
                ss = ss.Replace("%", "");
                ss = ss.Replace("^", "");
                ss = ss.Replace("&", "");
                ss = ss.Replace("*", "");
                ss = ss.Replace("(", "");
                ss = ss.Replace(")", "");
                ss = ss.Replace(":", "");
                ss = ss.Replace(";", "");
                ss = ss.Replace("<", "");
                ss = ss.Replace(",", "");
                ss = ss.Replace(">", "");
                ss = ss.Replace("-", "");
                ss = ss.Replace("--", "");
                ss = ss.Replace("_", "");
                ss = ss.Replace("_-_", "");
                ss = ss.Replace("__", "");
                ss = ss.Replace("+", "");
                ss = ss.Replace("=", "");
                ss = ss.Replace(".", "");
                ss = ss.Replace("?", "");
                ss = ss.Replace("/", "");
                ss = ss.Replace("//", "");
                ss = ss.Replace("///", "");
                ss = ss.Replace("/*", "");
                ss = ss.Replace("*/", "");
                return ss;
            }
            else
            {
                return s;
            }
        }
        /// <summary>
        /// ������ĸ�Ļ��ASCII��
        /// </summary>
        /// <param name="s_Liter">26��ƴ����ĸ</param>
        /// <returns></returns>
        public static string GetASCIIByLiter(string s_Liter)
        {
            byte[] array = new byte[1];
            array = Encoding.ASCII.GetBytes(s_Liter);
            int asciicode = (short)(array[0]);
            return Convert.ToString(asciicode);
        }

        /// <summary>
        /// ����ASCII������ĸ
        /// </summary>
        /// <param name="s_ASCII">ASCII��</param>
        /// <returns></returns>
        public static string GetLiterByASCII(string s_ASCII)
        {
            byte[] array = new byte[1];
            array[0] = (byte)(Convert.ToInt32(s_ASCII));
            return Convert.ToString(Encoding.ASCII.GetString(array));
        }

        /// <summary>
        /// ȡ�ú��ֵ���λ��
        /// </summary>
        /// <param name="s_ChineseCharacters">����</param>
        /// <returns></returns>
        public static string GetHanziSectionPositionCode(string s_ChineseCharacters)
        {
            byte[] array = new byte[2];
            array = Encoding.Default.GetBytes("" + s_ChineseCharacters + "");
            int front = (short)(array[0] - '\0');
            int back = (short)(array[1] - '\0');
            return Convert.ToString(front - 160) + Convert.ToString(back - 160);
        }

        /// <summary>
        /// ȡ�ú���
        /// </summary>
        /// <param name="s_HanziSectionPositionCode">������λ��</param>
        /// <returns></returns>
        public static string GetChineseCharacters(string s_HanziSectionPositionCode)
        {
            byte[] array = new byte[2];
            string str = s_HanziSectionPositionCode;
            string str1 = str.Substring(0, 2);
            string str2 = str.Substring(2, 2);
            int front = Convert.ToInt32(str1) + 160;
            int back = Convert.ToInt32(str2) + 160;
            array[0] = (byte)front;
            array[1] = (byte)back;
            return Encoding.Default.GetString(array);
        }

        /// <summary>
        /// ��ĸȫ��ת��Ϊ��д
        /// </summary>
        /// <param name="s_Liter"></param>
        /// <returns></returns>
        public static string GetToUpper(string s_Liter)
        {
            return s_Liter.ToUpper();
        }
        /// <summary>
        /// ��ĸȫ��ת��ΪСд
        /// </summary>
        /// <param name="s_Liter"></param>
        /// <returns></returns>
        public static string GetToLower(string s_Liter)
        {
            return s_Liter.ToLower();
        }
        /// <summary>
        /// ���ַ���תΪ�ֽ���
        /// </summary>
        /// <param name="s_string"></param>
        /// <returns></returns>
        public static string GetBytes(string s_string)
        {
            string s_String = "";
            byte[] bytes = Encoding.Default.GetBytes(s_string);
            for (int i = 0; i < bytes.Length; i++)
            {
                s_String += bytes[i].ToString();
            }
            return s_String;
        }
        /// <summary>
        /// ���ո�ָ���ַ����洢��ArrarList������
        /// </summary>
        /// <param name="s_string"></param>
        /// <returns></returns>
        public static ArrayList GetArrayList(string s_string)
        {
            string[] strArr = s_string.Split(' ');
            ArrayList mylist = new System.Collections.ArrayList();
            foreach (string strArray in strArr)
            {
                mylist.Add(strArray);
            }
            return mylist;
        }
        /// <summary>
        /// �ַ��������ֵĳ���
        /// </summary>
        /// <param name="s_string"></param>
        /// <returns></returns>
        public static int GetNumberLength(string s_string)
        {
            ArrayList itemList = new ArrayList();
            CharEnumerator CEnumerator = s_string.GetEnumerator();
            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode >= 48 && asciicode <= 57)
                {
                    itemList.Add(CEnumerator.Current.ToString());
                }
            }
            return itemList.Count;
        }
        /// <summary>
        /// �ַ����ĳ���
        /// </summary>
        /// <param name="s_string"></param>
        /// <returns></returns>
        public static int GetStrLength(string s_string)
        {
            ArrayList itemList = new ArrayList();
            CharEnumerator CEnumerator = s_string.GetEnumerator();
            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if ((asciicode >= 48 && asciicode <= 57) || (asciicode >= 65 && asciicode <= 90) || (asciicode >= 97 && asciicode <= 122))
                {
                    itemList.Add(CEnumerator.Current.ToString());
                }
            }
            return itemList.Count;
        }
        /// <summary>
        /// �Ƴ��ַ����е����пո�
        /// </summary>
        /// <param name="s_string"></param>
        /// <returns></returns>
        public static string RemoveBlank(string s_string)
        {
            string s_String = "";
            CharEnumerator CEnumerator = s_string.GetEnumerator();
            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    s_String += CEnumerator.Current.ToString();
                }
            }
            return s_String;
        }
    }
}
