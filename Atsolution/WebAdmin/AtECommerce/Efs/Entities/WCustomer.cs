using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WCustomer
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    }
}
