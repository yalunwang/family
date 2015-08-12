using System.Collections.Generic;
using System.Text;

namespace ZKEShop.Common
{
   public class StringPlus
    {
       public static string DelLastChar(string str, string strchar)
       {
           return str.Substring(0, str.LastIndexOf(strchar));
       }
       public static string DelLastComma(string str)
       {
           return str.Substring(0, str.LastIndexOf(","));
       }
       public static string GetArrayStr(List<string> list, string speater)
       {
           StringBuilder builder = new StringBuilder();
           for (int i = 0; i < list.Count; i++)
           {
               if (i == (list.Count - 1))
               {
                   builder.Append(list[i]);
               }
               else
               {
                   builder.Append(list[i]);
                   builder.Append(speater);
               }
           }
           return builder.ToString();
       }
       public static string[] GetStrArray(string str)
       {
           return str.Split(new char[0x2c]);
       }
    }
}
