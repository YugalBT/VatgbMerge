using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10004
    {
        public string Userid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public short Qtytype { get; set; }
        public string Frombin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public int DexRowId { get; set; }
    }
}
