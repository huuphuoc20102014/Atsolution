using System;
using System.Collections.Generic;

namespace AtConsole.Efs.Entities
{
    public partial class TestTable
    {
        public string Id { get; set; }
        public string ColString { get; set; }
        public string ColStringNull { get; set; }
        public string ColStringMax { get; set; }
        public string ColStringMaxNull { get; set; }
        public string ColText { get; set; }
        public string ColTextNull { get; set; }
        public int ColInt { get; set; }
        public int? ColIntNull { get; set; }
        public long ColLong { get; set; }
        public long? ColLongNul { get; set; }
        public double ColDecimal { get; set; }
        public double? ColDecimalNull { get; set; }
        public DateTime ColDate { get; set; }
        public DateTime? ColDateNull { get; set; }
        public DateTime ColDateTime { get; set; }
        public DateTime? ColDateTimeNull { get; set; }
        public bool ColBool { get; set; }
        public bool? ColBoolNull { get; set; }
        public byte[] ColTimeStamp { get; set; }
    }
}
