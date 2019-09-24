using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class FixedAssetCategory
    {
        public string FixedAssetCategoryId { get; set; }
        public string ParentId { get; set; }
        public string MisacodeId { get; set; }
        public bool IsParent { get; set; }
        public int? Grade { get; set; }
        public string FixedAssetCategoryCode { get; set; }
        public string FixedAssetCategoryName { get; set; }
        public string OrgPriceAccount { get; set; }
        public string DepreciationAccount { get; set; }
        public bool? Inactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SortMisacodeId { get; set; }
    }
}
