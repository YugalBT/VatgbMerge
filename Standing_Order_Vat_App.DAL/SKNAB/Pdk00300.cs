using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk00300
    {
        public string Employid { get; set; } = null!;
        public DateTime Parepdt { get; set; }
        public short Parepd { get; set; }
        public string Pacomm { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public int DexRowId { get; set; }
    }
}
