using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11100
    {
        public string Padocnumber20 { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Patu { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal PabilledTax { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Patotbillings { get; set; }
        public decimal PatotalTaxableBillings { get; set; }
        public byte Posted { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal PaorigBilledTax { get; set; }
        public decimal PaorigTotalBilings { get; set; }
        public decimal PaorigTotalTaxableBill { get; set; }
        public int DexRowId { get; set; }
    }
}
