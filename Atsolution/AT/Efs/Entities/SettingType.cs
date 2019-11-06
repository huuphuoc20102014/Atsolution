using System;
using System.Collections.Generic;

namespace AT.Efs.Entities
{
    public partial class SettingType
    {
        public SettingType()
        {
            Setting = new HashSet<Setting>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int RowStatus { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Setting> Setting { get; set; }
    }
}
