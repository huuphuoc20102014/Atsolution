using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WPostService
    {
        public string Id { get; set; }
        public string AccountObjectId { get; set; }
        public string PostProviderName { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string FkPostApimethod { get; set; }
        public string Apikey { get; set; }
        public string Apiusername { get; set; }
        public string Apipassword { get; set; }
        public string Skapi { get; set; }
        public string Sl { get; set; }
        public string Urlapi { get; set; }
        public string NameOfSender { get; set; }
        public string EmailOfSender { get; set; }
        public string PhoneOfSender { get; set; }
        public string AddressOfSender { get; set; }
        public string FkProvine { get; set; }
        public string FkDictrist { get; set; }
        public string PostType { get; set; }
        public string ServiceCode { get; set; }
        public string ProductCode { get; set; }
        public string PaymentType { get; set; }
        public bool? IsSanBox { get; set; }
        public bool? IsFreeShip { get; set; }
    }
}
