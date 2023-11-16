using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11000
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Comprcnt { get; set; }
        public decimal Comdlram { get; set; }
        public decimal Cmmslamt { get; set; }
        public short Paperbill { get; set; }
        public short Comappto { get; set; }
        public decimal PabillingAmount { get; set; }
        public short Commflag { get; set; }
        public short Actvtype { get; set; }
        public decimal Ncomamnt { get; set; }
        public byte Posted { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal Orcosamt { get; set; }
        public decimal PaorigBillAmount { get; set; }
        public decimal Orncmamt { get; set; }
        public int DexRowId { get; set; }
    }
}
