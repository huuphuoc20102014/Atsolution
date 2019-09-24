using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class VoucherReference
    {
        public string RefId1 { get; set; }
        public string RefId2 { get; set; }
        public int? RefType1 { get; set; }
        public int? RefType2 { get; set; }
        public string RefNoFinance1 { get; set; }
        public string RefNoFinance2 { get; set; }
        public string RefNoManagement1 { get; set; }
        public string RefNoManagement2 { get; set; }
        public int? ReferenceType { get; set; }
        public int SortOrder { get; set; }
        public string ReferenceId { get; set; }
    }
}
