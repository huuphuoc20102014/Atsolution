using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Branch
    {
        public string BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string President { get; set; }
        public bool Inactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FkUserCreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string FkUserModifiedBy { get; set; }
    }
}
