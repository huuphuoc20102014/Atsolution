using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class GlvoucherCrossEntryDetail
    {
        public string RefDetailId { get; set; }
        public string MappingCrossId { get; set; }
        public string GlvoucherRefId { get; set; }
        public int CrossType { get; set; }
        public bool? ReceiptType { get; set; }
        public string AccountNumber { get; set; }
        public string CurrencyId { get; set; }
        public string AccountObjectId { get; set; }
        public string PayRefId { get; set; }
        public bool? IsPayVoucherPosted { get; set; }
        public int PayRefType { get; set; }
        public DateTime PayRefDate { get; set; }
        public DateTime PayPostedDate { get; set; }
        public string PayRefNo { get; set; }
        public string PayDescription { get; set; }
        public decimal TotalPayableAmountOc { get; set; }
        public decimal TotalPayableAmount { get; set; }
        public decimal PayableAmountOc { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal PayAmountOc { get; set; }
        public decimal PayAmount { get; set; }
        public string DebtRefId { get; set; }
        public bool? IsDebtVoucherPosted { get; set; }
        public int DebtRefType { get; set; }
        public DateTime DebtRefDate { get; set; }
        public DateTime DebtPostedDate { get; set; }
        public string DebtRefNo { get; set; }
        public string DebtInvNo { get; set; }
        public DateTime? DebtDueDate { get; set; }
        public string DebtDescription { get; set; }
        public decimal TotalDebtableAmountOc { get; set; }
        public decimal TotalDebtableAmount { get; set; }
        public decimal DebtableAmountOc { get; set; }
        public decimal DebtableAmount { get; set; }
        public decimal DebtAmountOc { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmountOc { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountAccount { get; set; }
        public string PaymentTermId { get; set; }
        public decimal ExchangeDiffAmount { get; set; }
        public int SortOrder { get; set; }
        public string BranchId { get; set; }
        public int DisplayOnBook { get; set; }
        public decimal? DebtExchangeRate { get; set; }
        public decimal? LastExchangeRate { get; set; }
        public DateTime? DebtInvDate { get; set; }
        public string DebtEmployeeId { get; set; }
    }
}
