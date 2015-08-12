using System;
using System.Collections.Generic;

namespace ZKEShop.Common
{
    /// <summary>
    /// 科目对照设置中PRC科目组合规则列表
    /// </summary>
    public struct MapList
    {
        private int _AccRuleID;
        private DateTime _BeginDate;
        private IList<MapSubledger> _Subledger;

        public int AccRuleID
        {
            get { return _AccRuleID; }
            set { _AccRuleID = value; }
        }

        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; }
        }

        public IList<MapSubledger> Subledger
        {
            get { return _Subledger; }
            set { _Subledger = value; }
        }
    }

    public struct MapSubledger
    {
        private int _SubledgerType;
        private int _ConditionType;
        private string[] _ConditionValue1;
        private string[] _ConditionValue2;

        public int SubledgerType
        {
            get { return _SubledgerType; }
            set { _SubledgerType = value; }
        }

        public int ConditionType
        {
            get { return _ConditionType; }
            set { _ConditionType = value; }
        }

        public string[] ConditionValue1
        {
            get { return _ConditionValue1; }
            set { _ConditionValue1 = value; }
        }

        public string[] ConditionValue2
        {
            get { return _ConditionValue2; }
            set { _ConditionValue2 = value; }
        }

    }
}
