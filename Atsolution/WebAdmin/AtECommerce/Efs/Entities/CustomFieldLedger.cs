using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class CustomFieldLedger
    {
        public string CustomFieldLegerId { get; set; }
        public string RefDetailId { get; set; }
        public string RefId { get; set; }
        public bool IsPostToManagementBook { get; set; }
        public string BranchId { get; set; }
        public DateTime? PostedDate { get; set; }
        public string MasterCustomField1 { get; set; }
        public string MasterCustomField2 { get; set; }
        public string MasterCustomField3 { get; set; }
        public string MasterCustomField4 { get; set; }
        public string MasterCustomField5 { get; set; }
        public string MasterCustomField6 { get; set; }
        public string MasterCustomField7 { get; set; }
        public string MasterCustomField8 { get; set; }
        public string MasterCustomField9 { get; set; }
        public string MasterCustomField10 { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }
        public bool IsUpdateRedundant { get; set; }
    }
}
