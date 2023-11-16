using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl10300
    {
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public decimal Sqncline { get; set; }
        public decimal Sqncline2 { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal OriginatingTaxableAmt { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Txdtlpct { get; set; }
        public decimal Txdtlamt { get; set; }
        public short Txdtltyp { get; set; }
        public int Actindx { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
