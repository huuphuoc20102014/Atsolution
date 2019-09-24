using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WContact
    {
        public string Id { get; set; }
        public string YourName { get; set; }
        public string Email { get; set; }
        public string Enquiry { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Tag { get; set; }
    }
}
