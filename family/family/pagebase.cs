using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ZKEShop.Common;
namespace family
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
        /// <summary>
        /// 重写初始化函数
        /// </summary>
        /// <param name="e"></param>
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitDomain();

          
        }
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

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="total"></param>
        /// <param name="pageSize"></param>
        /// <param name="PageNo"></param>
        /// <returns></returns>
        public string ShowPages(int total, int pageSize, int PageNo)
        {
            
            int next = 0;
            int pre = 0;
            int startcount = 0;
            int endcount = 0;
            var str = new System.Text.StringBuilder();
            next = PageNo + 1;
            pre = PageNo - 1;
            startcount = (PageNo + 3) > total ? total - 5 : PageNo - 2;//中间页起始序号 
            //中间页终止序号 
            endcount = PageNo < 3 ? 6 : PageNo + 3;
            if (startcount < 1) { startcount = 1; } //为了避免输出的时候产生负数，设置如果小于1就从序号1开始 
            if (total < endcount) { endcount = total; }//页码+5的可能性就会产生最终输出序号大于总页码，那么就要将其控制在页码数之内 
            //  <Font1009 value="1009">首页</Font1009>
            //<Font1010 value="1010">上一页</Font1010>
            // <Font1011 value="1011">下一页</Font1011>
            // <Font1012 value="1012">末页</Font1012>
            if (PageNo > 1)
            {
                str.Append("<a  class='btn_b' href='javascript:GoPage(1)'>" + "首页"+ "</a>&nbsp;");
                str.Append("<a class='btn_b' href='javascript:GoPage(" + (PageNo - 1) + ")'><span>◀</span>" + "上一页" + "</a>&nbsp;");
            }
            else
            {
                str.Append("<a class='btn_b no' href='javascript:void(0)'>" + "首页" + "</a>&nbsp;");
            }

            //中间页处理，这个增加时间复杂度，减小空间复杂度 
            for (int i = startcount; i <= endcount; i++)
            {
                if (PageNo == i)
                    str.Append("<a class='btn_b no' href='javascript:void(0)'>" + i + "</a>&nbsp;");
                else
                    str.Append("<a class='btn_b' href='javascript:GoPage(" + i + ")'>" + i + "</a>&nbsp;");
            }

            if (PageNo != total)
            {
                str.Append("<a  class='btn_b' href='javascript:GoPage(" + (PageNo + 1) + ")'>" +"下一页" + "<span>▶</span></a>&nbsp;");
                str.Append("<a class='btn_b' href='javascript:GoPage(" + total + ")'>" + "末页" +

"</a>&nbsp;");
            }
            else
            {
                str.Append("<a class='btn_b no' href='javascript:void(0)'>" + "末页" + "</a>&nbsp;");
            }

            return str.ToString();
        }



      
    }
}