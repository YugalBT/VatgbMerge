using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123501
    {
        public string PpNumber { get; set; } = null!;
        public string Mebankid { get; set; } = null!;
        public string OutputFormat { get; set; } = null!;
        public string Bankid { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public byte Hypelink { get; set; }
        public string Dlfilapth { get; set; } = null!;
        public string Hypepath { get; set; } = null!;
        public byte Meincwft { get; set; }
        public string Meupldid { get; set; } = null!;
        public DateTime Mklsstdd { get; set; }
        public DateTime Meuptim { get; set; }
        public short MeNumberOfChecks { get; set; }
        public decimal MeChecksAmount { get; set; }
        public short MeNumberOfVoids { get; set; }
        public decimal MeVoidsAmount { get; set; }
        public string MeConfirmationNumber { get; set; } = null!;
        public DateTime LastReconciledDate { get; set; }
        public decimal LastReconciledBalance { get; set; }
        public int DexRowId { get; set; }
    }
}
