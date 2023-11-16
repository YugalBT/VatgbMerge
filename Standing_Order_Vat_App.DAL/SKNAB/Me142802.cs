using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142802
    {
        public string Arnum { get; set; } = null!;
        public string Mebankid { get; set; } = null!;
        public string OutputFormat { get; set; } = null!;
        public string Bankid { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public byte Hypelink { get; set; }
        public string Ardlfilapth { get; set; } = null!;
        public string MeCommLinkPath { get; set; } = null!;
        public string Meardlid { get; set; } = null!;
        public DateTime Mklsstdd { get; set; }
        public DateTime Meldtdt { get; set; }
        public DateTime LastReconciledDate { get; set; }
        public decimal LastReconciledBalance { get; set; }
        public short MeNumberOfChecks { get; set; }
        public short MeNumberOfDeps { get; set; }
        public decimal MeDebitsTotal { get; set; }
        public decimal MeCreditsTotal { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
