using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WProduct
    {
        public string Id { get; set; }
        public string FkWcategory { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDes { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductPriceSale { get; set; }
        public string ProductDesShor { get; set; }
        public string ProductDes { get; set; }
        public int Productindex { get; set; }
        public int ProductView { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string YoutubeLink { get; set; }
        public string Tag { get; set; }
        public bool? StopSelling { get; set; }
        public bool? Acitve { get; set; }
        public string ProductImage { get; set; }
    }
}
