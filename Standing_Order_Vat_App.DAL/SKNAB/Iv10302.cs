using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10302
    {
        public string Stckcntid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public decimal Countedqty { get; set; }
        public decimal Capturedqty { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Itmtrkop { get; set; }
        public string Serltnum { get; set; } = null!;
        public short Serialstatus { get; set; }
        public decimal Varianceqty { get; set; }
        public byte Verified { get; set; }
        public short Qtytype { get; set; }
        public decimal TempAllocatedQuantity { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
