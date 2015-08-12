
using System;
using System.Text.RegularExpressions;
using System.Web;

namespace ZKEShop.Common
{
   public class ServerInfo
    {
        /// <summary>
        /// ȡ����վ�ĸ�Ŀ¼��URL
        /// </summary>
        /// <returns></returns>
        public static string GetRootURI()
        {
            string AppPath = "";
            HttpContext HttpCurrent = HttpContext.Current;
            HttpRequest Req;
            if (HttpCurrent != null)
            {
                Req = HttpCurrent.Request;

                string UrlAuthority = Req.Url.GetLeftPart(UriPartial.Authority);
                if (Req.ApplicationPath == null || Req.ApplicationPath == "/")
                    //ֱ�Ӱ�װ��   Web   վ��   
                    AppPath = UrlAuthority;
                else
                    //��װ��������Ŀ¼��   
                    AppPath = UrlAuthority + Req.ApplicationPath;
            }
            return AppPath;
        }
        /// <summary>
        /// ȡ����վ�ĸ�Ŀ¼��URL
        /// </summary>
        /// <param name="Req"></param>
        /// <returns></returns>
        public static string GetRootURI(HttpRequest Req)
        {
            string AppPath = "";
            if (Req != null)
            {
                string UrlAuthority = Req.Url.GetLeftPart(UriPartial.Authority);
                if (Req.ApplicationPath == null || Req.ApplicationPath == "/")
                    //ֱ�Ӱ�װ��   Web   վ��   
                    AppPath = UrlAuthority;
                else
                    //��װ��������Ŀ¼��   
                    AppPath = UrlAuthority + Req.ApplicationPath;
            }
            return AppPath;
        }
        /// <summary>
        /// ȡ����վ��Ŀ¼������·��
        /// </summary>
        /// <returns></returns>
        public static string GetRootPath()
        {
            string AppPath = "";
            HttpContext HttpCurrent = HttpContext.Current;
            if (HttpCurrent != null)
            {
                AppPath = HttpCurrent.Server.MapPath("~");
            }
            else
            {
                AppPath = AppDomain.CurrentDomain.BaseDirectory;
                if (Regex.Match(AppPath, @"\\$", RegexOptions.Compiled).Success)
                    AppPath = AppPath.Substring(0, AppPath.Length - 1);
            }
            return AppPath;
        }
    }
}
