using System;
using System.Collections.Generic;

namespace AT.Efs.Entities
{
    public partial class Setting
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool? IsManual { get; set; }
        public string Style { get; set; }
        public int? RowStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public string ImageSlug { get; set; }

        public virtual SettingType StyleNavigation { get; set; }
    }
}
