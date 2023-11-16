using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx20500
    {
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Apfrdcnm { get; set; } = null!;
        public short Apfrdcty { get; set; }
        public short Series { get; set; }
        public short TaxRebateType { get; set; }
        public int Seqnumbr { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal OriginatingTaxableAmt { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public int Actindx { get; set; }
        public byte Ectrx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public string CustomerVendorId { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
