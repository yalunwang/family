using System;
using System.Collections.Generic;
using System.Xml;
using ZKEShop.Common;
using System.Web;

namespace ZKEShop.SystemFramework
{

    /// <summary>
    /// 信息配置类
    /// </summary>
    public class MsgConfig
    {
        #region 中文定义变量

        public static AppLanguage lang = AppLanguage.CN;

        static XmlDocument docCN;
        static XmlDocument docEN;

        /// <summary>
        /// serverHost
        /// </summary>
        public static string serverHost;

        #region 枚举名称
        /// <summary>
        /// _FormWordsCN
        /// </summary>
        private static Dictionary<string, string> _FormWordsCN;

        /// <summary>
        /// 促销类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionTypeCN;

        /// <summary>
        /// 促销条件类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionConditionTypeCN;

        /// <summary>
        /// 促销条件匹配类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromConditionFitTypeCN;

        /// <summary>
        /// 促销优惠类型枚举
        /// </summary>
        private static Dictionary<string, string> _GiftsTypeCN;

        /// <summary>
        /// 支付枚举
        /// </summary>
        private static Dictionary<string, string> _PaymentKindCN;

        /// <summary>
        /// 业务操作种类
        /// </summary>
        private static Dictionary<string, string> _OperTypeIDCN;

        /// <summary>
        /// 订单配送类型
        /// </summary>
        private static Dictionary<string, string> _PostTypeCN;

        /// <summary>
        /// 订单状态

        /// </summary>
        private static Dictionary<string, string> _OrdersStatusCN;

        /// <summary>
        /// 账户记录状态

        /// </summary>
        private static Dictionary<string, string> _AccStatusCN;

        /// <summary>
        /// 资讯提问状态

        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionStatusCN;

        /// <summary>
        /// 资讯提问属性

        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionTypeCN;

        /// <summary>
        /// 网站公告类别
        /// </summary>
        private static Dictionary<string, string> _NotifyTypeCN;

        /// <summary>
        /// 联盟网站类型
        /// </summary>
        private static Dictionary<string, string> _WebSiteTypeCN;

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        private static Dictionary<string, string> _UnionAccountTypeCN;

        /// <summary>
        /// 网站联盟合作类型
        /// </summary>
        private static Dictionary<string, string> _CooperationTypeCN;

        /// <summary>
        /// 网站频道
        /// </summary>
        private static Dictionary<string, string> _ChannelTypeCN;

        /// <summary>
        /// 支付状态

        /// </summary>
        private static Dictionary<string, string> _PayStatusCN;

        /// <summary>
        /// 礼品兑换状态
        /// </summary>
        private static Dictionary<string, string> _EGiftStatusCN;


        /// <summary>
        /// 产品类型
        /// </summary>
        private static Dictionary<string, string> _ProductTypeCN;

        /// <summary>
        /// 订单类型
        /// </summary>
        private static Dictionary<string, string> _OrderTypeCN;

        /// <summary>
        /// 会员认证状态
        /// </summary>
        private static Dictionary<string, string> _CusVerifyStatusCN;

        /// <summary>
        /// 退换货状态
        /// </summary>
        private static Dictionary<string, string> _ReStatusCN;
        /// <summary>
        /// 推荐商品类别
        /// </summary>
        private static Dictionary<string, string> _RecomProKindCN;
        /// <summary>
        /// 入库单状态


        /// </summary>
        private static Dictionary<string, string> _StoreInStatusCN;

        /// <summary>
        /// 库存核算方法
        /// </summary>
        private static Dictionary<string, string> _CostModeCN;

        /// <summary>
        /// 发货单状态


        /// </summary>
        private static Dictionary<string, string> _ShipOrderStatusCN;

        /// <summary>
        /// 出库类型
        /// </summary>
        private static Dictionary<string, string> _StoreOutTypeCN;

        /// <summary>
        /// 入库类型
        /// </summary>
        private static Dictionary<string, string> _StoreInTypeCN;

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        private static Dictionary<string, string> _DefTypeCN;

        /// <summary>
        /// 淘宝订单状态


        /// </summary>
        private static Dictionary<string, string> _TBOrdStatusCN;

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        private static Dictionary<string, string> _TBCarryTypeCN;

        /// <summary>
        /// 网页版块功能
        /// </summary>
        private static Dictionary<string, string> _FunctionIDCN;

        /// <summary>
        /// 客流统计类别
        /// </summary>
        private static Dictionary<string, string> _CusNumTypeCN;

        /// <summary>
        /// 呼叫中心会话类型
        /// </summary>
        private static Dictionary<string, string> _CusChatTypeCN;

        /// <summary>
        /// 退款单状态


        /// </summary>
        private static Dictionary<string, string> _ReMoneyStatusCN;

        /// <summary>
        /// 仓库属性


        /// </summary>
        private static Dictionary<string, string> _StoreHousePropertyCN;


        /// <summary>
        /// 采购订单审核条件
        /// </summary>
        private static Dictionary<string, string> _PuchaseCheckConditionCN;


        /// <summary>
        /// 采购订单状态

        /// </summary>
        private static Dictionary<string, string> _CheckStatusCN;


        /// <summary>
        /// 结账点

        /// </summary>
        private static Dictionary<string, string> _CheckoutPointCN;

        /// <summary>
        /// 商品排序规则
        /// </summary>
        private static Dictionary<string, string> _ProSortRuleCN;

        /// <summary>
        /// 商品储存温度属性

        /// </summary>
        private static Dictionary<string, string> _TemperaAttrCN;


        /// <summary>
        /// 采购单退货方式

        /// </summary>
        private static Dictionary<string, string> _PurchaseReturnTypeCN;

        /// <summary>
        /// 配车单状态

        /// </summary>
        private static Dictionary<string, string> _CarrySheetStatusCN;

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        private static Dictionary<string, string> _AlertSourceTypeCN;

        /// <summary>
        /// 采购类型
        /// </summary>
        private static Dictionary<string, string> _POTypeCN;

        /// <summary>
        /// 销售价格状态

        /// </summary>
        private static Dictionary<string, string> _SalePriceStatusCN;

        /// <summary>
        /// 入库单的实际业务操作状态
        /// </summary>
        private static Dictionary<string, string> _StockDealStatusCN;

        /// <summary>
        /// 店铺导航类别
        /// </summary>
        private static Dictionary<string, string> _ProvNavLinkTypeCN;

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        private static Dictionary<string, string> _CusCateConditionTypeCN;

        private static Dictionary<string, string> _ProPromCataIDCN;

        private static Dictionary<string, string> _TousuTypeCN;

        private static Dictionary<string, string> _PackageTypeCN;

        private static Dictionary<string, string> _BakTemplateTypeCN;

        private static Dictionary<string, string> _ReAmountStatusCN;

      

        #endregion

        #region 国际化文字

        /// <summary>
        /// 商户中心菜单
        /// </summary>
        private static Dictionary<string, string> _MsgSellerMenuCN;

        private static Dictionary<string, string> _MsgSellerHeadCN;

        private static Dictionary<string, string> _MsgSelOrderListCN;

        private static Dictionary<string, string> _MsgSelOrderDetailCN;

        private static Dictionary<string, string> _MsgSelShipOrderListCN;

        private static Dictionary<string, string> _MsgSelShipOrderDetailCN;

        private static Dictionary<string, string> _MsgSelOrderReGoodsListCN;

        private static Dictionary<string, string> _MsgSelOrderReGoodsDetailCN;

        private static Dictionary<string, string> _MsgSelOrderMarkCN;

        private static Dictionary<string, string> _MsgSelNavAdFlashPicInfoCN;

        private static Dictionary<string, string> _MsgSelProductChoiceProCataCN;

        private static Dictionary<string, string> _MsgSelProductDetailCN;

        private static Dictionary<string, string> _MsgSelProductProductTjCN;

        private static Dictionary<string, string> _MsSelProductListCN;

        private static Dictionary<string, string> _MsgProductStoreListCN;

        private static Dictionary<string, string> _MsgPromotionLimitTjInfoCN;

        private static Dictionary<string, string> _MsgPromotionLimitTjListCN;

        private static Dictionary<string, string> _MsgPromotionPackageInfoCN;

        private static Dictionary<string, string> _MsgPromotionPackageListCN;

        private static Dictionary<string, string> _MsgPromotionProInfoCN;

        private static Dictionary<string, string> _MsgPromotionProInfo2CN;

        private static Dictionary<string, string> _MsgPromotionInfo3CN;

        private static Dictionary<string, string> _MsgPromotionListCN;

        private static Dictionary<string, string> _MsgServiceAfterMLCN;

        private static Dictionary<string, string> _MsgServiceCompListCN;

        private static Dictionary<string, string> _MsgServiceConsultingListCN;

        private static Dictionary<string, string> _MsgSetupCarryTempCN;

        private static Dictionary<string, string> _MseSetupCarryTempListCN;

        private static Dictionary<string, string> _MseSetupConsumerProCN;

        private static Dictionary<string, string> _MsgSelOrderReGoodsConfirmCN;

        private static Dictionary<string, string> _MsgSelOrderModPriceCN;

        private static Dictionary<string, string> _MsgSelOrderRefRegoodsCN;

        private static Dictionary<string, string> _DeliveryBaseCN;

        private static Dictionary<string, string> _MsgSelReviewManageCN;

        private static Dictionary<string, string> _MsgPageBaseCN;

        private static Dictionary<string, string> _ChargeTypeCN;

        /// <summary>
        /// 公共的


        /// </summary>
        private static Dictionary<string, string> _CommonCN;

        /// <summary>
        /// DataList表


        /// </summary>
        private static Dictionary<string, string> _DataListCN;

        /// <summary>
        /// 仓储系统
        /// </summary>
        private static Dictionary<string, string> _StorageCN;

        /// <summary>
        /// 供货系统
        /// </summary>
        private static Dictionary<string, string> _PurchaseCN;

        /// <summary>
        /// 订单系统
        /// </summary>
        private static Dictionary<string, string> _OrderCN;

        /// <summary>
        /// 商品系统
        /// </summary>
        private static Dictionary<string, string> _ProductCN;

        /// <summary>
        /// 仓储设置
        /// </summary>
        private static Dictionary<string, string> _StockCN;

        /// <summary>
        /// 我的菜单
        /// </summary>
        private static Dictionary<string, string> _MenuCN;

        /// <summary>
        /// 员工
        /// </summary>
        private static Dictionary<string, string> _UsersCN;

        /// <summary>
        /// 营销管理
        /// </summary>
        private static Dictionary<string, string> _PromManageCN;

        /// <summary>
        /// 会员管理
        /// </summary>
        private static Dictionary<string, string> _CusManageCN;

        /// <summary>
        /// 网站管理
        /// </summary>
        private static Dictionary<string, string> _WebsiteManageCN;

        /// <summary>
        /// 财务管理
        /// </summary>
        private static Dictionary<string, string> _FinaceManageCN;

        /// <summary>
        /// 系统设置
        /// </summary>
        private static Dictionary<string, string> _SysSetupCN;

        /// <summary>
        /// 桌面 
        /// </summary>
        private static Dictionary<string, string> _DeskTopCN;


        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        private static Dictionary<string, string> _WebCommonCN;

        /// <summary>
        /// 网站商品页面
        /// </summary>
        private static Dictionary<string, string> _WebProductCN;

        /// <summary>
        /// 网站团购页面
        /// </summary>
        private static Dictionary<string, string> _WebTuanCN;

        /// <summary>
        /// 网站主题套餐页面
        /// </summary>
        private static Dictionary<string, string> _WebThemeCN;


        /// <summary>
        /// 网站帮助
        /// </summary>
        private static Dictionary<string, string> _WebHelpCN;


        /// <summary>
        /// 网站个人中心
        /// </summary>
        private static Dictionary<string, string> _WebAccoutCN;

        /// <summary>
        /// 结算方式
        /// </summary>
        private static Dictionary<string, string> _BalanceTypeCN;

        /// <summary>
        /// 结算状态

        /// </summary>
        private static Dictionary<string, string> _BalanceStatusCN;

        private static Dictionary<string, string> _ServiceStatusCN;
        #endregion

        #endregion

        #region 英文定义变量

        #region 枚举名称
        /// <summary>
        /// _FormWordsEN
        /// </summary>
        private static Dictionary<string, string> _FormWordsEN;

        /// <summary>
        /// 促销类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionTypeEN;

        /// <summary>
        /// 促销条件类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionConditionTypeEN;

        /// <summary>
        /// 促销条件匹配类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromConditionFitTypeEN;

        /// <summary>
        /// 促销优惠类型枚举
        /// </summary>
        private static Dictionary<string, string> _GiftsTypeEN;

        /// <summary>
        /// 支付枚举
        /// </summary>
        private static Dictionary<string, string> _PaymentKindEN;

        /// <summary>
        /// 业务操作种类
        /// </summary>
        private static Dictionary<string, string> _OperTypeIDEN;

        /// <summary>
        /// 订单配送类型


        /// </summary>
        private static Dictionary<string, string> _PostTypeEN;

        /// <summary>
        /// 订单状态


        /// </summary>
        private static Dictionary<string, string> _OrdersStatusEN;

        /// <summary>
        /// 账户记录状态


        /// </summary>
        private static Dictionary<string, string> _AccStatusEN;

        /// <summary>
        /// 资讯提问状态


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionStatusEN;

        /// <summary>
        /// 资讯提问属性


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionTypeEN;

        /// <summary>
        /// 网站公告类别
        /// </summary>
        private static Dictionary<string, string> _NotifyTypeEN;

        /// <summary>
        /// 联盟网站类型
        /// </summary>
        private static Dictionary<string, string> _WebSiteTypeEN;

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        private static Dictionary<string, string> _UnionAccountTypeEN;

        /// <summary>
        /// 网站联盟合作类型
        /// </summary>
        private static Dictionary<string, string> _CooperationTypeEN;

        /// <summary>
        /// 网站频道
        /// </summary>
        private static Dictionary<string, string> _ChannelTypeEN;

        /// <summary>
        /// 支付状态


        /// </summary>
        private static Dictionary<string, string> _PayStatusEN;

        /// <summary>
        /// 礼品兑换状态

        /// </summary>
        private static Dictionary<string, string> _EGiftStatusEN;
        /// <summary>
        /// 产品类型
        /// </summary>
        private static Dictionary<string, string> _ProductTypeEN;


        /// <summary>
        /// 退换货状态
        /// </summary>
        private static Dictionary<string, string> _ReStatusEN;
        /// <summary>
        /// 推荐商品类别
        /// </summary>
        private static Dictionary<string, string> _RecomProKindEN;
        /// <summary>
        /// 入库单状态


        /// </summary>
        private static Dictionary<string, string> _StoreInStatusEN;
        /// <summary>
        /// 库存核算方法
        /// </summary>
        private static Dictionary<string, string> _CostModeEN;

        /// <summary>
        /// 发货单状态



        /// </summary>
        private static Dictionary<string, string> _ShipOrderStatusEN;

        /// <summary>
        /// 出库类型
        /// </summary>
        private static Dictionary<string, string> _StoreOutTypeEN;

        /// <summary>
        /// 入库类型
        /// </summary>
        private static Dictionary<string, string> _StoreInTypeEN;

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        private static Dictionary<string, string> _DefTypeEN;

        /// <summary>
        /// 淘宝订单状态


        /// </summary>
        private static Dictionary<string, string> _TBOrdStatusEN;

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        private static Dictionary<string, string> _TBCarryTypeEN;

        /// <summary>
        /// 网页版块功能
        /// </summary>
        private static Dictionary<string, string> _FunctionIDEN;

        /// <summary>
        /// 客流统计类别
        /// </summary>
        private static Dictionary<string, string> _CusNumTypeEN;

        /// <summary>
        /// 呼叫中心会话类型
        /// </summary>
        private static Dictionary<string, string> _CusChatTypeEN;

        /// <summary>
        /// 退款单状态


        /// </summary>
        private static Dictionary<string, string> _ReMoneyStatusEN;

        /// <summary>
        /// 仓库属性

        /// </summary>
        private static Dictionary<string, string> _StoreHousePropertyEN;


        /// <summary>
        /// 结账点

        /// </summary>
        private static Dictionary<string, string> _CheckoutPointEN;

        /// <summary>
        /// 商品排序规则
        /// </summary>
        private static Dictionary<string, string> _ProSortRuleEN;

        /// <summary>
        /// 商品储存温度属性

        /// </summary>
        private static Dictionary<string, string> _TemperaAttrEN;


        /// <summary>
        /// 采购单退货方式

        /// </summary>
        private static Dictionary<string, string> _PurchaseReturnTypeEN;

        /// <summary>
        /// 采购订单审核条件
        /// </summary>
        private static Dictionary<string, string> _PuchaseCheckConditionEN;

        /// <summary>
        /// 配车单状态

        /// </summary>
        private static Dictionary<string, string> _CarrySheetStatusEN;

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        private static Dictionary<string, string> _AlertSourceTypeEN;

        /// <summary>
        /// 采购类型
        /// </summary>
        private static Dictionary<string, string> _POTypeEN;

        /// <summary>
        /// 销售价格状态

        /// </summary>
        private static Dictionary<string, string> _SalePriceStatusEN;

        /// <summary>
        /// 入库单的实际业务操作状态

        /// </summary>
        private static Dictionary<string, string> _StockDealStatusEN;

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        private static Dictionary<string, string> _CusCateConditionTypeEN;

        #endregion

        #region 国际化文字


        /// <summary>
        /// 公共的

        /// </summary>
        private static Dictionary<string, string> _CommonEN;

        /// <summary>
        /// DataList表

        /// </summary>
        private static Dictionary<string, string> _DataListEN;

        /// <summary>
        /// 仓储系统
        /// </summary>
        private static Dictionary<string, string> _StorageEN;

        /// <summary>
        /// 供货系统
        /// </summary>
        private static Dictionary<string, string> _PurchaseEN;

        /// <summary>
        /// 订单系统
        /// </summary>
        private static Dictionary<string, string> _OrderEN;

        /// <summary>
        /// 商品系统
        /// </summary>
        private static Dictionary<string, string> _ProductEN;

        /// <summary>
        /// 仓储设置
        /// </summary>
        private static Dictionary<string, string> _StockEN;

        /// <summary>
        /// 我的菜单
        /// </summary>
        private static Dictionary<string, string> _MenuEN;

        /// <summary>
        /// 员工
        /// </summary>
        private static Dictionary<string, string> _UsersEN;

        /// <summary>
        /// 营销管理
        /// </summary>
        private static Dictionary<string, string> _PromManageEN;

        /// <summary>
        /// 会员管理
        /// </summary>
        private static Dictionary<string, string> _CusManageEN;

        /// <summary>
        /// 网站管理
        /// </summary>
        private static Dictionary<string, string> _WebsiteManageEN;

        /// <summary>
        /// 财务管理
        /// </summary>
        private static Dictionary<string, string> _FinaceManageEN;

        /// <summary>
        /// 系统设置
        /// </summary>
        private static Dictionary<string, string> _SysSetupEN;

        /// <summary>
        /// 桌面 
        /// </summary>
        private static Dictionary<string, string> _DeskTopEN;

        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        private static Dictionary<string, string> _WebCommonEN;

        /// <summary>
        /// 网站商品页面
        /// </summary>
        private static Dictionary<string, string> _WebProductEN;

        /// <summary>
        /// 网站团购页面
        /// </summary>
        private static Dictionary<string, string> _WebTuanEN;

        /// <summary>
        /// 网站主题套餐页面
        /// </summary>
        private static Dictionary<string, string> _WebThemeEN;


        /// <summary>
        /// 网站帮助
        /// </summary>
        private static Dictionary<string, string> _WebHelpEN;


        /// <summary>
        /// 网站个人中心
        /// </summary>
        private static Dictionary<string, string> _WebAccoutEN;


        #endregion

        #endregion

        #region 法文定义变量

        #region 枚举名称
        /// <summary>
        /// _FormWordsFR
        /// </summary>
        private static Dictionary<string, string> _FormWordsFR;

        /// <summary>
        /// 促销类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionTypeFR;

        /// <summary>
        /// 促销条件类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionConditionTypeFR;

        /// <summary>
        /// 促销条件匹配类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromConditionFitTypeFR;

        /// <summary>
        /// 促销优惠类型枚举
        /// </summary>
        private static Dictionary<string, string> _GiftsTypeFR;

        /// <summary>
        /// 支付枚举
        /// </summary>
        private static Dictionary<string, string> _PaymentKindFR;

        /// <summary>
        /// 业务操作种类
        /// </summary>
        private static Dictionary<string, string> _OperTypeIDFR;

        /// <summary>
        /// 订单配送类型


        /// </summary>
        private static Dictionary<string, string> _PostTypeFR;

        /// <summary>
        /// 订单状态


        /// </summary>
        private static Dictionary<string, string> _OrdersStatusFR;

        /// <summary>
        /// 账户记录状态


        /// </summary>
        private static Dictionary<string, string> _AccStatusFR;

        /// <summary>
        /// 资讯提问状态


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionStatusFR;

        /// <summary>
        /// 资讯提问属性


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionTypeFR;

        /// <summary>
        /// 网站公告类别
        /// </summary>
        private static Dictionary<string, string> _NotifyTypeFR;

        /// <summary>
        /// 联盟网站类型
        /// </summary>
        private static Dictionary<string, string> _WebSiteTypeFR;

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        private static Dictionary<string, string> _UnionAccountTypeFR;

        /// <summary>
        /// 网站联盟合作类型
        /// </summary>
        private static Dictionary<string, string> _CooperationTypeFR;

        /// <summary>
        /// 网站频道
        /// </summary>
        private static Dictionary<string, string> _ChannelTypeFR;

        /// <summary>
        /// 支付状态


        /// </summary>
        private static Dictionary<string, string> _PayStatusFR;

        /// <summary>
        /// 礼品兑换状态

        /// </summary>
        private static Dictionary<string, string> _EGiftStatusFR;
        /// <summary>
        /// 产品类型
        /// </summary>
        private static Dictionary<string, string> _ProductTypeFR;
        /// <summary>
        /// 退换货状态


        /// </summary>
        private static Dictionary<string, string> _ReStatusFR;
        /// <summary>
        /// 推荐商品类别
        /// </summary>
        private static Dictionary<string, string> _RecomProKindFR;
        /// <summary>
        /// 入库单状态


        /// </summary>
        private static Dictionary<string, string> _StoreInStatusFR;
        /// <summary>
        /// 库存核算方法
        /// </summary>
        private static Dictionary<string, string> _CostModeFR;

        /// <summary>
        /// 发货单状态



        /// </summary>
        private static Dictionary<string, string> _ShipOrderStatusFR;

        /// <summary>
        /// 出库类型
        /// </summary>
        private static Dictionary<string, string> _StoreOutTypeFR;

        /// <summary>
        /// 入库类型
        /// </summary>
        private static Dictionary<string, string> _StoreInTypeFR;

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        private static Dictionary<string, string> _DefTypeFR;

        /// <summary>
        /// 淘宝订单状态


        /// </summary>
        private static Dictionary<string, string> _TBOrdStatusFR;

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        private static Dictionary<string, string> _TBCarryTypeFR;

        /// <summary>
        /// 网页版块功能
        /// </summary>
        private static Dictionary<string, string> _FunctionIDFR;

        /// <summary>
        /// 客流统计类别
        /// </summary>
        private static Dictionary<string, string> _CusNumTypeFR;

        /// <summary>
        /// 呼叫中心会话类型
        /// </summary>
        private static Dictionary<string, string> _CusChatTypeFR;

        /// <summary>
        /// 退款单状态


        /// </summary>
        private static Dictionary<string, string> _ReMoneyStatusFR;

        /// <summary>
        /// 仓库属性

        /// </summary>
        private static Dictionary<string, string> _StoreHousePropertyFR;


        /// <summary>
        /// 结账点

        /// </summary>
        private static Dictionary<string, string> _CheckoutPointFR;

        /// <summary>
        /// 商品排序规则
        /// </summary>
        private static Dictionary<string, string> _ProSortRuleFR;

        /// <summary>
        /// 商品储存温度属性

        /// </summary>
        private static Dictionary<string, string> _TemperaAttrFR;


        /// <summary>
        /// 采购单退货方式

        /// </summary>
        private static Dictionary<string, string> _PurchaseReturnTypeFR;

        /// <summary>
        /// 采购订单审核条件
        /// </summary>
        private static Dictionary<string, string> _PuchaseCheckConditionFR;

        /// <summary>
        /// 配车单状态

        /// </summary>
        private static Dictionary<string, string> _CarrySheetStatusFR;

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        private static Dictionary<string, string> _AlertSourceTypeFR;

        /// <summary>
        /// 采购类型
        /// </summary>
        private static Dictionary<string, string> _POTypeFR;

        /// <summary>
        /// 销售价格状态

        /// </summary>
        private static Dictionary<string, string> _SalePriceStatusFR;

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        private static Dictionary<string, string> _CusCateConditionTypeFR;

        #endregion

        #region 国际化文字


        /// <summary>
        /// 公共的

        /// </summary>
        private static Dictionary<string, string> _CommonFR;

        /// <summary>
        /// DataList表

        /// </summary>
        private static Dictionary<string, string> _DataListFR;

        /// <summary>
        /// 仓储系统
        /// </summary>
        private static Dictionary<string, string> _StorageFR;

        /// <summary>
        /// 供货系统
        /// </summary>
        private static Dictionary<string, string> _PurchaseFR;

        /// <summary>
        /// 订单系统
        /// </summary>
        private static Dictionary<string, string> _OrderFR;

        /// <summary>
        /// 商品系统
        /// </summary>
        private static Dictionary<string, string> _ProductFR;

        /// <summary>
        /// 仓储设置
        /// </summary>
        private static Dictionary<string, string> _StockFR;

        /// <summary>
        /// 我的菜单
        /// </summary>
        private static Dictionary<string, string> _MenuFR;

        /// <summary>
        /// 员工
        /// </summary>
        private static Dictionary<string, string> _UsersFR;

        /// <summary>
        /// 营销管理
        /// </summary>
        private static Dictionary<string, string> _PromManageFR;

        /// <summary>
        /// 会员管理
        /// </summary>
        private static Dictionary<string, string> _CusManageFR;

        /// <summary>
        /// 网站管理
        /// </summary>
        private static Dictionary<string, string> _WebsiteManageFR;

        /// <summary>
        /// 财务管理
        /// </summary>
        private static Dictionary<string, string> _FinaceManageFR;

        /// <summary>
        /// 系统设置
        /// </summary>
        private static Dictionary<string, string> _SysSetupFR;

        /// <summary>
        /// 桌面 
        /// </summary>
        private static Dictionary<string, string> _DeskTopFR;

        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        private static Dictionary<string, string> _WebCommonFR;

        /// <summary>
        /// 网站商品页面
        /// </summary>
        private static Dictionary<string, string> _WebProductFR;

        /// <summary>
        /// 网站团购页面
        /// </summary>
        private static Dictionary<string, string> _WebTuanFR;

        /// <summary>
        /// 网站主题套餐页面
        /// </summary>
        private static Dictionary<string, string> _WebThemeFR;


        /// <summary>
        /// 网站帮助
        /// </summary>
        private static Dictionary<string, string> _WebHelpFR;

        /// <summary>
        /// 网站个人中心
        /// </summary>
        private static Dictionary<string, string> _WebAccoutFR;

        #endregion

        #endregion

        #region 德语定义变量

        #region 枚举名称
        /// <summary>
        /// _FormWordsGE
        /// </summary>
        private static Dictionary<string, string> _FormWordsGE;

        /// <summary>
        /// 促销类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionTypeGE;

        /// <summary>
        /// 促销条件类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionConditionTypeGE;

        /// <summary>
        /// 促销条件匹配类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromConditionFitTypeGE;

        /// <summary>
        /// 促销优惠类型枚举
        /// </summary>
        private static Dictionary<string, string> _GiftsTypeGE;

        /// <summary>
        /// 支付枚举
        /// </summary>
        private static Dictionary<string, string> _PaymentKindGE;

        /// <summary>
        /// 业务操作种类
        /// </summary>
        private static Dictionary<string, string> _OperTypeIDGE;

        /// <summary>
        /// 订单配送类型


        /// </summary>
        private static Dictionary<string, string> _PostTypeGE;

        /// <summary>
        /// 订单状态


        /// </summary>
        private static Dictionary<string, string> _OrdersStatusGE;

        /// <summary>
        /// 账户记录状态


        /// </summary>
        private static Dictionary<string, string> _AccStatusGE;

        /// <summary>
        /// 资讯提问状态


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionStatusGE;

        /// <summary>
        /// 资讯提问属性


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionTypeGE;

        /// <summary>
        /// 网站公告类别
        /// </summary>
        private static Dictionary<string, string> _NotifyTypeGE;

        /// <summary>
        /// 联盟网站类型
        /// </summary>
        private static Dictionary<string, string> _WebSiteTypeGE;

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        private static Dictionary<string, string> _UnionAccountTypeGE;

        /// <summary>
        /// 网站联盟合作类型
        /// </summary>
        private static Dictionary<string, string> _CooperationTypeGE;

        /// <summary>
        /// 网站频道
        /// </summary>
        private static Dictionary<string, string> _ChannelTypeGE;

        /// <summary>
        /// 支付状态


        /// </summary>
        private static Dictionary<string, string> _PayStatusGE;

        /// <summary>
        /// 礼品兑换状态

        /// </summary>
        private static Dictionary<string, string> _EGiftStatusGE;
        /// <summary>
        /// 产品类型
        /// </summary>
        private static Dictionary<string, string> _ProductTypeGE;
        /// <summary>
        /// 退换货状态


        /// </summary>
        private static Dictionary<string, string> _ReStatusGE;
        /// <summary>
        /// 推荐商品类别
        /// </summary>
        private static Dictionary<string, string> _RecomProKindGE;
        /// <summary>
        /// 入库单状态


        /// </summary>
        private static Dictionary<string, string> _StoreInStatusGE;
        /// <summary>
        /// 库存核算方法
        /// </summary>
        private static Dictionary<string, string> _CostModeGE;

        /// <summary>
        /// 发货单状态



        /// </summary>
        private static Dictionary<string, string> _ShipOrderStatusGE;

        /// <summary>
        /// 出库类型
        /// </summary>
        private static Dictionary<string, string> _StoreOutTypeGE;

        /// <summary>
        /// 入库类型
        /// </summary>
        private static Dictionary<string, string> _StoreInTypeGE;

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        private static Dictionary<string, string> _DefTypeGE;

        /// <summary>
        /// 淘宝订单状态


        /// </summary>
        private static Dictionary<string, string> _TBOrdStatusGE;

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        private static Dictionary<string, string> _TBCarryTypeGE;

        /// <summary>
        /// 网页版块功能
        /// </summary>
        private static Dictionary<string, string> _FunctionIDGE;

        /// <summary>
        /// 客流统计类别
        /// </summary>
        private static Dictionary<string, string> _CusNumTypeGE;

        /// <summary>
        /// 呼叫中心会话类型
        /// </summary>
        private static Dictionary<string, string> _CusChatTypeGE;

        /// <summary>
        /// 退款单状态


        /// </summary>
        private static Dictionary<string, string> _ReMoneyStatusGE;

        /// <summary>
        /// 仓库属性

        /// </summary>
        private static Dictionary<string, string> _StoreHousePropertyGE;


        /// <summary>
        /// 结账点

        /// </summary>
        private static Dictionary<string, string> _CheckoutPointGE;

        /// <summary>
        /// 商品排序规则
        /// </summary>
        private static Dictionary<string, string> _ProSortRuleGE;

        /// <summary>
        /// 商品储存温度属性

        /// </summary>
        private static Dictionary<string, string> _TemperaAttrGE;


        /// <summary>
        /// 采购单退货方式

        /// </summary>
        private static Dictionary<string, string> _PurchaseReturnTypeGE;

        /// <summary>
        /// 采购订单审核条件
        /// </summary>
        private static Dictionary<string, string> _PuchaseCheckConditionGE;

        /// <summary>
        /// 配车单状态

        /// </summary>
        private static Dictionary<string, string> _CarrySheetStatusGE;

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        private static Dictionary<string, string> _AlertSourceTypeGE;

        /// <summary>
        /// 采购类型
        /// </summary>
        private static Dictionary<string, string> _POTypeGE;

        /// <summary>
        /// 销售价格状态

        /// </summary>
        private static Dictionary<string, string> _SalePriceStatusGE;

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        private static Dictionary<string, string> _CusCateConditionTypeGE;

        #endregion

        #region 国际化文字


        /// <summary>
        /// 公共的

        /// </summary>
        private static Dictionary<string, string> _CommonGE;

        /// <summary>
        /// DataList表

        /// </summary>
        private static Dictionary<string, string> _DataListGE;

        /// <summary>
        /// 仓储系统
        /// </summary>
        private static Dictionary<string, string> _StorageGE;

        /// <summary>
        /// 供货系统
        /// </summary>
        private static Dictionary<string, string> _PurchaseGE;

        /// <summary>
        /// 订单系统
        /// </summary>
        private static Dictionary<string, string> _OrderGE;

        /// <summary>
        /// 商品系统
        /// </summary>
        private static Dictionary<string, string> _ProductGE;

        /// <summary>
        /// 仓储设置
        /// </summary>
        private static Dictionary<string, string> _StockGE;

        /// <summary>
        /// 我的菜单
        /// </summary>
        private static Dictionary<string, string> _MenuGE;

        /// <summary>
        /// 员工
        /// </summary>
        private static Dictionary<string, string> _UsersGE;

        /// <summary>
        /// 营销管理
        /// </summary>
        private static Dictionary<string, string> _PromManageGE;

        /// <summary>
        /// 会员管理
        /// </summary>
        private static Dictionary<string, string> _CusManageGE;

        /// <summary>
        /// 网站管理
        /// </summary>
        private static Dictionary<string, string> _WebsiteManageGE;

        /// <summary>
        /// 财务管理
        /// </summary>
        private static Dictionary<string, string> _FinaceManageGE;

        /// <summary>
        /// 系统设置
        /// </summary>
        private static Dictionary<string, string> _SysSetupGE;

        /// <summary>
        /// 桌面 
        /// </summary>
        private static Dictionary<string, string> _DeskTopGE;

        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        private static Dictionary<string, string> _WebCommonGE;

        /// <summary>
        /// 网站商品页面
        /// </summary>
        private static Dictionary<string, string> _WebProductGE;

        /// <summary>
        /// 网站团购页面
        /// </summary>
        private static Dictionary<string, string> _WebTuanGE;

        /// <summary>
        /// 网站主题套餐页面
        /// </summary>
        private static Dictionary<string, string> _WebThemeGE;


        /// <summary>
        /// 网站帮助
        /// </summary>
        private static Dictionary<string, string> _WebHelpGE;

        /// <summary>
        /// 网站个人中心
        /// </summary>
        private static Dictionary<string, string> _WebAccoutGE;

        #endregion

        #endregion

        #region 意大利文定义变量

        #region 枚举名称
        /// <summary>
        /// _FormWordsIT
        /// </summary>
        private static Dictionary<string, string> _FormWordsIT;

        /// <summary>
        /// 促销类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionTypeIT;

        /// <summary>
        /// 促销条件类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromotionConditionTypeIT;

        /// <summary>
        /// 促销条件匹配类型枚举
        /// </summary>
        private static Dictionary<string, string> _PromConditionFitTypeIT;

        /// <summary>
        /// 促销优惠类型枚举
        /// </summary>
        private static Dictionary<string, string> _GiftsTypeIT;

        /// <summary>
        /// 支付枚举
        /// </summary>
        private static Dictionary<string, string> _PaymentKindIT;

        /// <summary>
        /// 业务操作种类
        /// </summary>
        private static Dictionary<string, string> _OperTypeIDIT;

        /// <summary>
        /// 订单配送类型


        /// </summary>
        private static Dictionary<string, string> _PostTypeIT;

        /// <summary>
        /// 订单状态


        /// </summary>
        private static Dictionary<string, string> _OrdersStatusIT;

        /// <summary>
        /// 账户记录状态


        /// </summary>
        private static Dictionary<string, string> _AccStatusIT;

        /// <summary>
        /// 资讯提问状态


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionStatusIT;

        /// <summary>
        /// 资讯提问属性


        /// </summary>
        private static Dictionary<string, string> _ArticleQuestionTypeIT;

        /// <summary>
        /// 网站公告类别
        /// </summary>
        private static Dictionary<string, string> _NotifyTypeIT;

        /// <summary>
        /// 联盟网站类型
        /// </summary>
        private static Dictionary<string, string> _WebSiteTypeIT;

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        private static Dictionary<string, string> _UnionAccountTypeIT;

        /// <summary>
        /// 网站联盟合作类型
        /// </summary>
        private static Dictionary<string, string> _CooperationTypeIT;

        /// <summary>
        /// 网站频道
        /// </summary>
        private static Dictionary<string, string> _ChannelTypeIT;

        /// <summary>
        /// 支付状态


        /// </summary>
        private static Dictionary<string, string> _PayStatusIT;

        /// <summary>
        /// 礼品兑换状态

        /// </summary>
        private static Dictionary<string, string> _EGiftStatusIT;
        /// <summary>
        /// 产品类型
        /// </summary>
        private static Dictionary<string, string> _ProductTypeIT;
        /// <summary>
        /// 退换货状态


        /// </summary>
        private static Dictionary<string, string> _ReStatusIT;
        /// <summary>
        /// 推荐商品类别
        /// </summary>
        private static Dictionary<string, string> _RecomProKindIT;
        /// <summary>
        /// 入库单状态


        /// </summary>
        private static Dictionary<string, string> _StoreInStatusIT;
        /// <summary>
        /// 库存核算方法
        /// </summary>
        private static Dictionary<string, string> _CostModeIT;

        /// <summary>
        /// 发货单状态



        /// </summary>
        private static Dictionary<string, string> _ShipOrderStatusIT;

        /// <summary>
        /// 出库类型
        /// </summary>
        private static Dictionary<string, string> _StoreOutTypeIT;

        /// <summary>
        /// 入库类型
        /// </summary>
        private static Dictionary<string, string> _StoreInTypeIT;

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        private static Dictionary<string, string> _DefTypeIT;

        /// <summary>
        /// 淘宝订单状态


        /// </summary>
        private static Dictionary<string, string> _TBOrdStatusIT;

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        private static Dictionary<string, string> _TBCarryTypeIT;

        /// <summary>
        /// 网页版块功能
        /// </summary>
        private static Dictionary<string, string> _FunctionIDIT;

        /// <summary>
        /// 客流统计类别
        /// </summary>
        private static Dictionary<string, string> _CusNumTypeIT;

        /// <summary>
        /// 呼叫中心会话类型
        /// </summary>
        private static Dictionary<string, string> _CusChatTypeIT;

        /// <summary>
        /// 退款单状态


        /// </summary>
        private static Dictionary<string, string> _ReMoneyStatusIT;

        /// <summary>
        /// 仓库属性

        /// </summary>
        private static Dictionary<string, string> _StoreHousePropertyIT;


        /// <summary>
        /// 结账点

        /// </summary>
        private static Dictionary<string, string> _CheckoutPointIT;

        /// <summary>
        /// 商品排序规则
        /// </summary>
        private static Dictionary<string, string> _ProSortRuleIT;

        /// <summary>
        /// 商品储存温度属性

        /// </summary>
        private static Dictionary<string, string> _TemperaAttrIT;


        /// <summary>
        /// 采购单退货方式

        /// </summary>
        private static Dictionary<string, string> _PurchaseReturnTypeIT;

        /// <summary>
        /// 采购订单审核条件
        /// </summary>
        private static Dictionary<string, string> _PuchaseCheckConditionIT;

        /// <summary>
        /// 配车单状态

        /// </summary>
        private static Dictionary<string, string> _CarrySheetStatusIT;

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        private static Dictionary<string, string> _AlertSourceTypeIT;

        /// <summary>
        /// 采购类型
        /// </summary>
        private static Dictionary<string, string> _POTypeIT;

        /// <summary>
        /// 销售价格状态

        /// </summary>
        private static Dictionary<string, string> _SalePriceStatusIT;

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        private static Dictionary<string, string> _CusCateConditionTypeIT;

        #endregion

        #region 国际化文字
        /// <summary>
        /// 公共的
        /// </summary>
        private static Dictionary<string, string> _CommonIT;

        /// <summary>
        /// DataList表
        /// </summary>
        private static Dictionary<string, string> _DataListIT;

        /// <summary>
        /// 仓储系统
        /// </summary>
        private static Dictionary<string, string> _StorageIT;

        /// <summary>
        /// 供货系统
        /// </summary>
        private static Dictionary<string, string> _PurchaseIT;

        /// <summary>
        /// 订单系统
        /// </summary>
        private static Dictionary<string, string> _OrderIT;

        /// <summary>
        /// 商品系统
        /// </summary>
        private static Dictionary<string, string> _ProductIT;

        /// <summary>
        /// 仓储设置
        /// </summary>
        private static Dictionary<string, string> _StockIT;

        /// <summary>
        /// 我的菜单
        /// </summary>
        private static Dictionary<string, string> _MenuIT;

        /// <summary>
        /// 员工
        /// </summary>
        private static Dictionary<string, string> _UsersIT;

        /// <summary>
        /// 营销管理
        /// </summary>
        private static Dictionary<string, string> _PromManageIT;

        /// <summary>
        /// 会员管理
        /// </summary>
        private static Dictionary<string, string> _CusManageIT;

        /// <summary>
        /// 网站管理
        /// </summary>
        private static Dictionary<string, string> _WebsiteManageIT;

        /// <summary>
        /// 财务管理
        /// </summary>
        private static Dictionary<string, string> _FinaceManageIT;

        /// <summary>
        /// 系统设置
        /// </summary>
        private static Dictionary<string, string> _SysSetupIT;

        /// <summary>
        /// 桌面 
        /// </summary>
        private static Dictionary<string, string> _DeskTopIT;

        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        private static Dictionary<string, string> _WebCommonIT;

        /// <summary>
        /// 网站商品页面
        /// </summary>
        private static Dictionary<string, string> _WebProductIT;

        /// <summary>
        /// 网站团购页面
        /// </summary>
        private static Dictionary<string, string> _WebTuanIT;

        /// <summary>
        /// 网站主题套餐页面
        /// </summary>
        private static Dictionary<string, string> _WebThemeIT;


        /// <summary>
        /// 网站帮助
        /// </summary>
        private static Dictionary<string, string> _WebHelpIT;

        /// <summary>
        /// 网站个人中心
        /// </summary>
        private static Dictionary<string, string> _WebAccoutIT;

        #endregion

        #endregion

        public static Dictionary<string, string> GetFormWords(AppLanguage lang)
        {
            switch (lang)
            {
                case AppLanguage.CN:
                    return _FormWordsCN;
                case AppLanguage.EN:
                    return _FormWordsEN;
                case AppLanguage.FR:
                    return _FormWordsFR;
                case AppLanguage.GE:
                    return _FormWordsGE;
                case AppLanguage.IT:
                    return _FormWordsIT;
            }
            return null;
        }

        /// <summary>
        /// create by niuyy
        /// 根据语言版本得到下拉框中的项
        /// </summary>
        /// <param name="lang">语言版本</param>
        /// <param name="msgType">枚举类型</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetSelectOption(AppLanguage lang, AppEnumName msgType)
        {
            switch (lang)
            {
                case AppLanguage.CN:
                    switch (msgType)
                    {
                        case AppEnumName.NoEnumName:
                            return _FormWordsCN;
                        case AppEnumName.FieldName:
                        case AppEnumName.Country:
                            break;
                        case AppEnumName.PromotionType:
                            return _PromotionTypeCN;
                        case AppEnumName.OperType:
                            return _OperTypeIDCN;
                        case AppEnumName.SnsOperType:
                            break;
                        case AppEnumName.PromotionConditionType:
                            return _PromotionConditionTypeCN;
                        case AppEnumName.PromConditionFitType:
                            return _PromConditionFitTypeCN;
                        case AppEnumName.PromConditionGiftsType:
                            return _GiftsTypeCN;
                        case AppEnumName.PaymentKind:
                            return _PaymentKindCN;
                        case AppEnumName.PostType:
                            return _PostTypeCN;
                        case AppEnumName.OrdersStatus:
                            return _OrdersStatusCN;
                        case AppEnumName.AccStatus:
                            return _AccStatusCN;
                        case AppEnumName.ArticleQuestionStatus:
                            return _ArticleQuestionStatusCN;
                        case AppEnumName.NotifyType:
                            return _NotifyTypeCN;
                        case AppEnumName.WebSiteType:
                            return _WebSiteTypeCN;
                        case AppEnumName.UnionAccountType:
                            return _UnionAccountTypeCN;
                        case AppEnumName.CooperationType:
                            return _CooperationTypeCN;
                        case AppEnumName.ChannelType:
                            return _ChannelTypeCN;
                        case AppEnumName.ArticleQuestionType:
                            return _ArticleQuestionTypeCN;
                        case AppEnumName.EGiftStatus:
                            return _EGiftStatusCN;
                        case AppEnumName.ProductType:
                            return _ProductTypeCN;
                        case AppEnumName.OrderType:
                            return _OrderTypeCN;
                        case AppEnumName.CusVerifyStatus:
                            return _CusVerifyStatusCN;
                        case AppEnumName.ReStatus:
                            return _ReStatusCN;
                        case AppEnumName.StoreInStatus:
                            return _StoreInStatusCN;
                        case AppEnumName.CostMode:
                            return _CostModeCN;
                        case AppEnumName.ShipOrderStatus:
                            return _ShipOrderStatusCN;
                        case AppEnumName.StoreOutType:
                            return _StoreOutTypeCN;
                        case AppEnumName.StoreInType:
                            return _StoreInTypeCN;
                        case AppEnumName.DefType:
                            return _DefTypeCN;
                        case AppEnumName.TBOrdStatus:
                            return _TBOrdStatusCN;
                        case AppEnumName.TBCarryType:
                            return _TBCarryTypeCN;
                        case AppEnumName.FunctionID:
                            return _FunctionIDCN;
                        case AppEnumName.CusNumType:
                            return _CusNumTypeCN;
                        case AppEnumName.CusChatType:
                            return _CusChatTypeCN;
                        case AppEnumName.ReMoneyStatus:
                            return _ReMoneyStatusCN;
                        case AppEnumName.StoreHouseProperty:
                            return _StoreHousePropertyCN;
                        case AppEnumName.PuchaseCheckCondition:
                            return _PuchaseCheckConditionCN;
                        case AppEnumName.CheckStatus:
                            return _CheckStatusCN;
                        case AppEnumName.CheckoutPoint:
                            return _CheckoutPointCN;
                        case AppEnumName.ProSortRule:
                            return _ProSortRuleCN;
                        case AppEnumName.TemperaAttr:
                            return _TemperaAttrCN;
                        case AppEnumName.PurchaseReturnType:
                            return _PurchaseReturnTypeCN;
                        case AppEnumName.CarrySheetStatus:
                            return _CarrySheetStatusCN;
                        case AppEnumName.AlertSourceType:
                            return _AlertSourceTypeCN;
                        case AppEnumName.POType:
                            return _POTypeCN;
                        case AppEnumName.SalePriceStatus:
                            return _SalePriceStatusCN;
                        case AppEnumName.StockDealStatus:
                            return _StockDealStatusCN;
                        case AppEnumName.PayStatus:
                            return _PayStatusCN;
                        case AppEnumName.CusCateConditionType:
                            return _CusCateConditionTypeCN;
                        case AppEnumName.ProPromCataID:
                            return _ProPromCataIDCN;
                        case AppEnumName.TousuType:
                            return _TousuTypeCN;
                        case AppEnumName.packageType:
                            return _PackageTypeCN;
                        case AppEnumName.BakTemplateType:
                            return _BakTemplateTypeCN;
                        case AppEnumName.BalanceType:
                            return _BalanceTypeCN;
                        case AppEnumName.BalanceStatus:
                            return _BalanceStatusCN;
                        case AppEnumName.ProvNavLinkType:
                            return _ProvNavLinkTypeCN;
                        case AppEnumName.ReAmountStatus:
                            return _ReAmountStatusCN;

                    }
                    break;

                case AppLanguage.EN:
                    switch (msgType)
                    {
                        case AppEnumName.NoEnumName:
                            return _FormWordsEN;
                        case AppEnumName.FieldName:
                        case AppEnumName.Country:
                            break;
                        case AppEnumName.PromotionType:
                            return _PromotionTypeEN;
                        case AppEnumName.OperType:
                            return _OperTypeIDEN;
                        case AppEnumName.SnsOperType:
                            break;
                        case AppEnumName.PromotionConditionType:
                            return _PromotionConditionTypeEN;
                        case AppEnumName.PromConditionFitType:
                            return _PromConditionFitTypeEN;
                        case AppEnumName.PromConditionGiftsType:
                            return _GiftsTypeEN;
                        case AppEnumName.PaymentKind:
                            return _PaymentKindEN;
                        case AppEnumName.PostType:
                            return _PostTypeEN;
                        case AppEnumName.OrdersStatus:
                            return _OrdersStatusEN;
                        case AppEnumName.AccStatus:
                            return _AccStatusEN;
                        case AppEnumName.ArticleQuestionStatus:
                            return _ArticleQuestionStatusEN;
                        case AppEnumName.NotifyType:
                            return _NotifyTypeEN;
                        case AppEnumName.WebSiteType:
                            return _WebSiteTypeEN;
                        case AppEnumName.UnionAccountType:
                            return _UnionAccountTypeEN;
                        case AppEnumName.CooperationType:
                            return _CooperationTypeEN;
                        case AppEnumName.ChannelType:
                            return _ChannelTypeEN;
                        case AppEnumName.ArticleQuestionType:
                            return _ArticleQuestionTypeEN;
                        case AppEnumName.EGiftStatus:
                            return _EGiftStatusEN;
                        case AppEnumName.ProductType:
                            return _ProductTypeEN;
                        case AppEnumName.ReStatus:
                            return _ReStatusEN;
                        case AppEnumName.StoreInStatus:
                            return _StoreInStatusEN;
                        case AppEnumName.CostMode:
                            return _CostModeEN;
                        case AppEnumName.ShipOrderStatus:
                            return _ShipOrderStatusEN;
                        case AppEnumName.StoreOutType:
                            return _StoreOutTypeEN;
                        case AppEnumName.StoreInType:
                            return _StoreInTypeEN;
                        case AppEnumName.DefType:
                            return _DefTypeEN;
                        case AppEnumName.TBOrdStatus:
                            return _TBOrdStatusEN;
                        case AppEnumName.TBCarryType:
                            return _TBCarryTypeEN;
                        case AppEnumName.FunctionID:
                            return _FunctionIDEN;
                        case AppEnumName.CusNumType:
                            return _CusNumTypeEN;
                        case AppEnumName.CusChatType:
                            return _CusChatTypeEN;
                        case AppEnumName.ReMoneyStatus:
                            return _ReMoneyStatusEN;
                        case AppEnumName.StoreHouseProperty:
                            return _StoreHousePropertyEN;
                        case AppEnumName.CheckoutPoint:
                            return _CheckoutPointEN;
                        case AppEnumName.ProSortRule:
                            return _ProSortRuleEN;
                        case AppEnumName.TemperaAttr:
                            return _TemperaAttrEN;
                        case AppEnumName.PurchaseReturnType:
                            return _PurchaseReturnTypeEN;
                        case AppEnumName.PuchaseCheckCondition:
                            return _PuchaseCheckConditionEN;
                        case AppEnumName.CarrySheetStatus:
                            return _CarrySheetStatusEN;
                        case AppEnumName.AlertSourceType:
                            return _AlertSourceTypeEN;
                        case AppEnumName.POType:
                            return _POTypeEN;
                        case AppEnumName.SalePriceStatus:
                            return _SalePriceStatusEN;
                        case AppEnumName.StockDealStatus:
                            return _StockDealStatusEN;
                        case AppEnumName.CusCateConditionType:
                            return _CusCateConditionTypeEN;
                    }
                    break;

                case AppLanguage.FR:
                    switch (msgType)
                    {
                        case AppEnumName.NoEnumName:
                            return _FormWordsFR;
                        case AppEnumName.FieldName:
                        case AppEnumName.Country:
                            break;
                        case AppEnumName.PromotionType:
                            return _PromotionTypeFR;
                        case AppEnumName.OperType:
                            return _OperTypeIDFR;
                        case AppEnumName.SnsOperType:
                            break;
                        case AppEnumName.PromotionConditionType:
                            return _PromotionConditionTypeFR;
                        case AppEnumName.PromConditionFitType:
                            return _PromConditionFitTypeFR;
                        case AppEnumName.PromConditionGiftsType:
                            return _GiftsTypeFR;
                        case AppEnumName.PaymentKind:
                            return _PaymentKindFR;
                        case AppEnumName.PostType:
                            return _PostTypeFR;
                        case AppEnumName.OrdersStatus:
                            return _OrdersStatusFR;
                        case AppEnumName.AccStatus:
                            return _AccStatusFR;
                        case AppEnumName.ArticleQuestionStatus:
                            return _ArticleQuestionStatusFR;
                        case AppEnumName.NotifyType:
                            return _NotifyTypeFR;
                        case AppEnumName.WebSiteType:
                            return _WebSiteTypeFR;
                        case AppEnumName.UnionAccountType:
                            return _UnionAccountTypeFR;
                        case AppEnumName.CooperationType:
                            return _CooperationTypeFR;
                        case AppEnumName.ChannelType:
                            return _ChannelTypeFR;
                        case AppEnumName.ArticleQuestionType:
                            return _ArticleQuestionTypeFR;
                        case AppEnumName.EGiftStatus:
                            return _EGiftStatusFR;
                        case AppEnumName.ProductType:
                            return _ProductTypeFR;
                        case AppEnumName.ReStatus:
                            return _ReStatusFR;
                        case AppEnumName.StoreInStatus:
                            return _StoreInStatusFR;
                        case AppEnumName.CostMode:
                            return _CostModeFR;
                        case AppEnumName.ShipOrderStatus:
                            return _ShipOrderStatusFR;
                        case AppEnumName.StoreOutType:
                            return _StoreOutTypeFR;
                        case AppEnumName.StoreInType:
                            return _StoreInTypeFR;
                        case AppEnumName.DefType:
                            return _DefTypeFR;
                        case AppEnumName.TBOrdStatus:
                            return _TBOrdStatusFR;
                        case AppEnumName.TBCarryType:
                            return _TBCarryTypeFR;
                        case AppEnumName.FunctionID:
                            return _FunctionIDFR;
                        case AppEnumName.CusNumType:
                            return _CusNumTypeFR;
                        case AppEnumName.CusChatType:
                            return _CusChatTypeFR;
                        case AppEnumName.ReMoneyStatus:
                            return _ReMoneyStatusFR;
                        case AppEnumName.StoreHouseProperty:
                            return _StoreHousePropertyFR;
                        case AppEnumName.CheckoutPoint:
                            return _CheckoutPointFR;
                        case AppEnumName.ProSortRule:
                            return _ProSortRuleFR;
                        case AppEnumName.TemperaAttr:
                            return _TemperaAttrFR;
                        case AppEnumName.PurchaseReturnType:
                            return _PurchaseReturnTypeFR;
                        case AppEnumName.PuchaseCheckCondition:
                            return _PuchaseCheckConditionFR;
                        case AppEnumName.CarrySheetStatus:
                            return _CarrySheetStatusFR;
                        case AppEnumName.AlertSourceType:
                            return _AlertSourceTypeFR;
                        case AppEnumName.POType:
                            return _POTypeFR;
                        case AppEnumName.SalePriceStatus:
                            return _SalePriceStatusFR;
                        case AppEnumName.CusCateConditionType:
                            return _CusCateConditionTypeFR;
                    }
                    break;

                case AppLanguage.GE:
                    switch (msgType)
                    {
                        case AppEnumName.NoEnumName:
                            return _FormWordsGE;
                        case AppEnumName.FieldName:
                        case AppEnumName.Country:
                            break;
                        case AppEnumName.PromotionType:
                            return _PromotionTypeGE;
                        case AppEnumName.OperType:
                            return _OperTypeIDGE;
                        case AppEnumName.SnsOperType:
                            break;
                        case AppEnumName.PromotionConditionType:
                            return _PromotionConditionTypeGE;
                        case AppEnumName.PromConditionFitType:
                            return _PromConditionFitTypeGE;
                        case AppEnumName.PromConditionGiftsType:
                            return _GiftsTypeGE;
                        case AppEnumName.PaymentKind:
                            return _PaymentKindGE;
                        case AppEnumName.PostType:
                            return _PostTypeGE;
                        case AppEnumName.OrdersStatus:
                            return _OrdersStatusGE;
                        case AppEnumName.AccStatus:
                            return _AccStatusGE;
                        case AppEnumName.ArticleQuestionStatus:
                            return _ArticleQuestionStatusGE;
                        case AppEnumName.NotifyType:
                            return _NotifyTypeGE;
                        case AppEnumName.WebSiteType:
                            return _WebSiteTypeGE;
                        case AppEnumName.UnionAccountType:
                            return _UnionAccountTypeGE;
                        case AppEnumName.CooperationType:
                            return _CooperationTypeGE;
                        case AppEnumName.ChannelType:
                            return _ChannelTypeGE;
                        case AppEnumName.ArticleQuestionType:
                            return _ArticleQuestionTypeGE;
                        case AppEnumName.EGiftStatus:
                            return _EGiftStatusGE;
                        case AppEnumName.ProductType:
                            return _ProductTypeGE;
                        case AppEnumName.ReStatus:
                            return _ReStatusGE;
                        case AppEnumName.StoreInStatus:
                            return _StoreInStatusGE;
                        case AppEnumName.CostMode:
                            return _CostModeGE;
                        case AppEnumName.ShipOrderStatus:
                            return _ShipOrderStatusGE;
                        case AppEnumName.StoreOutType:
                            return _StoreOutTypeGE;
                        case AppEnumName.StoreInType:
                            return _StoreInTypeGE;
                        case AppEnumName.DefType:
                            return _DefTypeGE;
                        case AppEnumName.TBOrdStatus:
                            return _TBOrdStatusGE;
                        case AppEnumName.TBCarryType:
                            return _TBCarryTypeGE;
                        case AppEnumName.FunctionID:
                            return _FunctionIDGE;
                        case AppEnumName.CusNumType:
                            return _CusNumTypeGE;
                        case AppEnumName.CusChatType:
                            return _CusChatTypeGE;
                        case AppEnumName.ReMoneyStatus:
                            return _ReMoneyStatusGE;
                        case AppEnumName.StoreHouseProperty:
                            return _StoreHousePropertyGE;
                        case AppEnumName.CheckoutPoint:
                            return _CheckoutPointGE;
                        case AppEnumName.ProSortRule:
                            return _ProSortRuleGE;
                        case AppEnumName.TemperaAttr:
                            return _TemperaAttrGE;
                        case AppEnumName.PurchaseReturnType:
                            return _PurchaseReturnTypeGE;
                        case AppEnumName.PuchaseCheckCondition:
                            return _PuchaseCheckConditionGE;
                        case AppEnumName.CarrySheetStatus:
                            return _CarrySheetStatusGE;
                        case AppEnumName.AlertSourceType:
                            return _AlertSourceTypeGE;
                        case AppEnumName.POType:
                            return _POTypeGE;
                        case AppEnumName.SalePriceStatus:
                            return _SalePriceStatusGE;
                        case AppEnumName.CusCateConditionType:
                            return _CusCateConditionTypeGE;
                    }
                    break;

                case AppLanguage.IT:
                    switch (msgType)
                    {
                        case AppEnumName.NoEnumName:
                            return _FormWordsIT;
                        case AppEnumName.FieldName:
                        case AppEnumName.Country:
                            break;
                        case AppEnumName.PromotionType:
                            return _PromotionTypeIT;
                        case AppEnumName.OperType:
                            return _OperTypeIDIT;
                        case AppEnumName.SnsOperType:
                            break;
                        case AppEnumName.PromotionConditionType:
                            return _PromotionConditionTypeIT;
                        case AppEnumName.PromConditionFitType:
                            return _PromConditionFitTypeIT;
                        case AppEnumName.PromConditionGiftsType:
                            return _GiftsTypeIT;
                        case AppEnumName.PaymentKind:
                            return _PaymentKindIT;
                        case AppEnumName.PostType:
                            return _PostTypeIT;
                        case AppEnumName.OrdersStatus:
                            return _OrdersStatusIT;
                        case AppEnumName.AccStatus:
                            return _AccStatusIT;
                        case AppEnumName.ArticleQuestionStatus:
                            return _ArticleQuestionStatusIT;
                        case AppEnumName.NotifyType:
                            return _NotifyTypeIT;
                        case AppEnumName.WebSiteType:
                            return _WebSiteTypeIT;
                        case AppEnumName.UnionAccountType:
                            return _UnionAccountTypeIT;
                        case AppEnumName.CooperationType:
                            return _CooperationTypeIT;
                        case AppEnumName.ChannelType:
                            return _ChannelTypeIT;
                        case AppEnumName.ArticleQuestionType:
                            return _ArticleQuestionTypeIT;
                        case AppEnumName.EGiftStatus:
                            return _EGiftStatusIT;
                        case AppEnumName.ProductType:
                            return _ProductTypeIT;
                        case AppEnumName.ReStatus:
                            return _ReStatusIT;
                        case AppEnumName.StoreInStatus:
                            return _StoreInStatusIT;
                        case AppEnumName.CostMode:
                            return _CostModeIT;
                        case AppEnumName.ShipOrderStatus:
                            return _ShipOrderStatusIT;
                        case AppEnumName.StoreOutType:
                            return _StoreOutTypeIT;
                        case AppEnumName.StoreInType:
                            return _StoreInTypeIT;
                        case AppEnumName.DefType:
                            return _DefTypeIT;
                        case AppEnumName.TBOrdStatus:
                            return _TBOrdStatusIT;
                        case AppEnumName.TBCarryType:
                            return _TBCarryTypeIT;
                        case AppEnumName.FunctionID:
                            return _FunctionIDIT;
                        case AppEnumName.CusNumType:
                            return _CusNumTypeIT;
                        case AppEnumName.CusChatType:
                            return _CusChatTypeIT;
                        case AppEnumName.ReMoneyStatus:
                            return _ReMoneyStatusIT;
                        case AppEnumName.StoreHouseProperty:
                            return _StoreHousePropertyIT;
                        case AppEnumName.CheckoutPoint:
                            return _CheckoutPointIT;
                        case AppEnumName.ProSortRule:
                            return _ProSortRuleIT;
                        case AppEnumName.TemperaAttr:
                            return _TemperaAttrIT;
                        case AppEnumName.PurchaseReturnType:
                            return _PurchaseReturnTypeIT;
                        case AppEnumName.PuchaseCheckCondition:
                            return _PuchaseCheckConditionIT;
                        case AppEnumName.CarrySheetStatus:
                            return _CarrySheetStatusIT;
                        case AppEnumName.AlertSourceType:
                            return _AlertSourceTypeIT;
                        case AppEnumName.POType:
                            return _POTypeIT;
                        case AppEnumName.SalePriceStatus:
                            return _SalePriceStatusIT;
                        case AppEnumName.CusCateConditionType:
                            return _CusCateConditionTypeIT;
                        case AppEnumName.ServiceStatus:
                            return _ServiceStatusCN;
                    }
                    break;
            }
            return null;
        }

        /// <summary>
        /// create by minzw
        /// 根据语言版本得到国际化的显示文本
        /// </summary>
        /// <param name="lang">语言版本</param>
        /// <param name="msgType">枚举类型</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetSelectOption(AppLanguage lang, Internationalization interType)
        {
            switch (lang)
            {
                case AppLanguage.CN:
                    switch (interType)
                    {
                        case Internationalization.Common:
                            return _CommonCN;
                        case Internationalization.DataList:
                            return _DataListCN;
                        case Internationalization.Storage:
                            return _StorageCN;
                        case Internationalization.Purchasing:
                            return _PurchaseCN;
                        case Internationalization.OrderSys:
                            return _OrderCN;
                        case Internationalization.ProductSys:
                            return _ProductCN;
                        case Internationalization.StockSet:
                            return _StockCN;
                        case Internationalization.MyMenu:
                            return _MenuCN;
                        case Internationalization.Users:
                            return _UsersCN;
                        case Internationalization.PromManage:
                            return _PromManageCN;
                        case Internationalization.CustomerManage:
                            return _CusManageCN;
                        case Internationalization.WebsiteManage:
                            return _WebsiteManageCN;
                        case Internationalization.FinaceManage:
                            return _FinaceManageCN;
                        case Internationalization.SysSetup:
                            return _SysSetupCN;
                        case Internationalization.DeskTop:
                            return _DeskTopCN;
                        case Internationalization.WebCommon:
                            return _WebCommonCN;
                        case Internationalization.WebProduct:
                            return _WebProductCN;
                        case Internationalization.WebTuan:
                            return _WebTuanCN;
                        case Internationalization.WebTheme:
                            return _WebThemeCN;
                        case Internationalization.WebHelp:
                            return _WebHelpCN;
                        case Internationalization.WebAccout:
                            return _WebAccoutCN;
                    }
                    break;

                case AppLanguage.EN:
                    switch (interType)
                    {
                        case Internationalization.Common:
                            return _CommonEN;
                        case Internationalization.DataList:
                            return _DataListEN;
                        case Internationalization.Storage:
                            return _StorageEN;
                        case Internationalization.Purchasing:
                            return _PurchaseEN;
                        case Internationalization.OrderSys:
                            return _OrderEN;
                        case Internationalization.ProductSys:
                            return _ProductEN;
                        case Internationalization.StockSet:
                            return _StockEN;
                        case Internationalization.MyMenu:
                            return _MenuEN;
                        case Internationalization.Users:
                            return _UsersEN;
                        case Internationalization.PromManage:
                            return _PromManageEN;
                        case Internationalization.CustomerManage:
                            return _CusManageEN;
                        case Internationalization.WebsiteManage:
                            return _WebsiteManageEN;
                        case Internationalization.FinaceManage:
                            return _FinaceManageEN;
                        case Internationalization.SysSetup:
                            return _SysSetupEN;
                        case Internationalization.DeskTop:
                            return _DeskTopEN;
                        case Internationalization.WebCommon:
                            return _WebCommonEN;
                        case Internationalization.WebProduct:
                            return _WebProductEN;
                        case Internationalization.WebTuan:
                            return _WebTuanEN;
                        case Internationalization.WebTheme:
                            return _WebThemeEN;
                        case Internationalization.WebHelp:
                            return _WebHelpEN;
                        case Internationalization.WebAccout:
                            return _WebAccoutEN;
                    }
                    break;

                case AppLanguage.FR:
                    switch (interType)
                    {
                        case Internationalization.Common:
                            return _CommonFR;
                        case Internationalization.DataList:
                            return _DataListFR;
                        case Internationalization.Storage:
                            return _StorageFR;
                        case Internationalization.Purchasing:
                            return _PurchaseFR;
                        case Internationalization.OrderSys:
                            return _OrderFR;
                        case Internationalization.ProductSys:
                            return _ProductFR;
                        case Internationalization.StockSet:
                            return _StockFR;
                        case Internationalization.MyMenu:
                            return _MenuFR;
                        case Internationalization.Users:
                            return _UsersFR;
                        case Internationalization.PromManage:
                            return _PromManageFR;
                        case Internationalization.CustomerManage:
                            return _CusManageFR;
                        case Internationalization.WebsiteManage:
                            return _WebsiteManageFR;
                        case Internationalization.FinaceManage:
                            return _FinaceManageFR;
                        case Internationalization.SysSetup:
                            return _SysSetupFR;
                        case Internationalization.DeskTop:
                            return _DeskTopFR;
                        case Internationalization.WebCommon:
                            return _WebCommonFR;
                        case Internationalization.WebProduct:
                            return _WebProductFR;
                        case Internationalization.WebTuan:
                            return _WebTuanFR;
                        case Internationalization.WebTheme:
                            return _WebThemeFR;
                        case Internationalization.WebHelp:
                            return _WebHelpFR;
                        case Internationalization.WebAccout:
                            return _WebAccoutFR;
                    }
                    break;

                case AppLanguage.GE:
                    switch (interType)
                    {
                        case Internationalization.Common:
                            return _CommonGE;
                        case Internationalization.DataList:
                            return _DataListGE;
                        case Internationalization.Storage:
                            return _StorageGE;
                        case Internationalization.Purchasing:
                            return _PurchaseGE;
                        case Internationalization.OrderSys:
                            return _OrderGE;
                        case Internationalization.ProductSys:
                            return _ProductGE;
                        case Internationalization.StockSet:
                            return _StockGE;
                        case Internationalization.MyMenu:
                            return _MenuGE;
                        case Internationalization.Users:
                            return _UsersGE;
                        case Internationalization.PromManage:
                            return _PromManageGE;
                        case Internationalization.CustomerManage:
                            return _CusManageGE;
                        case Internationalization.WebsiteManage:
                            return _WebsiteManageGE;
                        case Internationalization.FinaceManage:
                            return _FinaceManageGE;
                        case Internationalization.SysSetup:
                            return _SysSetupGE;
                        case Internationalization.DeskTop:
                            return _DeskTopGE;
                        case Internationalization.WebCommon:
                            return _WebCommonGE;
                        case Internationalization.WebProduct:
                            return _WebProductGE;
                        case Internationalization.WebTuan:
                            return _WebTuanGE;
                        case Internationalization.WebTheme:
                            return _WebThemeGE;
                        case Internationalization.WebHelp:
                            return _WebHelpGE;
                        case Internationalization.WebAccout:
                            return _WebAccoutGE;
                    }
                    break;


                case AppLanguage.IT:
                    switch (interType)
                    {
                        case Internationalization.Common:
                            return _CommonIT;
                        case Internationalization.DataList:
                            return _DataListIT;
                        case Internationalization.Storage:
                            return _StorageIT;
                        case Internationalization.Purchasing:
                            return _PurchaseIT;
                        case Internationalization.OrderSys:
                            return _OrderIT;
                        case Internationalization.ProductSys:
                            return _ProductIT;
                        case Internationalization.StockSet:
                            return _StockIT;
                        case Internationalization.MyMenu:
                            return _MenuIT;
                        case Internationalization.Users:
                            return _UsersIT;
                        case Internationalization.PromManage:
                            return _PromManageIT;
                        case Internationalization.CustomerManage:
                            return _CusManageIT;
                        case Internationalization.WebsiteManage:
                            return _WebsiteManageIT;
                        case Internationalization.FinaceManage:
                            return _FinaceManageIT;
                        case Internationalization.SysSetup:
                            return _SysSetupIT;
                        case Internationalization.DeskTop:
                            return _DeskTopIT;
                        case Internationalization.WebCommon:
                            return _WebCommonIT;
                        case Internationalization.WebProduct:
                            return _WebProductIT;
                        case Internationalization.WebTuan:
                            return _WebTuanIT;
                        case Internationalization.WebTheme:
                            return _WebThemeIT;
                        case Internationalization.WebHelp:
                            return _WebHelpIT;
                        case Internationalization.WebAccout:
                            return _WebAccoutIT;
                    }
                    break;

            }
            return null;
        }

        /// <summary>
        /// 应用程序加载时讲配置文件信息读取到内存中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static void ReadMessageConfigCN(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\zh-cn.xml");
            foreach (XmlNode node in doc.SelectSingleNode("//root").ChildNodes)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (!node.HasChildNodes)
                {
                    continue;
                }

                foreach (XmlNode nodec in node.ChildNodes)
                {
                    if (nodec.NodeType != XmlNodeType.Element)
                        continue;
                    if (nodec.Attributes["value"] != null)
                    {
                        try
                        {
                            dic.Add(nodec.Attributes["value"].Value, nodec.InnerText);
                        }
                        catch (Exception)
                        {
                            HttpContext.Current.Response.Write(node.Name + " 字典中 " + nodec.Attributes["value"].Value + " " + nodec.InnerText + " 重复");
                        }
                    }
                }

                switch (node.Name)
                {
                    case "FormWords":
                        _FormWordsCN = dic;
                        break;
                    case "PromotionType":
                        _PromotionTypeCN = dic;
                        break;
                    case "PromotionConditionType":
                        _PromotionConditionTypeCN = dic;
                        break;
                    case "PromConditionFitType":
                        _PromConditionFitTypeCN = dic;
                        break;
                    case "GiftsType":
                        _GiftsTypeCN = dic;
                        break;
                    case "PaymentKind":
                        _PaymentKindCN = dic;
                        break;
                    case "OperTypeID":
                        _OperTypeIDCN = dic;
                        break;
                    case "PostType":
                        _PostTypeCN = dic;
                        break;
                    case "OrdersStatus":
                        _OrdersStatusCN = dic;
                        break;
                    case "AccStatus":
                        _AccStatusCN = dic;
                        break;
                    case "ArticleQuestionStatus":
                        _ArticleQuestionStatusCN = dic;
                        break;
                    case "NotifyType":
                        _NotifyTypeCN = dic;
                        break;
                    case "WebSiteType":
                        _WebSiteTypeCN = dic;
                        break;
                    case "UnionAccountType":
                        _UnionAccountTypeCN = dic;
                        break;
                    case "CooperationType":
                        _CooperationTypeCN = dic;
                        break;
                    case "ChannelType":
                        _ChannelTypeCN = dic;
                        break;
                    case "ArticleQuestionType":
                        _ArticleQuestionTypeCN = dic;
                        break;
                    case "PayStatus":
                        _PayStatusCN = dic;
                        break;
                    case "EGiftStatus":
                        _EGiftStatusCN = dic;
                        break;
                    case "ProductType":
                        _ProductTypeCN = dic;
                        break;
                    case "OrderType":
                        _OrderTypeCN = dic;
                        break;
                    case "CusVerifyStatus":
                        _CusVerifyStatusCN = dic;
                        break;
                    case "ReStatus":
                        _ReStatusCN = dic;
                        break;
                    case "RecomProKind":
                        _RecomProKindCN = dic;
                        break;
                    case "StoreInStatus":
                        _StoreInStatusCN = dic;
                        break;
                    case "CostMode":
                        _CostModeCN = dic;
                        break;
                    case "ShipOrderStatus":
                        _ShipOrderStatusCN = dic;
                        break;
                    case "StoreOutType":
                        _StoreOutTypeCN = dic;
                        break;
                    case "StoreInType":
                        _StoreInTypeCN = dic;
                        break;
                    case "DefType":
                        _DefTypeCN = dic;
                        break;
                    case "TBOrdStatus":
                        _TBOrdStatusCN = dic;
                        break;
                    case "TBCarryType":
                        _TBCarryTypeCN = dic;
                        break;
                    case "FunctionID":
                        _FunctionIDCN = dic;
                        break;
                    case "CusNumType":
                        _CusNumTypeCN = dic;
                        break;
                    case "CusChatType":
                        _CusChatTypeCN = dic;
                        break;
                    case "ReMoneyStatus":
                        _ReMoneyStatusCN = dic;
                        break;
                    case "Common":
                        _CommonCN = dic;
                        break;
                    case "DataList":
                        _DataListCN = dic;
                        break;
                    case "Storage":
                        _StorageCN = dic;
                        break;
                    case "Purchasing":
                        _PurchaseCN = dic;
                        break;
                    case "Order":
                        _OrderCN = dic;
                        break;
                    case "ProductManage":
                        _ProductCN = dic;
                        break;
                    case "StockSet":
                        _StockCN = dic;
                        break;
                    case "MyMenu":
                        _MenuCN = dic;
                        break;
                    case "HR":
                        _UsersCN = dic;
                        break;
                    case "Marketing":
                        _PromManageCN = dic;
                        break;
                    case "StoreHouseProperty":
                        _StoreHousePropertyCN = dic;
                        break;
                    case "PuchaseCheckCondition":
                        _PuchaseCheckConditionCN = dic;
                        break;
                    case "CheckStatus":
                        _CheckStatusCN = dic;
                        break;
                    case "Customer":
                        _CusManageCN = dic;
                        break;
                    case "WebSiteManage":
                        _WebsiteManageCN = dic;
                        break;
                    case "FinaceManange":
                        _FinaceManageCN = dic;
                        break;
                    case "SysSetup":
                        _SysSetupCN = dic;
                        break;
                    case "CheckoutPoint":
                        _CheckoutPointCN = dic;
                        break;
                    case "ProSortRule":
                        _ProSortRuleCN = dic;
                        break;
                    case "TemperaAttr":
                        _TemperaAttrCN = dic;
                        break;
                    case "PurchaseReturnType":
                        _PurchaseReturnTypeCN = dic;
                        break;
                    case "CarrySheetStatus":
                        _CarrySheetStatusCN = dic;
                        break;
                    case "AlertSourceType":
                        _AlertSourceTypeCN = dic;
                        break;
                    case "DeskTop":
                        _DeskTopCN = dic;
                        break;

                    case "WebCommon":
                        _WebCommonCN = dic;
                        break;

                    case "WebProduct":
                        _WebProductCN = dic;
                        break;
                    case "WebTuan":
                        _WebTuanCN = dic;
                        break;
                    case "WebTheme":
                        _WebThemeCN = dic;
                        break;
                    case "WebHelp":
                        _WebHelpCN = dic;
                        break;
                    case "WebAccout":
                        _WebAccoutCN = dic;
                        break;
                    case "POType":
                        _POTypeCN = dic;
                        break;
                    case "SalePriceStatus":
                        _SalePriceStatusCN = dic;
                        break;
                    case "StockDealStatus":
                        _StockDealStatusCN = dic;
                        break;
                    case "CusCateConditionType":
                        _CusCateConditionTypeCN = dic;
                        break;
                    case "ProPromCataID":
                        _ProPromCataIDCN = dic;
                        break;
                    case "TousuType":
                        _TousuTypeCN = dic;
                        break;
                    case "packageType":
                        _PackageTypeCN = dic;
                        break;
                    case "BakTemplateType":
                        _BakTemplateTypeCN = dic;
                        break;
                    case "BalanceStatus":
                        _BalanceStatusCN = dic;
                        break;
                    case "BalanceType":
                        _BalanceTypeCN = dic;
                        break;
                    case "ProvNavLinkType":
                        _ProvNavLinkTypeCN = dic;
                        break;
                    case "MsgSellerMenu":
                        _MsgSellerMenuCN = dic;
                        break;
                    case "MsgSellerHead":
                        _MsgSellerHeadCN = dic;
                        break;
                    case "MsgSelOrderList":
                        _MsgSelOrderListCN = dic;
                        break;
                    case "MsgSelOrderDetail":
                        _MsgSelOrderDetailCN = dic;
                        break;
                    case "MsgSelShipOrderList":
                        _MsgSelShipOrderListCN = dic;
                        break;
                    case "MsgSelShipOrderDetail":
                        _MsgSelShipOrderDetailCN = dic;
                        break;
                    case "MsgSelOrderReGoodsList":
                        _MsgSelOrderReGoodsListCN = dic;
                        break;
                    case "MsgSelOrderReGoodsDetail":
                        _MsgSelOrderReGoodsDetailCN = dic;
                        break;
                    case "MsgSelOrderMark":
                        _MsgSelOrderMarkCN = dic;
                        break;
                    case "MsgSelNavAdFlashPicInfo":
                        _MsgSelNavAdFlashPicInfoCN = dic;
                        break;
                    case "MsgSelProductChoiceProCata":
                        _MsgSelProductChoiceProCataCN = dic;
                        break;
                    case "MsgSelProductDetail":
                        _MsgSelProductDetailCN = dic;
                        break;
                    case "MsgSelProductProductTj":
                        _MsgSelProductProductTjCN = dic;
                        break;
                    case "MsSelProductList":
                        _MsSelProductListCN = dic;
                        break;
                    case "MsgProductStoreList":
                        _MsgProductStoreListCN = dic;
                        break;
                    case "MsgPromotionLimitTjInfo":
                        _MsgPromotionLimitTjInfoCN = dic;
                        break;
                    case "MsgPromotionLimitTjList":
                        _MsgPromotionLimitTjListCN = dic;
                        break;
                    case "MsgPromotionPackageInfo":
                        _MsgPromotionPackageInfoCN = dic;
                        break;
                    case "MsgPromotionPackageList":
                        _MsgPromotionPackageListCN = dic;
                        break;
                    case "MsgPromotionProInfo":
                        _MsgPromotionProInfoCN = dic;
                        break;
                    case "MsgPromotionProInfo2":
                        _MsgPromotionProInfo2CN = dic;
                        break;
                    case "MsgPromotionInfo3":
                        _MsgPromotionInfo3CN = dic;
                        break;
                    case "MsgPromotionList":
                        _MsgPromotionListCN = dic;
                        break;
                    case "MsgServiceAfterML":
                        _MsgServiceAfterMLCN = dic;
                        break;
                    case "MsgServiceCompList":
                        _MsgServiceCompListCN = dic;
                        break;
                    case "MsgServiceConsultingList":
                        _MsgServiceConsultingListCN = dic;
                        break;
                    case "MsgSetupCarryTemp":
                        _MsgSetupCarryTempCN = dic;
                        break;
                    case "MseSetupCarryTempList":
                        _MseSetupCarryTempListCN = dic;
                        break;
                    case "MseSetupConsumerPro":
                        _MseSetupConsumerProCN = dic;
                        break;

                    case "MsgSelOrderReGoodsConfirm":
                        _MsgSelOrderReGoodsConfirmCN = dic;
                        break;
                    case "MsgSelOrderModPrice":
                        _MsgSelOrderModPriceCN = dic;
                        break;
                    case "MsgSelOrderRefRegoods":
                        _MsgSelOrderRefRegoodsCN = dic;
                        break;

                    case "DeliveryBase":
                        _DeliveryBaseCN = dic;
                        break;
                    case "MsgSelReviewManage":
                        _MsgSelReviewManageCN = dic;
                        break;
                    case "ServiceStatus":
                        _ServiceStatusCN = dic;
                        break;
                    case "MsgPageBase":
                        _MsgPageBaseCN = dic;
                        break;
                    case "ReAmountStatus":
                        _ReAmountStatusCN = dic;
                        break;
                }
            }
        }


        /// <summary>
        /// 应用程序加载时讲配置文件信息读取到内存中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static void ReadMessageConfigEN(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\en-us.xml");
            foreach (XmlNode node in doc.SelectSingleNode("//root").ChildNodes)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (!node.HasChildNodes)
                {
                    continue;
                }

                foreach (XmlNode nodec in node.ChildNodes)
                {
                    if (nodec.NodeType != XmlNodeType.Element)
                        continue;
                    if (nodec.Attributes["value"] != null)
                    {
                        try
                        {
                            dic.Add(nodec.Attributes["value"].Value, nodec.InnerText);
                        }
                        catch (Exception e)
                        {
                            HttpContext.Current.Response.Write(node.Name + " 字典中 " + nodec.Attributes["value"].Value + " " + nodec.InnerText + " 重复");
                        }

                    }
                }
                switch (node.Name)
                {
                    case "FormWords":
                        _FormWordsEN = dic;
                        break;
                    case "PromotionType":
                        _PromotionTypeEN = dic;
                        break;
                    case "PromotionConditionType":
                        _PromotionConditionTypeEN = dic;
                        break;
                    case "PromConditionFitType":
                        _PromConditionFitTypeEN = dic;
                        break;
                    case "GiftsType":
                        _GiftsTypeEN = dic;
                        break;
                    case "PaymentKind":
                        _PaymentKindEN = dic;
                        break;
                    case "OperTypeID":
                        _OperTypeIDEN = dic;
                        break;
                    case "PostType":
                        _PostTypeEN = dic;
                        break;
                    case "OrdersStatus":
                        _OrdersStatusEN = dic;
                        break;
                    case "AccStatus":
                        _AccStatusEN = dic;
                        break;
                    case "ArticleQuestionStatus":
                        _ArticleQuestionStatusEN = dic;
                        break;
                    case "NotifyType":
                        _NotifyTypeEN = dic;
                        break;
                    case "WebSiteType":
                        _WebSiteTypeEN = dic;
                        break;
                    case "UnionAccountType":
                        _UnionAccountTypeEN = dic;
                        break;
                    case "CooperationType":
                        _CooperationTypeEN = dic;
                        break;
                    case "ChannelType":
                        _ChannelTypeEN = dic;
                        break;
                    case "ArticleQuestionType":
                        _ArticleQuestionTypeEN = dic;
                        break;
                    case "PayStatus":
                        _PayStatusEN = dic;
                        break;
                    case "EGiftStatus":
                        _EGiftStatusEN = dic;
                        break;
                    case "ProductType":
                        _ProductTypeEN = dic;
                        break;
                    case "ReStatus":
                        _ReStatusEN = dic;
                        break;
                    case "RecomProKind":
                        _RecomProKindEN = dic;
                        break;
                    case "StoreInStatus":
                        _StoreInStatusEN = dic;
                        break;
                    case "CostMode":
                        _CostModeEN = dic;
                        break;
                    case "ShipOrderStatus":
                        _ShipOrderStatusEN = dic;
                        break;
                    case "StoreOutType":
                        _StoreOutTypeEN = dic;
                        break;
                    case "StoreInType":
                        _StoreInTypeEN = dic;
                        break;
                    case "DefType":
                        _DefTypeEN = dic;
                        break;
                    case "TBOrdStatus":
                        _TBOrdStatusEN = dic;
                        break;
                    case "TBCarryType":
                        _TBCarryTypeEN = dic;
                        break;
                    case "FunctionID":
                        _FunctionIDEN = dic;
                        break;
                    case "CusNumType":
                        _CusNumTypeEN = dic;
                        break;
                    case "CusChatType":
                        _CusChatTypeEN = dic;
                        break;
                    case "ReMoneyStatus":
                        _ReMoneyStatusEN = dic;
                        break;
                    case "Common":
                        _CommonEN = dic;
                        break;
                    case "DataList":
                        _DataListEN = dic;
                        break;
                    case "Storage":
                        _StorageEN = dic;
                        break;
                    case "Purchasing":
                        _PurchaseEN = dic;
                        break;
                    case "Order":
                        _OrderEN = dic;
                        break;
                    case "ProductManage":
                        _ProductEN = dic;
                        break;
                    case "StockSet":
                        _StockEN = dic;
                        break;
                    case "MyMenu":
                        _MenuEN = dic;
                        break;
                    case "HR":
                        _UsersEN = dic;
                        break;
                    case "Marketing":
                        _PromManageEN = dic;
                        break;
                    case "StoreHouseProperty":
                        _StoreHousePropertyEN = dic;
                        break;
                    case "Customer":
                        _CusManageEN = dic;
                        break;
                    case "WebSiteManage":
                        _WebsiteManageEN = dic;
                        break;
                    case "FinaceManange":
                        _FinaceManageEN = dic;
                        break;
                    case "SysSetup":
                        _SysSetupEN = dic;
                        break;
                    case "CheckoutPoint":
                        _CheckoutPointEN = dic;
                        break;
                    case "ProSortRule":
                        _ProSortRuleEN = dic;
                        break;
                    case "TemperaAttr":
                        _TemperaAttrEN = dic;
                        break;
                    case "PurchaseReturnType":
                        _PurchaseReturnTypeEN = dic;
                        break;
                    case "PuchaseCheckCondition":
                        _PuchaseCheckConditionEN = dic;
                        break;
                    case "CarrySheetStatus":
                        _CarrySheetStatusEN = dic;
                        break;
                    case "AlertSourceType":
                        _AlertSourceTypeEN = dic;
                        break;
                    case "DeskTop":
                        _DeskTopEN = dic;
                        break;

                    case "WebCommon":
                        _WebCommonEN = dic;
                        break;

                    case "WebProduct":
                        _WebProductEN = dic;
                        break;
                    case "WebTuan":
                        _WebTuanEN = dic;
                        break;
                    case "WebTheme":
                        _WebThemeEN = dic;
                        break;
                    case "WebHelp":
                        _WebHelpEN = dic;
                        break;
                    case "WebAccout":
                        _WebAccoutEN = dic;
                        break;
                    case "POType":
                        _POTypeEN = dic;
                        break;
                    case "SalePriceStatus":
                        _SalePriceStatusEN = dic;
                        break;
                    case "StockDealStatus":
                        _StockDealStatusEN = dic;
                        break;
                    case "CusCateConditionType":
                        _CusCateConditionTypeEN = dic;
                        break;
                }
            }
        }

        /// <summary>
        /// 应用程序加载时讲配置文件信息读取到内存中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static void ReadMessageConfigFR(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\fr-lang.xml");
            foreach (XmlNode node in doc.SelectSingleNode("//root").ChildNodes)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (!node.HasChildNodes)
                {
                    continue;
                }

                foreach (XmlNode nodec in node.ChildNodes)
                {
                    if (nodec.NodeType != XmlNodeType.Element)
                        continue;
                    if (nodec.Attributes["value"] != null)
                    {
                        try
                        {
                            dic.Add(nodec.Attributes["value"].Value, nodec.InnerText);
                        }
                        catch (Exception e)
                        {
                            int test = 1;
                            HttpContext.Current.Response.Write(node.Name + " 字典中 " + nodec.Attributes["value"].Value + " " + nodec.InnerText + " 重复");

                        }

                    }
                }
                switch (node.Name)
                {
                    case "FormWords":
                        _FormWordsFR = dic;
                        break;
                    case "PromotionType":
                        _PromotionTypeFR = dic;
                        break;
                    case "PromotionConditionType":
                        _PromotionConditionTypeFR = dic;
                        break;
                    case "PromConditionFitType":
                        _PromConditionFitTypeFR = dic;
                        break;
                    case "GiftsType":
                        _GiftsTypeFR = dic;
                        break;
                    case "PaymentKind":
                        _PaymentKindFR = dic;
                        break;
                    case "OperTypeID":
                        _OperTypeIDFR = dic;
                        break;
                    case "PostType":
                        _PostTypeFR = dic;
                        break;
                    case "OrdersStatus":
                        _OrdersStatusFR = dic;
                        break;
                    case "AccStatus":
                        _AccStatusFR = dic;
                        break;
                    case "ArticleQuestionStatus":
                        _ArticleQuestionStatusFR = dic;
                        break;
                    case "NotifyType":
                        _NotifyTypeFR = dic;
                        break;
                    case "WebSiteType":
                        _WebSiteTypeFR = dic;
                        break;
                    case "UnionAccountType":
                        _UnionAccountTypeFR = dic;
                        break;
                    case "CooperationType":
                        _CooperationTypeFR = dic;
                        break;
                    case "ChannelType":
                        _ChannelTypeFR = dic;
                        break;
                    case "ArticleQuestionType":
                        _ArticleQuestionTypeFR = dic;
                        break;
                    case "PayStatus":
                        _PayStatusFR = dic;
                        break;
                    case "EGiftStatus":
                        _EGiftStatusFR = dic;
                        break;
                    case "ProductType":
                        _ProductTypeFR = dic;
                        break;
                    case "ReStatus":
                        _ReStatusFR = dic;
                        break;
                    case "RecomProKind":
                        _RecomProKindFR = dic;
                        break;
                    case "StoreInStatus":
                        _StoreInStatusFR = dic;
                        break;
                    case "CostMode":
                        _CostModeFR = dic;
                        break;
                    case "ShipOrderStatus":
                        _ShipOrderStatusFR = dic;
                        break;
                    case "StoreOutType":
                        _StoreOutTypeFR = dic;
                        break;
                    case "StoreInType":
                        _StoreInTypeFR = dic;
                        break;
                    case "DefType":
                        _DefTypeFR = dic;
                        break;
                    case "TBOrdStatus":
                        _TBOrdStatusFR = dic;
                        break;
                    case "TBCarryType":
                        _TBCarryTypeFR = dic;
                        break;
                    case "FunctionID":
                        _FunctionIDFR = dic;
                        break;
                    case "CusNumType":
                        _CusNumTypeFR = dic;
                        break;
                    case "CusChatType":
                        _CusChatTypeFR = dic;
                        break;
                    case "ReMoneyStatus":
                        _ReMoneyStatusFR = dic;
                        break;
                    case "Common":
                        _CommonFR = dic;
                        break;
                    case "DataList":
                        _DataListFR = dic;
                        break;
                    case "Storage":
                        _StorageFR = dic;
                        break;
                    case "Purchasing":
                        _PurchaseFR = dic;
                        break;
                    case "Order":
                        _OrderFR = dic;
                        break;
                    case "ProductManage":
                        _ProductFR = dic;
                        break;
                    case "StockSet":
                        _StockFR = dic;
                        break;
                    case "MyMenu":
                        _MenuFR = dic;
                        break;
                    case "HR":
                        _UsersFR = dic;
                        break;
                    case "Marketing":
                        _PromManageFR = dic;
                        break;
                    case "StoreHouseProperty":
                        _StoreHousePropertyFR = dic;
                        break;
                    case "Customer":
                        _CusManageFR = dic;
                        break;
                    case "WebSiteManage":
                        _WebsiteManageFR = dic;
                        break;
                    case "FinaceManange":
                        _FinaceManageFR = dic;
                        break;
                    case "SysSetup":
                        _SysSetupFR = dic;
                        break;
                    case "CheckoutPoint":
                        _CheckoutPointFR = dic;
                        break;
                    case "ProSortRule":
                        _ProSortRuleFR = dic;
                        break;
                    case "TemperaAttr":
                        _TemperaAttrFR = dic;
                        break;
                    case "PurchaseReturnType":
                        _PurchaseReturnTypeFR = dic;
                        break;
                    case "PuchaseCheckCondition":
                        _PuchaseCheckConditionFR = dic;
                        break;
                    case "CarrySheetStatus":
                        _CarrySheetStatusFR = dic;
                        break;
                    case "AlertSourceType":
                        _AlertSourceTypeFR = dic;
                        break;
                    case "DeskTop":
                        _DeskTopFR = dic;
                        break;
                    case "WebCommon":
                        _WebCommonFR = dic;
                        break;

                    case "WebProduct":
                        _WebProductFR = dic;
                        break;
                    case "WebTuan":
                        _WebTuanFR = dic;
                        break;
                    case "WebTheme":
                        _WebThemeFR = dic;
                        break;
                    case "WebHelp":
                        _WebHelpFR = dic;
                        break;
                    case "WebAccout":
                        _WebAccoutFR = dic;
                        break;

                    case "POType":
                        _POTypeFR = dic;
                        break;
                    case "SalePriceStatus":
                        _SalePriceStatusFR = dic;
                        break;
                    case "CusCateConditionType":
                        _CusCateConditionTypeFR = dic;
                        break;
                }
            }
        }

        /// <summary>
        /// 应用程序加载时讲配置文件信息读取到内存中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static void ReadMessageConfigGE(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\ge-lang.xml");
            foreach (XmlNode node in doc.SelectSingleNode("//root").ChildNodes)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (!node.HasChildNodes)
                {
                    continue;
                }

                foreach (XmlNode nodec in node.ChildNodes)
                {
                    if (nodec.NodeType != XmlNodeType.Element)
                        continue;
                    if (nodec.Attributes["value"] != null)
                    {
                        try
                        {
                            dic.Add(nodec.Attributes["value"].Value, nodec.InnerText);
                        }
                        catch (Exception e)
                        {
                            //int test = 1;
                            HttpContext.Current.Response.Write(nodec.Attributes["value"].Value + nodec.InnerText);
                        }

                    }
                }
                switch (node.Name)
                {
                    case "FormWords":
                        _FormWordsGE = dic;
                        break;
                    case "PromotionType":
                        _PromotionTypeGE = dic;
                        break;
                    case "PromotionConditionType":
                        _PromotionConditionTypeGE = dic;
                        break;
                    case "PromConditionFitType":
                        _PromConditionFitTypeGE = dic;
                        break;
                    case "GiftsType":
                        _GiftsTypeGE = dic;
                        break;
                    case "PaymentKind":
                        _PaymentKindGE = dic;
                        break;
                    case "OperTypeID":
                        _OperTypeIDGE = dic;
                        break;
                    case "PostType":
                        _PostTypeGE = dic;
                        break;
                    case "OrdersStatus":
                        _OrdersStatusGE = dic;
                        break;
                    case "AccStatus":
                        _AccStatusGE = dic;
                        break;
                    case "ArticleQuestionStatus":
                        _ArticleQuestionStatusGE = dic;
                        break;
                    case "NotifyType":
                        _NotifyTypeGE = dic;
                        break;
                    case "WebSiteType":
                        _WebSiteTypeGE = dic;
                        break;
                    case "UnionAccountType":
                        _UnionAccountTypeGE = dic;
                        break;
                    case "CooperationType":
                        _CooperationTypeGE = dic;
                        break;
                    case "ChannelType":
                        _ChannelTypeGE = dic;
                        break;
                    case "ArticleQuestionType":
                        _ArticleQuestionTypeGE = dic;
                        break;
                    case "PayStatus":
                        _PayStatusGE = dic;
                        break;
                    case "EGiftStatus":
                        _EGiftStatusGE = dic;
                        break;
                    case "ProductType":
                        _ProductTypeGE = dic;
                        break;
                    case "ReStatus":
                        _ReStatusGE = dic;
                        break;
                    case "RecomProKind":
                        _RecomProKindGE = dic;
                        break;
                    case "StoreInStatus":
                        _StoreInStatusGE = dic;
                        break;
                    case "CostMode":
                        _CostModeGE = dic;
                        break;
                    case "ShipOrderStatus":
                        _ShipOrderStatusGE = dic;
                        break;
                    case "StoreOutType":
                        _StoreOutTypeGE = dic;
                        break;
                    case "StoreInType":
                        _StoreInTypeGE = dic;
                        break;
                    case "DefType":
                        _DefTypeGE = dic;
                        break;
                    case "TBOrdStatus":
                        _TBOrdStatusGE = dic;
                        break;
                    case "TBCarryType":
                        _TBCarryTypeGE = dic;
                        break;
                    case "FunctionID":
                        _FunctionIDGE = dic;
                        break;
                    case "CusNumType":
                        _CusNumTypeGE = dic;
                        break;
                    case "CusChatType":
                        _CusChatTypeGE = dic;
                        break;
                    case "ReMoneyStatus":
                        _ReMoneyStatusGE = dic;
                        break;
                    case "Common":
                        _CommonGE = dic;
                        break;
                    case "DataList":
                        _DataListGE = dic;
                        break;
                    case "Storage":
                        _StorageGE = dic;
                        break;
                    case "Purchasing":
                        _PurchaseGE = dic;
                        break;
                    case "Order":
                        _OrderGE = dic;
                        break;
                    case "ProductManage":
                        _ProductGE = dic;
                        break;
                    case "StockSet":
                        _StockGE = dic;
                        break;
                    case "MyMenu":
                        _MenuGE = dic;
                        break;
                    case "HR":
                        _UsersGE = dic;
                        break;
                    case "Marketing":
                        _PromManageGE = dic;
                        break;
                    case "StoreHouseProperty":
                        _StoreHousePropertyGE = dic;
                        break;
                    case "Customer":
                        _CusManageGE = dic;
                        break;
                    case "WebSiteManage":
                        _WebsiteManageGE = dic;
                        break;
                    case "FinaceManange":
                        _FinaceManageGE = dic;
                        break;
                    case "SysSetup":
                        _SysSetupGE = dic;
                        break;
                    case "CheckoutPoint":
                        _CheckoutPointGE = dic;
                        break;
                    case "ProSortRule":
                        _ProSortRuleGE = dic;
                        break;
                    case "TemperaAttr":
                        _TemperaAttrGE = dic;
                        break;
                    case "PurchaseReturnType":
                        _PurchaseReturnTypeGE = dic;
                        break;
                    case "PuchaseCheckCondition":
                        _PuchaseCheckConditionGE = dic;
                        break;
                    case "CarrySheetStatus":
                        _CarrySheetStatusGE = dic;
                        break;
                    case "AlertSourceType":
                        _AlertSourceTypeGE = dic;
                        break;
                    case "DeskTop":
                        _DeskTopGE = dic;
                        break;
                    case "WebCommon":
                        _WebCommonGE = dic;
                        break;

                    case "WebProduct":
                        _WebProductGE = dic;
                        break;
                    case "WebTuan":
                        _WebTuanGE = dic;
                        break;
                    case "WebTheme":
                        _WebThemeGE = dic;
                        break;
                    case "WebHelp":
                        _WebHelpGE = dic;
                        break;
                    case "WebAccout":
                        _WebAccoutGE = dic;
                        break;
                    case "POType":
                        _POTypeGE = dic;
                        break;
                    case "SalePriceStatus":
                        _SalePriceStatusGE = dic;
                        break;
                    case "CusCateConditionType":
                        _CusCateConditionTypeGE = dic;
                        break;
                }
            }
        }

        /// <summary>
        /// 应用程序加载时讲配置文件信息读取到内存中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static void ReadMessageConfigIT(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\it-lang.xml");
            foreach (XmlNode node in doc.SelectSingleNode("//root").ChildNodes)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (!node.HasChildNodes)
                {
                    continue;
                }

                foreach (XmlNode nodec in node.ChildNodes)
                {
                    if (nodec.NodeType != XmlNodeType.Element)
                        continue;
                    if (nodec.Attributes["value"] != null)
                    {
                        try
                        {
                            dic.Add(nodec.Attributes["value"].Value, nodec.InnerText);
                        }
                        catch (Exception e)
                        {
                            int test = 1;
                            //throw e;
                            HttpContext.Current.Response.Write(node.Name + " 字典中 " + nodec.Attributes["value"].Value + " " + nodec.InnerText + " 重复");

                        }

                    }
                }
                switch (node.Name)
                {
                    case "FormWords":
                        _FormWordsIT = dic;
                        break;
                    case "PromotionType":
                        _PromotionTypeIT = dic;
                        break;
                    case "PromotionConditionType":
                        _PromotionConditionTypeIT = dic;
                        break;
                    case "PromConditionFitType":
                        _PromConditionFitTypeIT = dic;
                        break;
                    case "GiftsType":
                        _GiftsTypeIT = dic;
                        break;
                    case "PaymentKind":
                        _PaymentKindIT = dic;
                        break;
                    case "OperTypeID":
                        _OperTypeIDIT = dic;
                        break;
                    case "PostType":
                        _PostTypeIT = dic;
                        break;
                    case "OrdersStatus":
                        _OrdersStatusIT = dic;
                        break;
                    case "AccStatus":
                        _AccStatusIT = dic;
                        break;
                    case "ArticleQuestionStatus":
                        _ArticleQuestionStatusIT = dic;
                        break;
                    case "NotifyType":
                        _NotifyTypeIT = dic;
                        break;
                    case "WebSiteType":
                        _WebSiteTypeIT = dic;
                        break;
                    case "UnionAccountType":
                        _UnionAccountTypeIT = dic;
                        break;
                    case "CooperationType":
                        _CooperationTypeIT = dic;
                        break;
                    case "ChannelType":
                        _ChannelTypeIT = dic;
                        break;
                    case "ArticleQuestionType":
                        _ArticleQuestionTypeIT = dic;
                        break;
                    case "PayStatus":
                        _PayStatusIT = dic;
                        break;
                    case "EGiftStatus":
                        _EGiftStatusIT = dic;
                        break;
                    case "ProductType":
                        _ProductTypeIT = dic;
                        break;
                    case "ReStatus":
                        _ReStatusIT = dic;
                        break;
                    case "RecomProKind":
                        _RecomProKindIT = dic;
                        break;
                    case "StoreInStatus":
                        _StoreInStatusIT = dic;
                        break;
                    case "CostMode":
                        _CostModeIT = dic;
                        break;
                    case "ShipOrderStatus":
                        _ShipOrderStatusIT = dic;
                        break;
                    case "StoreOutType":
                        _StoreOutTypeIT = dic;
                        break;
                    case "StoreInType":
                        _StoreInTypeIT = dic;
                        break;
                    case "DefType":
                        _DefTypeIT = dic;
                        break;
                    case "TBOrdStatus":
                        _TBOrdStatusIT = dic;
                        break;
                    case "TBCarryType":
                        _TBCarryTypeIT = dic;
                        break;
                    case "FunctionID":
                        _FunctionIDIT = dic;
                        break;
                    case "CusNumType":
                        _CusNumTypeIT = dic;
                        break;
                    case "CusChatType":
                        _CusChatTypeIT = dic;
                        break;
                    case "ReMoneyStatus":
                        _ReMoneyStatusIT = dic;
                        break;
                    case "Common":
                        _CommonIT = dic;
                        break;
                    case "DataList":
                        _DataListIT = dic;
                        break;
                    case "Storage":
                        _StorageIT = dic;
                        break;
                    case "Purchasing":
                        _PurchaseIT = dic;
                        break;
                    case "Order":
                        _OrderIT = dic;
                        break;
                    case "ProductManage":
                        _ProductIT = dic;
                        break;
                    case "StockSet":
                        _StockIT = dic;
                        break;
                    case "MyMenu":
                        _MenuIT = dic;
                        break;
                    case "HR":
                        _UsersIT = dic;
                        break;
                    case "Marketing":
                        _PromManageIT = dic;
                        break;
                    case "StoreHouseProperty":
                        _StoreHousePropertyIT = dic;
                        break;
                    case "Customer":
                        _CusManageIT = dic;
                        break;
                    case "WebSiteManage":
                        _WebsiteManageIT = dic;
                        break;
                    case "FinaceManange":
                        _FinaceManageIT = dic;
                        break;
                    case "SysSetup":
                        _SysSetupIT = dic;
                        break;
                    case "CheckoutPoint":
                        _CheckoutPointIT = dic;
                        break;
                    case "ProSortRule":
                        _ProSortRuleIT = dic;
                        break;
                    case "TemperaAttr":
                        _TemperaAttrIT = dic;
                        break;
                    case "PurchaseReturnType":
                        _PurchaseReturnTypeIT = dic;
                        break;
                    case "PuchaseCheckCondition":
                        _PuchaseCheckConditionIT = dic;
                        break;
                    case "CarrySheetStatus":
                        _CarrySheetStatusIT = dic;
                        break;
                    case "AlertSourceType":
                        _AlertSourceTypeIT = dic;
                        break;
                    case "DeskTop":
                        _DeskTopIT = dic;
                        break;
                    case "WebCommon":
                        _WebCommonIT = dic;
                        break;

                    case "WebProduct":
                        _WebProductIT = dic;
                        break;
                    case "WebTuan":
                        _WebTuanIT = dic;
                        break;
                    case "WebTheme":
                        _WebThemeIT = dic;
                        break;
                    case "WebHelp":
                        _WebHelpIT = dic;
                        break;
                    case "WebAccout":
                        _WebAccoutIT = dic;
                        break;
                    case "POType":
                        _POTypeIT = dic;
                        break;
                    case "SalePriceStatus":
                        _SalePriceStatusIT = dic;
                        break;
                    case "CusCateConditionType":
                        _CusCateConditionTypeIT = dic;
                        break;
                }
            }
        }

        /// <summary>
        /// create by niuyy
        /// 根据语言版本，枚举类型，枚举值返回枚举描述
        /// </summary>
        /// <param name="lang">语言版本</param>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        public static string GetMessage(AppLanguage lang, AppEnumName msgType, string messageID)
        {
            switch (lang)
            {
                case AppLanguage.CN:
                    return GetMessageCN(msgType, messageID);
                case AppLanguage.EN:
                    return GetMessageEN(msgType, messageID);
                case AppLanguage.FR:
                    return GetMessageFR(msgType, messageID);
                case AppLanguage.GE:
                    return GetMessageGE(msgType, messageID);
                case AppLanguage.IT:
                    return GetMessageIT(msgType, messageID);
            }
            return "";
        }

        public static string GetMessage(AppLanguage lang, Internationalization interType, string messageID)
        {
            string revalue = "";
            try
            {
                switch (lang)
                {
                    case AppLanguage.CN:
                        revalue = GetMessageCN(interType, messageID);
                        break;
                    case AppLanguage.EN:
                        revalue = GetMessageEN(interType, messageID);
                        break;
                    case AppLanguage.FR:
                        revalue = GetMessageFR(interType, messageID);
                        break;
                    case AppLanguage.GE:
                        revalue = GetMessageGE(interType, messageID);
                        break;
                    case AppLanguage.IT:
                        revalue = GetMessageIT(interType, messageID);
                        break;
                }
            }
            catch
            {
                return "错误节点位置：" + Enum.GetName(typeof(ZKEShop.Common.Internationalization), interType) + "-" + messageID.ToString();
                //return "错误错误错误" +  messageID.ToString();
            }
            return revalue;
        }

        /*public static string GetMessage(AppLanguage lang, Internationalization interType, ZKEShop.DataAccess.UserDataList field)
        {
            string revalue = "";
            try
            {
                switch (lang)
                {
                    case AppLanguage.CN:
                        revalue = GetMessageCN(interType, field.DataListID.ToString());
                        break;
                    case AppLanguage.EN:
                        revalue = GetMessageEN(interType, field.DataListID.ToString());
                        break;
                    case AppLanguage.FR:
                        revalue = GetMessageFR(interType, field.DataListID.ToString());
                        break;
                    case AppLanguage.GE:
                        revalue = GetMessageGE(interType, field.DataListID.ToString());
                        break;
                    case AppLanguage.IT:
                        revalue = GetMessageIT(interType, field.DataListID.ToString());
                        break;
                }
            }
            catch
            {
                return "错误节点位置：" + Enum.GetName(typeof(ZKEShop.Common.Internationalization), interType) + "-" + field.DataListID.ToString();
                //return "错误错误错误" +  messageID.ToString();
            }

            if (revalue == field.DataListID.ToString())
            {
                revalue = field.FieldText;
            }
            return revalue;
        }*/

        /// <summary>
        /// create by niuyy
        /// 根据枚举及值得到枚举的描述
        /// </summary>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        static string GetMessageCN(AppEnumName msgType, string messageID)
        {
            try
            {
                switch (msgType)
                {
                    case AppEnumName.NoEnumName:
                        return _FormWordsCN[messageID];
                        break;
                    case AppEnumName.PromotionType:
                        return _PromotionTypeCN[messageID];
                    case AppEnumName.PromotionConditionType:
                        return _PromotionConditionTypeCN[messageID];
                    case AppEnumName.PromConditionFitType:
                        return _PromConditionFitTypeCN[messageID];
                    case AppEnumName.GiftsType:
                        return _GiftsTypeCN[messageID];
                    case AppEnumName.OperType:
                        return _OperTypeIDCN[messageID];
                    case AppEnumName.PaymentKind:
                        if (messageID == "5")
                            return "邮局付款";
                        return _PaymentKindCN[messageID];
                    case AppEnumName.PostType:
                        return _PostTypeCN[messageID];
                    case AppEnumName.OrdersStatus:
                        return _OrdersStatusCN[messageID];
                    case AppEnumName.AccStatus:
                        return _AccStatusCN[messageID];
                    case AppEnumName.ArticleQuestionStatus:
                        return _ArticleQuestionStatusCN[messageID];
                    case AppEnumName.NotifyType:
                        return _NotifyTypeCN[messageID];
                    case AppEnumName.WebSiteType:
                        return _WebSiteTypeCN[messageID];
                    case AppEnumName.UnionAccountType:
                        return _UnionAccountTypeCN[messageID];
                    case AppEnumName.CooperationType:
                        return _CooperationTypeCN[messageID];
                    case AppEnumName.ChannelType:
                        return _ChannelTypeCN[messageID];
                    case AppEnumName.ArticleQuestionType:
                        return _ArticleQuestionTypeCN[messageID];
                    case AppEnumName.PayStatus:
                        return _PayStatusCN[messageID];
                    case AppEnumName.EGiftStatus:
                        return _EGiftStatusCN[messageID];
                    case AppEnumName.ProductType:
                        return _ProductTypeCN[messageID];
                    case AppEnumName.OrderType:
                        return _OrderTypeCN[messageID];
                    case AppEnumName.CusVerifyStatus:
                        return _CusVerifyStatusCN[messageID];
                    case AppEnumName.ReStatus:
                        return _ReStatusCN[messageID];
                    case AppEnumName.RecomProKind:
                        return _RecomProKindCN[messageID];
                    case AppEnumName.StoreInStatus:
                        return _StoreInStatusCN[messageID];
                    case AppEnumName.CostMode:
                        return _CostModeCN[messageID];
                    case AppEnumName.ShipOrderStatus:
                        return _ShipOrderStatusCN[messageID];
                    case AppEnumName.StoreOutType:
                        return _StoreOutTypeCN[messageID];
                    case AppEnumName.StoreInType:
                        return _StoreInTypeCN[messageID];
                    case AppEnumName.DefType:
                        return _DefTypeCN[messageID];
                    case AppEnumName.TBOrdStatus:
                        return _TBOrdStatusCN[messageID];
                    case AppEnumName.TBCarryType:
                        return _TBCarryTypeCN[messageID];
                    case AppEnumName.FunctionID:
                        return _FunctionIDCN[messageID];
                    case AppEnumName.CusNumType:
                        return _CusNumTypeCN[messageID];
                    case AppEnumName.CusChatType:
                        return _CusChatTypeCN[messageID];
                    case AppEnumName.ReMoneyStatus:
                        return _ReMoneyStatusCN[messageID];
                    case AppEnumName.StoreHouseProperty:
                        return _StoreHousePropertyCN[messageID];
                    case AppEnumName.PuchaseCheckCondition:
                        return _PuchaseCheckConditionCN[messageID];
                    case AppEnumName.CheckStatus:
                        return _CheckStatusCN[messageID];
                    case AppEnumName.CheckoutPoint:
                        return _CheckoutPointCN[messageID];
                    case AppEnumName.ProSortRule:
                        return _ProSortRuleCN[messageID];
                    case AppEnumName.TemperaAttr:
                        return _TemperaAttrCN[messageID];
                    case AppEnumName.PurchaseReturnType:
                        return _PurchaseReturnTypeCN[messageID];
                    case AppEnumName.CarrySheetStatus:
                        return _CarrySheetStatusCN[messageID];
                    case AppEnumName.AlertSourceType:
                        return _AlertSourceTypeCN[messageID];
                    case AppEnumName.POType:
                        return _POTypeCN[messageID];
                    case AppEnumName.SalePriceStatus:
                        return _SalePriceStatusCN[messageID];
                    case AppEnumName.StockDealStatus:
                        return _StockDealStatusCN[messageID];
                    case AppEnumName.CusCateConditionType:
                        return _CusCateConditionTypeCN[messageID];
                    case AppEnumName.ProPromCataID:
                        return _ProPromCataIDCN[messageID];
                    case AppEnumName.TousuType:
                        return _TousuTypeCN[messageID];
                    case AppEnumName.packageType:
                        return _PackageTypeCN[messageID];
                    case AppEnumName.BakTemplateType:
                        return _BakTemplateTypeCN[messageID];
                    case AppEnumName.BalanceStatus:
                        return _BalanceStatusCN[messageID];
                    case AppEnumName.ProvNavLinkType:
                        return _ProvNavLinkTypeCN[messageID];
                    case AppEnumName.ReAmountStatus:
                        return _ReAmountStatusCN[messageID];
                    case AppEnumName.ChargeType:
                        return _ChargeTypeCN[messageID];
                    default:
                        return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
                }

            }
            catch (Exception)
            {
            }
            return messageID;
        }
        static string GetMessageCN(Internationalization interType, string messageID)
        {
            try
            {
                switch (interType)
                {
                    case Internationalization.Common:
                        return _CommonCN[messageID];
                    case Internationalization.DataList:
                        return _DataListCN[messageID];
                    case Internationalization.Storage:
                        return _StorageCN[messageID];
                    case Internationalization.Purchasing:
                        return _PurchaseCN[messageID];
                    case Internationalization.OrderSys:
                        return _OrderCN[messageID];
                    case Internationalization.ProductSys:
                        return _ProductCN[messageID];
                    case Internationalization.StockSet:
                        return _StockCN[messageID];
                    case Internationalization.MyMenu:
                        return _MenuCN[messageID];
                    case Internationalization.Users:
                        return _UsersCN[messageID];
                    case Internationalization.PromManage:
                        return _PromManageCN[messageID];
                    case Internationalization.CustomerManage:
                        return _CusManageCN[messageID];
                    case Internationalization.WebsiteManage:
                        return _WebsiteManageCN[messageID];
                    case Internationalization.FinaceManage:
                        return _FinaceManageCN[messageID];
                    case Internationalization.SysSetup:
                        return _SysSetupCN[messageID];
                    case Internationalization.DeskTop:
                        return _DeskTopCN[messageID];
                    case Internationalization.WebCommon:
                        return _WebCommonCN[messageID];
                    case Internationalization.WebProduct:
                        return _WebProductCN[messageID];
                    case Internationalization.WebTuan:
                        return _WebTuanCN[messageID];
                    case Internationalization.WebTheme:
                        return _WebThemeCN[messageID];
                    case Internationalization.WebHelp:
                        return _WebHelpCN[messageID];
                    case Internationalization.WebAccout:
                        return _WebAccoutCN[messageID];
                    case Internationalization.FunctionID:
                        return _FunctionIDCN[messageID];
                    case Internationalization.MsgSellerMenu:
                        return _MsgSellerMenuCN[messageID];
                    case Internationalization.MsgSellerHead:
                        return _MsgSellerHeadCN[messageID];
                    case Internationalization.MsgSelOrderList:
                        return _MsgSelOrderListCN[messageID];
                    case Internationalization.MsgSelOrderDetail:
                        return _MsgSelOrderDetailCN[messageID];
                    case Internationalization.MsgSelShipOrderList:
                        return _MsgSelShipOrderListCN[messageID];
                    case Internationalization.MsgSelShipOrderDetail:
                        return _MsgSelShipOrderDetailCN[messageID];
                    case Internationalization.MsgSelOrderReGoodsList:
                        return _MsgSelOrderReGoodsListCN[messageID];
                    case Internationalization.MsgSelOrderReGoodsDetail:
                        return _MsgSelOrderReGoodsDetailCN[messageID];
                    case Internationalization.MsgSelOrderMark:
                        return _MsgSelOrderMarkCN[messageID];
                    case Internationalization.MsgSelNavAdFlashPicInfo:
                        return _MsgSelNavAdFlashPicInfoCN[messageID];
                    case Internationalization.MsgSelProductChoiceProCata:
                        return _MsgSelProductChoiceProCataCN[messageID];
                    case Internationalization.MsgSelProductDetail:
                        return _MsgSelProductDetailCN[messageID];
                    case Internationalization.MsgSelProductProductTj:
                        return _MsgSelProductProductTjCN[messageID];
                    case Internationalization.MsSelProductList:
                        return _MsSelProductListCN[messageID];
                    case Internationalization.MsgProductStoreList:
                        return _MsgProductStoreListCN[messageID];
                    case Internationalization.MsgPromotionLimitTjInfo:
                        return _MsgPromotionLimitTjInfoCN[messageID];
                    case Internationalization.MsgPromotionLimitTjList:
                        return _MsgPromotionLimitTjListCN[messageID];
                    case Internationalization.MsgPromotionPackageInfo:
                        return _MsgPromotionPackageInfoCN[messageID];
                    case Internationalization.MsgPromotionPackageList:
                        return _MsgPromotionPackageListCN[messageID];
                    case Internationalization.MsgPromotionProInfo:
                        return _MsgPromotionProInfoCN[messageID];
                    case Internationalization.MsgPromotionProInfo2:
                        return _MsgPromotionProInfo2CN[messageID];
                    case Internationalization.MsgPromotionInfo3:
                        return _MsgPromotionInfo3CN[messageID];
                    case Internationalization.MsgPromotionList:
                        return _MsgPromotionListCN[messageID];
                    case Internationalization.MsgServiceAfterML:
                        return _MsgServiceAfterMLCN[messageID];
                    case Internationalization.MsgServiceCompList:
                        return _MsgServiceCompListCN[messageID];
                    case Internationalization.MsgServiceConsultingList:
                        return _MsgServiceConsultingListCN[messageID];
                    case Internationalization.MsgSetupCarryTemp:
                        return _MsgSetupCarryTempCN[messageID];
                    case Internationalization.MseSetupCarryTempList:
                        return _MseSetupCarryTempListCN[messageID];
                    case Internationalization.MseSetupConsumerPro:
                        return _MseSetupConsumerProCN[messageID];

                    case Internationalization.MsgSelOrderReGoodsConfirm:
                        return _MsgSelOrderReGoodsConfirmCN[messageID];
                    case Internationalization.MsgSelOrderModPrice:
                        return _MsgSelOrderModPriceCN[messageID];
                    case Internationalization.MsgSelOrderRefRegoods:
                        return _MsgSelOrderRefRegoodsCN[messageID];
                    case Internationalization.DeliveryBase:
                        return _DeliveryBaseCN[messageID];
                    case Internationalization.MsgSelReviewManage:
                        return _MsgSelReviewManageCN[messageID];
                    case Internationalization.MsgPageBase:
                        return _MsgPageBaseCN[messageID];

                    default:
                        return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
                }

            }
            catch (Exception)
            {
            }
            return messageID;
        }


        /// <summary>
        /// create by niuyy
        /// 根据枚举及值得到枚举的描述
        /// </summary>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        static string GetMessageEN(AppEnumName msgType, string messageID)
        {
            switch (msgType)
            {
                case AppEnumName.NoEnumName:
                    return _FormWordsEN[messageID];
                    break;
                case AppEnumName.PromotionType:
                    return _PromotionTypeEN[messageID];
                case AppEnumName.PromotionConditionType:
                    return _PromotionConditionTypeEN[messageID];
                case AppEnumName.PromConditionFitType:
                    return _PromConditionFitTypeEN[messageID];
                case AppEnumName.GiftsType:
                    return _GiftsTypeEN[messageID];
                case AppEnumName.OperType:
                    return _OperTypeIDEN[messageID];
                case AppEnumName.PaymentKind:
                    if (messageID == "5")
                        return "邮局付款";
                    return _PaymentKindEN[messageID];
                case AppEnumName.PostType:
                    return _PostTypeEN[messageID];
                case AppEnumName.OrdersStatus:
                    return _OrdersStatusEN[messageID];
                case AppEnumName.AccStatus:
                    return _AccStatusEN[messageID];
                case AppEnumName.ArticleQuestionStatus:
                    return _ArticleQuestionStatusEN[messageID];
                case AppEnumName.NotifyType:
                    return _NotifyTypeEN[messageID];
                case AppEnumName.WebSiteType:
                    return _WebSiteTypeEN[messageID];
                case AppEnumName.UnionAccountType:
                    return _UnionAccountTypeEN[messageID];
                case AppEnumName.CooperationType:
                    return _CooperationTypeEN[messageID];
                case AppEnumName.ChannelType:
                    return _ChannelTypeEN[messageID];
                case AppEnumName.ArticleQuestionType:
                    return _ArticleQuestionTypeEN[messageID];
                case AppEnumName.PayStatus:
                    return _PayStatusEN[messageID];
                case AppEnumName.EGiftStatus:
                    return _EGiftStatusEN[messageID];
                case AppEnumName.ProductType:
                    return _ProductTypeEN[messageID];
                case AppEnumName.ReStatus:
                    return _ReStatusEN[messageID];
                case AppEnumName.RecomProKind:
                    return _RecomProKindEN[messageID];
                case AppEnumName.StoreInStatus:
                    return _StoreInStatusEN[messageID];
                case AppEnumName.CostMode:
                    return _CostModeEN[messageID];
                case AppEnumName.ShipOrderStatus:
                    return _ShipOrderStatusEN[messageID];
                case AppEnumName.StoreOutType:
                    return _StoreOutTypeEN[messageID];
                case AppEnumName.StoreInType:
                    return _StoreInTypeEN[messageID];
                case AppEnumName.DefType:
                    return _DefTypeEN[messageID];
                case AppEnumName.TBOrdStatus:
                    return _TBOrdStatusEN[messageID];
                case AppEnumName.TBCarryType:
                    return _TBCarryTypeEN[messageID];
                case AppEnumName.FunctionID:
                    return _FunctionIDEN[messageID];
                case AppEnumName.CusNumType:
                    return _CusNumTypeEN[messageID];
                case AppEnumName.CusChatType:
                    return _CusChatTypeEN[messageID];
                case AppEnumName.ReMoneyStatus:
                    return _ReMoneyStatusEN[messageID];
                case AppEnumName.StoreHouseProperty:
                    return _StoreHousePropertyEN[messageID];
                case AppEnumName.ProSortRule:
                    return _ProSortRuleEN[messageID];
                case AppEnumName.TemperaAttr:
                    return _TemperaAttrEN[messageID];
                case AppEnumName.CarrySheetStatus:
                    return _CarrySheetStatusEN[messageID];
                case AppEnumName.AlertSourceType:
                    return _AlertSourceTypeEN[messageID];
                case AppEnumName.POType:
                    return _POTypeEN[messageID];
                case AppEnumName.SalePriceStatus:
                    return _SalePriceStatusEN[messageID];
                case AppEnumName.StockDealStatus:
                    return _StockDealStatusEN[messageID];
                case AppEnumName.CusCateConditionType:
                    return _CusCateConditionTypeEN[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }
        static string GetMessageEN(Internationalization interType, string messageID)
        {
            switch (interType)
            {
                case Internationalization.Common:
                    return _CommonEN[messageID];
                case Internationalization.DataList:
                    return _DataListEN[messageID];
                case Internationalization.Storage:
                    return _StorageEN[messageID];
                case Internationalization.Purchasing:
                    return _PurchaseEN[messageID];
                case Internationalization.OrderSys:
                    return _OrderEN[messageID];
                case Internationalization.ProductSys:
                    return _ProductEN[messageID];
                case Internationalization.StockSet:
                    return _StockEN[messageID];
                case Internationalization.MyMenu:
                    return _MenuEN[messageID];
                case Internationalization.Users:
                    return _UsersEN[messageID];
                case Internationalization.PromManage:
                    return _PromManageEN[messageID];
                case Internationalization.CustomerManage:
                    return _CusManageEN[messageID];
                case Internationalization.WebsiteManage:
                    return _WebsiteManageEN[messageID];
                case Internationalization.FinaceManage:
                    return _FinaceManageEN[messageID];
                case Internationalization.SysSetup:
                    return _SysSetupEN[messageID];
                case Internationalization.DeskTop:
                    return _DeskTopEN[messageID];

                case Internationalization.WebCommon:
                    return _WebCommonEN[messageID];
                case Internationalization.WebProduct:
                    return _WebProductEN[messageID];
                case Internationalization.WebTuan:
                    return _WebTuanEN[messageID];
                case Internationalization.WebTheme:
                    return _WebThemeEN[messageID];
                case Internationalization.WebHelp:
                    return _WebHelpEN[messageID];
                case Internationalization.WebAccout:
                    return _WebAccoutEN[messageID];

                case Internationalization.FunctionID:
                    return _FunctionIDEN[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }


        /// <summary>
        /// create by niuyy
        /// 根据枚举及值得到枚举的描述
        /// </summary>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        static string GetMessageFR(AppEnumName msgType, string messageID)
        {
            switch (msgType)
            {
                case AppEnumName.NoEnumName:
                    return _FormWordsFR[messageID];
                    break;
                case AppEnumName.PromotionType:
                    return _PromotionTypeFR[messageID];
                case AppEnumName.PromotionConditionType:
                    return _PromotionConditionTypeFR[messageID];
                case AppEnumName.PromConditionFitType:
                    return _PromConditionFitTypeFR[messageID];
                case AppEnumName.GiftsType:
                    return _GiftsTypeFR[messageID];
                case AppEnumName.OperType:
                    return _OperTypeIDFR[messageID];
                case AppEnumName.PaymentKind:
                    if (messageID == "5")
                        return "邮局付款";
                    return _PaymentKindFR[messageID];
                case AppEnumName.PostType:
                    return _PostTypeFR[messageID];
                case AppEnumName.OrdersStatus:
                    return _OrdersStatusFR[messageID];
                case AppEnumName.AccStatus:
                    return _AccStatusFR[messageID];
                case AppEnumName.ArticleQuestionStatus:
                    return _ArticleQuestionStatusFR[messageID];
                case AppEnumName.NotifyType:
                    return _NotifyTypeFR[messageID];
                case AppEnumName.WebSiteType:
                    return _WebSiteTypeFR[messageID];
                case AppEnumName.UnionAccountType:
                    return _UnionAccountTypeFR[messageID];
                case AppEnumName.CooperationType:
                    return _CooperationTypeFR[messageID];
                case AppEnumName.ChannelType:
                    return _ChannelTypeFR[messageID];
                case AppEnumName.ArticleQuestionType:
                    return _ArticleQuestionTypeFR[messageID];
                case AppEnumName.PayStatus:
                    return _PayStatusFR[messageID];
                case AppEnumName.EGiftStatus:
                    return _EGiftStatusFR[messageID];
                case AppEnumName.ProductType:
                    return _ProductTypeFR[messageID];
                case AppEnumName.ReStatus:
                    return _ReStatusFR[messageID];
                case AppEnumName.RecomProKind:
                    return _RecomProKindFR[messageID];
                case AppEnumName.StoreInStatus:
                    return _StoreInStatusFR[messageID];
                case AppEnumName.CostMode:
                    return _CostModeFR[messageID];
                case AppEnumName.ShipOrderStatus:
                    return _ShipOrderStatusFR[messageID];
                case AppEnumName.StoreOutType:
                    return _StoreOutTypeFR[messageID];
                case AppEnumName.StoreInType:
                    return _StoreInTypeFR[messageID];
                case AppEnumName.DefType:
                    return _DefTypeFR[messageID];
                case AppEnumName.TBOrdStatus:
                    return _TBOrdStatusFR[messageID];
                case AppEnumName.TBCarryType:
                    return _TBCarryTypeFR[messageID];
                case AppEnumName.FunctionID:
                    return _FunctionIDFR[messageID];
                case AppEnumName.CusNumType:
                    return _CusNumTypeFR[messageID];
                case AppEnumName.CusChatType:
                    return _CusChatTypeFR[messageID];
                case AppEnumName.ReMoneyStatus:
                    return _ReMoneyStatusFR[messageID];
                case AppEnumName.StoreHouseProperty:
                    return _StoreHousePropertyFR[messageID];
                case AppEnumName.ProSortRule:
                    return _ProSortRuleFR[messageID];
                case AppEnumName.TemperaAttr:
                    return _TemperaAttrFR[messageID];
                case AppEnumName.CarrySheetStatus:
                    return _CarrySheetStatusFR[messageID];
                case AppEnumName.AlertSourceType:
                    return _AlertSourceTypeFR[messageID];
                case AppEnumName.POType:
                    return _POTypeFR[messageID];
                case AppEnumName.SalePriceStatus:
                    return _SalePriceStatusFR[messageID];
                case AppEnumName.CusCateConditionType:
                    return _CusCateConditionTypeFR[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }
        static string GetMessageFR(Internationalization interType, string messageID)
        {
            switch (interType)
            {
                case Internationalization.Common:
                    return _CommonFR[messageID];
                case Internationalization.DataList:
                    return _DataListFR[messageID];
                case Internationalization.Storage:
                    return _StorageFR[messageID];
                case Internationalization.Purchasing:
                    return _PurchaseFR[messageID];
                case Internationalization.OrderSys:
                    return _OrderFR[messageID];
                case Internationalization.ProductSys:
                    return _ProductFR[messageID];
                case Internationalization.StockSet:
                    return _StockFR[messageID];
                case Internationalization.MyMenu:
                    return _MenuFR[messageID];
                case Internationalization.Users:
                    return _UsersFR[messageID];
                case Internationalization.PromManage:
                    return _PromManageFR[messageID];
                case Internationalization.CustomerManage:
                    return _CusManageFR[messageID];
                case Internationalization.WebsiteManage:
                    return _WebsiteManageFR[messageID];
                case Internationalization.FinaceManage:
                    return _FinaceManageFR[messageID];
                case Internationalization.SysSetup:
                    return _SysSetupFR[messageID];
                case Internationalization.DeskTop:
                    return _DeskTopFR[messageID];
                case Internationalization.WebCommon:
                    return _WebCommonFR[messageID];
                case Internationalization.WebProduct:
                    return _WebProductFR[messageID];
                case Internationalization.WebTuan:
                    try
                    {
                        return _WebTuanFR[messageID];
                    }
                    catch (Exception e)
                    { throw new ApplicationException(messageID); }
                case Internationalization.WebTheme:
                    return _WebThemeFR[messageID];
                case Internationalization.WebHelp:
                    return _WebHelpFR[messageID];
                case Internationalization.WebAccout:
                    return _WebAccoutFR[messageID];

                case Internationalization.FunctionID:
                    return _FunctionIDFR[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }

        /// <summary>
        /// create by niuyy
        /// 根据枚举及值得到枚举的描述
        /// </summary>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        static string GetMessageGE(AppEnumName msgType, string messageID)
        {
            switch (msgType)
            {
                case AppEnumName.NoEnumName:
                    return _FormWordsGE[messageID];
                    break;
                case AppEnumName.PromotionType:
                    return _PromotionTypeGE[messageID];
                case AppEnumName.PromotionConditionType:
                    return _PromotionConditionTypeGE[messageID];
                case AppEnumName.PromConditionFitType:
                    return _PromConditionFitTypeGE[messageID];
                case AppEnumName.GiftsType:
                    return _GiftsTypeGE[messageID];
                case AppEnumName.OperType:
                    return _OperTypeIDGE[messageID];
                case AppEnumName.PaymentKind:
                    if (messageID == "5")
                        return "邮局付款";
                    return _PaymentKindGE[messageID];
                case AppEnumName.PostType:
                    return _PostTypeGE[messageID];
                case AppEnumName.OrdersStatus:
                    return _OrdersStatusGE[messageID];
                case AppEnumName.AccStatus:
                    return _AccStatusGE[messageID];
                case AppEnumName.ArticleQuestionStatus:
                    return _ArticleQuestionStatusGE[messageID];
                case AppEnumName.NotifyType:
                    return _NotifyTypeGE[messageID];
                case AppEnumName.WebSiteType:
                    return _WebSiteTypeGE[messageID];
                case AppEnumName.UnionAccountType:
                    return _UnionAccountTypeGE[messageID];
                case AppEnumName.CooperationType:
                    return _CooperationTypeGE[messageID];
                case AppEnumName.ChannelType:
                    return _ChannelTypeGE[messageID];
                case AppEnumName.ArticleQuestionType:
                    return _ArticleQuestionTypeGE[messageID];
                case AppEnumName.PayStatus:
                    return _PayStatusGE[messageID];
                case AppEnumName.EGiftStatus:
                    return _EGiftStatusGE[messageID];
                case AppEnumName.ProductType:
                    return _ProductTypeGE[messageID];
                case AppEnumName.ReStatus:
                    return _ReStatusGE[messageID];
                case AppEnumName.RecomProKind:
                    return _RecomProKindGE[messageID];
                case AppEnumName.StoreInStatus:
                    return _StoreInStatusGE[messageID];
                case AppEnumName.CostMode:
                    return _CostModeGE[messageID];
                case AppEnumName.ShipOrderStatus:
                    return _ShipOrderStatusGE[messageID];
                case AppEnumName.StoreOutType:
                    return _StoreOutTypeGE[messageID];
                case AppEnumName.StoreInType:
                    return _StoreInTypeGE[messageID];
                case AppEnumName.DefType:
                    return _DefTypeGE[messageID];
                case AppEnumName.TBOrdStatus:
                    return _TBOrdStatusGE[messageID];
                case AppEnumName.TBCarryType:
                    return _TBCarryTypeGE[messageID];
                case AppEnumName.FunctionID:
                    return _FunctionIDGE[messageID];
                case AppEnumName.CusNumType:
                    return _CusNumTypeGE[messageID];
                case AppEnumName.CusChatType:
                    return _CusChatTypeGE[messageID];
                case AppEnumName.ReMoneyStatus:
                    return _ReMoneyStatusGE[messageID];
                case AppEnumName.StoreHouseProperty:
                    return _StoreHousePropertyGE[messageID];
                case AppEnumName.ProSortRule:
                    return _ProSortRuleGE[messageID];
                case AppEnumName.TemperaAttr:
                    return _TemperaAttrGE[messageID];
                case AppEnumName.CarrySheetStatus:
                    return _CarrySheetStatusGE[messageID];
                case AppEnumName.AlertSourceType:
                    return _AlertSourceTypeGE[messageID];
                case AppEnumName.POType:
                    return _POTypeGE[messageID];
                case AppEnumName.SalePriceStatus:
                    return _SalePriceStatusGE[messageID];
                case AppEnumName.CusCateConditionType:
                    return _CusCateConditionTypeGE[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }
        static string GetMessageGE(Internationalization interType, string messageID)
        {
            switch (interType)
            {
                case Internationalization.Common:
                    return _CommonGE[messageID];
                case Internationalization.DataList:
                    return _DataListGE[messageID];
                case Internationalization.Storage:
                    return _StorageGE[messageID];
                case Internationalization.Purchasing:
                    return _PurchaseGE[messageID];
                case Internationalization.OrderSys:
                    return _OrderGE[messageID];
                case Internationalization.ProductSys:
                    return _ProductGE[messageID];
                case Internationalization.StockSet:
                    return _StockGE[messageID];
                case Internationalization.MyMenu:
                    return _MenuGE[messageID];
                case Internationalization.Users:
                    return _UsersGE[messageID];
                case Internationalization.PromManage:
                    return _PromManageGE[messageID];
                case Internationalization.CustomerManage:
                    return _CusManageGE[messageID];
                case Internationalization.WebsiteManage:
                    return _WebsiteManageGE[messageID];
                case Internationalization.FinaceManage:
                    return _FinaceManageGE[messageID];
                case Internationalization.SysSetup:
                    return _SysSetupGE[messageID];
                case Internationalization.DeskTop:
                    return _DeskTopGE[messageID];
                case Internationalization.WebCommon:
                    return _WebCommonGE[messageID];
                case Internationalization.WebProduct:
                    return _WebProductGE[messageID];
                case Internationalization.WebTuan:
                    return _WebTuanGE[messageID];
                case Internationalization.WebTheme:
                    return _WebThemeGE[messageID];
                case Internationalization.WebHelp:
                    return _WebHelpGE[messageID];
                case Internationalization.WebAccout:
                    return _WebAccoutGE[messageID];
                case Internationalization.FunctionID:
                    return _FunctionIDGE[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }


        /// <summary>
        /// create by niuyy
        /// 根据枚举及值得到枚举的描述
        /// </summary>
        /// <param name="msgType">枚举类型</param>
        /// <param name="messageID">枚举值</param>
        /// <returns></returns>
        static string GetMessageIT(AppEnumName msgType, string messageID)
        {
            switch (msgType)
            {
                case AppEnumName.NoEnumName:
                    return _FormWordsIT[messageID];
                    break;
                case AppEnumName.PromotionType:
                    return _PromotionTypeIT[messageID];
                case AppEnumName.PromotionConditionType:
                    return _PromotionConditionTypeIT[messageID];
                case AppEnumName.PromConditionFitType:
                    return _PromConditionFitTypeIT[messageID];
                case AppEnumName.GiftsType:
                    return _GiftsTypeIT[messageID];
                case AppEnumName.OperType:
                    return _OperTypeIDIT[messageID];
                case AppEnumName.PaymentKind:
                    if (messageID == "5")
                        return "邮局付款";
                    return _PaymentKindIT[messageID];
                case AppEnumName.PostType:
                    return _PostTypeIT[messageID];
                case AppEnumName.OrdersStatus:
                    return _OrdersStatusIT[messageID];
                case AppEnumName.AccStatus:
                    return _AccStatusIT[messageID];
                case AppEnumName.ArticleQuestionStatus:
                    return _ArticleQuestionStatusIT[messageID];
                case AppEnumName.NotifyType:
                    return _NotifyTypeIT[messageID];
                case AppEnumName.WebSiteType:
                    return _WebSiteTypeIT[messageID];
                case AppEnumName.UnionAccountType:
                    return _UnionAccountTypeIT[messageID];
                case AppEnumName.CooperationType:
                    return _CooperationTypeIT[messageID];
                case AppEnumName.ChannelType:
                    return _ChannelTypeIT[messageID];
                case AppEnumName.ArticleQuestionType:
                    return _ArticleQuestionTypeIT[messageID];
                case AppEnumName.PayStatus:
                    return _PayStatusIT[messageID];
                case AppEnumName.EGiftStatus:
                    return _EGiftStatusIT[messageID];
                case AppEnumName.ProductType:
                    return _ProductTypeIT[messageID];
                case AppEnumName.ReStatus:
                    return _ReStatusIT[messageID];
                case AppEnumName.RecomProKind:
                    return _RecomProKindIT[messageID];
                case AppEnumName.StoreInStatus:
                    return _StoreInStatusIT[messageID];
                case AppEnumName.CostMode:
                    return _CostModeIT[messageID];
                case AppEnumName.ShipOrderStatus:
                    return _ShipOrderStatusIT[messageID];
                case AppEnumName.StoreOutType:
                    return _StoreOutTypeIT[messageID];
                case AppEnumName.StoreInType:
                    return _StoreInTypeIT[messageID];
                case AppEnumName.DefType:
                    return _DefTypeIT[messageID];
                case AppEnumName.TBOrdStatus:
                    return _TBOrdStatusIT[messageID];
                case AppEnumName.TBCarryType:
                    return _TBCarryTypeIT[messageID];
                case AppEnumName.FunctionID:
                    return _FunctionIDIT[messageID];
                case AppEnumName.CusNumType:
                    return _CusNumTypeIT[messageID];
                case AppEnumName.CusChatType:
                    return _CusChatTypeIT[messageID];
                case AppEnumName.ReMoneyStatus:
                    return _ReMoneyStatusIT[messageID];
                case AppEnumName.StoreHouseProperty:
                    return _StoreHousePropertyIT[messageID];
                case AppEnumName.ProSortRule:
                    return _ProSortRuleIT[messageID];
                case AppEnumName.TemperaAttr:
                    return _TemperaAttrIT[messageID];
                case AppEnumName.CarrySheetStatus:
                    return _CarrySheetStatusIT[messageID];
                case AppEnumName.AlertSourceType:
                    return _AlertSourceTypeIT[messageID];
                case AppEnumName.POType:
                    return _POTypeIT[messageID];
                case AppEnumName.SalePriceStatus:
                    return _SalePriceStatusIT[messageID];
                case AppEnumName.CusCateConditionType:
                    return _CusCateConditionTypeIT[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }
        static string GetMessageIT(Internationalization interType, string messageID)
        {
            switch (interType)
            {
                case Internationalization.Common:
                    return _CommonIT[messageID];
                case Internationalization.DataList:
                    return _DataListIT[messageID];
                case Internationalization.Storage:
                    return _StorageIT[messageID];
                case Internationalization.Purchasing:
                    return _PurchaseIT[messageID];
                case Internationalization.OrderSys:
                    return _OrderIT[messageID];
                case Internationalization.ProductSys:
                    return _ProductIT[messageID];
                case Internationalization.StockSet:
                    return _StockIT[messageID];
                case Internationalization.MyMenu:
                    return _MenuIT[messageID];
                case Internationalization.Users:
                    return _UsersIT[messageID];
                case Internationalization.PromManage:
                    return _PromManageIT[messageID];
                case Internationalization.CustomerManage:
                    return _CusManageIT[messageID];
                case Internationalization.WebsiteManage:
                    return _WebsiteManageIT[messageID];
                case Internationalization.FinaceManage:
                    return _FinaceManageIT[messageID];
                case Internationalization.SysSetup:
                    return _SysSetupIT[messageID];
                case Internationalization.DeskTop:
                    return _DeskTopIT[messageID];
                case Internationalization.WebCommon:
                    return _WebCommonIT[messageID];
                case Internationalization.WebProduct:
                    return _WebProductIT[messageID];
                case Internationalization.WebTuan:
                    return _WebTuanIT[messageID];
                case Internationalization.WebTheme:
                    return _WebThemeIT[messageID];
                case Internationalization.WebHelp:
                    return _WebHelpIT[messageID];
                case Internationalization.WebAccout:
                    return _WebAccoutIT[messageID];

                case Internationalization.FunctionID:
                    return _FunctionIDIT[messageID];
                default:
                    return "暂时还未初始化数据，应该在SystemFramework.MsgConfig类中初始化！";
            }
        }

        /*   public static System.Web.UI.HtmlControls.HtmlTableCell DataListCell(ZKEShop.DataAccess.UserDataList field, ZKEShop.Common.AppLanguage lang, string sortStr0, string sortDirction)
           {
               var cell = new System.Web.UI.HtmlControls.HtmlTableCell();
               cell.Attributes["class"] = "borderon";
               if (field.DataList.isSort != false)
               {
                   cell.Attributes["onclick"] = "fSortGoSearch('" + field.FieldName + "')";
               }
               cell.NoWrap = true;
               cell.InnerHtml = GetMessage(lang, ZKEShop.Common.Internationalization.DataList, field.DataListID.ToString());
               if (cell.InnerHtml == field.DataListID.ToString())
                   cell.InnerHtml = field.FieldText;
               if (sortStr0 == field.FieldName)
                   cell.InnerHtml += sortDirction;
               return cell;
           }
       
           public static string DataListCell(AppLanguage lang, ZKEShop.DataAccess.UserDataList field, string sortStr0, string sortDirction)
           {
               string strHtml = "<td class='borderon' nowrap";
               if (field.DataList.isSort != false)
                   strHtml += " onclick=\"sortGoSearch('" + field.FieldName + "')\"";
               strHtml += ">";
               string fieldText = GetMessage(lang, ZKEShop.Common.Internationalization.DataList, field.DataListID.ToString());
               if (fieldText == field.DataListID.ToString())
                   fieldText = field.FieldText;
               if (sortStr0 == field.FieldName)
                   fieldText += sortDirction;
               strHtml += fieldText + "</td>";
               return strHtml;
           } */
    }
}
