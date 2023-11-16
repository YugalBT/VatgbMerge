using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd021
    {
        public string Vendorid { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short CheckbookFrom { get; set; }
        public int GivePmntDocGlacctIdx { get; set; }
        public int PayPmntDocGlacctIdx { get; set; }
        public short PmntDocGlacctFrom { get; set; }
        public decimal MaxPmntDocAmt { get; set; }
        public short MaxPmntDocAmtFrom { get; set; }
        public string ExceedPmntDocPassword { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
