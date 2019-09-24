using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AutoBusiness
    {
        public string AutoBusinessId { get; set; }
        public string AutoBusinessName { get; set; }
        public int VoucherType { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
