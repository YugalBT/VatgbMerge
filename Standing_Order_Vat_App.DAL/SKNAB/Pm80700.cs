using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80700
    {
        public string Vendorid { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Taxdtlid { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public int Actindx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
