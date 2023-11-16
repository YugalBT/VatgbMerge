using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc10101
    {
        public string Userid { get; set; } = null!;
        public short Pstgstus { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public short Aptodcty { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Disttype { get; set; }
        public int Dstindx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public byte Changed { get; set; }
        public string Custnmbr { get; set; } = null!;
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Mcstruct1 { get; set; } = null!;
        public short Mcstruct2 { get; set; }
        public string Mcstruct3 { get; set; } = null!;
        public string Mcstruct4 { get; set; } = null!;
        public decimal Mcstruct5 { get; set; }
        public DateTime Mcstruct6 { get; set; }
        public short Mcstruct7 { get; set; }
        public DateTime Mcstruct8 { get; set; }
        public short Mcstruct9 { get; set; }
        public short Mcstruct10 { get; set; }
        public short Mcstruct11 { get; set; }
        public DateTime Mcstruct12 { get; set; }
        public decimal Mcstruct13 { get; set; }
        public short Mcstruct14 { get; set; }
        public short Spcldist { get; set; }
        public int DexRowId { get; set; }
    }
}
