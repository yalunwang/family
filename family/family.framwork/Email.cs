using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace family.framwork
{
    public class Email
    {
        public YalunwangDataDataContext db = new YalunwangDataDataContext(System.Configuration.ConfigurationSettings.AppSettings["ConnStr.net"]);
        private DataAccess.user _userDal;
        DataAccess.MessageKind messageKindDal;
        DataAccess.MailTemplate mailTemplateDal;
        string emailto;
        public DataAccess.user userDal
        {
            get { return _userDal; }
            
        }
        public Email(DataAccess.user user)
        {
            _userDal = user;
          
        }
        public Email(DataAccess.user user, string email)
        {
            _userDal = user;
            emailto = email;
        }
        public void Mailinfo(ZKEShop.Common.MessageType messageType)
        {
            string userName = _userDal.UserName;
            string userEmail = _userDal.Email;
            messageKindDal = db.MessageKind.FirstOrDefault(o=>o.MessageKindID==(short)messageType);
            mailTemplateDal = messageKindDal.MailTemplate;
            string subject=mailTemplateDal.MailSubject;
            string content=mailTemplateDal.MailBody;
            SendOneMail(userEmail,subject,content,"");

            
           
        }
        #region 发送单封邮件

        /// <summary>
        /// 发送单封邮件 copy EBSSHOP
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        /// <param name="revertmail"></param>
        public void SendOneMail(string email, string subject, string content, string revertmail)
        {
            string RevertMail = string.Empty;
            RevertMail = revertmail;

            DataAccess.PostMailInfo PM = new DataAccess.PostMailInfo();
            PM = db.PostMailInfo.FirstOrDefault();
            if (PM == null)
            {
                return;
            }

            SmtpClient MClient = new SmtpClient();
            MClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            MClient.Host = PM.ServerName;
            MClient.Credentials = new System.Net.NetworkCredential(PM.UserName.ToString(), PM.MailPassword.ToString());

            MailMessage MailMsg = new MailMessage(PM.MailAddress, email);
            if (string.IsNullOrEmpty(RevertMail))
            {
                MailMsg.From = new MailAddress(PM.MailAddress.ToString());
            }
            else
            {
                MailMsg.From = new MailAddress(RevertMail.ToString());
            }


            MailMsg.BodyEncoding = System.Text.Encoding.UTF8;
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.High;
            MailMsg.Subject = subject.ToString();
            MailMsg.Body = content.ToString();
            try
            {
                MClient.Send(MailMsg);
            }
            catch (Exception e)
            {

            }
        }
        #endregion

    }
}
