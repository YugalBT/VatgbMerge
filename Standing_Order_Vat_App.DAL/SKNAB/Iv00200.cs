using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00200
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Fgditmnm { get; set; } = null!;
        public string Fgsernbr { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public int Rctseqnm { get; set; }
        public string Vndrnmbr { get; set; } = null!;
        public byte Cmpfingd { get; set; }
        public byte Serlnsld { get; set; }
        public short Qtytype { get; set; }
        public string Bin { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
