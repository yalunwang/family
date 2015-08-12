using System.Collections.Generic;

namespace FormWare.Common
{
    public class FentanRow
    {
        public List<FentanRowSuble> suble
        {
            get;
            set;
        }

        public string VouchDebit
        {
            get;
            set;
        }

        public string VouchCredit
        {
            get;
            set;
        }

        public string VouchDebitF
        {
            get;
            set;
        }

        public string VouchCreditF
        {
            get;
            set;
        }

        public string VouchERPAcccode
        {
            get;
            set;
        }

        public string AccountCode
        {
            get;
            set;
        }

        public string VouchDes
        {
            get;
            set;
        }

        public string CurrencyID
        {
            get;
            set;
        }
    }

    public class FentanRowSuble
    {
        public string SubleTypeCode
        {
            get;
            set;
        }

        public string SubleDetailCode
        {
            get;
            set;
        }
    }
}
