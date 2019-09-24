using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public bool IsFollowEdit { get; set; }
    }
}
