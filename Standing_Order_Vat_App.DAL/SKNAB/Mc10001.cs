using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc10001
    {
        public string Rvlueid { get; set; } = null!;
        public byte Revalunt { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public short Rvludttn { get; set; }
        public string Exgtblid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public DateTime Exchdate { get; set; }
        public decimal Xchgrate { get; set; }
        public int DexRowId { get; set; }
    }
}
