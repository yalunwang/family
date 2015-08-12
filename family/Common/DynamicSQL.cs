using System.Text;

namespace ZKEShop.Common
{
    public static class DynamicSQL
    {
        public static string GetSQL(string SearchField, string SearchOper, string Keywords)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(SearchField);
            switch (SearchOper.ToLower())
            {
                case "like":
                    sql.AppendFormat(".Contains(\"{0}\")", Keywords);
                    break;
                case "=":
                    sql.AppendFormat(" == {0}", Keywords);
                    break;
                case ">":
                    sql.AppendFormat(" > {0}", Keywords);
                    break;
                case "<":
                    sql.AppendFormat(" > {0}", Keywords);
                    break;
                case "<>":
                    sql.AppendFormat(" != {0}", Keywords);
                    break;
            }
            return sql.ToString();
        }
    }
}
