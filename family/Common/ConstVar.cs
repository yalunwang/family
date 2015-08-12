namespace ZKEShop.Common
{
    /// <summary>
    /// 常用变量类
    /// </summary>
    public static class ConstVar
    {
        /// <summary>
        /// 数据链接字符串
        /// zhangw
        /// </summary>
        public static string Connstr
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ConnStr.net"]; }
        }

        /// <summary>
        /// 系统支持的图片格式
        /// </summary>
        public const string PicfileType = "image/pjpeg,image/gif,image/jpeg,image/jpg,image/bmp,image/x-png";

        /// <summary>
        /// 商品图片上传的临时文件夹
        /// </summary>
        public const string PicfileTempPath = "/Resource/PoductPicTemp";

        /// <summary>
        /// 商品分类相关的图片文件夹
        /// </summary>
        public const string ProductCataFilePath = "/Resource/ProductCataFilePath";

        /// <summary>
        /// 资讯图片文件夹
        /// </summary>
        public const string ArticlePicFilePath = "/Resource/ArticleFilePath";

        /// <summary>
        /// 菜谱图片文件夹
        /// </summary>
        public const string RecipePicFilePath = "/Resource/RecipeFilePath";

        /// <summary>
        /// 套餐图片文件夹
        /// </summary>
        public const string TaocanPicFilePath = "/Resource/TaocanPicPath";

        /// <summary>
        /// 网站联盟广告图片文件夹
        /// </summary>
        public const string UnionADPicFilePath = "/Resource/UnionADPic";

        /// <summary>
        /// 网站礼品图片文件夹
        /// </summary>
        public const string GiftCardPicFilePath = "/Resource/GiftCardPic";

        /// <summary>
        /// 网站联盟身份证图片 
        /// </summary>
        public const string UnionCardIDPicPath = "/Resource/UnionCardIDPic";

        /// <summary>
        /// 会员头像图片文件夹 
        /// </summary>
        public const string HeadPicPath = "/Resource/HeadPic";

        /// <summary>
        /// 店铺资料图片文件夹 
        /// </summary>
        public const string ProviderPath = "/Resource/ProviderPost";
        
        /// <summary>
        /// 系统支持的模版文件格式 copy EBSSHOP
        /// </summary>
        public const string UploadfileType = "text/html,text/htm";


        //Session=====================================================
        /// <summary>
        /// 网页验证码
        /// </summary>
        public const string SESSION_CODE = "zk_session_code";
        /// <summary>
        /// 短信验证码
        /// </summary>
        public const string SESSION_SMS_CODE = "zk_session_sms_code";
        /// <summary>
        /// 后台管理员
        /// </summary>
        public const string SESSION_ADMIN_INFO = "zk_session_admin_info";
        /// <summary>
        /// 会员用户
        /// </summary>
        public const string SESSION_USER_INFO = "zk_session_user_info";

        //Cookies=====================================================
        /// <summary>
        /// 防重复顶踩KEY
        /// </summary>
        public const string COOKIE_DIGG_KEY = "zk_cookie_digg_key";
        /// <summary>
        /// 防重复评论KEY
        /// </summary>
        public const string COOKIE_COMMENT_KEY = "zk_cookie_comment_key";
        /// <summary>
        /// 防止下载重复扣各分
        /// </summary>
        public const string COOKIE_DOWNLOAD_KEY = "zk_download_attach_key";
        /// <summary>
        /// 记住会员用户名
        /// </summary>
        public const string COOKIE_USER_NAME_REMEMBER = "zk_cookie_user_name_remember";
        /// <summary>
        /// 记住会员密码
        /// </summary>
        public const string COOKIE_USER_PWD_REMEMBER = "zk_cookie_user_pwd_remember";
        /// <summary>
        /// 购物车
        /// </summary>
        public const string COOKIE_SHOPPING_CART = "zk_cookie_shopping_cart";
        /// <summary>
        /// 返回上一页
        /// </summary>
        public const string COOKIE_URL_REFERRER = "zk_cookie_url_referrer";

        /// <summary>
        /// 网站联盟广告Cookies
        /// </summary>
        public const string COOKIES_SOURCE = "Union:Source";

        /// <summary>
        /// 邀请好友Cookies
        /// </summary>
        public const string COOKIES_INVITER = "Inviter:Source";
    }
}
