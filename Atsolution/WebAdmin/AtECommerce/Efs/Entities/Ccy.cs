using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Ccy
    {
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool ExchangeRateOperator { get; set; }
        public bool? Inactive { get; set; }
        public string Caaccount { get; set; }
        public string Baaccount { get; set; }
        public string Prefix { get; set; }
        public string Ccyname { get; set; }
        public string DecimalSeperate { get; set; }
        public string AfterDecimal { get; set; }
        public string Subfix { get; set; }
        public decimal? ConvertRate { get; set; }
        public string PrefixEng { get; set; }
        public string CcynameEng { get; set; }
        public string DecimalSeperateEng { get; set; }
        public string AfterDecimalEng { get; set; }
        public string SubfixEng { get; set; }
        public decimal? ConvertRateEng { get; set; }
        public string PrefixDefault { get; set; }
        public string CcynameDefault { get; set; }
        public string DecimalSeperateDefault { get; set; }
        public string AfterDecimalDefault { get; set; }
        public string SubfixDefault { get; set; }
        public decimal? ConvertRateDefault { get; set; }
        public string PrefixDefaultEng { get; set; }
        public string CcynameDefaultEng { get; set; }
        public string DecimalSeperateDefaultEng { get; set; }
        public string AfterDecimalDefaultEng { get; set; }
        public string SubfixDefaultEng { get; set; }
        public decimal? ConvertRateDefaultEng { get; set; }
        public decimal? ExampleAmount { get; set; }
        public int? SortOrder { get; set; }
        public string ValueOfMoney { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
