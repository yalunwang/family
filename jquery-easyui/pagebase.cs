using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ZKEShop.Common;
namespace jquery_easyui
{
    public class pagebase : System.Web.UI.Page
    {
        public YalunwangDataDataContext db = new YalunwangDataDataContext(System.Configuration.ConfigurationSettings.AppSettings["ConnStr.net"]);
        public const String KEY_CACHEUserID = "UserID";
        public string domain = "";
        /// <summary>
        /// 站点域名
        /// </summary>
        public Domain SiteDomain;
        //登录用户
        public DataAccess.user LoginUser
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[KEY_CACHEUserID] != null && HttpContext.Current.Request.Cookies[KEY_CACHEUserID].Value != "")
                {
                    //TODO:这里日志记录到错误：输入的字符串格式不正确 cookie 中的数据发生异常时，会出现此错误，导致登陆一直报错，需要关闭全部浏览器重新登陆 zhaowf 2015-3-10 09:51:46
                    var user = db.user.FirstOrDefault(o => o.UserID == Convert.ToInt32(HttpContext.Current.Request.Cookies[KEY_CACHEUserID].Value));
                   
                    return user;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    ZKEShop.Common.Utils.WriteCookie(KEY_CACHEUserID, "", -1, domain);
                   
                }
                else
                {
                    ZKEShop.Common.Utils.WriteCookie(KEY_CACHEUserID, value.UserID.ToString(), null, domain);
                 
                }
            }
        }

        public string GetUserID
        {
            get
            {
                if (HttpContext.Current.Request.Cookies[KEY_CACHEUserID] != null)
                {
                    return HttpContext.Current.Request.Cookies[KEY_CACHEUserID].Value;
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 初始化Domain
        /// </summary>
        void InitDomain()
        {
            
            string mainDomain = ConfigurationManager.AppSettings["MainWebUrl"];
            SiteDomain.MainDomain = Tools.AddUrlProtocol(mainDomain, "http://");
            string userDomain = ConfigurationManager.AppSettings["userUrl"];
            SiteDomain.UserDomain = Tools.AddUrlProtocol(userDomain, "http://");
           

            domain = "";
            string[] host = HttpContext.Current.Request.Url.Host.Split('.');
            if (host.Length > 2)
            {
                for (int i = 1; i < host.Length; i++)
                {
                    if (domain == "")
                        domain = host[i];
                    else
                        domain += "." + host[i];
                }
            }
            else
            {
                domain = HttpContext.Current.Request.Url.Host;
            }
        }

        /// <summary>
        /// 域名配置
        /// </summary>
        public struct Domain
        {
            /// <summary>
            /// 主域
            /// </summary>
            public string MainDomain;
            /// <summary>
            /// 用户中心域名
            /// </summary>
            public string UserDomain;
           
            public string ImgDomain { get; set; }
        }

      
    }
}