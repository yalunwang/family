using System;

namespace ZKEShop.Common
{
   public  class Rmb
    {
       public static string CmycurD(decimal num)
       {
           string str = "��Ҽ��������½��ƾ�";
           string str2 = "��Ǫ��ʰ��Ǫ��ʰ��Ǫ��ʰԪ�Ƿ�";
           string str3 = "";
           string str4 = "";
           string str5 = "";
           string str6 = "";
           string str7 = "";
           int num4 = 0;
           num = Math.Round(Math.Abs(num), 2);
           str4 = ((long)(num * 100M)).ToString();
           int length = str4.Length;
           if (length > 15)
           {
               return "���";
           }
           str2 = str2.Substring(15 - length);
           for (int i = 0; i < length; i++)
           {
               str3 = str4.Substring(i, 1);
               int startIndex = Convert.ToInt32(str3);
               if (((i != (length - 3)) && (i != (length - 7))) && ((i != (length - 11)) && (i != (length - 15))))
               {
                   if (str3 == "0")
                   {
                       str6 = "";
                       str7 = "";
                       num4++;
                   }
                   else if ((str3 != "0") && (num4 != 0))
                   {
                       str6 = "��" + str.Substring(startIndex, 1);
                       str7 = str2.Substring(i, 1);
                       num4 = 0;
                   }
                   else
                   {
                       str6 = str.Substring(startIndex, 1);
                       str7 = str2.Substring(i, 1);
                       num4 = 0;
                   }
               }
               else if ((str3 != "0") && (num4 != 0))
               {
                   str6 = "��" + str.Substring(startIndex, 1);
                   str7 = str2.Substring(i, 1);
                   num4 = 0;
               }
               else if ((str3 != "0") && (num4 == 0))
               {
                   str6 = str.Substring(startIndex, 1);
                   str7 = str2.Substring(i, 1);
                   num4 = 0;
               }
               else if ((str3 == "0") && (num4 >= 3))
               {
                   str6 = "";
                   str7 = "";
                   num4++;
               }
               else if (length >= 11)
               {
                   str6 = "";
                   num4++;
               }
               else
               {
                   str6 = "";
                   str7 = str2.Substring(i, 1);
                   num4++;
               }
               if ((i == (length - 11)) || (i == (length - 3)))
               {
                   str7 = str2.Substring(i, 1);
               }
               str5 = str5 + str6 + str7;
               if ((i == (length - 1)) && (str3 == "0"))
               {
                   str5 = str5 + '��';
               }
           }
           if (num == 0M)
           {
               str5 = "��Ԫ��";
           }
           return str5;
       }
       public static string CmycurD(string numstr)
       {
           try
           {
               return CmycurD(Convert.ToDecimal(numstr));
           }
           catch
           {
               return "��������ʽ��";
           }
       }

    }
}
