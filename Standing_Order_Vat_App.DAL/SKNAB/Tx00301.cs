using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00301
    {
        public string TaxReturnId { get; set; } = null!;
        public short Exception { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docdescr { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Taxdtlid { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal EuPurchasesTax { get; set; }
        public byte Ectrx { get; set; }
        public short Voidstts { get; set; }
        public int DexRowId { get; set; }
    }
}
