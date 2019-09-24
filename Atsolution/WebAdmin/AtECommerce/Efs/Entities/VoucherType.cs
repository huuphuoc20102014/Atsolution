using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class VoucherType
    {
        public string VoucherTypeId { get; set; }
        public byte MovementBy { get; set; }
        public string VoucherTypeCode { get; set; }
        public string VoucherTypeName { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public bool IsSystem { get; set; }
        public string Description { get; set; }
        public string VoucherTypeCategory { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Inactive { get; set; }
        public string PrintedCreditAccount { get; set; }
        public string PrintedDebitAccount { get; set; }
        public int? CorrespondingSummary { get; set; }
    }
}
