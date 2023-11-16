using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10707
    {
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public string Papurordnum { get; set; } = null!;
        public int Ord { get; set; }
        public byte[] Rctinvcerrors { get; set; } = null!;
        public decimal Rcptcost { get; set; }
        public short Rcptpriority { get; set; }
        public decimal Qtyonpo { get; set; }
        public decimal Qtyonpobase { get; set; }
        public decimal Qtyrecvd { get; set; }
        public decimal Qtyrecinbase { get; set; }
        public DateTime Rqstffdate { get; set; }
        public decimal Qtybsuom { get; set; }
        public int DexRowId { get; set; }
    }
}
