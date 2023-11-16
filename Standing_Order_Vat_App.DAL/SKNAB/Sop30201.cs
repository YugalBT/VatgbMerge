using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop30201
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public short Pymttype { get; set; }
        public decimal Amntpaid { get; set; }
        public decimal Oamtpaid { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public string Cardname { get; set; } = null!;
        public string Rctnccrd { get; set; } = null!;
        public DateTime Expndate { get; set; }
        public string Authcode { get; set; } = null!;
        public DateTime Pymntdat { get; set; }
        public DateTime Glpostdt { get; set; }
        public int Cashindex { get; set; }
        public int Depindex { get; set; }
        public byte Delete1 { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public string Ratetpid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public string Exgtblid { get; set; } = null!;
        public DateTime Exchdate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Time1 { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
