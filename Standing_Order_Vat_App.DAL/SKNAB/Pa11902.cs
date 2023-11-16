using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11902
    {
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public int PaProjClosingSequence { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int Dstsqnum { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public int Dstindx { get; set; }
        public short Disttype { get; set; }
        public string DistRef { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
