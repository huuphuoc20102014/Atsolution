using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountTransfer
    {
        public string AccountTransferId { get; set; }
        public string AccountTransferCode { get; set; }
        public int? TransferOrder { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public int? TransferSide { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int SetupType { get; set; }
    }
}
