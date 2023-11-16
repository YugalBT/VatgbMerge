using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00303
    {
        public string TaxReturnId { get; set; } = null!;
        public int Actindx { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public string Sdocdscr { get; set; } = null!;
        public int Jrnentry { get; set; }
        public DateTime Trxdate { get; set; }
        public string Ordocnum { get; set; } = null!;
        public DateTime Orpstddt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
