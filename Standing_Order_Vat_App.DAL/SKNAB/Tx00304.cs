using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00304
    {
        public string TaxReturnId { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public short Series { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal Docamnt { get; set; }
        public decimal EuPurchasesTax { get; set; }
        public byte Ectrx { get; set; }
        public short Voidstts { get; set; }
        public string CustomerVendorId { get; set; } = null!;
        public string Docdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
