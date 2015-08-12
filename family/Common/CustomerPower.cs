using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZKEShop.Common
{
    public enum SysObjectCustomer
    {
        /// <summary>
        /// 用户权限表
        /// </summary>
        CustomerPower=1

    }
    public enum CustomerPower : short
    {
        /// <summary>
        /// 报表查看
        /// </summary>
        ReportView = 1,
        /// <summary>
        /// 订单查看
        /// </summary>
        CheckOrders = 2,
        /// <summary>
        /// 投票查看
        /// </summary>
        VotingView = 3,
        /// <summary>
        /// 积分查看
        /// </summary>
        IntegralView = 4,
        /// <summary>
        /// 手机号码变更
        /// </summary>
        PhoneNumber = 5,
        /// <summary>
        /// 会员地址变更
        /// </summary>
        ChangeOfCustomer = 6,
        /// <summary>
        /// 收货地址变更
        /// </summary>
        ChangeOfAddress = 7
    }
}
