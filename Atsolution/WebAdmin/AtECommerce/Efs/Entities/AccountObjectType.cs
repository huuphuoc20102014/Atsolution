using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountObjectType
    {
        public AccountObjectType()
        {
            AccountObject = new HashSet<AccountObject>();
        }

        public int Id { get; set; }
        public string AccountObjectTypeName { get; set; }
        public bool IsSystem { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsVendor { get; set; }
        public bool IsCustomer { get; set; }

        public virtual ICollection<AccountObject> AccountObject { get; set; }
    }
}
