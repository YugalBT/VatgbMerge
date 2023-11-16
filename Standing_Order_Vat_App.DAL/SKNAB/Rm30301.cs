using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30301
    {
        public string Trxsorce { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Docnumbr { get; set; } = null!;
        public short Disttype { get; set; }
        public short Rmdtypal { get; set; }
        public int Seqnumbr { get; set; }
        public string Custnmbr { get; set; } = null!;
        public int Dstindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Projctid { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public short Categusd { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string DistRef { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
