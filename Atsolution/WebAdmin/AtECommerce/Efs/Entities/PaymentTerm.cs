using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class PaymentTerm
    {
        public string PaymentTermId { get; set; }
        public string PaymentTermCode { get; set; }
        public string PaymentTermName { get; set; }
        public int DueTime { get; set; }
        public int DiscountTime { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
