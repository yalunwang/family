using System;

namespace ZKEShop.Common
{
    public class FormatNumeral
    {
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="d_value">��ֵ</param>
        /// <param name="i_digit">λ��</param>
        /// <returns></returns>
        public static double Round(double d_value, int i_digit)
        {
            if (d_value >= 0)
            {
                d_value += 5 * Math.Pow(10, -(i_digit + 1));//
            }
            else
            {
                d_value += -5 * Math.Pow(10, -(i_digit + 1));
            }
            string str = d_value.ToString();
            string[] strs = str.Split('.');
            int idot = str.IndexOf('.');
            string prestr = strs[0];
            string poststr = strs[1];
            if (poststr.Length > i_digit)
            {
                poststr = str.Substring(idot + 1, i_digit);
            }
            if (poststr.Length <= 2)
            {
                poststr = poststr + "0";
            }
            string strd = prestr + "." + poststr;
            d_value = Double.Parse(strd);
            return d_value;
        }
        /// <summary>
        /// �����ת���ɴ�д���
        /// </summary>
        /// <param name="d_money"></param>
        /// <returns></returns>
        public static string ChineseNumeral(decimal d_money)
        {
            String[] Scale = { "��", "��", "Ԫ", "ʰ", "��", "Ǫ", "��", "ʰ", "��", "Ǫ", "��", "ʰ", "��", "Ǫ", "��", "ʰ", "��", "Ǫ" };
            String[] Base = { "��", "Ҽ", "��", "��", "��", "��", "½", "��", "��", "��" };
            String Temp = d_money.ToString();
            String Info = null;
            int index = Temp.IndexOf(".", 0, Temp.Length);//�ж��Ƿ���С����
            if (index != -1)
            {
                Temp = Temp.Remove(Temp.IndexOf("."), 1);
                for (int i = Temp.Length; i > 0; i--)
                {
                    int Data = Convert.ToInt16(Temp[Temp.Length - i]);
                    Info += Base[Data - 48];
                    Info += Scale[i - 1];
                }
            }
            else
            {
                for (int i = Temp.Length; i > 0; i--)
                {

                    int Data = Convert.ToInt16(Temp[Temp.Length - i]);
                    Info += Base[Data - 48];
                    Info += Scale[i + 1];
                }
            }
            return Info;
        }


        public static string CmycurD(decimal num)
        {
            string str1 = "��Ҽ��������½��ƾ�";            //0-9����Ӧ�ĺ��� 
            string str2 = "��Ǫ��ʰ��Ǫ��ʰ��Ǫ��ʰԪ�Ƿ�"; //����λ����Ӧ�ĺ��� 
            string str3 = "";    //��ԭnumֵ��ȡ����ֵ 
            string str4 = "";    //���ֵ��ַ�����ʽ 
            string str5 = "";  //����Ҵ�д�����ʽ 
            int i;    //ѭ������ 
            int j;    //num��ֵ����100���ַ������� 
            string ch1 = "";    //���ֵĺ������ 
            string ch2 = "";    //����λ�ĺ��ֶ��� 
            int nzero = 0;  //����������������ֵ�Ǽ��� 
            int temp;            //��ԭnumֵ��ȡ����ֵ 

            num = Math.Round(Math.Abs(num), 2);    //��numȡ����ֵ����������ȡ2λС�� 
            str4 = ((long)(num * 100)).ToString();        //��num��100��ת�����ַ�����ʽ 
            j = str4.Length;      //�ҳ����λ 
            if (j > 15) { return "���"; }
            str2 = str2.Substring(15 - j);   //ȡ����Ӧλ����str2��ֵ���磺200.55,jΪ5����str2=��ʰԪ�Ƿ� 

            //ѭ��ȡ��ÿһλ��Ҫת����ֵ 
            for (i = 0; i < j; i++)
            {
                str3 = str4.Substring(i, 1);          //ȡ����ת����ĳһλ��ֵ 
                temp = Convert.ToInt32(str3);      //ת��Ϊ���� 
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //����ȡλ����ΪԪ�����ڡ������ϵ�����ʱ 
                    if (str3 == "0")
                    {
                        ch1 = "";
                        ch2 = "";
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "��" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //��λ�����ڣ��ڣ���Ԫλ�ȹؼ�λ 
                    if (str3 != "0" && nzero != 0)
                    {
                        ch1 = "��" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == "0" && nzero >= 3)
                            {
                                ch1 = "";
                                ch2 = "";
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = "";
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //�����λ����λ��Ԫλ�������д�� 
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == "0")
                {
                    //���һλ���֣�Ϊ0ʱ�����ϡ����� 
                    str5 = str5 + '��';
                }
            }
            if (num == 0)
            {
                str5 = "��Ԫ��";
            }
            return str5;
        } 


    }
}
