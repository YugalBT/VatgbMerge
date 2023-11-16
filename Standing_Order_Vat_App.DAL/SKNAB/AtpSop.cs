using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AtpSop
    {
        public string Itemnmbr { get; set; } = null!;
        public string? Locncode { get; set; }
        public DateTime? Expdate { get; set; }
        public int Tabletype { get; set; }
        public short? Soptype { get; set; }
        public int Doctype { get; set; }
        public string? Docnumber { get; set; }
        public int? Lnitmseq { get; set; }
        public string? Dbcrid { get; set; }
        public string? Dbcrname { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Backorder { get; set; }
        public decimal? Allocated { get; set; }
        public string? Uofm { get; set; }
        public decimal? Qtybsuom { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; } = null!;
    }
}
