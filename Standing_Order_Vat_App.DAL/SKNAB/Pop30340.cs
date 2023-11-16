using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30340
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
