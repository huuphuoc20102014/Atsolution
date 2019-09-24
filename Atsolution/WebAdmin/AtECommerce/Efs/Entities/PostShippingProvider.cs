using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class PostShippingProvider
    {
        public PostShippingProvider()
        {
            Order = new HashSet<Order>();
        }

        public string Id { get; set; }
        public string ProviderName { get; set; }
        public string Api { get; set; }
        public string AccountObjectId { get; set; }
        public string UserApi { get; set; }
        public string PassApi { get; set; }
        public bool InActive { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
