using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductPayOrder
    {
        public string Id { get; set; }
        public string FkRequestBuyProduct { get; set; }
        public string PayOrderCode { get; set; }
        public string FkPayFor { get; set; }
        public string FkUserRequestPay { get; set; }
        public DateTime RequestPayDate { get; set; }
        public string FkUserProcess { get; set; }
        public DateTime? UserProcessDate { get; set; }
        public string UserProcessNote { get; set; }
        public string FkUserApprover { get; set; }
        public DateTime? UserApproverDate { get; set; }
        public string UserApproverNote { get; set; }
        public decimal Amount { get; set; }
        public int FkType { get; set; }
        public int FkPrioty { get; set; }
        public DateTime PayPlan { get; set; }
        public string Note { get; set; }
        public string FkBankAccount { get; set; }
        public string FkBankAccountApproved { get; set; }
        public string Accompanying { get; set; }
        public string BankName { get; set; }
        public string BranhBank { get; set; }
        public string BankAddress { get; set; }
        public string SwiftCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public int PayOrderStatus { get; set; }
        public decimal PayAmount { get; set; }
        public string Explain { get; set; }

        public virtual RequestBuyProduct FkRequestBuyProductNavigation { get; set; }
    }
}
