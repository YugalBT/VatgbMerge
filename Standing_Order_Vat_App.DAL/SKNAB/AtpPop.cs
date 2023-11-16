using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AtpPop
    {
        public string Itemnmbr { get; set; } = null!;
        public string? Locncode { get; set; }
        public DateTime? Expdate { get; set; }
        public int Tabletype { get; set; }
        public int Soptype { get; set; }
        public short? Doctype { get; set; }
        public string? Docnumber { get; set; }
        public int? Lnitmseq { get; set; }
        public string? Dbcrid { get; set; }
        public string? Dbcrname { get; set; }
        public decimal? Quantity { get; set; }
        public int Backorder { get; set; }
        public int Allocated { get; set; }
        public string? Uofm { get; set; }
        public int Qtybsuom { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; } = null!;
    }
}
