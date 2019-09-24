using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }
        public string OrderCode { get; set; }
        public string FkCustomer { get; set; }
        public string FkAspNetUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverProvine { get; set; }
        public string ReceiverDistrict { get; set; }
        public string ReceiverWard { get; set; }
        public string FkShippingProvider { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public string PaymentType { get; set; }
        public string PaymentNumber { get; set; }
        public string PaymentRef { get; set; }
        public int OrderStatus { get; set; }
        public string Note { get; set; }

        public virtual PostShippingProvider FkShippingProviderNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
