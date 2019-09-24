using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WOrder
    {
        public string Id { get; set; }
        public string WCustomer { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Totalmoney { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string OrderNote { get; set; }
    }
}
