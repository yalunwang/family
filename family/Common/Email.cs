using System;
using System.Net.Mail;

namespace ZKEShop.Common
{
    public static class Email
    {
        #region 发送电子邮件
        /// <summary>
        /// 发送电子邮件
        /// </summary>
        /// <param name="smtpserver">SMTP服务器</param>
        /// <param name="userName">登录帐号</param>
        /// <param name="pwd">登录密码</param>
        /// <param name="nickName">发件人昵称</param>
        /// <param name="strfrom">发件人</param>
        /// <param name="strto">收件人</param>
        /// <param name="subj">主题</param>
        /// <param name="bodys">内容</param>
        public static void SendMail(string smtpserver, string userName, string pwd, string nickName, string strfrom, string strto, string subj, string bodys)
        {
            var smtpClient = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Host = smtpserver,
                Credentials = new System.Net.NetworkCredential(userName, pwd)
            };

            //MailMessage _mailMessage = new MailMessage(strfrom, strto);
            var from = new MailAddress(strfrom, nickName);
            var to = new MailAddress(strto);
            var mailMessage = new MailMessage(from, to)
            {
                Subject = subj,
                Body = bodys,
                BodyEncoding = System.Text.Encoding.Default,
                IsBodyHtml = true,
                Priority = MailPriority.Normal
            };
            smtpClient.Send(mailMessage);
        }
        #endregion

        /// <summary>
        /// 获取掩码后的Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string GetHidEmail(string email)
        {
            if (email == null)
                return "";
            int pos = email.IndexOf("@");
            if (pos > -1)
            {
                string f = email.Substring(0, pos);
                if (f.Length > 3)
                    f = f.Substring(0, f.Length - 3) + "***";
                else
                    f = "***";
                email = f + email.Substring(pos);
            }
            else if(email.Length > 3)
            { 
                Int64 m;
                Int64.TryParse(email, out m);
                if (m != 0)
                {
                    email = email.Substring(0, email.Length - 3) + "***";
                }
            }

            return email;
        }
        /// <summary>
        /// 获取掩码后的用户名
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string GetHidUserName(string username)
        {
            if (username == null)
                return "";

            username = username.Substring(0, Convert.ToInt32(username.Length/2)) + "****";
            
            return username;
        }
        /// <summary>
        /// 获取掩码后的手机号码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static string GetHidMobile(string mobile)
        {
            if (mobile == null)
                return "";

            mobile = mobile.Substring(0, 7) + "****";

            return mobile;
        }
    }
}
