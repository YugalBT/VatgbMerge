using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd022
    {
        public string Chekbkid { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string NextPmntDocNum { get; set; } = null!;
        public int GivePmntDocGlacctIdx { get; set; }
        public int PayPmntDocGlacctIdx { get; set; }
        public string GivePmntDocCheckbook { get; set; } = null!;
        public string PayPmntDocCheckbook { get; set; } = null!;
        public decimal MaxPmntDocAmt { get; set; }
        public string ExceedPmntDocPassword { get; set; } = null!;
        public byte DuplicatePmntDocNum { get; set; }
        public byte OverridePmntDocNum { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
