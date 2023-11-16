using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10103
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Pymttype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public string Cardname { get; set; } = null!;
        public string Rctnccrd { get; set; } = null!;
        public string Authcode { get; set; } = null!;
        public decimal Amntpaid { get; set; }
        public decimal Oamtpaid { get; set; }
        public decimal Amntrema { get; set; }
        public decimal Oamntrem { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Expndate { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public short Depstats { get; set; }
        public byte Delete1 { get; set; }
        public DateTime Glpostdt { get; set; }
        public int Cashindex { get; set; }
        public int Depindex { get; set; }
        public int DexRowId { get; set; }
    }
}
