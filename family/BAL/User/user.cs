using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BAL.User
{
    public class user
    {
        public YalunwangDataDataContext db = new YalunwangDataDataContext(System.Configuration.ConfigurationSettings.AppSettings["ConnStr.net"]);
        DataAccess.user _userDal;
        int _userid;
        public DataAccess.user UserDal
        {
            get { return _userDal; }
        }
        public user()
        {
            _userDal = new DataAccess.user();
        }
        /// <summary>
        /// 会员登录
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PassWord"></param>
        public user(string UserName, string PassWord)
        {
            //PassWord = (new ZKEShop.SystemFramework._MD5()).md5Encrypt(PassWord, ZKEShop.SystemFramework.GlobalConfig.PersonalPwdLength);
            var query = db.user.Where(o => (o.UserName == UserName || o.Email == UserName || o.UserMobile== UserName) && o.UserPwd == PassWord && (o.isActive==true));

            if (query.Count() == 1)
            {
                _userDal = query.First();
                _userid = _userDal.UserID;
            }
        }
  
    }
}
