using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class WSubMenu
    {
        public string Id { get; set; }
        public string WSubMenuGroup { get; set; }
        public string MenuName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDes { get; set; }
        public string SubMenuDes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public int ShowIndex { get; set; }
        public bool Show { get; set; }
    }
}
