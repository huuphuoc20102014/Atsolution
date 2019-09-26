using System;
using System.Collections.Generic;

namespace AtECommerce.Efs.Entities
{
    public partial class TestTable : AtBaseECommerceEntity
    {
        public string Id { get; set; }
        public short Col_Small_Int { get; set; }
        public int Col_Int { get; set; }
        public long Col_Big_Int { get; set; }
        public double Col_Float { get; set; }
        public decimal Col_Decimal { get; set; }
        public decimal Col_Numeric { get; set; }
        public float Col_Real { get; set; }
        public string Col_Char { get; set; }
        public string Col_Varchar { get; set; }
        public string Col_Varchar_Max { get; set; }
        public string Col_N_Varchar { get; set; }
        public string Col_N_Varchar_Max { get; set; }
        public string Col_Text { get; set; }
        public string Col_N_Text { get; set; }
        public DateTime Col_Date { get; set; }
        public DateTime Col_DateTime { get; set; }
        public DateTime Col_DateTime_2 { get; set; }
        public DateTimeOffset Col_DateTime_Offset { get; set; }
        public TimeSpan Col_Time { get; set; }
        public bool Col_Bit { get; set; }
    }
}
