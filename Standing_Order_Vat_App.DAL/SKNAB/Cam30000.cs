using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam30000
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public short Cntrltyp { get; set; }
        public string Vendorid { get; set; } = null!;
        public decimal CamAmountTotal { get; set; }
        public decimal CamAmountOwing { get; set; }
        public int DexRowId { get; set; }
    }
}
