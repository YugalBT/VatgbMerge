using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80600
    {
        public string Vchrnmbr { get; set; } = null!;
        public int Dstsqnum { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public int Dstindx { get; set; }
        public short Disttype { get; set; }
        public string Userid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public short Doctype { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Keysourc { get; set; } = null!;
        public short Aptodcty { get; set; }
        public string Aptvchnm { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Interid { get; set; } = null!;
        public byte Ictrx { get; set; }
        public string Iccurrid { get; set; } = null!;
        public short Iccurrix { get; set; }
        public int DexRowId { get; set; }
    }
}
