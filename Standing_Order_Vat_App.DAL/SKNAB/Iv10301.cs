using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10301
    {
        public string Stckcntid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public decimal Capturedqty { get; set; }
        public decimal Countedqty { get; set; }
        public DateTime Countdate { get; set; }
        public DateTime Counttime { get; set; }
        public short Decplqty { get; set; }
        public short Itmtrkop { get; set; }
        public int Ivivindx { get; set; }
        public decimal StockSerialLotCount { get; set; }
        public decimal Stcksrlltvrnc { get; set; }
        public int Ivvaridx { get; set; }
        public decimal Varianceqty { get; set; }
        public byte Verified { get; set; }
        public decimal TempAllocatedQuantity { get; set; }
        public byte Active { get; set; }
        public int DexRowId { get; set; }
    }
}
