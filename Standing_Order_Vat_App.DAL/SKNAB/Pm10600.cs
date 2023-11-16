using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm10600
    {
        public short Doctype { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public int Dstsqnum { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public int Dstindx { get; set; }
        public short Disttype { get; set; }
        public byte Changed { get; set; }
        public string Userid { get; set; } = null!;
        public short Pstgstus { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public DateTime Pstgdate { get; set; }
        public string Interid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Aptvchnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public short Spcldist { get; set; }
        public int DexRowId { get; set; }
    }
}
