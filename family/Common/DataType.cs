using System;

namespace ZKEShop.Common
{
    public class DataType
    {
        /// <summary>
        /// 判断数据是否为整数类型
        /// </summary>
        public static bool IsInt(object objInt)
        {
            try
            {
                if (objInt == null)
                    return false;
                Convert.ToInt32(objInt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为整数类型
        /// </summary>
        public static bool IsInt(string strInt)
        {
            try
            {
                Convert.ToInt32(strInt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为日期类型
        /// </summary>
        public static bool IsDate(object objDate)
        {
            try
            {
                if (objDate == null)
                    return false;
                Convert.ToDateTime(objDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为日期类型
        /// </summary>
        public static bool IsDate(string strDate)
        {
            try
            {
                Convert.ToDateTime(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为浮点类型
        /// </summary>
        public static bool IsDouble(object objDouble)
        {
            try
            {
                if (objDouble == null)
                    return false;
                Convert.ToDouble(objDouble);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为浮点类型
        /// </summary>
        public static bool IsDouble(string strDouble)
        {
            try
            {
                Convert.ToDouble(strDouble);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为十进制类型
        /// </summary>
        public static bool IsDecimal(object objDecimal)
        {
            try
            {
                if (objDecimal == null)
                    return false;
                Convert.ToDecimal(objDecimal);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为十进制类型
        /// </summary>
        public static bool IsDecimal(string strDecimal)
        {
            try
            {
                Convert.ToDecimal(strDecimal);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为布尔类型
        /// </summary>
        public static bool IsBoolean(object objBool)
        {
            try
            {
                if (objBool == null)
                    return false;
                Convert.ToBoolean(objBool);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为布尔类型
        /// </summary>
        public static bool IsBoolean(string strBool)
        {
            try
            {
                Convert.ToBoolean(strBool);
                return true;
            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// 判断数据是否为字符类型
        /// </summary>
        public static bool IsChar(object objBool)
        {
            try
            {
                if (objBool == null)
                    return false;
                Convert.ToChar(objBool);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断数据是否为字符类型
        /// </summary>
        public static bool IsChar(string strBool)
        {
            try
            {
                Convert.ToChar(strBool);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
