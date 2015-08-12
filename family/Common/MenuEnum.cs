namespace ZKEShop.Common
{
    public enum BtnPower : int
    {

        /// <summary>
        /// 添加商品
        /// </summary>
        AddProduct = 40101,//EBS复制

        /// <summary>
        /// 修改商品
        /// </summary>
        ModifyProduct = 40120,//EBS复制

        /// <summary>
        /// 删除商品
        /// </summary>
        DelProduct = 40121,//EBS复制

        /// <summary>
        /// 分类导航_顾客分类与咨询分类权限
        /// </summary>
        ClassifyPower = 1601,

        /// <summary>
        /// 促销活动查看
        /// </summary>
        PromotionsQuery = 1202,

        /// <summary>
        /// 促销活动新建|修改|删除
        /// </summary>
        PromotionsCreateNUpdate = 120201,
        PromotionsDelete = 120202,

        /// <summary>
        /// 提货券查看
        /// </summary>
        GoodsTickList = 2612,

        /// <summary>
        /// 提货券新建|修改
        /// </summary>
        GoodsTickAddAndUpdata = 2613,
        /// <summary>
        /// 提货券删除
        /// </summary>
        GoodsTickDelete = 26130,

        /// <summary>
        /// 网络广告查看
        /// </summary>
        WebAdvertQuery = 2614,

        /// <summary>
        /// 网络广告新建|修改|删除
        /// </summary>
        WebAdvertAMD = 2615,

        /// <summary>
        /// 价格比较查看
        /// </summary>
        PriceCompQuery = 2616,

        /// <summary>
        /// 价格比较新建|修改|删除
        /// </summary>
        PriceCompAMD = 2617,


        /// <summary>
        /// 礼品查看
        /// </summary>
        ExchangeGiftsLogQuery = 2618,

        /// <summary>
        /// 礼品新建|修改|删除
        /// </summary>
        ExchangeGiftsLogAMD = 2619,


        /// <summary>
        /// 发布礼品
        /// </summary>
        PublishedGifts = 120302,

        /// <summary>
        /// 邮件记录查看
        /// </summary>
        MailAMD = 1207,

        /// <summary>
        /// 邮件记录新建|修改|删除
        /// </summary>
        MailQuery = 2633,

        /// <summary>
        /// 礼品列表新建修改
        /// </summary>
        GiftCardListAddAndUpdate = 12030301,

        /// <summary>
        /// 礼品列表删除
        /// </summary>
        GiftCardListDelete = 12030302,

        /// <summary>
        /// 优惠类型
        /// </summary>
        OfferType = 2651,

        /// <summary>
        /// 邮件信息删除
        /// </summary>
        MailRecordDelete = 120701,

        /// <summary>
        /// 邮件信息删除全部
        /// </summary>
        MailRecordDeleteAll = 120702,

        /// <summary>
        /// 邮件信息导出未成功的Email
        /// </summary>
        MailRecordImUnsucc = 2681,

        /// <summary>
        /// 邮件信息重发未成功的Email
        /// </summary>
        MailRecordResendUnsucc = 120704,

        /// <summary>
        /// 短信记录_删除
        /// </summary>
        SMSRecordDelete = 120502,

        /// <summary>
        /// 顾客资料查看
        /// </summary>
        CusInfoQuery = 130202,

        /// <summary>
        /// 顾客资料新建 | 修改
        /// </summary>
        CusInfoCreateNUpdate = 130203,

        /// <summary>
        /// 顾客资料删除
        /// </summary>
        CusInfoDelete = 130204,

        /// <summary>
        /// 顾客资料收款录入
        /// </summary>
        CusInfoCollectionInput = 130205,

        /// <summary>
        /// 顾客分类查看
        /// </summary>
        CusCateQuery = 1303,

        /// <summary>
        /// 顾客分类新建 | 修改 | 删除
        /// </summary>
        CusCateAMD = 3623,

        /// <summary>
        /// 顾客等级查看
        /// </summary>
        CusLevelQuery = 1304,

        ///// <summary>
        ///// 顾客等级新建 | 修改 | 删除
        ///// </summary>
        //CusLevelAMD=3625,

        /// <summary>
        /// 顾客网币记录
        /// </summary>
        CusCurrencyRecord = 130206,

        /// <summary>
        /// 增加顾客网币
        /// </summary>
        AddCusCurrency = 130207,

        /// <summary>
        /// 顾客积分记录
        /// </summary>
        CusIntegralRecord = 130208,

        /// <summary>
        /// 增加|修改顾客积分
        /// </summary>
        AddAndUpdataCusIntegral = 130209,

        /// <summary>
        /// 删除顾客积分
        /// </summary>
        DeleteCusIntegral = 130210,

        /// <summary>
        /// 顾客等级新增|修改
        /// </summary>
        CusLevelAddAndUpdate = 130401,

        /// <summary>
        /// 顾客等级删除
        /// </summary>
        CusLevelDelete = 130402,

        /// <summary>
        /// 会员分类
        /// </summary>
        MemberCate = 130301,

        /// <summary>
        /// 会员分类新建 | 修改
        /// </summary>
        MemberAddAndUpdate = 130302,

        /// <summary>
        /// 会员分类删除
        /// </summary>
        MemberDelete = 130303,

        /// <summary>
        /// 导入顾客资料
        /// </summary>
        ImportCusInfo = 130501,

        /// <summary>
        /// 联盟公告管理_新建
        /// </summary>
        AllNoticeManageAdd = 3701,


        /// <summary>
        /// 联盟公告管理_删除
        /// </summary>
        AllNoticeManageDelete = 3711,

        /// <summary>
        /// 鼓了资料_收货人

        /// </summary>
        Consignee = 130210,

        /// <summary>
        /// 收货人_新增 | 修改
        /// </summary>
        ConsigneeAddModify = 130211,

        /// <summary>
        /// 删除
        /// </summary>
        ConsigneeDelete = 130212,

        /// <summary>
        /// 默认收货人

        /// </summary>
        ConsigneeDefault = 130213,

        /// <summary>
        /// 订单管理
        /// </summary>
        OrderManagement = 1401,

        /// <summary>
        /// 新建修改草稿订单
        /// </summary>
        DraftOrderAndUpdata = 1402,

        /// <summary>
        /// 分拆订单发货
        /// </summary>
        SplitOrderDelivery = 140101,


        /// <summary>
        /// 订单审核
        /// </summary>
        OrderAudit = 140102,

        /// <summary>
        /// 作废订单
        /// </summary>
        CanceledOrder = 140103,

        /// <summary>
        /// 顾客分类查看
        /// </summary>
        ReSheetQuery = 1303,

        /// <summary>
        /// 顾客分类新建 | 修改 | 删除
        /// </summary>
        ReSheetAMD = 4663,

        /// <summary>
        /// 打印订单
        /// </summary>
        PrintOrder = 140104,

        /// <summary>
        /// 合并订单
        /// </summary>
        MergeOrder = 140105,


        /// <summary>
        /// 查看订单详细
        /// </summary>
        QueryOrderDetail = 140106,


        /// <summary>
        /// 待到款订单|待退款订单页面权限

        /// </summary>
        BeToCurrOrBeRefundOrderPower = 1410,


        /// <summary>
        /// 订单到款录入
        /// </summary>
        OrderToCurrEntry = 141001,

        /// <summary>
        /// 导入网上支付款

        /// </summary>
        ImPayOnline = 141002,


        /// <summary>
        /// 订单发货 | 回执管理
        /// </summary>
        OrderDelOrReceiptManage = 1417,

        /// <summary>
        /// 生成配货单

        /// </summary>
        GenerPickingSingle = 141701,

        /// <summary>
        /// 发送提供商
        /// </summary>
        DeliveryProvider = 141702,

        /// <summary>
        /// 确认退款

        /// </summary>
        ConfirmTheRefund = 141703,


        /// <summary>
        /// 导入物流运单编号
        /// </summary>
        ImportPostCode = 140108,

        /// <summary>
        /// 保存运单编号
        /// </summary>
        SavePostCode = 140109,

        /// <summary>
        /// 导出订单
        /// </summary>
        OutPutOrder = 140107,



        /// <summary>
        /// 特惠商品新建|保存|删除
        /// </summary>
        SpecialOffersAMD = 5601,

        /// <summary>
        /// 商品套餐新建|修改
        /// </summary>
        PackageGoodsAddAndUpdate = 150502,

        /// <summary>
        /// 商品套餐删除
        /// </summary>
        PackageGoodsDelete = 150503,

        /// <summary>
        /// 新建商品
        /// </summary>
        AddModifyGoods = 150105,

        /// <summary>
        /// 删除商品
        /// </summary>
        DeleteGoods = 150106,

        /// <summary>
        /// 排序商品
        /// </summary>
        SortGoods = 150107,

        /// <summary>
        /// 修改商品库存
        /// </summary>
        ModifyGoodsInventory = 150201,


        /// <summary>
        /// 商品分类新建|修改
        /// </summary>
        GoodsCateAddAndModify = 150901,

        /// <summary>
        /// 商品分类删除
        /// </summary>
        GoodsCateDelete = 150902,

        /// <summary>
        /// 品牌管理新建|修改
        /// </summary>
        BrandManageAddAndModify = 1501001,

        /// <summary>
        /// 品牌管理删除
        /// </summary>
        BrandManageDel = 1501002,

        /// <summary>
        /// 商品评论修改
        /// </summary>
        ProReviewsModify = 150701,

        /// <summary>
        /// 商品评论删除
        /// </summary>
        ProReviewsDel = 150702,

        /// <summary>
        /// 商品咨询修改
        /// </summary>
        ProConsModify = 150801,

        /// <summary>
        /// 商品咨询删除
        /// </summary>
        ProConsDelete = 150802,

        /// <summary>
        /// 批量修改商品信息
        /// </summary>
        BatchModifyProInfo = 150108,

        /// <summary>
        /// 新建促销商品
        /// </summary>
        AddPromotionsPro = 5761,

        /// <summary>
        /// 修改促销商品
        /// </summary>
        ModifyPromotionsPro = 5771,

        /// <summary>
        /// 推荐新闻新建
        /// </summary>
        RecommendedNewsAdd = 5781,

        /// <summary>
        /// 推荐新闻删除
        /// </summary>
        RecommendedNewsDelete = 5791,

        /// <summary>
        /// 推荐商品新增
        /// </summary>
        FeaturedProductsAdd = 16010601,

        /// <summary>
        /// 推荐商品删除
        /// </summary>
        FeaturedProductsDel = 16010602,

        /// <summary>
        /// 推荐商品保存
        /// </summary>
        FeaturedProductsSave = 16010603,

        /// <summary>
        /// 搜索关键字管理_禁止显示 
        /// </summary>
        SearchKeywordSuppress = 150601,

        /// <summary>
        /// 搜索关键字管理_撤销显示
        /// </summary>
        SearchKeywordRemDis = 150602,

        /// <summary>
        /// 搜索关键字管理_删除
        /// </summary>
        SearchKeywordDelete = 150603,


        /// <summary>
        /// 网站调查_新建
        /// </summary>
        WebsiteSurveyAdd = 6601,

        /// <summary>
        /// 网站调查_修改
        /// </summary>
        WebsiteSurveyModify = 6611,

        /// <summary>
        /// 网站调查_删除
        /// </summary>
        WebsiteSurveyDelete = 6621,

        /// <summary>
        /// 网站调查_投票结果
        /// </summary>
        WebsiteSurveyPollRes = 6631,

        /// <summary>
        /// 销售问题_新增
        /// </summary>
        SaleOfAdd = 6641,

        /// <summary>
        /// 销售问题_修改
        /// </summary>
        SaleOfModify = 6651,

        /// <summary>
        /// 销售问题_删除
        /// </summary>
        SaleOfDelete = 6661,

        /// <summary>
        /// 采购单新建|修改
        /// </summary>
        BuyOrderAddandUpdata = 1803,

        /// <summary>
        /// 采购员通讯信息_新增
        /// </summary>
        BuyerCommuInfoAdd = 6671,

        /// <summary>
        /// 采购员通讯信息_修改
        /// </summary>
        BuyerCommuInfoModify = 6681,

        /// <summary>
        /// 采购员通讯信息_删除
        /// </summary>
        BuyerCommuInfoDelete = 6691,

        /// <summary>
        /// 板块管理新建|修改
        /// </summary>
        BlockManageAddAndMiddle = 160101,

        /// <summary>
        /// 板块管理删除
        /// </summary>
        BlockManageDelete = 160102,

        /// <summary>
        /// 网站帮助新建
        /// </summary>
        HelpDocumentationAdd = 160201,

        /// <summary>
        /// 网站帮助修改
        /// </summary>
        HelpDocumentationMiddle = 160202,

        /// <summary>
        /// 网站帮助删除
        /// </summary>
        HelpDocumentationDelete = 160203,

        /// <summary>
        /// 网站公告新建
        /// </summary>
        NotifyAdd = 6703,

        /// <summary>
        /// 网站公告修改
        /// </summary>
        NotifyMiddle = 6713,

        /// <summary>
        /// 网站公告删除
        /// </summary>
        NotifyDelete = 6723,

        /// <summary>
        /// 资讯管理新建
        /// </summary>
        InformationManageAdd = 160701,

        /// <summary>
        /// 资讯管理修改
        /// </summary>
        InformationManageMiddle = 160702,

        /// <summary>
        /// 资讯管理删除
        /// </summary>
        InformationManageDelete = 160703,

        /// <summary>
        /// 资讯管理修改
        /// </summary>
        InformationQAMiddle = 6715,

        /// <summary>
        /// 资讯问答删除
        /// </summary>
        InformationQADelete = 6725,

        /// <summary>
        /// 资讯关键字管理删除
        /// </summary>
        KeyManagementInformationDelete = 6726,

        /// <summary>
        /// 友情连接管理新建
        /// </summary>
        LinkManagementAdd = 160901,

        /// <summary>
        /// 友情连接管理修改
        /// </summary>
        LinkManagementMiddle = 160902,

        /// <summary>
        /// 友情连接管理删除
        /// </summary>
        LinkManagementDelete = 160903,

        /// <summary>
        /// 申请友情连接删除
        /// </summary>
        ApplyFriendLinkDelete = 6728,

        /// <summary>
        /// 索取目录用户资料删除
        /// </summary>
        RequestCatalogUserInfoDelete = 6729,

        /// <summary>
        /// 网站建议列表删除
        /// </summary>
        SiteRecommendedDelete = 6752,

        /// <summary>
        /// 网站抽奖新建
        /// </summary>
        WebsiteDrawAdd = 6733,

        /// <summary>
        /// 网站抽奖修改
        /// </summary>
        WebsiteDrawMiddle = 6743,

        /// <summary>
        /// 网站抽奖删除
        /// </summary>
        WebsiteDrawDelete = 6753,

        /// <summary>
        /// 邮件订阅删除
        /// </summary>
        MailSubscriptionDelete = 6754,

        /// <summary>
        /// 缺货登记删除
        /// </summary>
        ProStockDelete = 6731,

        /// <summary>
        /// 联系我们新增
        /// </summary>
        ContactUsAdd = 161001,

        /// <summary>
        /// 联系我们修改
        /// </summary>
        ContactUsModify = 161002,

        /// <summary>
        /// 联系我们删除
        /// </summary>
        ContactUsDelete = 161003,

        /// <summary>
        /// 联系我们新增
        /// </summary>
        ContactUsAdd1 = 161101,

        /// <summary>
        /// 联系我们修改
        /// </summary>
        ContactUsModify1 = 161102,

        /// <summary>
        /// 联系我们删除
        /// </summary>
        ContactUsDelete1 = 161103,


        /// <summary>
        /// 招聘英才管理新建
        /// </summary>
        JobAdd = 6751,

        /// <summary>
        /// 招聘英才管理删除
        /// </summary>
        JobDelete = 6761,

        /// <summary>
        /// 资讯纠错管理
        /// </summary>
        ArtCorrectionPower = 6771,

        /// <summary>
        /// 资讯纠错管理_ 删除
        /// </summary>
        ArtCorrectionPowerDelete = 6781,

        /// <summary>
        /// 资讯分类_新增
        /// </summary>
        ArtKindAdd = 160601,

        /// <summary>
        /// 资讯分类_修改
        /// </summary>
        ArtKindModify = 160602,

        /// <summary>
        /// 资讯分类_删除
        /// </summary>
        ArtKindDelete = 160603,

        /// <summary>
        /// 菜谱分类_新增
        /// </summary>
        RecipeCataAdd = 6911,

        /// <summary>
        /// 菜谱分类_修改
        /// </summary>
        RecipeCataModify = 6921,

        /// <summary>
        /// 菜谱分类_删除
        /// </summary>
        RecipeCataDelete = 6931,

        /// <summary>
        /// 主题套餐_新增
        /// </summary>
        TaocanAdd = 6912,

        /// <summary>
        /// 主题套餐_修改
        /// </summary>
        TaocanModify = 6922,

        /// <summary>
        /// 主题套餐_删除
        /// </summary>
        TaocanDelete = 6932,

        /// <summary>
        /// 定期特价_新增|修改
        /// </summary>
        ProductPromAddAndModify = 150401,

        /// <summary>
        /// 定期特价_删除
        /// </summary>
        ProductPromDelete = 150402,

        /// <summary>
        /// 菜谱管理_新增
        /// </summary>
        RecipeAdd = 6913,

        /// <summary>
        /// 菜谱管理_修改
        /// </summary>
        RecipeModify = 6923,

        /// <summary>
        /// 菜谱管理_删除
        /// </summary>
        RecipeDelete = 6933,

        /// <summary>
        /// 团购分类_新增
        /// </summary>
        TuanCataAdd = 6914,

        /// <summary>
        /// 团购分类_修改
        /// </summary>
        TuanCataModify = 6924,

        /// <summary>
        /// 团购分类_删除
        /// </summary>
        TuanCataDelete = 6934,

        /// <summary>
        /// 咨询投票分类_新增
        /// </summary>
        ArtVoteKindAdd = 7791,

        /// <summary>
        /// 咨询投票分类_修改
        /// </summary>
        ArtVoteKindModify = 7801,

        /// <summary>
        /// 咨询投票分类_删除
        /// </summary>
        ArtVoteKindDelete = 7811,

        /// <summary>
        /// 旅游在线预定分类_新增
        /// </summary>
        TravelBookOnlineAdd = 6961,

        /// <summary>
        /// 旅游在线预定分类_编辑
        /// </summary>
        TravelBookOnlineModify = 6971,

        /// <summary>
        /// 旅游在线预定分类_删除
        /// </summary>
        TravelBookOnlineDelete = 6981,

        /// <summary>
        /// 提问类别管理_新增
        /// </summary>
        ArtQuestionKindAdd = 6821,

        /// <summary>
        /// 提问类别管理_修改
        /// </summary>
        ArtQuestionKindModify = 6831,

        /// <summary>
        /// 提问类别管理_删除
        /// </summary>
        ArtQuestionKindDelete = 6841,


        /// <summary>
        /// 生成出库单

        /// </summary>
        CreateOutOrder = 170101,

        /// <summary>
        /// 库存状态查询

        /// </summary>
        StockStatusQuery = 171001,


        /// <summary>
        /// 盘点单管理_新建|修改
        /// </summary>
        StockTakingAddAndModify = 171201,

        /// <summary>
        /// 盘点单管理_删除
        /// </summary>
        StockTakingDelete = 171202,

        /// <summary>
        /// 新建入库单_删除
        /// </summary>
        StoreInInfoDelete = 7651,

        /// <summary>
        /// 新建入库单_保存草稿
        /// </summary>
        StoreInInfoSaveDraft = 7661,

        /// <summary>
        /// 新建入库单_保存
        /// </summary>
        StoreInInfoSave = 7671,

        /// <summary>
        /// 入库单管理_新建|修改
        /// </summary>
        StoreInListAddAndModify = 170701,

        /// <summary>
        /// 入库单管理删除
        /// </summary>
        StoreInListDelete = 170702,


        /// <summary>
        /// 出库单_修改
        /// </summary>
        StoreOutListModify = 7715,


        /// <summary>
        /// 出库单_新建
        /// </summary>
        StoreOutListAdd = 170901,

        /// <summary>
        /// 出库单_保存生效
        /// </summary>
        StoreOutListsave = 170902,

        /// <summary>
        /// 出库单_删除
        /// </summary>
        StoreOutListDelete = 170903,

        /// 出库单_保存草稿
        /// </summary>
        StoreOutListSaveDraft = 50115,

        /// 出库单_提交分拣
        /// </summary>
        StoreOutListSorting = 50117,

        /// 出库单_完成扫描
        /// </summary>
        StoreOutListScan = 50119,

        /// 出库单_打印发货单
        /// </summary>
        StoreOutListPrintShipOrder = 20004,

        /// 出库单_导出发货单
        /// </summary>
        StoreOutListExportShipOrder = 50118,

        /// 出库单_打印物流单
        /// </summary>
        StoreOutListPrintExpress = 50120,

        /// 出库单_打印出库单
        /// </summary>
        StoreOutListPrintStoreOut = 50121,

        /// <summary>
        /// 出库单_新建
        /// </summary>
        PurchaseOrderAdd = 7682,

        /// <summary>
        /// 出库单_修改
        /// </summary>
        PurchaseOrderModify = 7692,

        /// <summary>
        /// 出库单_删除
        /// </summary>
        PurchaseOrdertDelete = 7702,

        /// <summary>
        /// 出库单_新建
        /// </summary>
        ReturnOrderAdd = 7716,

        /// <summary>
        /// 出库单_修改
        /// </summary>
        ReturnOrderModify = 7717,

        /// <summary>
        /// 出库单_删除
        /// </summary>
        ReturnOrderDelete = 7718,

        /// <summary>
        /// 移库单管理_新建
        /// </summary>
        MoveStoreAdd = 7722,

        /// <summary>
        /// 移库单管理_修改
        /// </summary>
        MoveStoreModify = 7732,

        /// <summary>
        /// 移库单管理_删除
        /// </summary>
        MoveStoreDelete = 7742,

        /// <summary>
        /// 调拨单管理_新建
        /// </summary>
        TracStockProAdd = 7723,

        /// <summary>
        /// 调拨单管理_修改
        /// </summary>
        TracStockProModify = 7733,

        /// <summary>
        /// 调拨单管理_删除
        /// </summary>
        TracStockProDelete = 7743,

        /// <summary>
        /// 组装单管理_新建
        /// </summary>
        CombStockProAdd = 7724,

        /// <summary>
        /// 组装单管理_修改
        /// </summary>
        CombStockProModify = 7734,

        /// <summary>
        /// 组装单管理_删除
        /// </summary>
        CombStockProDelete = 7744,

        /// <summary>
        /// 订单异常情况登记表_新建
        /// </summary>
        OrderExcepAdd = 1351,

        /// <summary>
        /// 订单异常情况登记表_修改
        /// </summary>
        OrderExcepModify = 1352,

        /// <summary>
        /// 订单异常情况登记表_删除
        /// </summary>
        OrderExcepDelete = 1353,

        /// <summary>
        /// 配车单_新建
        /// </summary>
        CarrySheetAdd = 1354,

        /// <summary>
        /// 配车单_修改
        /// </summary>
        CarrySheetModify = 1355,

        /// <summary>
        /// 配车单_删除
        /// </summary>
        CarrySheetDelete = 1356,

        /// <summary>
        /// 询价报价单_新建
        /// </summary>
        InquiryQuotAdd = 8602,

        /// <summary>
        /// 询价报价单_修改
        /// </summary>
        InquiryQuotModify = 8612,

        /// <summary>
        /// 询价报价单_删除
        /// </summary>
        InquiryQuotDelete = 8622,

        /// <summary>
        /// 退款单_新建
        /// </summary>
        ReturnAmountAdd = 8603,

        /// <summary>
        /// 退款单_修改
        /// </summary>
        ReturnAmountModify = 8613,

        /// <summary>
        /// 退款单_删除
        /// </summary>
        ReturnAmountDelete = 8623,


        /// <summary>
        /// 发票管理_新建
        /// </summary>
        InvoiceAdd = 9602,

        /// <summary>
        /// 发票管理_修改
        /// </summary>
        InvoiceModify = 9612,

        /// <summary>
        /// 发票管理_删除
        /// </summary>
        InvoiceDelete = 9622,

        /// <summary>
        /// 储值卡设置_新建
        /// </summary>
        HabiCardKindAdd = 9604,

        /// <summary>
        /// 储值卡设置_修改
        /// </summary>
        HabiCardKindModify = 9614,

        /// <summary>
        /// 储值卡设置_删除
        /// </summary>
        HabiCardKindDelete = 9624,

        /// <summary>
        ///礼品卡详细_激活
        /// </summary>
        HabiCardKindaction = 9605,



        /// <summary>
        /// 新建|修改供应商资料
        /// </summary>
        AddAndUpdataVenderInfo = 180202,

        /// <summary>
        /// 供应商的联系人资料管理
        /// </summary>
        ProvConInfoManage = 180203,

        /// <summary>
        /// 删除供应商资料

        /// </summary>
        DeleteVenderInfo = 180204,

        /// <summary>
        /// 组织机构新建|修改
        /// </summary>
        OrganizationsAddAndUpdata = 210101,

        /// <summary>
        /// 组织机构删除
        /// </summary>
        OrganizationsDelete = 210102,


        /// 工单管理_新建
        /// </summary>
        CaseSheetAdd = 11602,

        /// <summary>
        /// 工单管理_修改
        /// </summary>
        CaseSheetModify = 11612,

        /// <summary>
        /// 工单管理_删除
        /// </summary>
        CaseSheetDelete = 11622,

        /// <summary>
        /// 自动消息_修改
        /// </summary>
        AutoMessageModify = 11613,

        /// 短信模板_新建
        /// </summary>
        SMSTemplateAdd = 11604,

        /// <summary>
        /// 短信模板_修改
        /// </summary>
        SMSTemplateModify = 11614,

        /// <summary>
        /// 短信模板_删除
        /// </summary>
        SMSTemplateDelete = 11624,

        /// 邮件模版_新建
        /// </summary>
        MailTemplateAdd = 11605,

        /// <summary>
        /// 邮件模版_修改
        /// </summary>
        MailTemplateModify = 11615,

        /// <summary>
        /// 邮件模版_删除
        /// </summary>
        MailTemplateDelete = 11625,


        /// <summary>
        /// 部门新建|修改
        /// </summary>
        DepartmentsAddAndUpdata = 210103,

        /// <summary>
        /// 部门删除
        /// </summary>
        DepartmentsDelete = 210104,

        /// <summary>
        /// 组织机构_部门员工删除
        /// </summary>
        OrganDeparDelete = 210105,


        /// <summary>
        /// 人员新建 | 修改
        /// </summary>
        StaffAddAndUpdata = 210201,

        /// <summary>
        /// 人员删除
        /// </summary>
        StaffDelete = 210202,

        /// <summary>
        /// 添加用户到组
        /// </summary>
        AddUserInGroup = 210301,

        /// <summary>
        /// 新建用户组

        /// </summary>
        UserGroupAMD = 210302,


        /// <summary>
        /// 删除用户组

        /// </summary>
        DeleteUserGroup = 210303,

        /// <summary>
        /// 用户组管理_组内用户新建
        /// </summary>
        GroupOfUserAdd = 210304,

        /// <summary>
        /// 用户组管理_组内用户删除
        /// </summary>
        GroupOfUserDelete = 210305,


        /// <summary>
        /// 权限新建 | 删除
        /// </summary>
        PowerAD = 211301,

        /// <summary>
        /// 基础信息设置
        /// </summary>
        SetOfBasicInfo = 211302,


        /// <summary>
        /// 运费设置新建
        /// </summary>
        FreightSetAdd = 211303,

        /// <summary>
        /// 运费设置修改
        /// </summary>
        FreightSetModify = 211304,

        /// <summary>
        /// 运费设置删除
        /// </summary>
        FreightSetDelete = 11752,


        /// 任务设置_新建
        /// </summary>
        PlanAdd = 11606,

        /// <summary>
        /// 任务设置_修改
        /// </summary>
        PlanModify = 11616,

        /// <summary>
        /// 任务设置_删除
        /// </summary>
        PlanDelete = 11626,

        /// <summary>
        /// 所属用户组新建
        /// </summary>
        UserOfGroupAdd = 211305,

        /// <summary>
        /// 所属用户组删除
        /// </summary>
        UserOfGroupDelete = 211306,

        /// <summary>
        /// 自动消息_移除
        /// </summary>
        AutoNewsRemove = 211307,

        /// <summary>
        /// 自动消息_添加员工
        /// </summary>
        AutoNewsAddPer = 211308,

        //兑换积分比率设置
        HabiToInterPower = 211309,

        /// <summary>
        /// 修改订单的快递公司

        /// </summary>
        ModifyOrderKuaidi = 211310,

        /// <summary>
        /// 上下架控制

        /// </summary>
        ControlIsWeb = 11092,

        ///<summary>
        ///后台模板新建_修改_删除
        ///</summary>
        BakTemplateAMD = 11093,

        /// <summary>
        /// 店铺分类_删除
        /// </summary>
        ProvCataDelete = 230303
    }

    public enum PagePower : int
    {

        /// <summary>
        /// 创建促销活动
        /// </summary>
        CreatePromotions = 2011,

        /// <summary>
        /// 促销活动管理
        /// </summary>
        PromotionsManage = 2131,

        /// <summary>
        /// 促销信息管理
        /// </summary>
        PromInfoManage = 120801,

        /// <summary>
        /// 礼品管理
        /// </summary>
        GiftManage = 120301,

        /// <summary>
        /// 礼品列表
        /// </summary>
        GiftCardList = 120303,

        /// <summary>
        /// 短信群发
        /// </summary>
        SMSMessage = 120401,

        /// <summary>
        /// 短信记录 
        /// </summary>
        SMSRecord = 120501,

        /// <summary>
        /// 邮件群发
        /// </summary>
        MailMessage = 120601,

        /// <summary>
        /// 邮件记录 
        /// </summary>
        MailRecord = 120602,

        /// <summary>
        /// 顾客资料管理
        /// </summary>
        CusDataManage = 130201,


        /// <summary>
        /// 导入顾客资料
        /// </summary>
        ImportCusData = 1720,

        /// <summary>
        /// 联盟会员管理
        /// </summary>
        AllianceMember = 3031,

        /// <summary>
        /// 联盟图片广告管理
        /// </summary>
        AllianceImgManage = 3041,

        /// <summary>
        /// 联盟公告管理
        /// </summary>
        AllianceNoticeManage = 3051,

        /// <summary>
        /// 电话订购
        /// </summary>
        PhoneOrder = 140111,

        /// <summary>
        /// 草稿订单
        /// </summary>
        DraftOrder = 1403,


        /// <summary>
        /// 货到付款审核
        /// </summary>
        DeliveryAudit = 1404,


        /// <summary>
        /// 待到款订单

        /// </summary>
        UntilSectionOrder = 1407,


        /// <summary>
        /// 配货调度
        /// </summary>
        PickingSchedule = 1418,

        /// <summary>
        /// 配货处理
        /// </summary>
        PickingTreatment = 1419,

        /// <summary>
        /// 配货查询
        /// </summary>
        PickingQuery = 1420,

        /// <summary>
        /// 订单查询
        /// </summary>
        OrderQuery = 1411,

        /// <summary>
        /// 订购商品查询
        /// </summary>
        OrderGoodsQuery = 1413,

        /// <summary>
        /// 商品资料管理
        /// </summary>
        GoodsInfoManage = 150101,

        /// <summary>
        /// 推荐商品
        /// </summary>
        FeaturedProducts = 160106,

        /// <summary>
        /// 特惠商品
        /// </summary>
        SpecialOffers = 5081,

        /// <summary>
        /// 商品套餐
        /// </summary>
        PackageGoods = 150501,

        /// <summary>
        /// 搜索关键字管理

        /// </summary>
        SearchKeywordManage = 1506,

        /// <summary>
        /// 推荐新闻
        /// </summary>
        RecommendedNews = 5111,

        /// <summary>
        /// 商品评论
        /// </summary>
        ProductsReviews = 1510,

        /// <summary>
        /// 商品咨询
        /// </summary>
        ProductsConsulting = 150111,

        /// <summary>
        /// 商品分类
        /// </summary>
        ProductsCate = 1509,

        /// <summary>
        /// 品牌管理
        /// </summary>
        BrandManagement = 1510,

        //导入商品资料
        ImportOfGoodsData = 150114,

        /// <summary>
        /// 淘宝导入商品
        /// </summary>
        TaobaoImportedGoods = 5181,

        /// <summary>
        /// 完善商品信息
        /// </summary>
        CompleteProInfo = 150115,

        /// <summary>
        /// 广告管理
        /// </summary>
        AdvertisingManage = 160103,


        /// <summary>
        /// 首页Flash图片管理
        /// </summary>
        HomeFlashPictures = 160104,


        /// <summary>
        /// 文字连接
        /// </summary>
        TextLink = 160105,

        /// <summary>
        /// 帮助文档
        /// </summary>
        HelpDocumentation = 1602,


        /// <summary>
        /// 网站公告
        /// </summary>
        SiteNotice = 1603,

        /// <summary>
        /// 网站调查
        /// </summary>
        WebsiteSurvey = 6061,

        /// <summary>
        /// 资讯管理
        /// </summary>
        InformationManage = 1607,

        /// <summary>
        /// 资讯问答
        /// </summary>
        InformationQA = 6081,

        /// <summary>
        /// 资讯关键字管理

        /// </summary>
        KeyManagementInformation = 6091,

        /// <summary>
        /// 友情连接管理
        /// </summary>
        LinkManagement = 1609,

        /// <summary>
        /// 申请友情连接
        /// </summary>
        ApplyFriendLink = 6111,

        /// <summary>
        /// 索取目录用户资料
        /// </summary>
        RequestCatalogUserInfo = 6121,

        /// <summary>
        /// 资讯类别管理
        /// </summary>
        InformationCataManage = 6131,

        /// <summary>
        /// 缺货登记
        /// </summary>
        ProStock = 6265,

        /// <summary>
        /// 提问类别管理
        /// </summary>
        QuestionCateManage = 6141,

        /// <summary>
        /// 招聘英才管理
        /// </summary>
        JobsManagement = 6151,

        /// <summary>
        /// 销售问题

        /// </summary>
        SaleOf = 6161,

        /// <summary>
        /// 采购员通讯信息
        /// </summary>
        BuyerCommuInfo = 6171,

        /// <summary>
        /// 板块管理
        /// </summary>
        BlockManage = 1601,

        /// <summary>
        /// 网站抽奖新建|修改
        /// </summary>
        WeblockerAddAndUpdata = 160501,

        /// <summary>
        /// 网站抽奖删除
        /// </summary>
        WeblockerDelete = 160502,

        /// <summary>
        /// 联系我们
        /// </summary>
        ContactUs = 1610,

        /// <summary>
        /// 网站抽奖
        /// </summary>
        WebsiteDraw = 6201,


        /// <summary>
        /// 邮件订阅
        /// </summary>
        MailSubscription = 6211,

        /// <summary>
        /// 网站建议列表
        /// </summary>
        SiteRecommendedList = 6221,

        /// <summary>
        /// 资讯分类
        /// </summary>
        ArtKind = 1606,

        /// <summary>
        /// 菜谱分类
        /// </summary>
        RecipeCata = 6901,

        /// <summary>
        /// 主题套餐
        /// </summary>
        Taocan = 6902,

        /// <summary>
        /// 菜谱管理
        /// </summary>
        Recipe = 6903,

        /// <summary>
        /// 团购分类
        /// </summary>
        TuanCata = 6904,

        /// <summary>
        /// 在线预定分类
        /// </summary>
        BookingOnline = 6951,


        /// <summary>
        /// 供应商管理

        /// </summary>
        VenderManage = 180201,


        /// <summary>
        /// 到款录入
        /// </summary>
        ToTheSectionEntry = 1904,

        /// <summary>
        /// 导入网上支付款

        /// </summary>
        ImportPaymentsOnline = 1905,

        /// <summary>
        /// 到款查询
        /// </summary>
        ToTheSectionQuery = 1906,

        /// <summary>
        /// 储值卡设置
        /// </summary>
        CardSet = 9051,

        /// <summary>
        /// 销售统计

        /// </summary>
        SalesStatistics = 200702,

        /// <summary>
        /// 顾客分析
        /// </summary>
        CustomersAnalysis = 200703,

        /// <summary>
        /// 商品分析
        /// </summary>
        ProductsAnalysis = 200704,

        /// <summary>
        /// 销售分析

        /// </summary>
        SalesAnalysis = 200705,


        /// <summary>
        /// 组织机构
        /// </summary>
        Organizations = 2101,

        /// <summary>
        /// 人员管理
        /// </summary>
        PersonnelManag = 2102,

        /// <summary>
        /// 用户组管理

        /// </summary>
        UserGroupManage = 2103,

        /// <summary>
        /// 自动消息
        /// </summary>
        AutoNews = 211314,

        /// <summary>
        /// 邮件模版
        /// </summary>
        MailTemp = 211315,

        /// <summary>
        /// 短信模板
        /// </summary>
        SMSTemplates = 211316,


        /// <summary>
        /// 基础资料
        /// </summary>
        BasicInformation = 211317,

        /// <summary>
        /// 配送费用

        /// </summary>
        DistributionCosts = 211318,
        /// <summary>
        /// 登录记录
        /// </summary>
        LogRecords = 2111,

        ///<summary>
        ///后台模板管理
        ///</summary>
        BakTemplate = 12011,

        /// <summary>
        /// 店铺分类
        /// </summary>
        ProvCata = 2303
       
    }
}
