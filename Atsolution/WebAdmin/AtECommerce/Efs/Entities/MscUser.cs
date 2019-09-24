using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class MscUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordEncryption { get; set; }
        public string JobTitle { get; set; }
        public string FullName { get; set; }
        public string OrganizationUnitId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string WorkAddress { get; set; }
        public string HomeAddress { get; set; }
        public byte[] Photo { get; set; }
        public bool IsWorkingWithFinanceBook { get; set; }
        public bool IsWorkingWithManagementBook { get; set; }
        public bool Inactive { get; set; }
        public bool IsSystem { get; set; }
    }
}
