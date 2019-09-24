using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Bank
    {
        public string BankId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankNameEnglish { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public bool Inactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string EbankCode { get; set; }
        public string SwiftCode { get; set; }
    }
}
