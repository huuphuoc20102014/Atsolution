using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestBuyProductProvider
    {
        public RequestBuyProductProvider()
        {
            RequestBuyProductProviderMaterial = new HashSet<RequestBuyProductProviderMaterial>();
        }

        public string Id { get; set; }
        public string FkRequestBuyProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public int HeightX { get; set; }
        public int WidthY { get; set; }
        public int ThicknessZ { get; set; }
        public decimal Weight { get; set; }
        public string FkWeightUnit { get; set; }
        public string FkProvider { get; set; }
        public string TermOfPayment { get; set; }
        public string FkPort { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal QuantityOfPacking { get; set; }
        public string FkUnit { get; set; }
        public string Packing { get; set; }
        public string FkUnitPacking { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int WarrantyMonth { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }
        public string Accessories { get; set; }

        public virtual RequestBuyProduct FkRequestBuyProductNavigation { get; set; }
        public virtual ICollection<RequestBuyProductProviderMaterial> RequestBuyProductProviderMaterial { get; set; }
    }
}
