using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WCommerceWebsite
    {
        public string Id { get; set; }
        public string WebsiteName { get; set; }
        public string ShopId { get; set; }
        public string PartnerId { get; set; }
        public string Apikey { get; set; }
        public string Url { get; set; }
        public string Password { get; set; }
        public string SaveStore { get; set; }
        public string SaveSource { get; set; }
        public bool? IsSyncStore { get; set; }
        public string Refix { get; set; }
        public string WebhookUrl { get; set; }
        public string LinkUrl { get; set; }
    }
}
