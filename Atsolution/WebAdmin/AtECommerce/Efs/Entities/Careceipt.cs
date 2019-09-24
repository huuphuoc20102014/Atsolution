using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Careceipt
    {
        public string RefId { get; set; }
        public int RefType { get; set; }
        public DateTime RefDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string RefNoFinance { get; set; }
        public string RefNoManagement { get; set; }
        public bool IsPostedFinance { get; set; }
        public bool IsPostedManagement { get; set; }
        public string AccountObjectId { get; set; }
        public string AccountObjectName { get; set; }
        public string AccountObjectAddress { get; set; }
        public string AccountObjectContactName { get; set; }
        public int? ReasonTypeId { get; set; }
        public string JournalMemo { get; set; }
        public string DocumentIncluded { get; set; }
        public string CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal TotalAmountOc { get; set; }
        public decimal TotalAmount { get; set; }
        public string BranchId { get; set; }
        public string EmployeeId { get; set; }
        public int DisplayOnBook { get; set; }
        public bool? IsPostedCashBookFinance { get; set; }
        public bool? IsPostedCashBookManagement { get; set; }
        public DateTime? CashBookPostedDate { get; set; }
        public string EditVersion { get; set; }
        public int RefOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }
        public string GlvoucherRefId { get; set; }
    }
}
