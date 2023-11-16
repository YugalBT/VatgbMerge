using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AtpPopRet
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public DateTime Expdate { get; set; }
        public int Tabletype { get; set; }
        public int Soptype { get; set; }
        public short Doctype { get; set; }
        public string Docnumber { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Dbcrid { get; set; } = null!;
        public string Dbcrname { get; set; } = null!;
        public decimal Quantity { get; set; }
        public int Backorder { get; set; }
        public int Allocated { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Qtybsuom { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; } = null!;
    }
}
