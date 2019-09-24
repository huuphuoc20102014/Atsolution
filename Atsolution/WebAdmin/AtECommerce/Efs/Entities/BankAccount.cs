using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class BankAccount
    {
        public string BankAccountId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public string AccountHolder { get; set; }
        public string ProvinceOrCity { get; set; }
    }
}
