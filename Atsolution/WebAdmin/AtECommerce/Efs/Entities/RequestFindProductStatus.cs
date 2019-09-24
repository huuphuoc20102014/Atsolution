using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductStatus
    {
        public RequestFindProductStatus()
        {
            RequestFindProduct = new HashSet<RequestFindProduct>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<RequestFindProduct> RequestFindProduct { get; set; }
    }
}
