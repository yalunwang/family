using System;
using System.Collections.Generic;
using System.Linq;

namespace ZKEShop.SystemFramework
{
    public static class GlobalConfig
    {
        public static List<short> bradids = new List<short>();

        static int _OrderPayDay = 0;
        /// <summary>
        /// 订单自动付款给商户的天数
        /// </summary>
        public static int OrderPayDay
        {
            get { return _OrderPayDay; }
        }

        static int _ReAmountDay = 0;
        /// <summary>
        /// 退款自动生效的天数
        /// </summary>
        public static int ReAmountDay
        {
            get { return _ReAmountDay; }
        }


        static int _ProPictureLength = 0;
        /// <summary>
        /// 产品图片文件大小限制(KB)
        /// </summary>
        public static int ProPictureLength
        {
            get { return _ProPictureLength; }
        }

        static string _ResourceDiskPath;
        /// <summary>
        /// 网站资料目录路径
        /// </summary>
        public static string ResourceDiskPath
        {
            get { return _ResourceDiskPath; }
            set { _ResourceDiskPath = value; }
        }

        static string _WebDiskPath;
        /// <summary>
        /// 网站根目录路径
        /// </summary>
        public static string WebDiskPath
        {
            get { return _WebDiskPath; }
            set { _WebDiskPath = value; }
        }

        static string _MallSiteDiskPath;
        /// <summary>
        /// 商城网站根目录路径
        /// </summary>
        public static string MallSiteDiskPath
        {
            get { return _MallSiteDiskPath; }
            set { _MallSiteDiskPath = value; }
        }
        
        
        static string _UsePicServ;
        /// <summary>
        /// 是否启用图片服务器
        /// </summary>
        public static string UsePicServ
        {
            get { return _UsePicServ; }
            set { _UsePicServ = value; }
        }

        static string _PicServDomain;
        /// <summary>
        /// 图片服务器域名
        /// </summary>
        public static string PicServDomain
        {
            get { return _PicServDomain; }
            set { _PicServDomain = value; }
        }


        static ZKEShop.Common.LockSotreNumType _lockSotreNumType;
        public static ZKEShop.Common.LockSotreNumType lockSotreNumType
        {
            get { return _lockSotreNumType; }
        }

        static short _CouponCodeLength;
        public static short CouponCodeLength
        {
            get { return _CouponCodeLength; }
        }

        static string _ShopName;
        /// <summary>
        /// 网店名称
        /// </summary>
        public static string ShopName
        {
            get { return _ShopName; }
        }

        static string _ShopWebUrl;
        /// <summary>
        /// 网店域名
        /// </summary>
        public static string ShopWebUrl
        {
            get { return _ShopWebUrl; }
        }

        static string _HabiName;
        /// <summary>
        /// 网币名称
        /// </summary>
        public static string HabiName
        {
            get { return _HabiName; }
        }

        static ZKEShop.Common.AppLanguage _ApplicationLanguage;
        /// <summary>
        /// 当前语言版本
        /// </summary>
        public static ZKEShop.Common.AppLanguage ApplicationLanguage
        {
            get { return _ApplicationLanguage; }
            set { _ApplicationLanguage = value; }
        }

        static string _ApplicationLanguageJS;
        /// <summary>
        /// 当前语言版本JS
        /// </summary>
        public static string ApplicationLanguageJS
        {
            get { return _ApplicationLanguageJS; }
            set { _ApplicationLanguageJS = value; }
        }


        static int _ReturnDays;
        /// <summary>
        /// 退货有效天数

        /// </summary>
        public static int ReturnDays
        {
            get { return _ReturnDays; }
        }

        static int _ExchangeDays;
        /// <summary>
        /// 换货有效天数
        /// </summary>
        public static int ExchangeDays
        {
            get { return _ExchangeDays; }
        }

        static int _SmallPicWidth;
        /// <summary>
        /// 商品小图宽度
        /// </summary>
        public static int SmallPicWidth
        {
            get { return _SmallPicWidth; }
        }

        static int _SmallPicHeight;
        /// <summary>
        /// 商品小图高度
        /// </summary>
        public static int SmallPicHeight
        {
            get { return _SmallPicHeight; }
        }

        static int _MidPicWidth;
        /// <summary>
        /// 商品中图宽度
        /// </summary>
        public static int MidPicWidth
        {
            get { return _MidPicWidth; }
        }

        static int _MidPicHeight;
        /// <summary>
        /// 商品中图高度
        /// </summary>
        public static int MidPicHeight
        {
            get { return _MidPicHeight; }
        }

        static int _LargePicWidth;
        /// <summary>
        /// 商品大图宽度
        /// </summary>
        public static int LargePicWidth
        {
            get { return _LargePicWidth; }
        }

        static int _LargePicHeight;
        /// <summary>
        /// 商品大图高度
        /// </summary>
        public static int LargePicHeight
        {
            get { return _LargePicHeight; }
        }

        /// <summary>
        /// 品牌小图宽度
        /// </summary>
        static int _BrandSmallPicWidth;
        public static int BrandSmallPicWidth
        {
            get { return _BrandSmallPicWidth; }
        }

        /// <summary>
        /// 品牌小图高度
        /// </summary>
        static int _BrandSmallPicHeight;
        public static int BrandSmallPicHeight
        {
            get { return _BrandSmallPicHeight; }
        }

        /// <summary>
        /// 品牌中图宽度
        /// </summary>
        static int _BrandMidPicWidth;
        public static int BrandMidPicWidth
        {
            get { return _BrandMidPicWidth; }
        }

        /// <summary>
        /// 品牌中图高度
        /// </summary>
        static int _BrandMidPicHeight;
        public static int BrandMidPicHeight
        {
            get { return _BrandMidPicHeight; }
        }

        /// <summary>
        /// 品牌大图宽度
        /// </summary>
        static int _BrandBigPicWidth;
        public static int BrandBigPicWidth
        {
            get { return _BrandBigPicWidth; }
        }

        /// <summary>
        /// 品牌中图高度
        /// </summary>
        static int _BrandBigPicHeight;
        public static int BrandBigPicHeight
        {
            get { return _BrandBigPicHeight; }
        }

        static string _DescInOrder;
        /// <summary>
        /// 订单中的宣传语
        /// </summary>
        public static string DescInOrder
        {
            get { return _DescInOrder; }
        }

        static bool _IsOLOrderNeedCheck = false;
        /// <summary>
        /// 必须核对订单资料后才能发货
        /// </summary>
        public static bool IsOLOrderNeedCheck
        {
            get { return _IsOLOrderNeedCheck; }
        }

        static bool _IsShowOOS = false;
        /// <summary>
        /// 是否显示缺货
        /// </summary>
        public static bool IsShowOOS
        {
            get { return _IsShowOOS; }
        }


        static bool _NoStoreNoOrder = false;
        /// <summary>
        /// 缺货不能下单
        /// </summary>
        public static bool NoStoreNoOrder
        {
            get { return _NoStoreNoOrder; }
        }

        static bool _IsStorageOn = false;

        /// <summary>
        /// 是否启用仓储系统
        /// </summary>
        public static bool IsStorageOn
        {
            get { return _IsStorageOn; }
        }

        static bool _IsDynaStockTakingOn = false;
        /// <summary>
        /// 是否启用动态盘点
        /// </summary>
        public static bool IsDynaStockTakingOn
        {
            get { return _IsDynaStockTakingOn; }
        }

        static bool _IsProHavePostSta = false;
        /// <summary>
        /// 商品是否启用配送中心
        /// </summary>
        public static bool IsProHavePostSta
        {
            get { return _IsProHavePostSta; }
        }


        /// <summary>
        /// 全局头部切换样式
        /// </summary>
        public static int HeadProductCataID;


        static int _UnionEffectiveOrdersMonth;
        /// <summary>
        /// 联盟有效订单月数
        /// </summary>
        public static int UnionEffectiveOrdersMonth
        {
            get { return _UnionEffectiveOrdersMonth; }
        }


        static bool _isMailSender = true;
        /// <summary>
        /// 是否启用邮件定时发送
        /// </summary>
        public static bool isMailSender
        {
            get { return _isMailSender; }
        }

        static int _MaxBoxNum;
        /// <summary>
        /// 拣货时最大盒子数
        /// </summary>
        public static int MaxBoxNum
        {
            get { return _MaxBoxNum; }
        }

        static string _menuname;
        /// <summary>
        /// 后台菜单名称
        /// </summary>
        public static string MenuName
        {
            get { return _menuname; }
        }

        static string _enmenuname;
        /// <summary>
        /// 后台英文菜单名称
        /// </summary>
        public static string enMenuName
        {
            get { return _enmenuname; }
        }

        static string _CallCenterIpAddress;
        /// <summary>
        /// 呼叫中心服务器IP地址
        /// </summary>
        public static string CallCenterIpAddress
        {
            get { return _CallCenterIpAddress; }
        }

        static string _ProductDetailInfo;
        /// <summary>
        /// 商品详细信息模版
        /// </summary>
        public static string ProductDetailInfo
        {
            get { return _ProductDetailInfo; }
        }

        static bool _isshowweight = true;
        /// <summary>
        /// 是否显示商品重量
        /// </summary>
        public static bool IsShowWeight
        {
            get { return _isshowweight; }
        }

        static bool _isusersn = false;
        /// <summary>
        /// 商品是否启用序列号管理
        /// </summary>
        public static bool IsUserSN
        {
            get { return _isusersn; }
        }

        static string _ProductSpecDetailInfo;
        /// <summary>
        /// 商品规格信息模版
        /// </summary>
        public static string ProductSpecDetailInfo
        {
            get { return _ProductSpecDetailInfo; }
        }

        static string _ProductDetailPic;
        /// <summary>
        /// 商品详细页面大图片


        /// </summary>
        public static string ProductDetailPic
        {
            get { return _ProductDetailPic; }
        }

        static int _CanlorderDay;
        public static int CanlorderDay
        {
            get { return _CanlorderDay; }
        }

        static int _MinYudingDay;
        /// <summary>
        /// 最小预订开始天数
        /// </summary>
        public static int MinYudingDay
        {
            get { return _MinYudingDay; }
        }

        static int _MaxYudingDay;
        /// <summary>
        /// 最大预订截止天数
        /// </summary>
        public static int MaxYudingDay
        {
            get { return _MaxYudingDay; }
        }


        static bool _isAutoCalProInte = false;
        /// <summary>
        /// 是否自动计算商品赠送积分
        /// </summary>
        public static bool isAutoCalProInte
        {
            get { return _isAutoCalProInte; }
        }

        static int _calProInteProportion;
        /// <summary>
        /// 商品积分自动计算百分比【商品积分=商品价格*百分比】


        /// </summary>
        public static int CalProInteProportion
        {
            get { return _calProInteProportion; }
        }

        static bool _isAviDateOn = false;
        /// <summary>
        /// 是否启用保质期管理


        /// </summary>
        public static bool isAviDateOn
        {
            get { return _isAviDateOn; }
        }

        static bool _isChgOrderAmountByPro = false;
        /// <summary>
        /// 是否商品降价修改订单金额
        /// </summary>
        public static bool IsChgOrderAmountByPro
        {
            get { return _isChgOrderAmountByPro; }
        }

        static string _PrintShipOrder;
        /// <summary>
        /// 发货单打印模板

        /// </summary>
        public static string PrintShipOrder
        {
            get { return _PrintShipOrder; }
        }

        static string _PrintPicking;
        /// <summary>
        /// 拣货单打印模板

        /// </summary>
        public static string PrintPicking
        {
            get { return _PrintPicking; }
        }


        static string _PrintPeihuo;
        /// <summary>
        /// 配货单打印模板

        /// </summary>
        public static string PrintPeihuo
        {
            get { return _PrintPeihuo; }
        }

        static string _PrintShipOrderList;
        /// <summary>
        /// 发货单清单打印模板

        /// </summary>
        public static string PrintShipOrderList
        {
            get { return _PrintShipOrderList; }
        }

        static string _PrintPurchaseOrder;
        /// <summary>
        /// 采购单打印模板

        /// </summary>
        public static string PrintPurchaseOrder
        {
            get { return _PrintPurchaseOrder; }
        }

        static int _calAvgSaleNumDay;
        /// <summary>
        /// 计算日均销量天数

        /// </summary>
        public static int CalAvgSaleNumDay
        {
            get { return _calAvgSaleNumDay; }
        }


        static int _calGrowthRateMonDay;
        /// <summary>
        /// 计算增长率月数

        /// </summary>
        public static int CalGrowthRateMonDay
        {
            get { return _calGrowthRateMonDay; }
        }


        static bool _isAutoClosePub = false;
        /// <summary>
        /// 商品库存为0时是否自动下架

        /// </summary>
        public static bool IsAutoClosePub
        {
            get { return _isAutoClosePub; }
        }

        static bool _isControlCarryTime = false;
        /// <summary>
        /// 是否控制发货时间
        /// </summary>
        public static bool IsControlCarryTime
        {
            get { return _isControlCarryTime; }
        }


        static bool _isAutoCreateSKU = false;
        /// <summary>
        /// 是否自动生成SKU
        /// </summary>
        public static bool IsAutoCreateSKU
        {
            get { return _isAutoCreateSKU; }
        }

        static bool _isAutoCreateProductCode = false;
        /// <summary>
        /// 是否自动生成商品编码
        /// </summary>
        public static bool IsAutoCreateProductCode
        {
            get { return _isAutoCreateProductCode; }
        }

         static bool _isAutoCreateCustomerCode = false;
        /// <summary>
        /// 是否自动生成客户编码
        /// </summary>
        public static bool IsAutoCreateCustomerCode
        {
            get { return _isAutoCreateCustomerCode; }
        }

        static bool _isAutoCreatePurchasingCode = false;
        /// <summary>
        /// 是否自动生成供应商编码
        /// </summary>
        public static bool IsAutoCreatePurchasingCode
        {
            get { return _isAutoCreatePurchasingCode; }
        }

        static bool _IsAutoCreateProductCataCode = true;
        /// <summary>
        /// 是否自动生成商品类别编码
        /// </summary>
        public static bool IsAutoCreateProductCataCode
        {
            get { return _IsAutoCreateProductCataCode; }
        }

        static int _frontCarryTimeHourNum;
        /// <summary>
        /// 订单指定送达时间前X小时必须进入待发货
        /// </summary>
        public static int FrontCarryTimeHourNum
        {
            get { return _frontCarryTimeHourNum; }
        }

        static int _UnclaimedDays;
        /// <summary>
        /// 无主商品无人认领天数
        /// </summary>
        public static int UnclaimedDays
        {
            get { return _UnclaimedDays; }
        }

        static ZKEShop.Common.ModOrderNode _ModOrderNode;
        /// <summary>
        /// 修改订单节点：1-待出库，2-待发货

        /// </summary>
        public static ZKEShop.Common.ModOrderNode ModOrderNode
        {
            get { return _ModOrderNode; }
        }


        static bool _isUseCountry = false;
        /// <summary>
        /// 订单是否启用国家
        /// </summary>
        public static bool IsUseCountry
        {
            get { return _isUseCountry; }
        }


        static string _PrintProvider;
        /// <summary>
        /// 供应商打印模板

        /// </summary>
        public static string PrintProvider
        {
            get { return _PrintProvider; }
        }


        static string _PrintQuot;
        /// <summary>
        /// 报价单打印模板

        /// </summary>
        public static string PrintQuot
        {
            get { return _PrintQuot; }
        }

        static string _PrintTrackPO;
        /// <summary>
        /// 采购跟踪打印模板
        /// </summary>
        public static string PrintTrackPO
        {
            get { return _PrintTrackPO; }
        }

        static string _PrintInternaPO;
        /// <summary>
        /// 国际采购单打印模板

        /// </summary>
        public static string PrintInternaPO
        {
            get { return _PrintInternaPO; }
        }

        static string _TempShopCartProList;

        /// <summary>
        /// 购物车产品列表模板

        /// </summary>
        public static string TempShopCartProList
        {
            get { return _TempShopCartProList; }
        }

        static string _TempShopCartInfo;
        /// <summary>
        /// 购物车信息（金额等）
        /// </summary>
        public static string TempShopCartInfo
        {
            get { return _TempShopCartInfo; }
        }

        /// <summary>
        /// 购物车为空模板

        /// </summary>
        static string _TempShopCartEmpty;
        public static string TempShopCartEmpty
        {
            get { return _TempShopCartEmpty; }
        }

        static string _TempShopCartSelectedProm;
        /// <summary>
        /// 购物车已享受的促销活动模板
        /// </summary>
        public static string TempShopCartSelectedProm
        {
            get { return _TempShopCartSelectedProm; }
        }

        static string _TempShopCartOptionProm;
        /// <summary>
        /// 购物车可选择的促销活动模板
        /// </summary>
        public static string TempShopCartOptionProm
        {
            get { return _TempShopCartOptionProm; }
        }

        static string _UseBalance;
        /// <summary>
        /// 购物车结算页面使用积分、余额、网币模板

        /// </summary>
        public static string UseBalance
        {
            get { return _UseBalance; }
        }

        static string _Domain;
        /// <summary>
        /// 网站域名        
        /// </summary>
        public static string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }

        static string _ServerIP;
         /// <summary>
         /// 服务器IP
         /// </summary>
        public static string  ServerIP
        {
            get { return _ServerIP; }
            set { _ServerIP = value; }
        }

        static string _APPTwoVal;
        public static string APPTwoVal
        {
            get { return _APPTwoVal; }
            set { _APPTwoVal = value; }
        }

        static string _APPFixtyTwoVal;
        public static string APPFixtyTwoVal
        {
            get { return _APPFixtyTwoVal; }
            set { _APPFixtyTwoVal = value; }
        }

        static decimal _ToXinyuRate;
        /// <summary>
        /// 订单金额转信誉额度

        /// </summary>
        public static decimal ToXinyuRate
        {
            get { return _ToXinyuRate; }
        }

        static int _CODXinyu;
        public static int CODXinyu
        {
            get { return _CODXinyu; }
        }


        static int _AutoJifenToYuEDays;
        /// <summary>
        /// 积分自动转余额天数

        /// </summary>
        public static int AutoJifenToYuEDays
        {
            get { return _AutoJifenToYuEDays; }
        }

        static int _MaxInvoice;
        /// <summary>
        /// 可开发票的期限

        /// </summary>
        public static int MaxInvoice
        {
            get { return _MaxInvoice; }
        }

        static int _AviDateRateY;
        /// <summary>
        /// 保质期有效率低于多少黄色提醒(百分比)
        /// </summary>
        public static int AviDateRateY
        {
            get { return _AviDateRateY; }
        }

        static int _AviDateRateR;
        /// <summary>
        /// 保质期有效率低于多少红色提醒(百分比)
        /// </summary>
        public static int AviDateRateR
        {
            get { return _AviDateRateR; }
        }

        static List<DateTime> _Holidays;
        public static List<DateTime> Holidays
        {
            get { return _Holidays; }
        }

        /// <summary>
        /// 自动生成SKU的规则定义
        /// </summary>
        static string _ProductSKURule;
        public static string ProductSKURule
        {
            get { return _ProductSKURule; }
        }

        /// <summary>
        /// 小购物车模版
        /// </summary>
        static string _smallCart;
        public static string SmallCart
        {
            get { return _smallCart; }
        }

        static int _ProCommentIntegral;
        /// <summary>
        /// 评论商品获得的积分
        /// </summary>
        public static int ProCommentIntegral
        {
            get { return GlobalConfig._ProCommentIntegral; }
            set { GlobalConfig._ProCommentIntegral = value; }
        }

        static bool _IsDisRettun;
        /// <summary>
        /// 是否将退货抵消销售报表

        /// </summary>
        public static bool IsDisRettun
        {
            get { return _IsDisRettun; }
            set { _IsDisRettun = value; }
        }

        static bool _IsPurPriceLast;
        /// <summary>
        /// 默认采购价取最后一次采购单价格
        /// </summary>
        public static bool IsPurPriceLast
        {
            get { return _IsPurPriceLast; }
            set { _IsPurPriceLast = value; }
        }

        static bool _CombToShipOrder = false ;
        /// <summary>
        /// 在发货单中展开组装商品
        /// </summary>
        public static bool CombToShipOrder
        {
            get { return _CombToShipOrder; }
            set { _CombToShipOrder = value; }
        }

        static int _MaxShipCaseRunNum;
        /// <summary>
        /// 最大的周转箱号码

        /// </summary>
        public static int MaxShipCaseRunNum
        {
            get { return _MaxShipCaseRunNum; }
            set { _MaxShipCaseRunNum = value; }
        }

        static int _CurShipCaseRunNum = 0;
        /// <summary>
        /// 当前的周转箱号码
        /// </summary>
        public static int CurShipCaseRunNum
        {
            get { return _CurShipCaseRunNum; }
            set { _CurShipCaseRunNum = value; }
        }

        static bool _IsCancelOrder = false;
        /// <summary>
        /// 顾客是否可取消订单
        /// </summary>
        public static bool IsCancelOrder
        {
            get { return _IsCancelOrder; }
            set { _IsCancelOrder = value; }
        }

        /// <summary>
        /// 商品编码
        /// </summary>
        static string _ProductCodeRule;
        public static string ProductCodeRule
        {
            get { return _ProductCodeRule; }
        }

        /// <summary>
        /// 供应编码
        /// </summary>
        static string _PurchasingCodeRule;
        public static string PurchasingCodeRule
        {
            get { return _PurchasingCodeRule; }
        }

        /// <summary>
        /// 商品类别编码
        /// </summary>
        static string _ProductCataCodeRule;
        public static string ProductCataCodeRule
        {
            get { return _ProductCataCodeRule; }
        }

        /// <summary>
        /// 客户编码
        /// </summary>
        static string _CustomerCodeRule;
        public static string CustomerCodeRule 
        {

            get { return _CustomerCodeRule; }
        }

        /// <summary>
        /// 销售订单编码
        /// </summary>
        static string _OrdersCodeRule;
        public static string OrdersCodeRule 
        {
            get { return _OrdersCodeRule; }
        }

        /// <summary>
        /// 采购订单编码
        /// </summary>
        static string _PurchaseOrderCodeRule;
        public static string PurchaseOrderCodeRule 
        {
            get { return _PurchaseOrderCodeRule; }
        }

        /// <summary>
        /// 采购退货单编码
        /// </summary>
        static string _ReturnOrderCodeRule;
        public static string ReturnOrderCodeRule 
        {
            get { return _ReturnOrderCodeRule; }
        }

        /// <summary>
        /// 退货入库单编码
        /// </summary>
        static string _ResheetCodeRule;
        public static string ResheetCodeRule
        {
            get { return _ResheetCodeRule; }
        }

        /// <summary>
        /// 调拨入库单编码
        /// </summary>
        static string _ShipOrderCodeRule;
        public static string ShipOrderCodeRule
        {
            get { return _ShipOrderCodeRule; }
        }

        /// <summary>
        /// 入库编码
        /// </summary>
        static string  _StoreInCodeRule;
        public static string StoreInCodeRule 
        {
            get { return _StoreInCodeRule; }
        }

        /// <summary>
        /// 出库编码
        /// </summary>
        static string  _CommonSKURule;
        public static string CommonSKURule 
        {
            get { return _CommonSKURule; }
        }

        static int _personalPwdLength;
        /// <summary>
        /// 个人会员密码加密长度
        /// </summary>
        public static int PersonalPwdLength
        {
            get { return GlobalConfig._personalPwdLength; }
            set { GlobalConfig._personalPwdLength = value; }
        }


        /// <summary>
        /// 系统初始化时从数据库读入全局配置
        /// </summary>
        /*public static void InitConfig()
        {
            DataAccess.YalunwangDataDataContext db = new DataAccess.YalunwangDataDataContext(System.Configuration.ConfigurationManager.AppSettings["ConnStr.net"]);
            
            //假日
            _Holidays = (from o in db.Holidy select o.HolidyDate).ToList();

            foreach (ZKEShop.DataAccess.GlobalSetup gs in db.GlobalSetup)
            {
                switch (gs.GlobalSetupID)
                {
                    case 1:
                        int.TryParse(gs.GlobalSetupValue, out _ProPictureLength);
                        break;
                    case 2:
                        _WebDiskPath = gs.GlobalSetupValue;
                        break;
                    case 3:
                        Int16 n;
                        Int16.TryParse(gs.GlobalSetupValue, out n);
                        _lockSotreNumType = (ZKEShop.Common.LockSotreNumType)n;
                        break;
                    case 4:
                        Int16.TryParse(gs.GlobalSetupValue, out _CouponCodeLength);
                        break;
                    case 5:
                        _ShopName = gs.GlobalSetupValue;
                        break;
                    case 6:
                        _ShopWebUrl = gs.GlobalSetupValue;
                        _Domain = gs.GlobalSetupValue;
                        break;
                    case 7:
                        _HabiName = gs.GlobalSetupValue;
                        break;
                    case 8:
                        int.TryParse(gs.GlobalSetupValue, out _ReturnDays);
                        break;
                    case 9:
                        _DescInOrder = gs.GlobalSetupValue;
                        break;
                    case 10:
                        if (gs.GlobalSetupValue == "1")
                            _IsOLOrderNeedCheck = true;
                        break;
                    case 11:
                        if (gs.GlobalSetupValue == "1")
                            _IsShowOOS = true;
                        break;
                    case 12:
                        if (gs.GlobalSetupValue == "1")
                            _NoStoreNoOrder = true;
                        break;
                    case 13:
                        if (gs.GlobalSetupValue == "1")
                            _IsStorageOn = true;
                        break;
                    case 14:
                        if (gs.GlobalSetupValue == "1")
                            _IsDynaStockTakingOn = true;
                        break;
                    case 15:
                        if (ZKEShop.Common.DataType.IsInt(gs.GlobalSetupValue))
                        {
                            _UnionEffectiveOrdersMonth = Convert.ToInt32(gs.GlobalSetupValue);
                        }
                        else
                        {
                            _UnionEffectiveOrdersMonth = 1;
                        }
                        break;
                    case 16:
                        if (gs.GlobalSetupValue == "1")
                            _IsProHavePostSta = true;
                        break;
                    case 17:
                        if (gs.GlobalSetupValue == "0")
                            _isMailSender = false;
                        break;
                    case 18:
                        if (ZKEShop.Common.DataType.IsInt(gs.GlobalSetupValue))
                        {
                            _MaxBoxNum = Convert.ToInt32(gs.GlobalSetupValue);
                        }
                        else
                        {
                            _MaxBoxNum = 20;
                        }
                        break;
                    case 19:
                        _menuname = gs.GlobalSetupValue;
                        break;
                    case 20:
                        _CallCenterIpAddress = gs.GlobalSetupValue;
                        break;
                    case 21:
                        _ProductDetailInfo = gs.GlobalSetupValue;
                        break;
                    case 22:
                        if (gs.GlobalSetupValue == "0")
                            _isshowweight = false;
                        break;
                    case 23:
                        if (gs.GlobalSetupValue == "1")
                            _isusersn = true;
                        break;
                    case 24:
                        _ProductSpecDetailInfo = gs.GlobalSetupValue;
                        break;
                    case 25:
                        _ProductDetailPic = gs.GlobalSetupValue;
                        break;
                    case 26:
                        int.TryParse(gs.GlobalSetupValue, out _CanlorderDay);
                        break;
                    case 27:
                        if (gs.GlobalSetupValue == "1")
                        {
                            _isAutoCalProInte = true;
                        }
                        else
                        {
                            _isAutoCalProInte = false;
                        }
                        break;
                    case 28:
                        int.TryParse(gs.GlobalSetupValue, out _calProInteProportion);
                        break;
                    case 29:
                        if (gs.GlobalSetupValue == "1")
                        {
                            _isAviDateOn = true;
                        }
                        else
                        {
                            _isAviDateOn = false;
                        }
                        break;
                    case 31:
                        if (gs.GlobalSetupValue == "1")
                        {
                            _isChgOrderAmountByPro = true;
                        }
                        else
                        {
                            _isChgOrderAmountByPro = false;
                        }
                        break;


                    case 32:
                        _PrintShipOrder = gs.GlobalSetupValue;
                        break;

                    case 33:
                        int.TryParse(gs.GlobalSetupValue, out _calAvgSaleNumDay);
                        break;

                    case 34:
                        int.TryParse(gs.GlobalSetupValue, out _calGrowthRateMonDay);
                        break;

                    case 35:

                        if (gs.GlobalSetupValue == "1")
                        {
                            _isAutoClosePub = true;
                        }
                        else
                        {
                            _isAutoClosePub = false;
                        }
                        break;

                    case 36:

                        if (gs.GlobalSetupValue == "1")
                        {
                            _isControlCarryTime = true;
                        }
                        else
                        {
                            _isControlCarryTime = false;
                        }
                        break;

                    case 37:
                        int.TryParse(gs.GlobalSetupValue, out _frontCarryTimeHourNum);
                        break;

                    case 38:
                        int.TryParse(gs.GlobalSetupValue, out _UnclaimedDays);
                        break;
                    case 39:
                        byte m;
                        byte.TryParse(gs.GlobalSetupValue, out m);
                        _ModOrderNode = (ZKEShop.Common.ModOrderNode)m;
                        break;

                    case 41:

                        if (gs.GlobalSetupValue == "1")
                        {
                            _isUseCountry = true;
                        }
                        else
                        {
                            _isUseCountry = false;
                        }

                        break;

                    case 42:
                        _PrintPurchaseOrder = gs.GlobalSetupValue;
                        break;

                    case 43:
                        _PrintProvider = gs.GlobalSetupValue;
                        break;

                    case 44:
                        _PrintQuot = gs.GlobalSetupValue;
                        break;

                    case 45:
                        _PrintTrackPO = gs.GlobalSetupValue;
                        break;

                    case 46:
                        _PrintInternaPO = gs.GlobalSetupValue;
                        break;

                    case 47:

                        if (gs.GlobalSetupValue == "1")
                        {
                            _isAutoCreateSKU = true;
                        }
                        else
                        {
                            _isAutoCreateSKU = false;
                        }

                        break;
                    case 48:
                        _APPTwoVal = gs.GlobalSetupValue;
                        break;
                    case 49:
                        _APPFixtyTwoVal = gs.GlobalSetupValue;
                        break;
                    case 50:
                        int.TryParse(gs.GlobalSetupValue, out _AviDateRateY);
                        break;
                    case 51:
                        int.TryParse(gs.GlobalSetupValue, out _AviDateRateR);
                        break;
                    case 52:
                        _PrintPicking = gs.GlobalSetupValue;
                        break;
                    case 53:
                        _PrintPeihuo = gs.GlobalSetupValue;
                        break;
                    case 54:
                        _PrintShipOrderList = gs.GlobalSetupValue;
                        break;
                    case 101:
                        int.TryParse(gs.GlobalSetupValue, out _MinYudingDay);
                        break;
                    case 102:
                        int.TryParse(gs.GlobalSetupValue, out _MaxYudingDay);
                        break;
                    case 201:
                        int.TryParse(gs.GlobalSetupValue, out _AutoJifenToYuEDays);
                        break;
                    case 202:
                        int.TryParse(gs.GlobalSetupValue, out _MaxInvoice);
                        break;
                    case 301:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _TempShopCartProList = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 302:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _TempShopCartInfo = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 303:
                        decimal.TryParse(gs.GlobalSetupValue, out _ToXinyuRate);
                        break;
                    case 304:
                        int.TryParse(gs.GlobalSetupValue, out _CODXinyu);
                        break;
                    case 305:
                        _ProductSKURule = gs.GlobalSetupValue;
                        break;
                    case 306:
                        _MallSiteDiskPath = gs.GlobalSetupValue;
                        break;
                    case 307:
                        _UsePicServ = gs.GlobalSetupValue;
                        break;
                    case 308:
                        _PicServDomain = gs.GlobalSetupValue;
                        break;
                    case 309:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _smallCart = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 311:
                        int.TryParse(gs.GlobalSetupValue, out _ExchangeDays);
                        break;
                    case 312:
                        int.TryParse(gs.GlobalSetupValue, out _ProCommentIntegral);
                        break;
                    case 313:
                        if (gs.GlobalSetupValue == "1")
                            _IsDisRettun = true;
                        else
                            _IsDisRettun = false;
                        break;
                    case 314:
                        if (gs.GlobalSetupValue == "1")
                            _IsPurPriceLast = true;
                        else
                            _IsPurPriceLast = false;
                        break;
                    case 315:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _TempShopCartEmpty = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 316:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _TempShopCartSelectedProm = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 317:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _TempShopCartOptionProm = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 318:
                        if (gs.GlobalSetupValue == "1")
                            _CombToShipOrder = true;
                        else
                            _CombToShipOrder = false;
                        break;
                    case 319:
                        try
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(ZKEShop.SystemFramework.GlobalConfig.ResourceDiskPath + gs.GlobalSetupValue);
                            _UseBalance = sr.ReadToEnd();
                            sr.Close();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 320:
                        _MaxShipCaseRunNum = Convert.ToInt32( gs.GlobalSetupValue);
                        break;
                    case 321:
                        _CurShipCaseRunNum = Convert.ToInt32(gs.GlobalSetupValue);
                        break;
                    case 322:
                        if (gs.GlobalSetupValue == "1")
                            _IsCancelOrder = true;
                        else
                            _IsCancelOrder = false;
                        break;
                    case 323:
                        _ProductCodeRule = gs.GlobalSetupValue;
                        break;
                    case 324:
                        _PurchasingCodeRule = gs.GlobalSetupValue;
                        break;
                    case 325:
                        _ProductCataCodeRule = gs.GlobalSetupValue;
                        break;
                    case 326:
                        _CustomerCodeRule = gs.GlobalSetupValue;
                        break;
                    case 327:
                        _OrdersCodeRule = gs.GlobalSetupValue;
                        break;
                    case 328:
                        _PurchaseOrderCodeRule = gs.GlobalSetupValue;
                        break;
                    case 329:
                        _ReturnOrderCodeRule = gs.GlobalSetupValue;
                        break;
                    case 330:
                        _ResheetCodeRule = gs.GlobalSetupValue;
                        break;
                    case 331:
                        _ShipOrderCodeRule = gs.GlobalSetupValue;
                        break;
                    case 332:
                        _StoreInCodeRule = gs.GlobalSetupValue;
                        break;
                    case 333:
                        _CommonSKURule = gs.GlobalSetupValue;
                        break;
                    case 334:
                        if (gs.GlobalSetupValue == "1")
                            _isAutoCreateProductCode = true;
                        else
                            _isAutoCreateProductCode = false;
                        break;
                    case 335:
                        if (gs.GlobalSetupValue == "1")
                            _isAutoCreateCustomerCode = true;
                        else
                            _isAutoCreateCustomerCode = false;
                        break;
                    case 336:
                        if (gs.GlobalSetupValue == "1")
                            _isAutoCreatePurchasingCode = true;
                        else
                            _isAutoCreatePurchasingCode = false;
                        break;
                    case 337:
                        if (gs.GlobalSetupValue == "1")
                            _IsAutoCreateProductCataCode = true;
                        else
                            _IsAutoCreateProductCataCode = false;
                        break;
                    case 338:
                        //商品自动排序规则
                        break;
                    case 339:
                        int.TryParse(gs.GlobalSetupValue, out _OrderPayDay);
                        break;
                    case 340:
                        int.TryParse(gs.GlobalSetupValue, out _ReAmountDay);
                        break;
                    case 341:
                        int.TryParse(gs.GlobalSetupValue, out _personalPwdLength);
                        break;
                }
            }

            string[] ary = null;
            foreach (ZKEShop.DataAccess.PicSizConfig psc in db.PicSizConfig)
            {
                switch (psc.PicSizConfigID)
                {
                    case 1:
                        ary = psc.PicSizNum.Split('*');
                        _SmallPicWidth = Convert.ToInt32(ary[0]);
                        _SmallPicHeight = Convert.ToInt32(ary[1]);
                        break;
                    case 2:
                        ary = psc.PicSizNum.Split('*');
                        _MidPicWidth = Convert.ToInt32(ary[0]);
                        _MidPicHeight = Convert.ToInt32(ary[1]);
                        break;
                    case 3:
                        ary = psc.PicSizNum.Split('*');
                        _LargePicWidth = Convert.ToInt32(ary[0]);
                        _LargePicHeight = Convert.ToInt32(ary[1]);
                        break;
                    case 4:
                        ary = psc.PicSizNum.Split('*');
                        _BrandSmallPicWidth = Convert.ToInt32(ary[0]);
                        _BrandSmallPicHeight = Convert.ToInt32(ary[1]);
                        break;
                    case 5:
                        ary = psc.PicSizNum.Split('*');
                        _BrandMidPicWidth = Convert.ToInt32(ary[0]);
                        _BrandMidPicHeight = Convert.ToInt32(ary[1]);
                        break;
                    case 6:
                        ary = psc.PicSizNum.Split('*');
                        _BrandBigPicWidth = Convert.ToInt32(ary[0]);
                        _BrandBigPicHeight = Convert.ToInt32(ary[1]);
                        break;
                }
            }

            switch (System.Configuration.ConfigurationManager.AppSettings["ApplicationLanguage"])
            {
                case "zh-cn":
                    _ApplicationLanguage = ZKEShop.Common.AppLanguage.CN;
                    _ApplicationLanguageJS = "zh-cn.js";
                    break;
                case "en-us":
                    _ApplicationLanguage = ZKEShop.Common.AppLanguage.EN;
                    _ApplicationLanguageJS = "en-us.js";
                    break;
                case "fr-lang":
                    _ApplicationLanguage = ZKEShop.Common.AppLanguage.FR;
                    _ApplicationLanguageJS = "fr-lang.js";
                    break;
                case "ge-lang":
                    _ApplicationLanguage = ZKEShop.Common.AppLanguage.GE;
                    _ApplicationLanguageJS = "ge-lang.js";
                    break;
                case "it-lang":
                    _ApplicationLanguage = ZKEShop.Common.AppLanguage.IT;
                    _ApplicationLanguageJS = "it-lang.js";
                    break;
            }
        }
        */
        static Dictionary<int, string> _SingPro = new Dictionary<int, string>();
        public static Dictionary<int, string> SingPro
        {
            get { return _SingPro; }
            set { _SingPro = value; }
        }

      

        static short _DefaultPostStaID = 22;
        public static short DefaultPostStaID
        {
            get { return _DefaultPostStaID; }
            set { _DefaultPostStaID = value; }
        }

        /// <summary>
        /// 存储网页模板的字典

        /// </summary>
        public static Dictionary<int, string> DicTemplete = new Dictionary<int, string>();
        /// <summary>
        /// 获取一个网页模板的内容
        /// </summary>
        /// <param name="TempID"></param>
        /// <returns></returns>
        public static string GetTempContent(int TempID)
        {
            return DicTemplete[TempID];
        }



        /// <summary>
        /// 商品编号是否自动编号  EBS复制
        /// </summary>
        static bool _IsProductCodeAutoCreate = false;
        public static bool IsProductCodeAutoCreate
        {
            get { return _IsProductCodeAutoCreate; }
        }
    }
}
