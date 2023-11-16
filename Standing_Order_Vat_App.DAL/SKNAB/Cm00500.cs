using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00500
    {
        public string Chekbkid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public byte Inactive { get; set; }
        public decimal Currblnc { get; set; }
        public string Bankid { get; set; } = null!;
        public string Cmusrdf1 { get; set; } = null!;
        public string Cmusrdf2 { get; set; } = null!;
        public decimal LastReconciledBalance { get; set; }
        public DateTime LastReconciledDate { get; set; }
        public short? Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
