using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Account
    {
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountNameEnglish { get; set; }
        public string Description { get; set; }
        public string ParentId { get; set; }
        public string MisacodeId { get; set; }
        public int? Grade { get; set; }
        public bool IsParent { get; set; }
        public int AccountCategoryKind { get; set; }
        public bool IsPostableInForeignCurrency { get; set; }
        public bool DetailByAccountObject { get; set; }
        public int? AccountObjectType { get; set; }
        public bool DetailByBankAccount { get; set; }
        public bool DetailByJob { get; set; }
        public int? DetailByJobKind { get; set; }
        public bool DetailByProjectWork { get; set; }
        public int? DetailByProjectWorkKind { get; set; }
        public bool DetailByOrder { get; set; }
        public int? DetailByOrderKind { get; set; }
        public bool DetailByContract { get; set; }
        public int? DetailByContractKind { get; set; }
        public bool DetailByExpenseItem { get; set; }
        public int? DetailByExpenseItemKind { get; set; }
        public bool DetailByDepartment { get; set; }
        public int? DetailByDepartmentKind { get; set; }
        public bool DetailByListItem { get; set; }
        public int? DetailByListItemKind { get; set; }
        public bool Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SortMisacodeId { get; set; }
        public bool DetailByPucontract { get; set; }
        public int? DetailByPucontractKind { get; set; }
    }
}
