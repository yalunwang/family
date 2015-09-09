using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKEShop.Common
{
    public  class number
    {
        /// <summary>
        /// 将decimal？转为小数点只有两位
        /// </summary>
        /// <returns></returns>
        public static decimal convTwo(decimal? moneywait )
        {
            decimal money;
            money = Convert.ToDecimal(moneywait);
            money = Math.Round(money,2);
            return money;
        }
    }
}
