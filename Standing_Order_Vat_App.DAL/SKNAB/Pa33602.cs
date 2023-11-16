using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33602
    {
        public string Docnumbr { get; set; } = null!;
        public string Padocnumber20 { get; set; } = null!;
        public short Pabilltrxt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public short PasourceType { get; set; }
        public string Parecordid { get; set; } = null!;
        public string Pacostdocno { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public decimal PabillingAmount { get; set; }
        public decimal Pafaa { get; set; }
        public decimal Paccaa { get; set; }
        public decimal Pawa { get; set; }
        public decimal Patta { get; set; }
        public decimal PaTaxAppliedAmount { get; set; }
        public decimal PaTermsTakenTaxAmt { get; set; }
        public decimal PaWriteOffTaxAmount { get; set; }
        public decimal PaCreditRetainerApp { get; set; }
        public int DexRowId { get; set; }
    }
}
