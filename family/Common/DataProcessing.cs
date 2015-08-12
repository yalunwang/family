using System.Text.RegularExpressions;

namespace ZKEShop.Common
{
    public class DataProcessing
    {
        /// <summary>
        /// 验证Email
        /// </summary>
        /// <param name="s_Email"></param>
        /// <returns></returns>
        public static bool IsEmail(string s_Email)
        {
            return Regex.IsMatch(s_Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// 验证IP地址
        /// </summary>
        /// <param name="s_IP"></param>
        /// <returns></returns>
        public static bool IPCheck(string s_IP)
        {
            return Regex.IsMatch(s_IP, @"^(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5])$");
        }
        /// <summary>
        /// 验证URL
        /// </summary>
        /// <param name="s_Url"></param>
        /// <returns></returns>
        public static bool IsUrl(string s_Url)
        {
            return Regex.IsMatch(s_Url, @"(http(s)?://([\w-]+\.)+[\w-]+(/[\w-   ./?%&=]*)?)|(http(s)?://\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}(:\d{1,5})?)");
        }
        /// <summary>
        /// 验证电话号码
        /// </summary>
        /// <param name="s_Telephone"></param>
        /// <returns></returns>
        /// ("(\d{3}-)?\d{8}|(\d{4}-)(\d{7})",
        public static bool IsTelePhone(string s_Telephone)
        {
            return Regex.IsMatch(s_Telephone, @"^\d{3,4}-)?\d{6,8}$");
        }
        /// <summary>
        /// 验证手机号码
        /// </summary>
        /// <param name="s_Handset"></param>
        /// <returns></returns>
        public static bool isHandset(string s_Handset)
        {
            return Regex.IsMatch(s_Handset, @"^[1]+[3,5]+\d{9}");
        }
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="s_PassWord">密码必须是由数字和26个英文字母组成的密码</param>
        /// <returns></returns>
        public static bool IsPassWord(string s_PassWord)
        {
            return Regex.IsMatch(s_PassWord, @"^[\a-zA-z]+[\0-9]+$");
        }
        /// <summary>
        /// 验证邮政编码
        /// </summary>
        /// <param name="s_Postalcode"></param>
        /// <returns></returns>
        public static bool IsPostakcode(string s_Postalcode)
        {
            return Regex.IsMatch(s_Postalcode, @"^\d{6}$");
        }
        /// <summary>
        /// 验证身份号码(15位和18位)
        /// </summary>
        /// <param name="s_Idcard">15位和18位身份证号码</param>
        /// <returns></returns>
        public static bool IsIdcard(string s_Idcard)
        {
            return Regex.IsMatch(s_Idcard, @"(^\d{18}$)|(^\d{15}$)");
        }
        /// <summary>
        /// 验证两位小数
        /// </summary>
        /// <param name="s_Decimal"></param>
        /// <returns></returns>
        public static bool IsDecimal(string s_Decimal)
        {
            return Regex.IsMatch(s_Decimal, @"^[0-9]+(.[0-9]{2})?$");
        }
        /// <summary>
        /// 验证一年的12月份
        /// </summary>
        /// <param name="s_Month"></param>
        /// <returns></returns>
        public static bool IsMonth(string s_Month)
        {
            return Regex.IsMatch(s_Month, @"^(0?[[1-9]|1[0-2])$");
        }
        /// <summary>
        /// 验证一个月的31天
        /// </summary>
        /// <param name="s_Day"></param>
        /// <returns></returns>
        public static bool IsDay(string s_Day)
        {
            return Regex.IsMatch(s_Day, @"^((0?[1-9])|((1|2)[0-9])|30|31)$");
        }
        /// <summary>
        /// 验证字符串是否为数字
        /// </summary>
        /// <param name="s_Number"></param>
        /// <returns></returns>
        public static bool IsNumber(string s_Number)
        {
            return Regex.IsMatch(s_Number, @"^[0-9]*$");
        }
        /// <summary>
        /// 验证密码长度(要求长度为6-18位)
        /// </summary>
        /// <param name="s_PassWord"></param>
        /// <returns></returns>
        public static bool IsPassWordLength(string s_PassWord)
        {
            return Regex.IsMatch(s_PassWord, @"^\d{6,18}$");
        }
        /// <summary>
        /// 验证非零的正整数
        /// </summary>
        /// <param name="s_IntNumber"></param>
        /// <returns></returns>
        public static bool IsIntNumber(string s_IntNumber)
        {
            return Regex.IsMatch(s_IntNumber, @"^\+?[1-9][0-9]*$");
        }
        /// <summary>
        /// 验证大写字母
        /// </summary>
        /// <param name="s_UpChar"></param>
        /// <returns></returns>
        public static bool IsUpChar(string s_UpChar)
        {
            return Regex.IsMatch(s_UpChar, @"^[A-Z]+$");
        }
        /// <summary>
        /// 验证小写字母
        /// </summary>
        /// <param name="s_UpChar"></param>
        /// <returns></returns>
        public static bool IsLowChar(string s_UpChar)
        {
            return Regex.IsMatch(s_UpChar, @"^[a-z]+$");
        }
        /// <summary>
        /// 验证输入字母
        /// </summary>
        /// <param name="s_Letter"></param>
        /// <returns></returns>
        public static bool IsLetter(string s_Letter)
        {
            return Regex.IsMatch(s_Letter, @"^[A-Za-z]+$");
        }
        /// <summary>
        /// 验证输入汉字
        /// </summary>
        /// <param name="s_Chinese"></param>
        /// <returns></returns>
        public static bool IsChinese(string s_Chinese)
        {
            return Regex.IsMatch(s_Chinese, @"^[\u4e00-\u9fa5],{0,}$");
        }

        /// <summary>
        /// 验证车牌号码
        /// </summary>
        /// <param name="s_License"></param>
        /// <returns></returns>
        public static bool IsLicense(string s_License)
        {
            return Regex.IsMatch(s_License, @"^([\u4e00-\u9fa5]|[A-Z]){1,2}[A-Za-z0-9]{1,2}-[0-9A-Za-z]{5}$");
        }
    }
}

