﻿using System;
using System.Collections.Generic;

namespace AtHelper.Efs.Entities
{
    public partial class TableVersion
    {
        public string Id { get; set; }
        public DateTime LastModify { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
