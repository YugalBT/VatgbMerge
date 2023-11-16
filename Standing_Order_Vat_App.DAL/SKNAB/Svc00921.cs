using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00921
    {
        public string Srvtype { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal Listprce { get; set; }
        public decimal Costamnt { get; set; }
        public string Pricshed { get; set; } = null!;
        public byte Cblabor { get; set; }
        public byte Cbarts { get; set; }
        public byte Cbexp { get; set; }
        public byte Cbaddnl { get; set; }
        public string Dlrorpct { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
