using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountObjectBankAccount
    {
        public string AccountObjectBankAccountId { get; set; }
        public int SortOrder { get; set; }
        public string FkAccountObjectId { get; set; }
        public string AccountHolder { get; set; }
        public string BankAccount { get; set; }
        public string FkBankId { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string ProvinceOrCity { get; set; }
        public string SwiftCode { get; set; }
    }
}
