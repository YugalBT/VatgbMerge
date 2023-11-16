using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc00500
    {
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public short Series { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Origcntrltot { get; set; }
        public decimal Origbtchtot { get; set; }
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public string Ratetpid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Chekdate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
