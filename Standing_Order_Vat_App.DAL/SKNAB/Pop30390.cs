using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30390
    {
        public string Poprctnm { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string DistRef { get; set; } = null!;
        public short Disttype { get; set; }
        public string Trxsorce { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
