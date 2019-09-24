using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Sample
    {
        public int ColAutoKey { get; set; }
        public int ColInt { get; set; }
        public long ColBigInt { get; set; }
        public bool ColBit { get; set; }
        public string ColNvarchar { get; set; }
        public double ColFloat { get; set; }
        public decimal ColDecimal180 { get; set; }
        public decimal ColNumeric180 { get; set; }
        public float ColReal { get; set; }
        public DateTime ColDate { get; set; }
        public DateTime ColDatetime { get; set; }
        public string ColText { get; set; }
        public int ColEnum { get; set; }
        public int? NullColInt { get; set; }
        public long? NullColBigInt { get; set; }
        public bool? NullColBit { get; set; }
        public string NullColNvarchar { get; set; }
        public double? NullColFloat { get; set; }
        public decimal? NullColDecimal180 { get; set; }
        public decimal? NullColNumeric180 { get; set; }
        public float? NullColReal { get; set; }
        public DateTime? NullColDate { get; set; }
        public DateTime? NullColDatetime { get; set; }
        public string NullColText { get; set; }
        public int? NullColEnum { get; set; }
    }
}
