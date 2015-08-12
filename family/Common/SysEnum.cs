using System;
using System.ComponentModel;
namespace ZKEShop.Common
{
    public enum SysObject
    {
        /// <summary>
        /// 顾客资料
        /// </summary>
        Customer = 1,

        /// <summary>
        /// 促销商品类别
        /// </summary>
        PromProductKind = 2,

        /// <summary>
        /// 送货时段
        /// </summary>
        SongTime = 3,

        /// <summary>
        /// 客户来源
        /// </summary>
        ResourceType = 4,

        /// <summary>
        /// 顾客类别
        /// </summary>
        CusCate = 5,

        /// <summary>
        /// 商品推荐类型
        /// </summary>
        RecomProKind = 6,

        /// <summary>
        /// 单品资料
        /// </summary>
        ProductItem = 7,

        /// <summary>
        /// 单品资料(含产品)
        /// </summary>
        ProductItemOfPro = 9,

        /// <summary>
        /// 快捷方式
        /// </summary>
        QuickLink = 10,

        /// <summary>
        /// 商品资料
        /// </summary>
        Product = 11,

        /// <summary>
        /// 销售统计(按顾客)
        /// </summary>
        ReportByCustomer = 12,

        /// <summary>
        /// 销售统计(按商品)
        /// </summary>
        ReportByProduct = 13,

        /// <summary>
        /// 商品品牌
        /// </summary>
        Brand = 15,

        /// <summary>
        /// 促销商品
        /// </summary>
        ProductPro = 16,

        /// <summary>
        /// 交易查询
        /// </summary>
        OrdersProductVS = 17,

        /// <summary>
        /// 退款单
        /// </summary>
        ReMoneySheet = 18,

        /// <summary>
        /// 收款记录
        /// </summary>
        Income = 19,

        /// <summary>
        /// 省份
        /// </summary>
        Province = 20,

        /// <summary>
        /// 人员职位
        /// </summary>
        Duty = 21,

        /// <summary>
        /// 职业
        /// </summary>
        Vocation = 22,

        /// <summary>
        /// 采购单

        /// </summary>
        PurchaseOrder = 23,

        /// <summary>
        /// 采购结算方式
        /// </summary>
        ClearingForm = 24,

        /// <summary>
        /// 采购运输方式
        /// </summary>
        PurCarryType = 25,

        /// <summary>
        /// 会员积分
        /// </summary>
        Integral = 26,

        /// <summary>
        /// 物流单号
        /// </summary>
        PostCodeSet = 27,

        /// <summary>
        /// 商品入库明细
        /// </summary>
        SIProduct = 28,

        /// <summary>
        /// 商品出库明细
        /// </summary>
        SOProduct = 29,

        /// <summary>
        /// 盘点差异
        /// </summary>
        STProDiff = 30,

        /// <summary>
        /// 移库单
        /// </summary>
        MoveStore = 31,

        /// <summary>
        /// 配车单
        /// </summary>
        CarrySheet = 32,

        /// <summary>
        /// 组装单

        /// </summary>
        CombStockPro = 33,

        /// <summary>
        /// 调拨单
        /// </summary>
        TracStockPro = 34,

        /// <summary>
        /// 采购预警
        /// </summary>
        PurchaseAlert = 35,

        /// <summary>
        /// 工单管理
        /// </summary>
        CaseSheet = 36,

        /// <summary>
        /// 收货人
        /// </summary>
        Contactor = 54,

        /// <summary>
        /// 订单处理
        /// </summary>
        Orders = 57,

        /// <summary>
        /// 发货单
        /// </summary>
        ShipOrder = 58,

        /// <summary>
        /// 采购退货单
        /// </summary>
        ReturnOrder = 59,

        /// <summary>
        /// 盘点单
        /// </summary>
        StockTaking = 65,

        /// <summary>
        /// 促销活动
        /// </summary>
        Promotion = 66,

        /// <summary>
        /// 送货方式
        /// </summary>
        CarryType = 67,

        /// <summary>
        /// 供应商资料
        /// </summary>
        Provider = 68,

        /// <summary>
        /// 销售退货单
        /// </summary>
        ReSheet = 69,

        /// <summary>
        /// 入库单
        /// </summary>
        StoreIn = 70,

        /// <summary>
        /// 出库单
        /// </summary>
        StoreOut = 71,

        /// <summary>
        /// 会员现金
        /// </summary>
        CusFund = 72,

        /// <summary>
        /// 帮助文档
        /// </summary>
        HelpNews = 73,

        /// <summary>
        /// 咨询管理
        /// </summary>
        Article = 74,

        /// <summary>
        /// 咨询评论
        /// </summary>
        CommentArt = 75,

        /// <summary>
        /// 咨询纠错
        /// </summary>
        ArtCorrection = 76,

        /// <summary>
        /// 咨询提问
        /// </summary>
        ArticleQuestion = 77,

        /// <summary>
        /// 咨询答复
        /// </summary>
        ReplyArtQuestion = 78,

        /// <summary>
        /// 推荐新闻
        /// </summary>
        ReCommendNews = 79,

        /// <summary>
        /// 网站公告
        /// </summary>
        Notify = 80,

        /// <summary>
        /// 联盟会员
        /// </summary>
        UnionAccount = 81,

        /// <summary>
        /// 联盟资金账户
        /// </summary>
        UnionFund = 82,

        /// <summary>
        /// 促销新闻
        /// </summary>
        PromNotify = 83,

        /// <summary>
        /// 联盟公告
        /// </summary>
        UnionNotify = 84,

        /// <summary>
        /// 联盟图片广告
        /// </summary>
        UnionAD = 85,

        /// <summary>
        /// 网站礼品
        /// </summary>
        GiftCard = 86,

        /// <summary>
        /// 银行转帐
        /// </summary>
        PaymentBank = 87,

        /// <summary>
        /// 订单邮件商品
        /// </summary>
        OrdersProduct = 88,

        /// <summary>
        /// 广告活动
        /// </summary>
        WebAdvert = 89,

        /// <summary>
        /// 联系我们
        /// </summary>
        ContactUS = 90,

        /// <summary>
        /// 组织机构
        /// </summary>
        Department = 91,

        /// <summary>
        /// 物流打印模板
        /// </summary>
        ShipPRTSet = 92,

        /// <summary>
        /// 短信记录
        /// </summary>
        BatchSMS = 93,

        /// <summary>
        /// 收件人记录

        /// </summary>
        MobileList = 94,

        /// <summary>
        /// 短信群发
        /// </summary>
        MailList = 95,

        /// <summary>
        /// 邮件订阅
        /// </summary>
        MagazineEmail = 96,

        /// <summary>
        /// 邮件记录
        /// </summary>
        BatchMail = 97,

        /// <summary>
        /// 询价报价单

        /// </summary>
        InquiryQuotation = 98,

        /// <summary>
        /// 长供商品
        /// </summary>
        LongSupply = 99,

        /// <summary>
        /// 网站调查
        /// </summary>
        Investigate = 100,

        /// <summary>
        /// 任务指令
        /// </summary>
        Plan = 101,

        /// <summary>
        /// 任务类别
        /// </summary>
        PlanType = 102,

        /// <summary>
        /// 供应商评分

        /// </summary>
        SupplierScore = 103,

        /// <summary>
        /// 包装箱

        /// </summary>
        PackingBox = 104,

        /// <summary>
        /// 任务状态

        /// </summary>
        planstatus = 105,

        /// <summary>
        /// 版块管理
        /// </summary>
        WebFuntion = 106,

        /// <summary>
        /// 搜索关键字管理

        /// </summary>
        Searchkey = 107,

        /// <summary>
        /// 搜索商品关键字管理

        /// </summary>
        ArtSearchkey = 108,

        /// <summary>
        /// 友情链接
        /// </summary>
        FriendLink = 109,

        /// <summary>
        /// 申请连接
        /// </summary>
        FriendSite = 110,

        /// <summary>
        /// 索取目录用户资料
        /// </summary>
        GetGift = 111,

        /// <summary>
        /// 网站建议列表
        /// </summary>
        Suggestion = 112,

        /// <summary>
        /// 网站抽奖
        /// </summary>
        Lottery = 113,

        /// <summary>
        /// 抽奖名单
        /// </summary>
        WinList = 114,

        /// <summary>
        /// 缺货登记
        /// </summary>
        ProStock = 115,

        /// <summary>
        /// 商品套餐
        /// </summary>
        ProPackage = 116,

        /// <summary>
        /// 商品咨询管理
        /// </summary>
        ProductConsult = 117,

        /// <summary>
        /// 完善商品信息
        /// </summary>
        ErrorPro = 118,

        /// <summary>
        /// 产品定制
        /// </summary>
        ProBook = 119,

        /// <summary>
        /// 价格比较
        /// </summary>
        PriceComp = 120,

        /// <summary>
        /// 储值卡设置
        /// </summary>
        HabiCardKind = 121,

        /// <summary>
        /// 菜谱管理
        /// </summary>
        Recipe = 122,

        /// <summary>
        /// 邮件模版
        /// </summary>
        MailTemplate = 123,

        /// <summary>
        /// 短信模版
        /// </summary>
        SMSTemplate = 124,

        /// <summary>
        /// 自动消息
        /// </summary>
        MessageKind = 125,

        /// <summary>
        /// 已售商品序列号

        /// </summary>
        SaledProSN = 126,
        /// <summary>
        /// 商品评论
        /// </summary>
        ProReview = 127,

        /// <summary>
        /// 送货时间段

        /// </summary>
        CarryTime = 128,

        /// <summary>
        /// 配送区域

        /// </summary>
        CarryGroup = 129,

        /// <summary>
        /// 索取发票

        /// </summary>
        Invoice = 130,

        /// <summary>
        /// 发票定单关联

        /// </summary>
        InvoiceOfOrders = 131,

        ///<summary>
        ///订购商品查询
        /// </summary>
        BookOrderList = 138,


        /// <summary>
        /// 门店介绍
        /// </summary>
        NovoTrueShop = 135,

        /// <summary>
        /// 门店楼层
        /// </summary>
        Floor = 136,

        /// <summary>
        /// 拍卖保证金

        /// </summary>
        PaimaiPayOrder = 137,

        /// <summary>
        /// 采购跟踪
        /// </summary>
        POProductV = 142,

        /// <summary>
        /// 用户登录
        /// </summary>
        Users = 147,

        /// <summary>
        /// 库存查询
        /// </summary>
        StorePostSta = 148,

        /// <summary>
        /// 库存明细
        /// </summary>
        StoreDetail = 149,

        /// <summary>
        /// 供应商结算
        /// </summary>
        ProvBalance = 150,

        /// <summary>
        /// 网币
        /// </summary>
        Habi = 155,

        /// <summary>
        /// 提货卷
        /// </summary>
        GoodsTicket = 152,


        /// <summary>
        /// 资讯类别
        /// </summary>
        ArtKind = 156,

        /// <summary>
        /// 资讯图片集
        /// </summary>
        Albums = 157,

        /// <summary>
        /// 推荐商品
        /// </summary>
        RecomPro = 158,

        /// <summary>
        /// 物流公司
        /// </summary>
        PostOffice = 159,

        ///<summary>
        ///会员等级
        ///</summary>
        CusLevel = 160,

        /// <summary>
        /// 组内用户
        /// </summary>
        UserInGroup = 161,

        /// <summary>
        /// 部门人员
        /// </summary>
        DepartmentUsers = 162,

        /// <summary>
        /// 商品类别
        /// </summary>
        ProductCata = 154,

        /// <summary>
        /// 用户组
        /// </summary>
        UserGroup = 164,

        /// <summary>
        /// 订单退款
        /// </summary>
        ReAmount = 165,

        /// <summary>
        /// 推荐商户
        /// </summary>
        RecomProvider = 166,

        /// <summary>
        /// 供应商级别
        /// </summary>
        ProviderLevel = 167,
        /// <summary>
        /// 资质认证
        /// </summary>
        ProvCertificateLog = 168,
        /// <summary>
        /// 商圈发布
        /// </summary>
        Forum = 169,
        /// <summary>
        /// 回空商品管理
        /// </summary>
        RecycleProduct = 170,


    }

    /// <summary>
    /// 配置节类型
    /// </summary>
    public enum AppEnumName : short
    {
        /// <summary>
        /// 界面显示
        /// </summary>
        NoEnumName = 0,

        /// <summary>
        /// 字段名称
        /// </summary>
        FieldName = 1,

        /// <summary>
        /// 国家名称
        /// </summary>
        Country = 2,

        /// <summary>
        /// 促销类型
        /// </summary>
        PromotionType = 3,

        /// <summary>
        /// 业务操作种类
        /// </summary>
        OperType = 4,

        /// <summary>
        /// 
        /// </summary>
        SnsOperType = 5,

        /// <summary>
        /// 促销条件类型
        /// </summary>
        PromotionConditionType = 6,

        /// <summary>
        /// 促销条件参与匹配逻辑
        /// </summary>
        PromConditionFitType = 7,

        /// <summary>
        /// 促销赠送优惠类型

        /// </summary>
        PromConditionGiftsType = 8,

        /// <summary>
        /// 支付方式
        /// </summary>
        PaymentKind = 9,

        /// <summary>
        /// 订单状态
        /// </summary>
        OrdersStatus = 10,

        /// <summary>
        /// 促销活动赠送优惠类型
        /// </summary>
        GiftsType = 11,

        /// <summary>
        /// 配送方式
        /// </summary>
        PostType = 12,

        /// <summary>
        /// 账户记录状态

        /// </summary>
        AccStatus = 13,

        /// <summary>
        /// 资讯提问状态

        /// </summary>
        ArticleQuestionStatus = 14,

        /// <summary>
        /// 网站公告类别
        /// </summary>
        NotifyType = 15,

        /// <summary>
        /// 网站类型
        /// </summary>
        WebSiteType = 16,

        /// <summary>
        /// 网站联盟账户类型
        /// </summary>
        UnionAccountType = 17,

        /// <summary>
        /// 联盟合作类型
        /// </summary>
        CooperationType = 18,

        /// <summary>
        /// 网站频道
        /// </summary>
        ChannelType = 19,

        /// <summary>
        /// 资讯提问属性

        /// </summary>
        ArticleQuestionType = 20,

        /// <summary>
        /// 支付状态
        /// </summary>
        PayStatus = 21,

        /// <summary>
        /// 推荐(产品销售，会员注册)广告类型
        /// </summary>
        WebSiteADType = 22,

        /// <summary>
        /// 支付银行
        /// </summary>
        NetPayID = 23,

        /// <summary>
        /// 礼品兑换状态
        /// </summary>
        EGiftStatus = 24,

        /// <summary>
        /// 产品类型
        /// </summary>
        ProductType = 25,

        /// <summary>
        /// 退换货状态
        /// </summary>
        ReStatus = 26,

        /// <summary>
        /// 推荐商品类别
        /// </summary>
        RecomProKind = 27,

        /// <summary>
        /// 入库单状态
        /// </summary>
        StoreInStatus = 28,

        /// <summary>
        /// 库存核算方法
        /// </summary>
        CostMode = 29,

        /// <summary>
        /// 发货单状态
        /// </summary>
        ShipOrderStatus = 30,

        /// <summary>
        /// 出库类型
        /// </summary>
        StoreOutType = 31,

        /// <summary>
        /// 入库类型
        /// </summary>
        StoreInType = 32,

        /// <summary>
        /// 广告活动识别方式
        /// </summary>
        DefType = 33,

        /// <summary>
        /// 淘宝订单状态
        /// </summary>
        TBOrdStatus = 34,

        /// <summary>
        /// 淘宝运输方式
        /// </summary>
        TBCarryType = 35,

        /// <summary>
        /// 网页版块功能
        /// </summary>
        FunctionID = 36,

        /// <summary>
        /// 客流统计类别
        /// </summary>
        CusNumType = 37,

        /// <summary>
        /// 呼叫中心会话状态
        /// </summary>
        CusChatType = 38,

        /// <summary>
        /// 退款支付方式

        /// </summary>
        ReturnPayType = 39,

        /// <summary>
        /// 退款状态

        /// </summary>
        ReMoneyStatus = 42,

        /// <summary>
        /// 国际化板块
        /// </summary>
        Internationalization = 45,

        /// <summary>
        /// 仓库属性

        /// </summary>
        StoreHouseProperty = 46,

        /// <summary>
        /// 审核状态

        /// </summary>
        CheckStatus = 48,

        /// <summary>
        /// 结账点

        /// </summary>
        CheckoutPoint = 49,

        /// <summary>
        /// 商品排序规则
        /// </summary>
        ProSortRule = 50,

        /// <summary>
        /// 商品存储温度属性

        /// </summary>
        TemperaAttr = 51,

        /// <summary>
        /// 采购单退货方式

        /// </summary>
        PurchaseReturnType = 52,

        /// <summary>
        /// 采购单审核条件

        /// </summary>
        PuchaseCheckCondition = 53,

        /// <summary>
        /// 配车状态

        /// </summary>
        CarrySheetStatus = 54,

        /// <summary>
        /// 修改订单节点
        /// </summary>
        ModOrderNode = 55,

        /// <summary>
        /// 采购预警来源类型
        /// </summary>
        AlertSourceType = 56,

        /// <summary>
        /// 采购类型
        /// </summary>
        POType = 57,

        /// <summary>
        /// 销售价格状态

        /// </summary>
        SalePriceStatus = 58,

        /// <summary>
        /// 扫描状态

        /// </summary>
        ScanStatus = 59,

        /// <summary>
        /// 入库单的实际业务操作状态

        /// </summary>
        StockDealStatus = 60,

        /// <summary>
        /// 退保证金状态

        /// </summary>
        RefundStatus = 61,

        /// <summary>
        /// 退保证金方式

        /// </summary>
        Refund = 62,

        /// <summary>
        /// 会员分类条件类型
        /// </summary>
        CusCateConditionType = 63,

        /// <summary>
        /// 促销分类
        /// </summary>
        ProPromCataID = 64,

        /// <summary>
        /// 投诉类型
        /// </summary>
        TousuType = 65,

        /// <summary>
        /// 商品套餐类型
        /// </summary>
        packageType = 66,

        ///<summary>
        ///后台模板类型
        ///</summary>
        BakTemplateType = 67,

        /// <summary>
        /// 供应商结算方式
        /// </summary>
        BalanceType = 68,

        /// <summary>
        /// 结算状态
        /// </summary>
        BalanceStatus = 69,

        /// <summary>
        /// 友情连接类型
        /// </summary>
        LinkType = 70,

        /// <summary>
        /// 店铺导航连接类型
        /// </summary>
        ProvNavLinkType = 71,

        /// <summary>
        /// 求购状态
        /// </summary>
        NeedStatus = 72,

        /// <summary>
        /// 服务状态
        /// </summary>
        ServiceStatus = 73,

        /// <summary>
        /// 退款状态【平台】
        /// </summary>
        ReAmountStatus = 74,

        /// <summary>
        /// 平台退款介入状态
        /// </summary>
        sysReGoodsStatus = 75,

        /// <summary>
        /// 运费收费模式
        /// </summary>
        ChargeType = 76,

        /// <summary>
        /// 订单类型
        /// </summary>
        OrderType = 77,

        /// <summary>
        /// 会员审核状态
        /// </summary>
        CusVerifyStatus = 78,
        /// <summary>
        /// 回空单状态
        /// </summary>
        RecycleOrderStatus = 79,
    }

    /// <summary>
    /// 国家化功能块
    /// </summary>
    public enum Internationalization : int
    {
        /// <summary>
        /// 网页版块功能
        /// </summary>
        FunctionID = 1,

        /// <summary>
        /// 客流统计类别
        /// </summary>
        CusNumType = 2,

        /// <summary>
        /// 呼叫中心会话状态
        /// </summary>
        CusChatType = 3,

        /// <summary>
        /// 公共的
        /// </summary>
        Common = 4,

        /// <summary>
        /// DataList表
        /// </summary>
        DataList = 5,

        /// <summary>
        /// 仓储系统
        /// </summary>
        Storage = 6,

        /// <summary>
        /// 供货系统
        /// </summary>
        Purchasing = 7,

        /// <summary>
        /// 订单系统
        /// </summary>
        OrderSys = 8,

        /// <summary>
        /// 商品系统
        /// </summary>
        ProductSys = 9,

        /// <summary>
        /// 仓储设置
        /// </summary>
        StockSet = 10,

        /// <summary>
        /// 我的菜单
        /// </summary>
        MyMenu = 11,

        /// <summary>
        /// 员工
        /// </summary>
        Users = 12,

        /// <summary>
        /// 营销管理
        /// </summary>
        PromManage = 13,

        /// <summary>
        /// 会员管理
        /// </summary>
        CustomerManage = 14,

        /// <summary>
        /// 网站管理
        /// </summary>
        WebsiteManage = 15,

        /// <summary>
        /// 财务管理
        /// </summary>
        FinaceManage = 16,

        /// <summary>
        /// 系统设置
        /// </summary>
        SysSetup = 17,

        ///快捷桌面
        ///
        DeskTop = 18,

        /// <summary>
        /// 网站前台公用节点
        /// </summary>
        WebCommon = 19,

        /// <summary>
        /// 网站商品页面
        /// </summary>
        WebProduct = 20,


        /// <summary>
        /// 网站团购页面
        /// </summary>
        WebTuan = 21,

        /// <summary>
        /// 网站主题套餐页面
        /// </summary> 
        WebTheme = 22,

        /// <summary>
        /// 网站帮助
        /// </summary>
        WebHelp = 23,

        /// <summary>
        /// 网站用户中心
        /// </summary>
        WebAccout = 24,

        /// <summary>
        /// 商户中心菜单menu.ascx
        /// </summary>
        MsgSellerMenu = 25,

        /// <summary>
        /// 商户中心head.ascx
        /// </summary>
        MsgSellerHead = 26,

        /// <summary>
        /// 商户中心orderslist.aspx
        /// </summary>
        MsgSelOrderList = 27,

        /// <summary>
        /// PageBase
        /// </summary>
        MsgPageBase = 28,

        /// <summary>
        /// 商户中心orderdetail1.aspx
        /// </summary>
        MsgSelOrderDetail = 29,

        /// <summary>
        /// 商户中心ReviewManage.aspx
        /// </summary>
        MsgSelReviewManage = 30,

        /// <summary>
        /// 我的发货地址库
        /// </summary>
        DeliveryBase = 31,

        /// <summary>
        /// 商户中心ShipOrderList.aspx
        /// </summary>
        MsgSelShipOrderList = 32,

        /// <summary>
        /// 商户中心发货单详细页面SendGoods.aspx
        /// </summary>
        MsgSelShipOrderDetail = 33,

        /// <summary>
        /// 商户中心退货页面 ReGoodsList.aspx
        /// </summary>

        MsgSelOrderReGoodsList = 34,

        /// <summary>
        /// 申请退款页面 ReGoodsDetail.aspx
        /// </summary>
        MsgSelOrderReGoodsDetail = 35,

        /// <summary>
        ///  退货提示页面 ReGoodsConfirm.aspx
        /// </summary>
        MsgSelOrderReGoodsConfirm = 36,

        /// <summary>
        /// 退货详情 RefRegoods.aspx
        /// </summary>
        MsgSelOrderRefRegoods = 37,
        /// <summary>
        /// 修改商品的价格 ModPrice.aspx
        /// </summary>
        MsgSelOrderModPrice = 38,
        /// <summary>
        ///  销售订单 Mark.aspx
        /// </summary>
        MsgSelOrderMark = 39,

        /// <summary>
        /// 添加产品 AdFlashPicInfo.aspx
        /// </summary>
        MsgSelNavAdFlashPicInfo = 40,
        /// <summary>
        /// 卖家中心 - 发布产品 ChoiceProCata.aspx
        /// </summary>
        MsgSelProductChoiceProCata = 41,
        /// <summary>
        /// 卖家中心 - 产品详细 ProductDetail.aspx
        /// </summary>
        MsgSelProductDetail = 42,
        /// <summary>
        /// 橱窗推荐 ProductTj.aspx
        /// </summary>
        MsgSelProductProductTj = 43,
        /// <summary>
        /// 出货列表 SellProductList.aspx
        /// </summary>
        MsSelProductList = 44,
        /// <summary>
        /// 卖家中心 - 出售中的宝贝 StoreProductList.aspx
        /// </summary>
        MsgProductStoreList = 45,
        /// <summary>
        /// 编辑促销活动 LimitTjInfo.aspx
        /// </summary>
        MsgPromotionLimitTjInfo = 46,
        /// <summary>
        ///限时限量特价页面 LimitTjList.aspx
        /// </summary>
        MsgPromotionLimitTjList = 47,
        /// <summary>
        /// 套餐信息 PackageInfo.aspx
        /// </summary>
        MsgPromotionPackageInfo = 48,
        /// <summary>
        ///套餐管理 PackageList.aspx
        /// </summary>
        MsgPromotionPackageList = 49,

        /// <summary>
        /// 编辑促销管理活动 PromotionInfo1.aspx
        /// </summary>
        MsgPromotionProInfo = 50,
        /// <summary>
        ///编辑促销活动1  PromotionInfo2.aspx
        /// </summary>
        MsgPromotionProInfo2 = 51,
        /// <summary>
        ///卖家中心 - 编辑促销活动2 PromotionInfo3.aspx
        /// </summary>
        MsgPromotionInfo3 = 52,
        /// <summary>
        ///买家确认收货   PromotionList.aspx
        /// </summary>
        MsgPromotionList = 53,
        /// <summary>
        ///买家确认收货 AfterMarketList.aspx
        /// </summary>
        MsgServiceAfterML = 54,
        /// <summary>
        /// 投诉管理 ComplaintsList.aspx
        /// </summary>
        MsgServiceCompList = 55,
        /// <summary>
        ///卖家中心 - 订单详细 - 4买家确认收货 ConsultingList.aspx
        /// </summary>
        MsgServiceConsultingList = 56,
        /// <summary>
        ///修改运费 CarryTempInfo.aspx
        /// </summary>
        MsgSetupCarryTemp = 57,
        /// <summary>
        ///卖家中心 - 运费设置  CarryTempList.aspx
        /// </summary>
        MseSetupCarryTempList = 58,
        /// <summary>
        ///消费者保障服务 ConsumerProtection.aspx
        /// </summary>
        MseSetupConsumerPro = 59,


    }

    public enum ChargeType : byte
    {
        /// <summary>
        /// 件
        /// </summary>
        Jian = 1,

        /// <summary>
        /// 重量
        /// </summary>
        Zhongliang = 2,

        /// <summary>
        /// 体积
        /// </summary>
        Tiji = 3,
    }

    /// <summary>
    /// 服务状态
    /// </summary>
    public enum ServiceStatus : byte
    {
        /// <summary>
        /// 顾客投诉
        /// </summary>
        CusTousu = 1,

        /// <summary>
        /// 商户投诉
        /// </summary>
        StoreTousu = 2,

        /// <summary>
        /// 退款中
        /// </summary>
        CusReMoney = 3,
    }

    /// <summary>
    /// 求购状态
    /// </summary>
    public enum NeedStatus
    {
        /// <summary>
        /// 发布中
        /// </summary>
        Fabu = 1,

        /// <summary>
        /// 关闭
        /// </summary>
        Close = 2
    }

    /// <summary>
    /// 结算方式
    /// </summary>
    public enum BalanceType : byte
    {
        /// <summary>
        /// 按天
        /// </summary>
        Day = 1,

        /// <summary>
        /// 按月
        /// </summary>
        Month = 2,

        /// <summary>
        /// 按金额
        /// </summary>
        Amount = 3,

        /// <summary>
        /// 按金额再月结
        /// </summary>
        AmountNMonth = 4,

        /// <summary>
        /// 按金额再周结
        /// </summary>
        AmountNWeek = 5,

        /// <summary>
        /// 周结，周一为第一天
        /// </summary>
        Week = 6

    }

    /// <summary>
    /// 供应商结算单状态

    /// </summary>
    public enum BalanceStatus : short
    {
        /// <summary>
        /// 待对账

        /// </summary>
        Approve = 1,

        /// <summary>
        /// 待付款

        /// </summary>
        WaitPay = 2,

        /// <summary>
        /// 已付款

        /// </summary>
        Over = 3,
    }

    public enum PurchaseReturnType : short
    {
        /// <summary>
        /// 抵货
        /// </summary>
        Deduction = 1,

        /// <summary>
        /// 退款

        /// </summary>
        Refund = 2
    }


    /// <summary>
    /// 语言类型
    /// </summary>
    public enum AppLanguage : short
    {
        /// <summary>
        /// 中文
        /// </summary>
        CN = 1,

        /// <summary>
        /// 英文
        /// </summary>
        EN = 2,

        /// <summary>
        /// 法文
        /// </summary>
        FR = 3,

        /// <summary>
        /// 德文
        /// </summary>
        GE = 4,

        /// <summary>
        /// 意大利文
        /// </summary>
        IT = 5
    }

    /// <summary>
    /// 业务操作类型枚举
    /// </summary>
    public enum OperTypeID : short
    {
        /// <summary>
        /// 订单支付
        /// </summary>
        OrdersPay = 1,

        /// <summary>
        /// 取消订单
        /// </summary>
        OrdersCancel = 2,

        /// <summary>
        /// 管理员赠送积分
        /// </summary>
        IntegralAdmin = 3,

        /// <summary>
        /// 购物积分
        /// </summary>
        OrderIntegral = 4,

        /// <summary>
        /// 账户提现
        /// </summary>
        CusTiXian = 5,

        /// <summary>
        /// 账户充值
        /// </summary>
        CusResult = 6,

        /// <summary>
        /// 订单退款
        /// </summary>
        ReturnMoney = 8,

        /// <summary>
        /// 现金兑哈币
        /// </summary>
        FundToHa = 11,

        /// <summary>
        /// 哈币兑积分
        /// </summary>
        HaToInteg = 12,

        /// <summary>
        /// 积分对哈币
        /// </summary>
        IntegToHa = 13,

        /// <summary>
        /// 积分兑换礼品
        /// </summary>
        IntegToGift = 14,

        /// <summary>
        /// 邀请送积分
        /// </summary>
        Integral = 15,

        /// <summary>
        /// 邀请送红包
        /// </summary>
        WebMoney = 16,

        /// <summary>
        /// 邀请送余额
        /// </summary>
        Balance = 17,

        /// <summary>
        /// 注册送积分
        /// </summary>
        RegIntegral = 18,

        /// <summary>
        /// 注册送红包
        /// </summary>
        RegWebMoney = 19,

        /// <summary>
        /// 注册送余额
        /// </summary>
        RegBalance = 20,

        /// <summary>
        /// 订单送礼
        /// </summary>
        OrderGifts = 21,

        /// <summary>
        /// 网币购买订单支付
        /// </summary>
        HabiCardBuySheetPay = 22,

        /// <summary>
        /// 购买的网币
        /// </summary>
        HabiCardBuy = 23,

        /// <summary>
        /// 联盟订单返利
        /// </summary>
        UnionOrderFanli = 24,

        /// <summary>
        /// 支付拍卖保证金
        /// </summary>
        PaimaiPay = 25,

        /// <summary>
        /// 退回保证金
        /// </summary>
        PaimaiReturn = 26,

        /// <summary>
        /// 管理员赠送网币
        /// </summary>
        HabiAdmin = 27,

        /// <summary>
        /// 预订支付
        /// </summary>
        BookOrderPay = 28,

        /// <summary>
        /// 补偿现金券
        /// </summary>
        SendValue = 29,

        /// <summary>
        /// 退换货退款
        /// </summary>
        ReturnGoods = 30,

        /// <summary>
        /// 积分转移网币
        /// </summary>
        InteTransWB = 31,

        /// <summary>
        /// 商品降价退差价
        /// </summary>
        ReductionPrice = 32,

        /// <summary>
        /// 赔偿积分
        /// </summary>
        CompenInteg = 33,

        /// <summary>
        /// 退保证金
        /// </summary>
        RetreatMargin = 34,

        /// <summary>
        /// 下单返利
        /// </summary>
        OrderFanli = 35,

        /// <summary>
        /// 退货返利
        /// </summary>
        ReturnGoodsFanli = 36,

        /// <summary>
        /// 回购返利
        /// </summary>
        RepoFanli = 37,

        /// <summary>
        /// 配送返利
        /// </summary>
        DispatchingFnali = 38,

        /// <summary>
        /// 补空箱扣款
        /// </summary>
        MakeUpFanli = 39
    }

    /// <summary>
    /// 促销赠送优惠类型

    /// </summary>
    public enum GiftsType : short
    {
        /// <summary>
        /// 赠品
        /// </summary>
        Present = 1,

        /// <summary>
        /// 优惠购
        /// </summary>
        FavorableBuy = 2,

        /// <summary>
        /// 返现
        /// </summary>
        ReturnFound = 3,

        /// <summary>
        /// 免运费
        /// </summary>
        FreeShipping = 4,

        /// <summary>
        /// 积分翻倍
        /// </summary>
        IntegralAdd = 5,

        /// <summary>
        /// 现金券
        /// </summary>
        FundTicket = 6,

        /// <summary>
        /// 送积分
        /// </summary>
        SongJiFen = 7,

        /// <summary>
        /// 送红包
        /// </summary>
        SongnHongBao = 8,

        /// <summary>
        /// 送电子优惠券
        /// </summary>
        SongECoupon = 9,

        /// <summary>
        /// 折扣券
        /// </summary>
        DisTicket = 10,

        /// <summary>
        /// 秒杀
        /// </summary>
        MiaoSha = 11,

        /// <summary>
        /// 团购
        /// </summary>
        Tuangou = 12,

        /// <summary>
        /// 拍卖
        /// </summary>
        Paimai = 13,

        /// <summary>
        /// 抽奖
        /// </summary>
        Luck = 14
    }

    public enum PromotionConditionType : short
    {
        /// <summary>
        /// 会员等级
        /// </summary>
        Cuslevel = 1,

        /// <summary>
        /// 购买指定商品(数量)
        /// </summary>
        ProductNum = 2,

        /// <summary>
        /// 购买指定商品(金额)
        /// </summary>
        ProductAmount = 3,

        /// <summary>
        /// 购买指定类别的商品(数量)
        /// </summary>
        ProCataNum = 4,

        /// <summary>
        /// 购买指定类别的商品(金额)
        /// </summary>
        ProCataAmount = 5,

        /// <summary>
        /// 购买指定品牌的商品(数量)
        /// </summary>
        BrandNum = 6,

        /// <summary>
        /// 购买指定品牌的商品(金额)
        /// </summary>
        BrandAmount = 7,

        /// <summary>
        /// 任意商品,满金额
        /// </summary>
        OrderAmount = 8,

        /// <summary>
        /// 注册会员
        /// </summary>
        RegMember = 9,

        /// <summary>
        /// 邀请好友来注册
        /// </summary>
        InviteRegMember = 10,

        /// <summary>
        /// 邀请好友来购买
        /// </summary>
        InviteRegBuy = 11,

        /// <summary>
        /// 注册邮件激活
        /// </summary>
        ActionMemeber = 12,

        /// <summary>
        /// 限时抢购
        /// </summary>
        XSQG = 13,

        /// <summary>
        /// 被邀请人来注册
        /// </summary>
        InviteeReg = 14,

        /// <summary>
        /// 扣减积分
        /// </summary>
        DisInte = 15

    }

    /// <summary>
    /// 逻辑匹配条件
    /// </summary>
    public enum PromConditionFitType : short
    {
        /// <summary>
        /// 必要条件
        /// </summary>
        Must = 0,

        /// <summary>
        /// 兼容条件
        /// </summary>
        Compatible = 1
    }


    public enum PaymentKind : short
    {
        /// <summary>
        /// 货到付款
        /// </summary>
        COD = 1,

        /// <summary>
        /// 网上支付
        /// </summary>
        NetPay = 3,

        /// <summary>
        /// 银行转账
        /// </summary>
        Bank = 4,

        /// <summary>
        /// 邮局汇款
        /// </summary>
        PostOffice = 5,

        /// <summary>
        /// 账期付款
        /// </summary>
        LPPayment = 6,

        /// <summary>
        /// 货到付款
        /// </summary>
        KindCOD = 7,
        /// <summary>
        /// 挂账
        /// </summary>
        KindGuaZ = 8,
        /// <summary>
        /// 网上支付
        /// </summary>
        KindNetPay = 9,
        /// <summary>
        /// 积分付款
        /// </summary>
        KindJFFK = 10

    }

    public enum ProPackageType
    {
        ///<summary>
        ///商品套餐
        ///</summary>
        ProductTaoc = 1,

        ///<summary>
        ///群英惠

        ///</summary>
        Qunyinghui = 2,
    }

    public enum OrdersStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        CaoGao = -1,

        /// <summary>
        /// 待确认
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        WaitApprove = 1,

        /// <summary>
        /// 待发货
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        WaitSend = 3,

        /// <summary>
        /// 待回执(配送途中)
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        WaitOver = 4,

        /// <summary>
        /// 完成
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        Over = 5,

        /// <summary>
        /// 关闭
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        Cancel = 6,

        /// <summary>
        /// 退款中
        /// </summary>
        [Obsolete("众网项目不适用，请使用 OrdersWaitApprove,OrdersWaitSend,OrdersWaitOver,OrdersOver,Ordersinvalid 枚举值")]
        ReturnAmount = 8,

        ///此处以下是追加的枚举

        /// <summary>
        /// 待审核
        /// </summary>
        OrdersWaitApprove = 9,
        /// <summary>
        /// 待发货
        /// </summary>
        OrdersWaitSend = 10,
        /// <summary>
        /// 待签收
        /// </summary>
        OrdersWaitOver = 11,
        /// <summary>
        /// 完成
        /// </summary>
        OrdersOver = 12,
        /// <summary>
        /// 作废
        /// </summary>
        Ordersinvalid = 13

    }
    /// <summary>
    /// 回空单状态
    /// </summary>
    public enum RecycleOrderStatus : short
    {
        /// <summary>
        /// 申请成功
        /// </summary>
        Wait = 1,
        /// <summary>
        /// 回空成功
        /// </summary>
        Completed = 2
    }
    public enum ReAmountStatus
    {
        /// <summary>
        /// 申请中
        /// </summary>
        ShenQing = 1,

        /// <summary>
        /// 商铺同意退款/待退货
        /// </summary>
        TongYi = 2,

        /// <summary>
        /// 拒绝，待修改
        /// </summary>
        Modify = 3,

        /// <summary>
        /// 顾客已退货/待商户收退货
        /// </summary>
        ReGoods = 4,

        /// <summary>
        /// 退款完成
        /// </summary>
        Over = 5,

        /// <summary>
        /// 关闭（商铺拒绝退款）
        /// </summary>
        JuJue = 6,

        /// <summary>
        /// 申请仲裁
        /// </summary>
        ZhongCai = 7,
    }

    /// <summary>
    /// 订单配送类型
    /// </summary>
    public enum PostType
    {
        /// <summary>
        /// 自提
        /// </summary>
        Ziti = 1,
        /// <summary>
        /// 送货上门
        /// </summary>
        ToHome = 2
    }

    /// <summary>
    /// 账户记录状态

    /// </summary>
    public enum AccStatus : short
    {
        /// <summary>
        /// 冻结
        /// </summary>
        DongJie = 1,
        /// <summary>
        /// 有效
        /// </summary>
        YouXiao = 2,

        /// <summary>
        /// 到期作废
        /// </summary>
        DaoQi = 3,
        /// <summary>
        /// 已使用
        /// </summary>
        Used = 4
    }

    public enum ArticleQuestionStatus : short
    {
        /// <summary>
        ///待解决问题

        /// </summary>
        Wait = 1,

        /// <summary>
        /// 已解决问题

        /// </summary>
        Finished = 2
    }

    public enum ArticleQuestionType : short
    {
        /// <summary>
        /// 最新问题

        /// </summary>
        NewQuestion = 1,

        /// <summary>
        /// 热门问题
        /// </summary>
        HotQuestion = 2
    }

    /// <summary>
    /// 推荐商品类别
    /// </summary>
    public enum RecomProKindID : short
    {
        /// <summary>
        /// 首页推荐
        /// </summary>
        RecomHome = 1,

        /// <summary>
        /// 购物车推荐

        /// </summary>
        RecomCart = 2,

        /// <summary>
        /// 推荐海报
        /// </summary>
        RecomPoster = 3,

        /// <summary>
        /// 首页母婴用品
        /// </summary>
        RecomMBaby = 4,

        /// <summary>
        /// 首页服饰
        /// </summary>
        RecomHomeFinery = 5,

        /// <summary>
        /// 首页玩具
        /// </summary>
        RecomHomeToy = 6,

        /// <summary>
        /// 首页美妆
        /// </summary>
        RecomHomeAdorn = 7,

        /// <summary>
        /// 首页保健
        /// </summary>
        RecomhealthHealthCare = 8,

        /// <summary>
        /// 频道
        /// </summary>
        RecomChannelHome = 9,

        /// <summary>
        /// 产品列表
        /// </summary>
        RecomProList = 10,

        /// <summary>
        /// 礼想家

        /// </summary>
        RecomHomeGift = 11
    }

    /// <summary>
    /// 网站公告类型
    /// </summary>
    public enum NotifyType : short
    {
        /// <summary>
        /// 网站公告
        /// </summary>
        WebNotify = 1,

        /// <summary>
        /// 网站促销公告
        /// </summary>
        PromNotify = 2,

        /// <summary>
        /// 关于网站
        /// </summary>
        AboutNotify = 3,

        /// <summary>
        /// 积分公告
        /// </summary>
        IntegralNotify = 4,
        /// <summary>
        /// 协议
        /// </summary>
        Agreement = 5
    }

    /// <summary>
    /// 品牌公告类型
    /// </summary>
    public enum BrandNotifyType : short
    {
        /// <summary>
        /// 品牌公告
        /// </summary>
        Notice = 1,

        /// <summary>
        /// 品牌促销活动
        /// </summary>
        Activity = 2

    }

    /// <summary>
    /// 联盟网站类型
    /// </summary>
    public enum WebSiteType : short
    {
        /// <summary>
        /// 导航站

        /// </summary>
        NavigationWeb = 1,

        /// <summary>
        /// 内容站

        /// </summary>
        ContentWeb = 2,

        /// <summary>
        /// 论坛
        /// </summary>
        ForumWeb = 3,

        /// <summary>
        /// 博客
        /// </summary>
        BlogWeb = 4,

        /// <summary>
        /// 其他
        /// </summary>
        OtherWeb = 5
    }

    /// <summary>
    /// 网站联盟账户类型
    /// </summary>
    public enum UnionAccountType : short
    {
        /// <summary>
        /// 个人帐号
        /// </summary>
        PersonalAccount = 1,

        /// <summary>
        /// 公司帐号
        /// </summary>
        CompanyAccount = 2
    }

    /// <summary>
    /// 联盟合作类型
    /// </summary>
    public enum CooperationType : short
    {
        /// <summary>
        /// 网站用户
        /// </summary>
        WebSiteUser = 1,

        /// <summary>
        /// 网店用户
        /// </summary>
        WebStoreUser = 2
    }

    /// <summary>
    /// 网站频道
    /// </summary>
    public enum ChannelType : short
    {
        /// <summary>
        /// 首页
        /// </summary>
        HomecChannel = 1,

        /// <summary>
        /// 母婴用品
        /// </summary>
        MBabyChannel = 2,

        /// <summary>
        /// 服饰
        /// </summary>
        FineryChannel = 3,

        /// <summary>
        /// 玩具
        /// </summary>
        ToyChannel = 4,

        /// <summary>
        /// 美妆
        /// </summary>
        AdornChannel = 5,

        /// <summary>
        /// 保健品

        /// </summary>
        HealthCareChannel = 6
    }

    /// <summary>
    /// 减库存类型

    /// </summary>
    public enum LockSotreNumType
    {
        /// <summary>
        /// 创建订单后

        /// </summary>
        CreateOrder = 1,

        /// <summary>
        /// 订单确认(支付成功)后

        /// </summary>
        ConfirmOrder = 2,

        /// <summary>
        /// 发起支付
        /// </summary>
        ToPayment = 5
    }

    public enum ModOrderNode : byte
    {
        /// <summary>
        /// 发货单待出库--此节点后都不能修改订单

        /// </summary>
        waitOutStore = 1,

        /// <summary>
        /// 发货单待发货--此节点后都不能修改订单

        /// </summary>
        waitSend = 2
    }

    public enum NetPayID : short
    {
        /// 支付宝

        Alipay = 0,

        ///招商银行
        CMB = 1,

        ///中国建设银行
        CCB = 2,

        ///中国工商银行
        ICBCB2C = 3,

        ///兴业银行
        CIB = 4,

        ///广东发展银行
        GDB = 5,

        ///深圳发展银行
        SDB = 6,

        ///中国民生银行
        CMBC = 7,

        ///交通银行

        COMM = 8,

        ///邮政储蓄银行
        POSTGC = 9,

        ///中信银行
        CITIC = 10,

        ///上海浦东发展银行(个人)
        SPDB = 11,

        ///上海浦东发展银行(公司)
        SPDBB2B = 12,

        ///杭州银行
        HZCBB2C = 13,

        ///中国光大银行
        CEBBANK = 14,

        ///中国农业银行(个人)
        ABC = 15,

        ///中国农业银行(公司)
        ABCBTB = 16,

        /// <summary>
        /// 贝宝支付
        /// </summary>
        Paypal = 17,

        /// <summary>
        /// 联华支付
        /// </summary>
        lhok = 18,

        /// <summary>
        /// 便利通支付

        /// </summary>
        blt = 19,

        /// <summary>
        /// 财付通支付

        /// </summary>
        cft = 20,
        /// <summary>
        /// 手机支付
        /// </summary>
        iposmnet = 21,

        /// <summary>
        /// 快钱
        /// </summary>
        bill = 22,

        /// <summary>
        /// 银联网银(chinabank)在线
        /// </summary>
        chinabank = 23,

        /// <summary>
        /// 环讯支付
        /// </summary>
        ips = 24,

        /// <summary>
        /// 银联(unionpay)支付
        /// </summary>
        unionpay = 25,

        /// <summary>
        /// 外币支付
        /// </summary>
        Visa = 26,

        /// <summary>
        /// 银联(chinapay)支付
        /// </summary>
        chinapay = 27
    }

    public enum PaymentByCOD : byte
    {
        /// <summary>
        /// 现金支付
        /// </summary>
        Cash = 1,

        /// <summary>
        /// 信用卡支付

        /// </summary>
        ShuaKa = 2,
    }

    /// <summary>
    /// 支付状态

    /// </summary>
    public enum PayStatus : byte
    {
        /// <summary>
        /// 未支付
        /// </summary>
        NotPay = 1,

        /// <summary>
        /// 已支付
        /// </summary>
        Payed = 2
    }

    /// <summary>
    /// 推荐(产品销售，会员注册)广告类型
    /// </summary>
    public enum WebSiteADType : short
    {
        /// <summary>
        /// 联盟广告
        /// </summary>
        union = 1,

        /// <summary>
        /// 会员邀请

        /// </summary>
        inviter = 2
    }

    public enum EGiftStatus : short
    {
        /// <summary>
        /// 等待发货
        /// </summary>
        wait = 1,

        /// <summary>
        /// 完成兑换
        /// </summary>
        finlished = 2,

        /// <summary>
        /// 作废
        /// </summary>
        invalid = 3
    }

    /// <summary>
    /// 账户类型
    /// </summary>
    public enum AccountType : byte
    {
        /// <summary>
        /// 积分账户
        /// </summary>
        Integral = 1,

        /// <summary>
        /// 网币账户
        /// </summary>
        Habi = 2,

        /// <summary>
        /// 现金账户
        /// </summary>
        Cash = 3,

        /// <summary>
        /// 礼品卡

        /// </summary>
        Card = 4
    }

    public enum MessageType : short
    {
        /// <summary>
        /// 会员注册成功邮件
        /// </summary>
        registersuccessful = 1,

        /// <summary>
        /// 会员邮箱验证成功邮件
        /// </summary>
        validateemailaddress = 2,

        /// <summary>
        /// 会员手机验证成功邮件
        /// </summary>
        validatemobileno = 3,

        /// <summary>
        /// 会员找回密码(重设密码邮件) 
        /// </summary>
        forgotpassword = 4,

        /// <summary>
        /// 会员重设密码成功邮件
        /// </summary>
        resetpwdsuccess = 5,

        /// <summary>
        /// 邀请好友成功返利邮件(积分,红包等) 
        /// </summary>
        invitemember = 6,

        /// <summary>
        /// 联盟会员注册成功邮件 
        /// </summary>
        unionregsuccessful = 7,

        /// <summary>
        /// 联盟会员广告订单邮件 
        /// </summary>
        createorderbyunionad = 8,

        /// <summary>
        /// 联盟会员公告，促销邮件
        /// </summary>
        unionnotify = 9,

        /// <summary>
        /// 联盟会员每月的账单通知邮件
        /// </summary>
        unionbillbymonth = 10,

        /// <summary>
        /// 收藏商品成功邮件 
        /// </summary>
        favoriteproductsuccess = 11,

        /// <summary>
        /// 商品咨询提交成功邮件
        /// </summary>
        advisoryproductsuccessful = 12,

        /// <summary>
        /// 商品咨询被回复通知邮件
        /// </summary>
        revertadvisory = 13,

        /// <summary>
        /// 商品评论成功邮件
        /// </summary>
        commentproductsuccessful = 14,

        /// <summary>
        /// 商品评论被回复邮件


        /// </summary>
        revertcomment = 15,

        /// <summary>
        /// 商品纠错感谢邮件 
        /// </summary>
        correctionproductsuccessful = 16,

        /// <summary>
        /// 缺货登记回复邮件 
        /// </summary>
        revertshortsupplyregistration = 17,

        /// <summary>
        /// 降价通知邮件
        /// </summary>
        pricereductionnotify = 18,

        /// <summary>
        /// 推荐商品给好友

        /// </summary>
        recommendproducttomyfriend = 19,

        /// <summary>
        /// E-mail 免费订阅网站打折促销信息成功通知
        /// </summary>
        emailsubscription = 20,

        /// <summary>
        /// 索取最新免费商品目录的信息提交成功通知
        /// </summary>
        catalogproductsuccessful = 21,

        /// <summary>
        /// 对网站的意见或者建议提交成功后的通知
        /// </summary>
        submitsuggesstionsuccessful = 22,

        /// <summary>
        /// 订单生成成功(待付款)通知邮件
        /// </summary>
        createordersuccessfule = 23,

        /// <summary>
        /// 提醒会员支付订单(定时发送邮件) 
        /// </summary>
        remindmembertopay = 24,

        /// <summary>
        /// 订单支付成功(待发货)通知邮件 
        /// </summary>
        paymentordersuccessful = 25,

        /// <summary>
        /// 取消订单成功邮件
        /// </summary>
        cancelordersuccessful = 26,

        /// <summary>
        /// 订单发货通知 
        /// </summary>
        consignmentordernotify = 27,

        /// <summary>
        /// 退货回复邮件

        /// </summary>
        revertreturnedpurchase = 28,

        /// <summary>
        /// 换货回复邮件
        /// </summary>
        revertniffer = 29,

        /// <summary>
        /// 人才招聘投简历回复邮件 
        /// </summary>
        revertjoboffers = 30,

        /// <summary>
        /// 在资讯问答中心提交问题成功

        /// </summary>
        informationsubmitsuccessful = 31,

        /// <summary>
        /// 在资讯问答中心提交的问题得到答复
        /// </summary>
        revertinformation = 32,

        /// <summary>
        /// 网站联盟用户忘记密码
        /// </summary>
        unionforgetpassword = 34,

        /// <summary>
        /// 新活动通知付款人

        /// </summary>
        NewActivePerson = 35,

        /// <summary>
        /// 发车发送短信

        /// </summary>
        FacheDuanxin = 36,

        /// <summary>
        /// 个人会员邮箱（手机）验证码邮件

        /// </summary>
        VerifyEmailMobile = 37,

        /// <summary>
        /// 会员自动升级发送邮件
        /// </summary>
        changeLeve = 38
    }

    /// <summary>
    /// 产品类型
    /// </summary>
    public enum ProductType : short
    {
        /// <summary>
        /// 进货产品
        /// </summary>
        Nomal = 1,

        /// <summary>
        /// 回空产品
        /// </summary>
        Repo = 2,

        /// <summary>
        /// 礼品卡
        /// </summary>
        GiftCard = 3
    }

    /// <summary>
    /// 订单类型
    /// </summary>
    public enum OrderType : short
    {
        /// <summary>
        /// 餐饮会员采购订单
        /// </summary>
        CusOrder = 1,

        /// <summary>
        /// 经销商会员采购订单
        /// </summary>
        DealerOrder = 2
    }

    public enum ReStatus : short
    {
        /// <summary>
        /// 待受理 申请状态
        /// </summary>
        DaiJieShou = 1,

        /// <summary>
        /// 审核通过
        /// </summary>
        ShengXiao = 2,

        /// <summary>
        /// 申请审核失败
        /// </summary>
        UnChecked = 4,

        /// <summary>
        /// 确认退还货
        /// </summary>
        Actived = 9,

        /// <summary>
        /// 拒收退回
        /// </summary>
        JuShouTuiHui = 10,

        /// <summary>
        /// 退换货完成
        /// </summary>
        Over = 3

    }

    public enum RecomProKind
    {
        /// <summary>
        /// 首页推荐
        /// </summary>
        HomePage = 1,
    }

    /// <summary>
    /// 入库单状态

    /// </summary>
    public enum StoreInStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        Caogao = 1,

        /// <summary>
        /// 生效
        /// </summary>
        ShegXiao = 2,

        /// <summary>
        /// 完成
        /// </summary>
        WanCheng = 3,

        /// <summary>
        /// 作废
        /// </summary>
        ZuoFei = 4
    }

    /// <summary>
    /// 库存核算模式
    /// </summary>
    public enum CostMode : byte
    {
        /// <summary>
        /// 移动加权平均
        /// </summary>
        AVG = 1,

        /// <summary>
        /// 月平均
        /// </summary>
        MonthAVG = 2,
    }

    /// <summary>
    /// 发货单状态

    /// </summary>
    public enum ShipOrderStatus : byte
    {
        /// <summary>
        /// 待出库
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        OutStore = 1,

        /// <summary>
        /// 待复检
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        Approve = 2,

        /// <summary>
        /// 待发货
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        Send = 3,

        /// <summary>
        /// 待回执
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        WaitHuiZhi = 4,

        /// <summary>
        /// 完成
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        Over = 5,

        /// <summary>
        /// 仓库已处理
        /// </summary>
        [Obsolete("众网项目不适用，请使用 ShipOrderDQS,ShipOrderWC,ShipOrderJQZF 枚举值")]
        WHDealed = 6,

        /// <summary>
        /// 待签收
        /// </summary>
        ShipOrderDQS = 7,
        /// <summary>
        /// 完成
        /// </summary>
        ShipOrderWC = 8,
        /// <summary>
        /// 拒签作废
        /// </summary>
        ShipOrderJQZF = 9

    }

    /// <summary>
    /// 出库类型
    /// </summary>
    public enum StoreOutType
    {
        /// <summary>
        /// 销售订单

        /// </summary>
        SaleOrder = 1,

        /// <summary>
        /// 调拨
        /// </summary>
        MoveStore = 2,

        /// <summary>
        /// 采购退货

        /// </summary>
        Return = 3,

        /// <summary>
        /// 报损
        /// </summary>
        Loss = 4,

        /// <summary>
        /// 组装出库
        /// </summary>
        CombPro = 5,
        /// <summary>
        /// 其他
        /// </summary>
        Other = 10

    }

    public enum StoreInType
    {
        /// <summary>
        /// 采购入库
        /// </summary>
        PurchaseOrder = 1,

        /// <summary>
        /// 调拨入库
        /// </summary>
        MoveStore = 2,

        /// <summary>
        /// 退货入库

        /// </summary>
        Return = 3,

        /// <summary>
        /// 报益入库
        /// </summary>
        Surplus = 4,

        /// <summary>
        /// 组装入库
        /// </summary>
        CombPro = 5,

        /// <summary>
        /// 其他入库
        /// </summary>
        Other = 10

    }

    public enum DefType
    {
        /// <summary>
        /// 匹配来源网址
        /// </summary>
        FitFrom = 1,

        /// <summary>
        /// 匹配本站网址
        /// </summary>
        FitLocal = 2,

        /// <summary>
        /// 匹配促销活动
        /// </summary>
        Promotion = 3,

        /// <summary>
        /// 匹配电话号码
        /// </summary>
        Telephone = 10
    }

    public enum TBOrdStatus
    {
        /// <summary>
        /// 没有创建支付宝交易

        /// </summary>
        TRADE_NO_CREATE_PAY = 1,

        /// <summary>
        /// 等待买家付款
        /// </summary>
        WAIT_BUYER_PAY = 2,

        /// <summary>
        /// 买家已付款

        /// </summary>
        WAIT_SELLER_SEND_GOODS = 3,

        /// <summary>
        /// 卖家已发货

        /// </summary>
        WAIT_BUYER_CONFIRM_GOODS = 4,

        /// <summary>
        /// 买家已签收

        /// </summary>
        TRADE_BUYER_SIGNED = 5,

        /// <summary>
        /// 交易成功
        /// </summary>
        TRADE_FINISHED = 6,

        /// <summary>
        /// 交易关闭
        /// </summary>
        TRADE_CLOSED = 7,

        /// <summary>
        /// 交易被淘宝关闭

        /// </summary>
        TRADE_CLOSED_BY_TAOBAO = 8
    }

    public enum TBCarryType
    {
        /// <summary>
        /// 卖家包邮
        /// </summary>
        TBfree = 1,

        /// <summary>
        /// 平邮
        /// </summary>
        TBpost = 2,

        /// <summary>
        /// 快递

        /// </summary>
        TBexpress = 3,

        /// <summary>
        /// EMS
        /// </summary>
        TBems = 4,

        /// <summary>
        /// 虚拟发货的，例如充值卡
        /// </summary>
        TBvirtual = 5
    }

    /// <summary>
    /// 网页版块功能ID
    /// </summary>
    public enum FunctionID
    {
        /// <summary>
        /// 图片轮播广告
        /// </summary>
        CarouselAD = 2,

        /// <summary>
        /// 推荐商品
        /// </summary>
        RecomProduct = 3,

        /// <summary>
        /// 浏览历史
        /// </summary>
        BrowseProduct = 5,

        /// <summary>
        /// 网站公告
        /// </summary>
        Notify = 6,

        /// <summary>
        /// 固定式广告
        /// </summary>
        FixedAD = 8,

        /// <summary>
        /// 关键字连接
        /// </summary>
        RecomUrl = 9,

        /// <summary>
        /// 热门评论
        /// </summary>
        ReComment = 10,

        /// <summary>
        /// 销售排行
        /// </summary>
        SalesRanking = 11,

        /// <summary>
        /// 网站促销公告
        /// </summary>
        SalesNotify = 12,

        ///// <summary>
        ///// 品牌最新商品

        ///// </summary>
        BrandNewPro = 13,

        ///// <summary>
        ///// 品牌热销商品
        ///// </summary>
        //HotSale = 14,

        ///// <summary>
        ///// 品牌公告
        ///// </summary>
        BrandNotice = 15,

        ///// <summary>
        ///// 品牌活动
        ///// </summary>
        BrandActivity = 16,

        /// <summary>
        /// 猜你喜欢
        /// </summary>
        Cainixihua = 17,

        /// <summary>
        /// 凑单商品
        /// </summary>
        CouDan = 20,

        /// <summary>
        /// 限时限量特价
        /// </summary>
        PromTejia = 21,

        /// <summary>
        /// 喜爱的商品
        /// </summary>
        FavoriteProduct = 22,

        /// <summary>
        /// 推荐品牌
        /// </summary>
        RecomBrand = 23,

        /// <summary>
        /// 评论排行
        /// </summary>
        SalesProReview = 24,

        /// <summary>
        /// 推荐套餐
        /// </summary>
        RecomProPack = 25,

        /// <summary>
        /// 首页全部商品类别导航
        /// </summary>
        AllProductCate = 26,

        /// <summary>
        /// 看了什么最终购买排序
        /// </summary>
        SeeSomethingBuy = 27,

        /// <summary>
        /// 店铺头部
        /// </summary>
        StoreHeader = 28,

        /// <summary>
        /// 店铺信息
        /// </summary>
        StoreInfo = 29,

        /// <summary>
        /// 店铺搜索
        /// </summary>
        StoreSearch = 30,

        /// <summary>
        /// 店铺服务
        /// </summary>
        StoreService = 31,

        /// <summary>
        /// 店铺分类
        /// </summary>
        StoreCata = 32,

        /// <summary>
        /// 推荐店铺
        /// </summary>
        RecomStore = 33,

        /// <summary>
        /// 店铺评价
        /// </summary>
        StoreComment = 34,

        /// <summary>
        /// 店铺交易记录
        /// </summary>
        StoreTrade = 35,

        /// <summary>
        /// 推荐资讯
        /// </summary>
        RecomeArticle = 36
    }

    /// <summary>
    /// 销售排行榜类别
    /// </summary>
    public enum SalesType
    {
        /// <summary>
        /// 周排行榜
        /// </summary>
        WeekRank = 1,

        /// <summary>
        /// 月排行榜
        /// </summary>
        MonthRank = 2,

        /// <summary>
        /// 季度排行榜

        /// </summary>
        QuarterRank = 3,

        /// <summary>
        /// 年排行榜
        /// </summary>
        YearRank = 4,

        /// <summary>
        /// 总榜
        /// </summary>
        AllRank = 5
    }

    /// <summary>
    /// 短信接口
    /// </summary>
    public enum SMSServerID
    {
        /// <summary>
        /// 翼锋短信
        /// </summary>
        YFSMS = 1,

        /// <summary>
        /// 乐搜
        /// </summary>
        Lesuo = 2,

        /// <summary>
        /// 一信通(中国联通)
        /// </summary>
        YiXinTong = 3
    }

    public enum CusNumType
    {
        /// <summary>
        /// 总人数

        /// </summary>
        TotalNum = 1,

        /// <summary>
        /// 注册人数
        /// </summary>
        RegNum = 2,

        /// <summary>
        /// 会员人数
        /// </summary>
        MemNum = 3,

        /// <summary>
        /// 购买人数
        /// </summary>
        BuyNum = 4
    }

    public enum BookOrderStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        Caogao = 1,

        /// <summary>
        /// 生效
        /// </summary>
        Booked = 2,

        /// <summary>
        /// 已转为订单(已完成)
        /// </summary>
        Over = 9,

        /// <summary>
        /// 作废
        /// </summary>
        Canceled = 10
    }

    public enum OpentionLog
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        ModuleName,
        /// <summary>
        /// 描述
        /// </summary>
        Description,
        /// <summary>
        /// 详细描述
        /// </summary>
        DetailDesc
    }

    public enum MsgType
    {
        /// <summary>
        /// 普通消息类
        /// </summary>
        FormwareMessage = 0,

        /// <summary>
        /// 金额类型
        /// </summary>
        AmountTypeName = 1,

        /// <summary>
        /// 期间 
        /// </summary>
        Phase = 2,

        /// <summary>
        /// 凭证 
        /// </summary>
        Vouch = 3,

        /// <summary>
        /// 系统参数设置
        /// </summary>
        SysParaSet = 4,

        /// <summary>
        /// 科目
        /// </summary>
        Account = 5,

        /// <summary>
        /// 系统设置
        /// </summary>
        SystemSet = 6,

        /// <summary>
        /// 地区
        /// </summary>
        Area = 7,

        /// <summary>
        /// 辅助账


        /// </summary>
        Subledger = 8,

        /// <summary>
        /// 枚举对应值


        /// </summary>
        EnumValue = 9,

        /// <summary>
        /// 报表
        /// </summary>
        Report = 10,

        /// <summary>
        /// 翻译
        /// </summary>
        Translate = 11,

        /// <summary>
        /// 窗体名称
        /// </summary>
        FormName = 12,

        /// <summary>
        /// 主窗体菜单名
        /// </summary>
        MenuName = 13,
        /// <summary>
        /// 固定资产参数设置：摘要模式


        /// </summary>
        DigestModel = 14,

        /// <summary>
        /// 资产状态


        /// </summary>
        AssetStatus = 15,

        /// <summary>
        /// 资产操作类型
        /// </summary>
        OperationType = 16,

        /// <summary>
        /// 资产科目类型
        /// </summary>
        AssetAccountType = 17,

        /// <summary>
        /// 系统折旧公式
        /// </summary>
        SysDepreFormular = 18,

        /// <summary>
        /// 小数处理方式
        /// </summary>
        RoundType = 19

    }

    public enum CusChatType
    {
        /// <summary>
        /// 会话呼入
        /// </summary>
        inhale = 1,

        /// <summary>
        /// 会话呼出
        /// </summary>
        exsufflate = 2
    }

    /// <summary>
    /// 婚姻状况
    /// </summary>
    public enum MarriageStaID : byte
    {
        /// <summary>
        /// 未婚
        /// </summary>
        unwed = 1,

        /// <summary>
        /// 已婚
        /// </summary>
        wedded = 2

    }

    /// <summary>
    /// 图片类型
    /// </summary>
    public enum PicSizeType : byte
    {
        /// <summary>
        /// 商品图片
        /// </summary>
        productpic = 1,

        /// <summary>
        /// 品牌图片
        /// </summary>
        brandpic = 2
    }

    /// <summary>
    /// 退货退款方式
    /// </summary>
    public enum ReturnPayType : byte
    {
        /// <summary>
        /// 退入账户余额
        /// </summary>
        Amount = 1,

        /// <summary>
        /// 直接退款
        /// </summary>
        Rediect = 2
    }

    /// <summary>
    /// 退款单状态
    /// </summary>
    public enum ReMoneyStatus : byte
    {
        /// <summary>
        /// 待退款
        /// </summary>
        WaitRefund = 1,

        /// <summary>
        /// 完成退款
        /// </summary>
        RefundOver = 2,

        /// <summary>
        /// 取消/作废
        /// </summary>
        Cancel = 10

    }

    /// <summary>
    /// 国际化的字段
    /// </summary>
    public enum LanguageMsgID : short
    {
        CusLevelName = 1
    }

    /// <summary>
    /// 仓库属性

    /// </summary>
    public enum StoreHouseProperty : byte
    {
        /// <summary>
        /// 正常               
        /// </summary>
        Normal = 1,
        /// <summary>
        /// 次品
        /// </summary>
        Inferior = 2,
        /// <summary>
        /// 报废
        /// </summary>
        Scrap = 3

    }

    /// <summary>
    /// 字段类型
    /// </summary>
    public enum FieldType : int
    {
        /// <summary>
        /// 文本
        /// </summary>
        Text = 10001,

        /// <summary>
        /// 数字
        /// </summary>
        Digital = 10005,

        /// <summary>
        /// 靠右数字
        /// </summary>
        DigitalRIght = 10002,

        /// <summary>
        /// 货币
        /// </summary>
        Currency = 10003,

        /// <summary>
        /// 靠右货币
        /// </summary>
        CurrencyRight = 10004,

        /// <summary>
        /// 日期
        /// </summary>
        DateTime = 10006,

        /// <summary>
        /// 是否
        /// </summary>
        BOOLEAN = 10008,

        /// <summary>
        /// 图片
        /// </summary>
        PICTURE = 10010,

        /// <summary>
        /// 富文本
        /// </summary>
        HTML = 10011,

    }

    public enum PuchaseCheckCondition : byte
    {
        /// <summary>
        ///采购单价比上次采购涨跌幅大于x%
        /// </summary>        
        RiseDecline = 1,

        /// <summary>
        ///采购金额大于x额度
        /// </summary>
        LargeAmount = 2,

        /// <summary>
        ///每30天内，采购次数大于前一个30天的x%
        /// </summary>
        PurchaseFrequency = 3
    }

    public enum CheckStatus : byte
    {
        /// <summary>
        /// 未审核

        /// </summary>
        undo = 1,

        /// <summary>
        /// 已审核批准

        /// </summary>
        checkit = 2,

        /// <summary>
        /// 未通过审核
        /// </summary>
        uncheckit = 3
    }

    public enum CheckoutPoint : byte
    {
        /// <summary>
        /// 出厂
        /// </summary>
        OutFactory = 1,

        /// <summary>
        ///离港
        /// </summary>
        DepartPort = 2,

        /// <summary>
        ///到岸
        /// </summary>
        CIF = 3,

        /// <summary>
        ///入库
        /// </summary>        
        InStorage = 4
    }

    /// <summary>
    /// 排序规则
    /// </summary>
    public enum ProSortRule : byte
    {
        /// <summary>
        /// 平均利润由高到低
        /// </summary>
        avgCostHToL = 1,

        /// <summary>
        /// 保质期限由短到长
        /// </summary>
        avidateLToH = 2
    }

    /// <summary>
    /// 商品储存温度属性

    /// </summary>
    public enum TemperaAttr : byte
    {
        /// <summary>
        /// 恒温
        /// </summary>
        henwen = 1,

        /// <summary>
        /// 冷藏
        /// </summary>
        lengcang = 2,

        /// <summary>
        /// 冷冻
        /// </summary>
        lengdong = 3

    }

    /// <summary>
    /// 配车单状态

    /// </summary>
    public enum CarrySheetStatus : byte
    {
        /// <summary>
        /// 草稿
        /// </summary>
        caoGao = 1,

        /// <summary>
        /// 待发车

        /// </summary>
        waitDrive = 2,

        /// <summary>
        /// 待回执

        /// </summary>
        waitHuiZhi = 3,

        /// <summary>
        /// 完成
        /// </summary>
        Over = 4

    }

    /// <summary>
    /// 采购预警来源类型
    /// </summary>
    public enum AlertSourceType : byte
    {
        /// <summary>
        /// 紧急采购--缺货订单的地方生成的
        /// </summary>
        EmergencyPurchase = 1,
        /// <summary>
        /// 安全库存
        /// </summary>
        SafeStore = 2,
        /// <summary>
        /// 预购订单
        /// </summary>
        BookOrder = 3
    }

    /// <summary>
    /// 按国家采购分类

    /// </summary>
    public enum POType : byte
    {
        /// <summary>
        /// 国内采购
        /// </summary>
        Domestic = 1,

        /// <summary>
        /// 国际采购
        /// </summary>
        International = 2
    }

    /// <summary>
    /// 参与方式
    /// </summary>
    public enum InType : byte
    {
        /// <summary>
        /// 我来指定参与者购买的商品
        /// </summary>
        IDecide = 1,

        /// <summary>
        /// 参与者自由选择购买我选的商品
        /// </summary>
        FreeSelect = 2
    }

    /// <summary>
    /// 销售价格状态

    /// </summary>
    public enum SalePriceStatus : byte
    {
        /// <summary>
        /// 正价销售

        /// </summary>
        NormalPrice = 1,

        /// <summary>
        /// 特价销售

        /// </summary>
        SpecialPrice = 2,

        /// <summary>
        /// 促销价

        /// </summary>
        PromotionPrice = 3,

        /// <summary>
        /// 组合销售

        /// </summary>
        CombPrice = 4

    }

    public enum ScanStatus : byte
    {
        /// <summary>
        /// 初始状态

        /// </summary>
        Init = 0,
        /// <summary>
        /// 准备扫描
        /// </summary>
        WaitScan = 1,
        /// <summary>
        /// 完成扫描
        /// </summary>
        OverScan = 2,

        /// <summary>
        /// 处理完成
        /// </summary>
        DealOver = 3
    }

    /// <summary>
    /// 入库操作的实际业务状态

    /// </summary>
    public enum StockDealStatus : byte
    {
        /// <summary>
        /// 初始状态

        /// </summary>
        Init = 0,
        /// <summary>
        /// 待点收

        /// </summary>
        WaitDS = 1,
        /// <summary>
        /// 已点收

        /// </summary>
        OverDS = 2,
        /// <summary>
        /// 待上架

        /// </summary>
        WaitShelf = 3,
        /// <summary>
        /// 已上架

        /// </summary>
        OverShelf = 4,
        /// <summary>
        /// 处理完成
        /// </summary>
        DealOver = 5
    }


    /// <summary>
    /// 验证类型
    /// </summary>
    public enum VerifyType : short
    {
        /// <summary>
        /// 邮箱验证
        /// </summary>
        email = 1,

        /// <summary>
        /// 短信验证
        /// </summary>
        mobile = 2
    }

    public enum ProPromKindID : byte
    {
        /// <summary>
        /// 自动
        /// </summary>
        auto = 1,

        /// <summary>
        /// 手动
        /// </summary>
        manu = 2
    }

    /// <summary>
    /// 退保证金方式

    /// </summary>
    public enum Refund : byte
    {
        /// <summary>
        /// 退入账户余额

        /// </summary>
        Amount = 1,

        /// <summary>
        /// 直接退款

        /// </summary>
        Rediect = 2
    }

    /// <summary>
    /// 退保证金状态
    /// </summary>
    public enum RefundStatus : byte
    {
        /// <summary>
        /// 待退款

        /// </summary>
        WaitRefund = 1,

        /// <summary>
        /// 完成退款

        /// </summary>
        RefundOver = 2,

        /// <summary>
        /// 取消/作废
        /// </summary>
        Cancel = 3

    }

    /// <summary>
    /// 付款方式
    /// </summary>
    public enum PaymentMethod : byte
    {
        /// <summary>
        /// 默认
        /// </summary>
        Default = 0,

        /// <summary>
        /// 在线支付
        /// </summary>
        PaymentOnline = 1,

        /// <summary>
        /// 货到付款
        /// </summary>
        CashOnDelivery = 2
    }

    /// <summary>
    /// 套餐类型
    /// </summary>
    public enum packageType : byte
    {
        /// <summary>
        /// 商品套餐
        /// </summary>
        GoodsPackage = 1,

        /// <summary>
        /// 群英惠

        /// </summary>
        BeatLOH = 2
    }

    ///<summary>
    ///后台模板类型
    /// </summary>
    public enum BakTemplateType : byte
    {

        ///<summary>
        ///采购单打印模板

        ///</summary>
        PrintStoreInOrderTemp = 1,

        ///<summary>
        ///发货单打印模版
        ///</summary>
        PrintShipOrderTemp = 2,

        ///<summary>
        ///供应商打印模板
        ///</summary>
        PrintProviderTemp = 3,

        ///<summary>
        ///报价单打印模板
        ///</summary>
        PrintQuotTemp = 4,

        ///<summary>
        ///采购跟踪打印模板
        ///</summary>
        PrintTrackPOTemp = 5,

        ///<summary>
        ///国际采购单打印模板
        ///</summary>
        PrintInternaPOTemp = 6,

        ///<summary>
        ///客户订单打印模板
        ///</summary>
        PrintCusOrderTemp = 7,

        ///<summary>
        ///缺货单据打印模板
        ///</summary>
        PrintOOSTemp = 8,

        ///<summary>
        ///退换货单据打印模板
        ///</summary>
        PrintReSheetTemp = 9,

        ///<summary>
        ///出库单打印模板
        ///</summary>
        PrintStoreOutTemp = 10,

        ///<summary>
        ///拣货单打印模板
        ///</summary>
        PrintPickingTemp = 11,

        ///<summary>
        ///退货单打印模板
        ///</summary>
        PrintReturnOrderTemp = 12

    }

    /// <summary>
    /// 会员分类条件类型
    /// </summary>
    public enum CusCateConditionType : byte
    {
        /// <summary>
        /// 客户来源
        /// </summary>
        ResourceType = 1,

        /// <summary>
        /// 城市
        /// </summary>
        City = 2
    }

    /// <summary>
    /// 退款/退货状态
    /// </summary>
    public enum ReGoodsStatus : byte
    {
        /// <summary>
        /// 退款申请等待卖家确认中 
        /// </summary>
        Shenqing = 1,

        /// <summary>
        /// 退款成功
        /// </summary>
        Chenggong = 2,

        /// <summary>
        /// 退款关闭
        /// </summary>
        Cancel = 3,
    }

    public enum ChatMsgType : byte
    {
        /// <summary>
        /// 文本信息
        /// </summary>
        txtMessage = 0,

        /// <summary>
        /// 客户登录
        /// </summary>
        CusLogin = 1,

        /// <summary>
        /// 客户询问自己是否在线,并更改其在线状态

        /// </summary>
        CusSeekStatus = 2,

        /// <summary>
        /// 客户退出

        /// </summary>
        CusCheckOut = 3,

        /// <summary>
        /// 客服登录
        /// </summary>
        ServiceLogin = 4,

        /// <summary>
        /// 客服询问自己是否在线,并更改其在线状态

        /// </summary>
        ServiceSeekStatus = 5,

        /// <summary>
        /// 客服退出

        /// </summary>
        ServiceCheckOut = 6,

        /// <summary>
        /// 发起对话
        /// </summary>
        StartChat = 11,

        /// <summary>
        /// 发送文件

        /// </summary>
        SendFile = 21
    }

    /// <summary>
    /// 促销分类
    /// </summary>
    public enum ProPromCataID : byte
    {
        /// <summary>
        /// 团购
        /// </summary>
        TuanGou = 1,

        /// <summary>
        /// 限时抢购
        /// </summary>
        QiangGou = 2,

        /// <summary>
        /// 一般特价

        /// </summary>
        Tejia = 3

    }

    /// <summary>
    /// 投诉状态

    /// </summary>
    public enum TousuStatus : short
    {
        /// <summary>
        /// 未受理

        /// </summary>
        Untreated = 1,

        /// <summary>
        /// 完成
        /// </summary>
        Over = 2,

        /// <summary>
        /// 关闭
        /// </summary>
        Cancel = 3
    }

    /// <summary>
    /// 投诉类型
    /// </summary>
    public enum TousuType : short
    {
        /// <summary>
        /// 产品相关
        /// </summary>
        ProductReID = 1,

        /// <summary>
        /// 价格相关
        /// </summary>
        PriceReID = 2,

        /// <summary>
        /// 物流相关
        /// </summary>
        WuliuReID = 3,

        /// <summary>
        /// 服务相关
        /// </summary>
        ServiceReID = 4,

        /// <summary>
        /// 售后相关
        /// </summary>
        ShouhouReID = 5,

        /// <summary>
        /// 财务相关
        /// </summary>
        FinanceReID = 6,

        /// <summary>
        /// 活动相关
        /// </summary>
        ActivityReID = 7,

        /// <summary>
        /// 网站相关
        /// </summary>
        WebSiteReID = 8,

        /// <summary>
        /// 预约相关
        /// </summary>
        YuyueReID = 9,

        /// <summary>
        /// 其他相关
        /// </summary>
        OtherReID = 10,
    }

    public enum OperationType : short
    {
        /// <summary>
        /// 修改资料
        /// </summary>
        ModifyInfo = 1,

        /// <summary>
        /// 删除资料
        /// </summary>
        DeleteInfo = 2,

        /// <summary>
        /// 登录系统
        /// </summary>
        Login = 3,

        /// <summary>
        /// 退出系统

        /// </summary>
        LogOut = 4,

        /// <summary>
        /// 新增资料
        /// </summary>
        NewInfo = 5,

        /// <summary>
        /// 审核资料
        /// </summary>
        Approve = 6,

    }

    public enum ProvNavLinkType
    {
        /// <summary>
        /// 自定义内容页
        /// </summary>
        Define = 1,

        /// <summary>
        /// 店铺首页
        /// </summary>
        HomePage = 2,

        /// <summary>
        /// 店铺类别
        /// </summary>
        ProvCata = 3
    }

    /// <summary>
    /// 审核状态
    /// </summary>
    public enum CusVerifyStatus
    {
        /// <summary>
        /// 待审核
        /// </summary>
        WaitVerify = 0,

        /// <summary>
        /// 审核成功
        /// </summary>
        VerifyPass = 1,

        /// <summary>
        /// 审核失败
        /// </summary>
        FailureVerify = -1
    }

    public static class GetEnumName
    {
        public static object GetEnumValueByTBOrdStatus(string name)
        {
            int returnVal = 1;
            switch (name)
            {
                case "TRADE_NO_CREATE_PAY":
                    returnVal = 1;
                    break;
                case "WAIT_BUYER_PAY":
                    returnVal = 2;
                    break;
                case "WAIT_SELLER_SEND_GOODS":
                    returnVal = 3;
                    break;
                case "WAIT_BUYER_CONFIRM_GOODS":
                    returnVal = 4;
                    break;
                case "TRADE_BUYER_SIGNED":
                    returnVal = 5;
                    break;
                case "TRADE_FINISHED":
                    returnVal = 6;
                    break;
                case "TRADE_CLOSED":
                    returnVal = 7;
                    break;
                case "TRADE_CLOSED_BY_TAOBAO":
                    returnVal = 8;
                    break;
            }
            return returnVal;
        }

        public static object GetEnumValueByTBCarryType(string name)
        {
            int returnVal = 1;
            switch (name)
            {
                case "TBfree":
                    returnVal = 1;
                    break;
                case "TBpost":
                    returnVal = 2;
                    break;
                case "TBexpress":
                    returnVal = 3;
                    break;
                case "TBems":
                    returnVal = 4;
                    break;
                case "TBvirtual":
                    returnVal = 5;
                    break;
            }
            return returnVal;
        }

        public enum MsgType
        {
            /// <summary>
            /// 普通消息类
            /// </summary>
            FormwareMessage = 0,

            /// <summary>
            /// 金额类型
            /// </summary>
            AmountTypeName = 1,

            /// <summary>
            /// 期间 
            /// </summary>
            Phase = 2,

            /// <summary>
            /// 凭证 
            /// </summary>
            Vouch = 3,

            /// <summary>
            /// 系统参数设置
            /// </summary>
            SysParaSet = 4,

            /// <summary>
            /// 科目
            /// </summary>
            Account = 5,

            /// <summary>
            /// 系统设置
            /// </summary>
            SystemSet = 6,

            /// <summary>
            /// 地区
            /// </summary>
            Area = 7,

            /// <summary>
            /// 辅助账


            /// </summary>
            Subledger = 8,

            /// <summary>
            /// 枚举对应值


            /// </summary>
            EnumValue = 9,

            /// <summary>
            /// 报表
            /// </summary>
            Report = 10,

            /// <summary>
            /// 翻译
            /// </summary>
            Translate = 11,

            /// <summary>
            /// 窗体名称
            /// </summary>
            FormName = 12,

            /// <summary>
            /// 主窗体菜单名
            /// </summary>
            MenuName = 13

        }
    }
}
